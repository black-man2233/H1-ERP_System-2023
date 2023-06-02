#pragma warning disable
using System.Data.SqlClient;
using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        private List<CustomerModel> Customers = new List<CustomerModel>();

        public void GetCustomersFromDB(SqlConnection connection)
        {
            try
            {
                SqlCommand command = new SqlCommand("SELECT * FROM dbo.Customers", connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    CustomerModel customer = new()
                    {
                        Address = new(Database.Instance.GetAddress(reader.GetInt32(6).ToString())),

                        CustomerNumber = reader["CustomerNumber"] != DBNull.Value ? (int)reader["CustomerNumber"] : 0,
                        LastPurchaseDate = reader["LastPurchaseDate"] != DBNull.Value
                            ? (DateTime)reader["LastPurchaseDate"]
                            : DateTime.MinValue,
                        FirstName = reader["FirstName"] != DBNull.Value ? (string)reader["FirstName"] : string.Empty,
                        LastName = reader["LastName"] != DBNull.Value ? (string)reader["LastName"] : string.Empty,
                        PhoneNumber = reader["PhoneNumber"] != DBNull.Value
                            ? (string)reader["PhoneNumber"]
                            : string.Empty,
                        EmailAddress = reader["EmailAddress"] != DBNull.Value
                            ? (string)reader["EmailAddress"]
                            : string.Empty
                    };
                    
                    Customers.Add(customer);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(
                    $"Something went wrong while trying to retrieve Customer from the database",
                    Console.ForegroundColor = ConsoleColor.Red);
                Console.ReadKey();
            }
            finally
            {
                connection.Close();
            }
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
                int.Parse(customerNumber), lastPurchaseDate));
        }

        public CustomerModel GetCustomer(string personID)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.CustomerNumber == int.Parse(personID))
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

        public void UpdateCustomer(string personID, string firstName, string lastName, AddressModel? address,
            string phoneNumber, string emailAddress, DateTime? lastPurchaseDate)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.CustomerNumber == int.Parse(personID))
                {
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.Address = address!;
                    customer.PhoneNumber = phoneNumber;
                    customer.EmailAddress = emailAddress;
                }
            }
        }

        public void RemoveCustomer(string personID)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.CustomerNumber == int.Parse(personID))
                {
                    Customers.Remove(customer);
                    break;
                }
            }
        }
    }
}