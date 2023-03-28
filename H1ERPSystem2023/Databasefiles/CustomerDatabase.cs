using H1ERPSystem2023.Domain_Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1_ERP_System_2023.Databasefiles
{
    public partial class CustomerDatabase
    {
        private List<Customer> Customers = new List<Customer>();

        void _addCompanies()
        {
            Customers.Add(new Customer(1, "FirstName", "LastName", null, "12345678", "Email@Email.com", "1", null));
            Customers.Add(new Customer(2, "AnotherGuy", "fafaf", null, "87654321", "AG@mail.com", "2", null));
        }

        public CustomerDatabase()   
        {
            _addCompanies();
        }
    }


public class MyFirstScreen : Screen
    {
        public override string Title { get; set; } = "My first screen";
        protected override void Draw()
        {
            Clear(this);
            Console.WriteLine("My first screen232322!");
        }
    }
}

