using H1ERPSystem2023;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using System;
using System.Collections.Generic;
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
                    Database CustomerDB = new();
                    ListPage<CustomerModel> customerList = new();

                    foreach (CustomerModel customerModel in CustomerDB.Customers)
                        customerList.Add(customerModel);

             
                ListPage<CustomerModel> listPage = new ListPage<CustomerModel>();
                    listPage.AddColumn("personId", "PersonId");
                    listPage.AddColumn("FirstName", "FirstName");
                    listPage.AddColumn("LastName", "LastName");
                    listPage.AddColumn("PhoneNumber", "phoneNumber");
                    listPage.AddColumn("EmailAddress", "emailAddress");

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

