using H1ERPSystem2023.DomainModel;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        private List<CustomerModel> Customers = new List<CustomerModel>();

        public void _addCustomers()
        {
            Customers.Add(new CustomerModel(1, "FirstName", "LastName", null, "12345678", "Email@Email.com", "1", null));
            Customers.Add(new CustomerModel(2, "AnotherGuy", "fafaf", null, "87654321", "AG@mail.com", "2", null));
        }

        public Database()
        {

            _addCustomers();
        }
    }
}
