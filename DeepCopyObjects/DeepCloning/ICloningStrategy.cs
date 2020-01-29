using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopyObjects.DeepCloning
{
    public interface ICloningStrategy
    {
        TObject Clone<TObject>(TObject originalObject);
    }
}
