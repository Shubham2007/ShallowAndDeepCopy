namespace DeepCopyObjects.Models
{
    /// <summary>
    /// Represent employee address details
    /// </summary>
    public class Address
    {
        public string Street { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Country { get; set; }

        public int Pincode { get; set; }
    }
}
