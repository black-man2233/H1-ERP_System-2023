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

namespace H1_ERP_System_2023.Screens
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


                customerList.AddColumn("personId", "PersonID");
                customerList.AddColumn("Name", "CustomerFullName");
                customerList.AddColumn("Phone Number", "PhoneNumber");
                customerList.AddColumn("EmailAddress", "EmailAddress");

                


                SelectedCustomer = customerList.Select();
                if (SelectedCustomer != null)
                    Screen.Display(new CompanyDetailScreen());
                else
                { Quit(); return; }
                customerList.Draw();
            } while (Show);
        }
    }
}

