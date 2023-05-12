#pragma warning disable
using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        private List<CustomerModel> Customers = new List<CustomerModel>();

        public void _addCustomers()
        {
           
        }

        public void AddCustomer(CustomerModel customer)
        {
            Customers.Add(customer);
        }

        public void AddCustomer(string firstName, string lastName, AddressModel? address,
            string phoneNumber, string emailAddress,
            string customerNumber, DateTime? lastPurchaseDate)
        {
            Customers.Add(new CustomerModel(firstName, lastName, address, phoneNumber, emailAddress,
                customerNumber, lastPurchaseDate));
        }

        public CustomerModel GetCustomer(string PersonID)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.CustomerNumber == PersonID)
                {
                    return customer;
                }
            }

            Console.WriteLine("ID findes Ikke");
            return null!;
        }

        public List<CustomerModel> GetAllCustomerModels()
        {
            List<CustomerModel> _allCustomeers = new();

            foreach (CustomerModel customer in Customers)
            {
                _allCustomeers.Add(customer);
            }

            return _allCustomeers;

            // SQL Connection thing -> SqlConnection SQLConn = getConnection(); <- touch at a later time
        }

        public void UpdateCustomer(string PersonID, string firstName, string lastName, AddressModel? address,
            string phoneNumber, string emailAddress, DateTime? lastPurchaseDate)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.CustomerNumber == PersonID)
                {
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.Address = address!;
                    customer.PhoneNumber = phoneNumber;
                    customer.EmailAddress = emailAddress;
                }
            }
        }

        public void RemoveCustomer(string PersonID)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.CustomerNumber == PersonID)
                {
                    Customers.Remove(customer);
                    break;
                }
            }
        }
    }
}