#pragma warning disable
using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        private List<CustomerModel> Customers = new List<CustomerModel>();

        public void _addCustomers()
        {

            Random random = new Random();
            string _rCustommerId = random.Next().ToString();

            for (int i = 0; i < 5; i++)
            {
                string _personId = random.Next().ToString();

                foreach (CustomerModel customer in Instance.GetAllCustomerModels())
                {
                    if (_personId == customer.PersonID)
                    {
                        _personId = random.Next().ToString();
                    }

                    if (_rCustommerId == customer.CustomerNumber)
                    {
                        _rCustommerId = random.Next().ToString();

                    }
                }

                Customers.Add(new(_personId, "Mathias", "Matutu", null, "91428084", "mathias@techshit.dk", _rCustommerId, null));
                Customers.Add(new("7", "TEST", "TEST", null, "91428084", "TEST@TEST.dk", "7", null));
            }
        }

        public void AddCustomer(CustomerModel customer)
        {
            Customers.Add(customer);
        }

        public void AddCustomer(string PersonID, string firstName, string lastName, AddressModel? address, string phoneNumber, string emailAddress,
            string customerNumber, DateTime? lastPurchaseDate)
        {
            Customers.Add(new CustomerModel(PersonID, firstName, lastName, address, phoneNumber, emailAddress, customerNumber, lastPurchaseDate));
        }

        public CustomerModel GetCustomer(string PersonID)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.PersonID == PersonID)
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
                if (customer.PersonID == PersonID)
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
                if (customer.PersonID == PersonID)
                {
                    Customers.Remove(customer);
                    break;
                }
            }
        }
    }
}