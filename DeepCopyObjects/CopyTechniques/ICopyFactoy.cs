using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopyObjects.CopyTechniques
{
    public interface ICopyFactory
    {
        TObject CopyObject<TObject>(TObject originalObject);
    }
}
