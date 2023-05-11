using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;


namespace H1ERPSystem2023.Screens
{
    public class CustomerDetailScreen : Screen
    {
        public override string Title { get; set; } = "Customers";


        protected override void Draw()
        {
            Clear(this);

            ListPage<CustomerModel> customerList = new();
            //Database customerDB = new();

            for (int i = 0; i < Database.Instance.GetAllCustomerModels().Count; i++)
                if (Database.Instance.GetAllCustomerModels()[i].CustomerNumber == CustomerListScreen.SelectedCustomer.CustomerNumber)
                    customerList.Add(Database.Instance.GetAllCustomerModels()[i]);

            customerList.AddColumn("Person ID", "PersonID");
            customerList.AddColumn("Full Name", "FullName");
            customerList.AddColumn("Phone Number", "PhoneNumber");
            customerList.AddColumn("Email Address", "EmailAddress");
            customerList.AddColumn("Address", "Address");
            customerList.AddColumn("Purchase Date", "LastPurchaseDate");

            customerList.Draw();
        }
    }
}