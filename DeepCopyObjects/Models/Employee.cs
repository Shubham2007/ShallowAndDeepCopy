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

        #endregion

    }
}
