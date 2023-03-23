using H1_ERP_System_2023.Domain_Model;
using System;
using System.Collections.Generic;
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
        public string Company { get; set; }

        List<CompanyModel> Companies = new List();
        Companies.Add(new Companies() { ID = 0, CompanyName = "Virksomhed", Street = "Vejej" StreetNumber = "Nummer", PostalCode = "9900", City = "Aalborg,", Country = "Denmark", })
            
        public CompanyModel GetCompany(int ID)
        {
            if ID == List.Find(Companies).ID == 0)
                return ID
        }
        public List<CompanyModel> GetAllCompanyModels()
        {
            foreach ID in Companies {

            }
                SqlConnection SQLConn = getConnection();

        }
        public List<CompanyModel> AddCompany() {
            Companies.Add(new Companies() { });
        }
        public CompanyModel UpdateCompany()
        {
            throw new NotImplementedException();

        }
        public List<CompanyModel> RemoveCompany()

        {Companies.Remove(Companies)


    }
    }
}

