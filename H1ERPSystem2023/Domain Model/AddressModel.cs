#pragma warning disable
namespace H1ERPSystem2023.DomainModel
{
    public class AddressModel
    {
        #region Properties
        public int AddressId { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        public string GetFullAdress { get => $"{Street} {StreetNumber}, {City} {PostalCode}, {Country} "; }

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

        public AddressModel(AddressModel adress)
        {
            if (adress is not null)
            {
                AddressId = adress.AddressId;
                Street = adress.Street;
                StreetNumber = adress.StreetNumber;
                City = adress.City;
                PostalCode = adress.PostalCode;
                Country = adress.Country;
            }
        }

        public AddressModel()
        {
            this.Street = "";
            this.Street = "";
            this.City = "";
            this.PostalCode = "";
            this.Country = "";
        }
        #endregion
    }
}
