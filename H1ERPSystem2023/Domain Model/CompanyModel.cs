namespace H1ERPSystem2023.DomainModel
{
    public enum Currency { DKK, USD }
    public class CompanyModel
    {
        public string ID { get; set; }
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Currency Currency { get; set; }

        public CompanyModel(string id, string companyName, string street, string streetNumber, string postalCode, string city, string country, Currency currency)
        {
            ID = id;
            CompanyName = companyName;
            Street = street;
            StreetNumber = streetNumber;
            PostalCode = postalCode;
            City = city;
            Country = country;
            Currency = currency;


        } 
          // Missing SQL setup (Check bottom Company database)

        public CompanyModel(CompanyModel company)
        {
            this.ID = company.ID;
            this.CompanyName = company.CompanyName;
            this.Street = company.Street;
            this.StreetNumber = company.StreetNumber;
            this.PostalCode = company.PostalCode;
            this.City = company.City;
            this.Country = company.Country;
            this.Currency = company.Currency;

        }
        public CompanyModel()
        {

        }

    }
}

