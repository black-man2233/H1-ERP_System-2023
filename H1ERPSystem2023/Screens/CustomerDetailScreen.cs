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


            for (int i = 0; i < Database.Instance.Customers.Count; i++)
                if (Database.Instance.Customers[i].PersonID == CustomerListScreen.SelectedCustomer.PersonID)
                { 
                    customerList.Add(Database.Instance.Companies[i]);
                }


            customerList.AddColumn("person Id", "PersonID");
            customerList.AddColumn("Name", "CustomerFullName");
            customerList.AddColumn("Phone Number", "PhoneNumber");
            customerList.AddColumn("Email Address", "EmailAddress");
            customerList.AddColumn("Address", "Address");
            customerList.AddColumn("Purchase Date", "PurchaseDate");
            // listPage.AddKey(Console

            customerList.Draw();
        }
    }
}
