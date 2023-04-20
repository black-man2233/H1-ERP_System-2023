using H1ERPSystem2023.DomainModel;
using H1ERPSystem2023;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;
using H1ERPSystem2023.Databasefiles;

namespace H1_ERP_System_2023.Screens
{
    public class CustomerDetailScreen : Screen
    {
        public override string Title { get; set; } = "¨Customers";


        protected override void Draw()
        {
            Clear(this);

            ListPage<CompanyModel> customerList = new();
            Database customerDB = new();

            for (int i = 0; i < Database.Instance.Customers.Count - 1; i++)
                if (Database.Instance.Customers[i].PersonId == CustomerListScreen.SelectedCustomer.PersonId)
                {
                    customerList.Add(Database.Instance.Companies[i]);
                }

            ListPage<CustomerModel> listPage = new ListPage<CustomerModel>();

            listPage.AddColumn("person Id", "PersonId");
            listPage.AddColumn("First Name", "FirstName");
            listPage.AddColumn("Middle Name", "MiddleName");
            listPage.AddColumn("Last Name", "LastName");
            listPage.AddColumn("Phone Number", "phoneNumber");
            listPage.AddColumn("Email Address", "emailAddress");
            listPage.AddColumn("Address", "Address");
            listPage.AddColumn("Purchase Date", "PurchaseDate");
            // listPage.AddKey(Console
        }
    }
}