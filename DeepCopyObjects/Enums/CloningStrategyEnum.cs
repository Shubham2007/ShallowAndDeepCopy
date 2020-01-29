using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopyObjects.Enums
{
    public enum CloningStrategyEnum
    {
        CopyConstructor = 1,

        MemberwiseClone = 2,

        Serialization = 3,

        Reflection = 4
    }
}
