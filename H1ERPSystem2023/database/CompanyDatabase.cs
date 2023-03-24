using H1_ERP_System_2023.Domain_Model;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP_System_2023.Database
{
    public partial class CompanyDatabase
    {

        public string Company { get; set; }

        private List<CompanyModel> Companies = new List<CompanyModel>();

        void _addCompanies()
        {
            Companies.Add(new CompanyModel(1, "Virksomhed", "Vejej", "Nummer", "9900", "Aalborg,", "Denmark"));

            Companies.Add(new CompanyModel(2, "Virksomhed2", "Rørdalsvej", "Nummer2", "9999", "København", " Denmark"));
        }

        public CompanyDatabase()
        {
            _addCompanies();
        }

        public CompanyModel GetCompany(int ID)
        {
            foreach (CompanyModel company in Companies)
            {
                if (company.ID == ID)
                {
                    return company;
                }
            }

            Console.WriteLine("Id findes Ikke");
            return null;
        }
        public List<CompanyModel> GetAllCompanyModels()
        {
            List<CompanyModel> _allComanies = new();

            foreach (CompanyModel Company in Companies)
            {
                _allComanies.Add(Company);
            }
            return _allComanies;

            //SqlConnection SQLConn = getConnection();

        }

        public void AddCompany(int id, string companyName, string street, string streetNumber, string postalCode, string city, string country)
        {
            Companies.Add(new CompanyModel(id, companyName, street, streetNumber, postalCode, city, country));

        }

        public void UpdateCompany(int ID, string companyName, string street, string streetNumber, string postalCode, string city, string country)
        {
            foreach (CompanyModel company in Companies)
            {
                if (company.ID == ID)
                {
                    company.CompanyName = companyName;
                    company.Street = street;
                    company.StreetNumber = streetNumber;
                    company.PostalCode = postalCode;
                    company.City = city;
                    company.Country = country;

                }
            }
        }

        public void RemoveCompany(int ID)
        {
            foreach (CompanyModel company in Companies)
            {
                if (company.ID == ID)
                {
                    Companies.Remove(company);
                    break;

                }
            }
        }
    }

}

