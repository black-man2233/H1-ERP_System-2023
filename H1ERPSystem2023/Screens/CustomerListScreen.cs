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
                Console.Clear();

                Console.WriteLine("F1 to create a new customer");
                Console.WriteLine("F2 to edit a exiting customer");
                Console.WriteLine("F5 to delete a customer");

                ListPage<CustomerModel> customerList = new();

                foreach (CustomerModel customerModel in Database.Instance.GetAllCustomerModels())
                    customerList.Add(customerModel);


                customerList.AddColumn("PersonId", "PersonID");
                customerList.AddColumn("Full Name", "FullName");
                customerList.AddColumn("Phone Number", "PhoneNumber");
                customerList.AddColumn("Email Address", "EmailAddress");

                customerList.AddKey(ConsoleKey.F1, NewCustomer);
                customerList.AddKey(ConsoleKey.F2, Edit);
                customerList.AddKey(ConsoleKey.F5, Delete);

                SelectedCustomer = customerList.Select();
                if (SelectedCustomer != null)
                    Screen.Display(new CustomerDetailScreen());
                else
                { Quit(); return; }
                customerList.Draw();

            } while (Show);

            void Edit(CustomerModel input)
            {
                if (input is CustomerModel customer)
                    Screen.Display(new CustomerEditScreen(customer));
            }
            void NewCustomer(Object O)
            {
                Display(new CustomerEditScreen());
            }
            void Delete(CustomerModel input)
            {

                Database.Instance.RemoveCustomer(input.PersonID);
                Draw();
            }
        }
    }
}

