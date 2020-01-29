using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;
using DeepCopyObjects.DeepCloning;
using DeepCopyObjects.Enums;

namespace DeepCopyObjects.CopyTechniques
{
    public class DeepCopy : ICopyFactory
    {
        public TObject CopyObject<TObject>(TObject originalObject)
        {
            PrintDeepCloningStrategy();
            WriteLine("Please enter the deep cloning strategy");

            string input = ReadLine();

            int inputInt = ValidateAndConvertInput(input, SystemConstants.MaxCloningStrategies, SystemConstants.InvalidStrategyError);

            ICloningStrategy strategy = GetStrategy((CloningStrategyEnum)inputInt);
            CloningStrategy cloningStrategy = new CloningStrategy(strategy);

            TObject copyObject = cloningStrategy.Clone<TObject>(originalObject);
            return copyObject;
        }

        private ICloningStrategy GetStrategy(CloningStrategyEnum inputInt)
        {
            switch (inputInt)
            {
                case CloningStrategyEnum.CopyConstructor:
                    return new CopyConstructorStrategy();

                case CloningStrategyEnum.MemberwiseClone:
                    return new MemberwiseCloneStrategy();

                case CloningStrategyEnum.Serialization:
                    return new SerializationStrategy();

                case CloningStrategyEnum.Reflection:
                    return new ReflectionStrategy();

                default:
                    return null;
            }
        }

        private static int ValidateAndConvertInput(string input, int maxRange, string message)
        {
            string errorMessage = string.IsNullOrWhiteSpace(message) ? SystemConstants.DefaultInputErrorMessage : message;

            bool success = int.TryParse(input, out int inputInt);

            if (!success)
                throw new CustomException(SystemConstants.InvalidIntegerError);

            else if (inputInt <= 0 || inputInt > maxRange)
                throw new CustomException(errorMessage);

            return inputInt;
        }

        private void PrintDeepCloningStrategy()
        {
            WriteLine("1 - Copy Constructor");
            WriteLine("2 - Memberwise Clone");
            WriteLine("3 - Serialization");
            WriteLine("4 - Reflection");
        }
    }
}
