using H1_ERP_System_2023.Domain_Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP_System_2023.Database
{
    internal partial class Database
    {
        string a
        public string Company { get; set; }

        List<CompanyModel> Companies = new List();
        Companies.Add(new Companies() { ID = 0, CompanyName = "Virksomhed", Street = "Vejej" StreetNumber = "Nummer", PostalCode = "9900", City = "Aalborg,", Country = "Denmark", })
            
        public CompanyModel GetCompany(int ID)
        {
            if Company.ID == List.Find(Companies).ID == 0)
                return ID
        }
        public List<CompanyModel> GetAllCompanyModels()
        {
            foreach CompanyModel Company in Companies {
                return Companies 
            }
                SqlConnection SQLConn = getConnection();

        }
        public List<CompanyModel> AddCompany() {
            Companies.Add(new Companies())
            {
            }
            
        }
        public CompanyModel UpdateCompany(string a, string b, string c, string d, string e)
        {
            if Company.ID == List.Find(Companies).ID == 0) {
                Company.CompanyName = a
                    Company.Street = b
                    Company.PostalCode = c
                    Company.City = d
                    Company.Country = e 
                    }



        }
        public List<CompanyModel> RemoveCompany()
        {
            Companies.Remove(Companies())
                {
            }
        }

    }
    }
}

