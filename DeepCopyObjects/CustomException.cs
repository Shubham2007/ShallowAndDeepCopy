using System;
using System.Collections.Generic;
using System.Text;

namespace DeepCopyObjects
{
    /// <summary>
    /// Class used to throw handled exception
    /// </summary>
    public class CustomException : Exception
    {
        public CustomException() : base()
        { }

        public CustomException(string errorMessage) : base(errorMessage)
        { }

        public CustomException(string errorMessage, Exception innerException) : base(errorMessage, innerException)
        { }
    }
}
