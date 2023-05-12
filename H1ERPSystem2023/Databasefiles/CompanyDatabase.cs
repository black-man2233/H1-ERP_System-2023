﻿using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        private List<CompanyModel> Companies = new List<CompanyModel>();

        //AddCompany uses the company List above, and gives us 2 companies to work with along with a lot of information
        //about them
        void _addCompanies()
        {
            //Companies.Add(ReadData("Company"));

            Companies.Add(new CompanyModel("1", "Virksomhed", "Vejej", "Nummer", "9900", "Aalborg,", "Denmark",
                Currency.DKK));

            Companies.Add(new CompanyModel("2", "Virksomhed2", "Rørdalsvej", "Nummer2", "9411", "San Francisco",
                " America", Currency.DKK));

        }

        //GetCompany Gets an ID i program.cs (by the user), and uses that with the foreach to take all companies
        //and check whichever one has a matching ID, so it can return the information.
        public CompanyModel GetCompany(string ID)
        {
            foreach (CompanyModel company in Companies)
            {
                if (company.ID == ID)
                {
                    return company;
                }
            }

            //If the ID given doesn't exist, the return is "ID doesn't exist" and null, otherwise it would give issues 
            Console.WriteLine("Id findes Ikke");
            return null!;
        }

        // Uses a foreach to take all Companies, and _AllCompanies is used to display said Companies. 
        public List<CompanyModel> GetAllCompanyModels()
        {
            List<CompanyModel> _allComanies = new();

            foreach (CompanyModel Company in Companies)
            {
                _allComanies.Add(Company);
            }

            return _allComanies;

            // SQL Connection thing -> SqlConnection SQLConn = getConnection(); <- touch at a later time
        }

        //AddCompany essentially takes user input and uses that to add it to the company list.
        //It uses the parameters given of ID, CompanyName, etc, 

        public void AddCompany(CompanyModel company)
        {
            Companies.Add(company);

        }

        //UpdateCompany uses foreach and if to Identity the company, then updates it, 
        //Void is used to avoid method wanting a return
        public void UpdateCompany(string ID, string companyName, string street, string streetNumber, string postalCode,
            string city, string country)
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
                    company.Currency = Currency.DKK;
                }
            }
        }

        //RemoveCompany uses the if and foreach to identify the right company, then uses remove company
        //RemoveCompany break is used due to the Company going back to company afterwards and
        //crashes due to ID not existing anymore.
        public void RemoveCompany(string ID)
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
        // /// //// ///// //// /// // /// //// ///// //// /// // /// //// ///// //// /// // /// //// ///// //// /// //
        /* SQL Update VERSION af Lærke, skal gerne implementeres senere sammen med SQL
     
        public void AddCompany(CompanyModel company)
        {
            Companies.Add(company);
       // Denne er et reference til SQL, og ikke Direkte kode -> sql = "insert into(name, adress) values (company.name, company.adress)"

        }
    }
}