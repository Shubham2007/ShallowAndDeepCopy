using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopyObjects.DeepCloning
{
    public class CopyConstructorStrategy : ICloningStrategy
    {
        public TObject Clone<TObject>(TObject originalObject)
        {
            TObject copyObject = (TObject)Activator.CreateInstance(typeof(TObject), originalObject);
            return copyObject;
        }
    }
}
