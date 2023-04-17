using H1ERPSystem2023.DomainModel;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        public List<CustomerModel> Customers = new List<CustomerModel>();
      
        public void _addCustomers()
        {
            Customers.Add(new CustomerModel("1", "FirstName", "LastName", null, "12345678", "Email@Email.com", null));
            Customers.Add(new CustomerModel("2", "AnotherGuy", "fafaf", null, "87654321", "AG@mail.com", null));
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
            return null;
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
        public void UpdateCustomer(string PersonID, string firstName, string lastName, AddressModel? address, string phoneNumber, string emailAddress, DateTime? lastPurchaseDate)
        {
            foreach (CustomerModel customer in Customers)
            {
                if (customer.PersonId == PersonID)
                {
                    customer.FirstName = firstName;
                    customer.LastName = lastName;
                    customer.Address = address;
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
