namespace H1ERPSystem2023.DomainModel
{
    public class AddressModel
    {
        #region Properties
        private int AdressId { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        #endregion

        #region Constructor
        public AddressModel(string street, string streetNumber, string city, string postalCode, string country)
        {
            this.Street = street;
            this.Street = streetNumber;
            this.City = city;
            this.PostalCode = postalCode;
            this.Country = country;
        }
        #endregion
    }
}
