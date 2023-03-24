using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP_System_2023.Domain_Model
{
    public enum Currency { DKK, USD }
    public class CompanyModel
    {

        public int ID { get; set; }
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Currency Currency { get; set; }

        public CompanyModel(int id, string companyName, string street, string streetNumber, string postalCode, string city, string country, Currency currency)
        {
            ID = id;
            CompanyName = companyName;
            Street = street;
            StreetNumber = streetNumber;
            this.PostalCode = postalCode;
            City = city;
            Country = country;
            Currency = currency;


        } // Missing Currency Selection (might be able to do Currency currency instead of currency.DKK/USD, Test Later
         //Measure from Product Database is same as above!!
          // Missing SQL setup (Check bottom Company database)

    }
}

