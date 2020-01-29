using DeepCopyObjects.CopyTechniques;
using DeepCopyObjects.Enums;
using DeepCopyObjects.Models;
using System;
using static System.Console;

namespace DeepCopyObjects
{
    class Program
    {
        // Entry point of program execution
        static void Main(string[] args)
        {
            try
            {
                // Create and print sample Employee
                Employee emp = CreateEmployeeObject();
                WriteLine(emp);

                PrintCopyMethods();
                WriteLine("Choose Copy Method");

                string copyMethod = ReadLine();
                int copyMethodValue = ValidateAndConvertInput(copyMethod,
                                                                maxRange: SystemConstants.MaxCopyMethods,
                                                                message: SystemConstants.InvalidMethodError);

                ICopyFactory copyFactory = CopyFactory.GetCopyMethod((CopyMethodsEnum)copyMethodValue); //Manual parse with vaidation

                //Creating Employee copy based on the user input method
                Employee empCopy = copyFactory.CopyObject<Employee>(emp);
                WriteLine(empCopy);
            }
            // Handled Exceptions
            catch(CustomException ce)
            {
                // Log Error
                WriteLine(ce.Message);
            }
            // Unhandled Exceptions(Error)
            catch(Exception e)
            {
                // Log Error
                WriteLine(SystemConstants.GeneralErrorMessage);
            }

            ReadKey();
        }

        /// <summary>
        /// Validate user input upto max range by converting it to integer
        /// </summary>
        /// <param name="input"></param>
        /// <param name="maxRange"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Prints copy techniques
        /// </summary>
        private static void PrintCopyMethods()
        {
            WriteLine("1 - Shallow Copy");
            WriteLine("2 - Deep Copy");
        }

        /// <summary>
        /// Creates new Employee instance
        /// </summary>
        /// <returns></returns>
        private static Employee CreateEmployeeObject()
        {
            return new Employee()
            {
                Name = "Shubham",
                Age = 24,
                Gender = "Male",
                Address = new Address()
                {
                    Street = "Agrasen Chowk",
                    City = "Haridwar",
                    State = "Uttarakhand",
                    Country = "India",
                    Pincode = 249401
                }
            };
        }
    }
}
