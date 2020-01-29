using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopyObjects
{
    public class SystemConstants
    {
        public const string DefaultInputErrorMessage = "Please enter the correct input";

        public const int MaxCopyMethods = 2;

        public const int MaxCloningStrategies = 4;

        public const string InvalidMethodError = "Please enter the correct copy method value";

        public const string InvalidStrategyError = "Please enter the correct strategy";

        public const string InvalidIntegerError = "Please enter valid integer only";

        public const string DeepCopyStrategyMethod = "DeepCopy";

        public const string GeneralErrorMessage = "Some error occured in application please try after sometime";

        public const string InvalidDeepCopyType = "Deep copy method must return the same type copy";

        public const string NotImplementedException = "Please implement DeepCopy method in your type to use this strategy";

        public const string StrategyCloningError = "Error occured while deep cloning. Please try again with some different strategy";
    }
}
