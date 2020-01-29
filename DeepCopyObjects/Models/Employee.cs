using System;

namespace DeepCopyObjects.Models
{
    /// <summary>
    /// Represent the employee in memory
    /// </summary>
    public class Employee
    {
        #region Constructors

        //Default Constructor
        public Employee()
        { }

        //Copy Constructor
        public Employee(Employee emp)
        {
            Name = emp.Name;
            Age = emp.Age;
            Gender = emp.Gender;
            Address = new Address()
            {
                Street = emp.Address.Street,
                City = emp.Address.City,
                State = emp.Address.State,
                Country = emp.Address.Country,
                Pincode = emp.Address.Pincode
            };
        }

        #endregion

        #region Properties

        public string Name { get; set; }

        public int Age { get; set; }

        public Address Address { get; set; }

        public string Gender { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// Used to print the Employee instance
        /// </summary>
        /// <returns></returns>
        public override string ToString()
            => $"Employee : Name = {Name}, Age = {Age}, City = {Address.City}, Pincode = {Address.Pincode}";

        /// <summary>
        /// Explicit way to create deep copy using Memberwise Clone
        /// </summary>
        /// <returns></returns>
        public Employee DeepCopy()
        {
            Employee emp = this.MemberwiseClone() as Employee;

            // Create deep cloning manually on shallow copy 
            if(emp != null)
            {
                emp.Name = string.Copy(this.Name);
                emp.Age = this.Age;
                emp.Gender = string.Copy(this.Gender);
                emp.Address = new Address
                {
                    Street = this.Address.Street,
                    City = this.Address.City,
                    State = this.Address.State,
                    Country = this.Address.Country,
                    Pincode = this.Address.Pincode
                };

                return emp;
            }

            throw new CustomException("Cannot create deep copy using Memberwise Clone strategy");
        }

        #endregion

    }
}
