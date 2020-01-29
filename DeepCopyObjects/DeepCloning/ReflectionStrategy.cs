using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopyObjects.DeepCloning
{
    public class ReflectionStrategy : ICloningStrategy
    {
        public TObject Clone<TObject>(TObject originalObject)
        {
            throw new NotImplementedException();
        }
    }
}
