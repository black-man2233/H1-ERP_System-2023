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


            for (int i = 0; i < Database.Instance.Customers.Count; i++)
                if (Database.Instance.Customers[i].PersonID == CustomerListScreen.SelectedCustomer.PersonID)
                { 
                    customerList.Add(Database.Instance.Customers[i]);
                }


            customerList.AddColumn("Name", "CustomerFullName");
            customerList.AddColumn("Address", "Address");
            customerList.AddColumn("Purchase Date", "LastPurchaseDate");
            // listPage.AddKey(Console

            customerList.Draw();
        }
    }
}
