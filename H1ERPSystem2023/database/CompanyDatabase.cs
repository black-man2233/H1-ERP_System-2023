using H1_ERP_System_2023.Domain_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_ERP_System_2023.Database
{
    internal partial class Database
    {
        public string Company { get; set; }
        
        public CompanyModel GetCompany()
        {
            return Company;
        }
        public List<CompanyModel> GetAllCompanyModels() { //foreach?

            throw new NotImplementedException();
        }
        public List<CompanyModel> AddCompany() {
            throw new NotImplementedException();  //List?
        }
        public CompanyModel UpdateCompany()
        {
            throw new NotImplementedException();

        }
        public List<CompanyModel> RemoveCompany()
        
        { throw new NotImplementedException(); } //List?
       

    }
}

