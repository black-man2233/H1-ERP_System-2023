using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;
#pragma warning disable
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

                customerList.AddColumn("personId", "PersonId");
                customerList.AddColumn("Name", "FullName");
                customerList.AddColumn("Phone Number", "PhoneNumber");
                customerList.AddColumn("EmailAddress", "EmailAddress");

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

