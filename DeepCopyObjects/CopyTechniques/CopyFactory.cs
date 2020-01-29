using DeepCopyObjects.Enums;

namespace DeepCopyObjects.CopyTechniques
{
    public static class CopyFactory
    {
        public static ICopyFactory GetCopyMethod(CopyMethodsEnum copyMethod)
        {
            switch (copyMethod)
            {
                case CopyMethodsEnum.ShallowCopy:
                    return new ShallowCopy();

                case CopyMethodsEnum.DeepCopy:
                    return new DeepCopy();

                default:
                    return null;
            }
        }
    }
}
