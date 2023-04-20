using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1_ERP_System_2023.Screens
{
    public class CustomerDetailScreen : Screen
    {
        public override string Title { get; set; } = "¨Customers";


        protected override void Draw()
        {
            Clear(this);

            ListPage<CustomerModel> customerList = new();
            //Database customerDB = new();

            for (int i = 0; i < Database.Instance.GetAllCustomerModels().Count - 1; i++)
            {
                if (Database.Instance.GetAllCustomerModels()[i].PersonId == CustomerListScreen.SelectedCustomer.PersonId)
                {
                    customerList.Add((Database.Instance.GetAllCustomerModels()[i]));
                }
            }

            //ListPage<CustomerModel> listPage = new ListPage<CustomerModel>();

            customerList.AddColumn("Person Id", "PersonId");
            customerList.AddColumn("Full Name", "FullName");
            customerList.AddColumn("Phone Number", "PhoneNumber");
            customerList.AddColumn("Email Address", "EmailAddress");
            customerList.AddColumn("Address", "GetFullAdress");
            customerList.AddColumn("Purchase Date", "LastPurchaseDate");

            customerList.Draw();

        }
    }
}