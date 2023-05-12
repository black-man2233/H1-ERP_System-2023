#pragma warning disable

namespace H1ERPSystem2023.DomainModel
{
    public enum Currency { DKK, USD }
    public class CompanyModel
    {
        public string       ID          { get; set; }
        public string       CompanyName { get; set; }
        public AddressModel Address     { get; set; }
        public string Street
        {
            get => Address.Street;
            set => Address.Street = value;
        }
        public string StreetNumber
        {
            get => Address.StreetNumber;
            set { Address.StreetNumber = value; }
        }
        public string PostalCode
        {
            get => Address.PostalCode;
            set { Address.PostalCode = value; }
        }
        public string City
        {
            get => Address.City;
            set { Address.City = value; }
        }
        public string Country
        {
            get => Address.Country;
            set { Address.Country = value; }
        }
        public Currency Currency { get; set; }

        public CompanyModel(string id, string companyName, string street, string streetNumber, string postalCode, string city, string country, Currency currency)
        {
            ID = id;
            CompanyName = companyName;
            Address = new();
            Address.Street = street;
            Address.StreetNumber = streetNumber;
            Address.PostalCode = postalCode;
            Address.City = city;
            Address.Country = country;
            Currency = currency;


        } // Missing Currency Selection (might be able to do Currency currency instead of currency.DKK/USD, Test Later
          //Measure from Product Database is same as above!!
          // Missing SQL setup (Check bottom Company database)

        public CompanyModel(CompanyModel company)
        {
            this.ID = company.ID;
            this.CompanyName = company.CompanyName;
            this.Address = new();
            this.Address.Street = company.Address.Street;
            this.Address.StreetNumber = company.Address.StreetNumber;
            this.Address.PostalCode = company.Address.PostalCode;
            this.Address.City = company.Address.City;
            this.Address.Country = company.Address.Country;
            this.Currency = company.Currency;

        }
        public CompanyModel()
        {
            this.Address = new();
        }

    }
}

