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
                    if (_personId == customer.PersonId)
                    {
                        _personId = random.Next().ToString();
                    }

                    if (_rCustommerId == customer.CustomerNumber)
                    {
                        _rCustommerId = random.Next().ToString();

                    }
                }

                Customers.Add(new(_personId, "Mathias", "Matutu", null, "91428084", "mathias@techshit.dk", _rCustommerId, null));
            }
        }

        public CustomerModel GetCustomer(string PersonID)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.PersonId == PersonID)
                {
                    return customer;
                }
            }

            Console.WriteLine("Id findes Ikke");
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
                if (customer.PersonId == PersonID)
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
                if (customer.PersonId == PersonID)
                {
                    Customers.Remove(customer);
                    break;
                }
            }
        }
    }
}