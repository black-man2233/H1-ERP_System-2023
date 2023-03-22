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
        public string CompanyName { get; set; }
        public string Street { get; set; }
        public string StreetNumber { get; set; }
        public string Zipcode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public Currency Currency { get; set; }
    }
}
