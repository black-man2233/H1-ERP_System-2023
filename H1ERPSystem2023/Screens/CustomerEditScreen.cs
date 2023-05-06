using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class CustomerEditScreen : Screen
    {

        public override string Title { get; set; } = "Edit Customer";
        public CustomerModel Customer { get; set; } = new();

        public CustomerEditScreen(Object? O)
        {
            if (O is CustomerModel product)
                this.Customer = new(product);
        }

        public bool IsCreate { get; set; }
        public CustomerEditScreen()
        {
            IsCreate = true;
        }


        void Create()
        {
            Form<CustomerModel> editor = new();

            editor.TextBox("First Name", "FirstName");
            editor.TextBox("Last Name", "LastName");
            editor.TextBox("Street Name", "Street");
            editor.IntBox("Street Number", "StreetNumber");
            editor.IntBox("Postal Code", "PostalCode");
            editor.TextBox("City", "City");
            editor.IntBox("Phone Number", "PhoneNumber");
            editor.TextBox("Email Address", "EmailAddress");

            editor.Edit(Customer);
        }

        protected override void Draw()
        {
            if (IsCreate)
            {
                Create();
                Database.Instance.AddCustomer(Customer);
            }
            else
            {
                Clear(this);

                Form<CustomerModel> editor = new();

                editor.TextBox("First Name", "FirstName");
                editor.TextBox("Last Name", "LastName");
                editor.TextBox("Street Name", "Street");
                editor.IntBox("Street Number", "StreetNumber");
                editor.IntBox("Postal Code", "PostalCode");
                editor.TextBox("City", "City");
                editor.IntBox("Phone Number", "PhoneNumber");
                editor.TextBox("Email Address", "Email");

                editor.Edit(Customer);
                Database.Instance.UpdateCustomer(Customer.PersonID, Customer.FirstName, Customer.LastName, Customer.Address, 
                    Customer.PhoneNumber, Customer.EmailAddress, Customer.LastPurchaseDate);
            }
        }
    }
}
