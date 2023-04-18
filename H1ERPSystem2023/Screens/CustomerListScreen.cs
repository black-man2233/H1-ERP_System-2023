using H1ERPSystem2023;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;
#pragma warning disable
namespace H1ERPSystem2023.Screens
{
    public class CustomerListScreen : Screen
    {
        public override string Title { get; set; } = "Customer List";

        public static CustomerModel SelectedCustomer;
        protected override void Draw()
        {
            do
            {
                Clear(this);
                ListPage<CustomerModel> customerList = new();

                foreach (CustomerModel customerModel in Database.Instance.GetAllCustomerModels())
                    customerList.Add(customerModel);


                customerList.AddColumn("PersonId", "PersonID");
                customerList.AddColumn("Name", "CustomerFullName");
                customerList.AddColumn("Phone Number", "PhoneNumber");
                customerList.AddColumn("Email Address", "EmailAddress");

                


                SelectedCustomer = customerList.Select();
                if (SelectedCustomer != null)
                    Screen.Display(new CustomerDetailScreen());
                else
                { Quit(); return; }
                customerList.Draw();
            } while (Show);
        }
    }
}

