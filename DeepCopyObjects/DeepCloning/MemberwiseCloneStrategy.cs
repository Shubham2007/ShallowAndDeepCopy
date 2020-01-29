using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace DeepCopyObjects.DeepCloning
{
    public class MemberwiseCloneStrategy : ICloningStrategy
    {
        public TObject Clone<TObject>(TObject originalObject)
        {
            MethodInfo method = typeof(TObject).GetMethod(SystemConstants.DeepCopyStrategyMethod);

            try
            {
                // Try to invoke DeepCopy method of type for getting Deep cloning object
                object deepCopyObject = method.Invoke(originalObject, null);

                if(deepCopyObject is TObject)
                    return (TObject)deepCopyObject;

                throw new CustomException(SystemConstants.InvalidDeepCopyType);
            }
            catch(TargetException te)
            {
                throw new CustomException(SystemConstants.NotImplementedException);
            }
            catch(TargetInvocationException tie)
            {
                throw new CustomException(SystemConstants.NotImplementedException);
            }
            catch(Exception e)
            {
                throw new CustomException(SystemConstants.StrategyCloningError);
            }
        }
    }
}
