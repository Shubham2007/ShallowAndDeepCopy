using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.Serialization;

namespace DeepCopyObjects.CopyTechniques
{
    public class ShallowCopy : ICopyFactory
    {
        public TObject CopyObject<TObject>(TObject originalObject)
        {
            object copy;
            Type type = originalObject.GetType();

            if (originalObject is ICloneable)
                return (TObject)((ICloneable)originalObject).Clone();

            List<MemberInfo> fields = new List<MemberInfo>();
            if (type.GetCustomAttributes(typeof(SerializableAttribute), false).Length == 0)
            {
                Type t = type;
                while (t != typeof(object))
                {
                    fields.AddRange(t.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));
                    t = t.BaseType;
                }
            }
            else
                fields.AddRange(FormatterServices.GetSerializableMembers(originalObject.GetType()));

            copy = FormatterServices.GetUninitializedObject(originalObject.GetType());
            object[] values = FormatterServices.GetObjectData(originalObject, fields.ToArray());
            FormatterServices.PopulateObjectMembers(copy, fields.ToArray(), values);

            return (TObject)copy;
        }
    }
}
