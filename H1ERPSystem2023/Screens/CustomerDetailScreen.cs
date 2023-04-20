using H1ERPSystem2023.DomainModel;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;


namespace H1ERPSystem2023.Screens
{
    public class CustomerDetailScreen : Screen
    {
        public override string Title { get; set; } = "¨Customers";


        protected override void Draw()
        {
            Clear(this);

            ListPage<CustomerModel> customerList = new();

            for (int i = 0; i < Database.Instance.Customers.Count - 1; i++)
                if (Database.Instance.Customers[i].PersonId == CustomerListScreen.SelectedCustomer.PersonId)
                {
                    customerList.Add(Database.Instance.Customers[i]);
                }


            customerList.AddColumn("person Id", "PersonId");
            customerList.AddColumn("First Name", "FirstName");
            customerList.AddColumn("Middle Name", "MiddleName");
            customerList.AddColumn("Last Name", "LastName");
            customerList.AddColumn("Phone Number", "phoneNumber");
            customerList.AddColumn("Email Address", "emailAddress");
            customerList.AddColumn("Address", "Address");
            customerList.AddColumn("Purchase Date", "PurchaseDate");
            // listPage.AddKey(Console
        }
    }
}