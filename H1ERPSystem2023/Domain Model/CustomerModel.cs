#pragma warning disable
namespace H1ERPSystem2023.DomainModel
{
    public class CustomerModel : PersonModel
    {
        public string CustomerNumber { get; set; }
        public DateTime? LastPurchaseDate { get; set; }

        public CustomerModel() : base() { }

        public CustomerModel(CustomerModel customer) : base(customer.PersonID, customer.FirstName, customer.LastName, customer.Address, customer.PhoneNumber, customer.EmailAddress)
        { 
            PersonID = customer.PersonID;
            FirstName = customer.FirstName;
            LastName = customer.LastName;
            Address = customer.Address;
            PhoneNumber = customer.PhoneNumber;
            EmailAddress = customer.EmailAddress;
            LastPurchaseDate = customer.LastPurchaseDate;
        }

        /// <summary>
        /// Creates a new Customer With a Person Parameters
        /// </summary>
        public CustomerModel(string personId, string firstName, string lastName, AddressModel address, string phoneNumber, string emailAddress, string customerNumber, DateTime? lastPurchaseDate) : base(personId, firstName, lastName, address, phoneNumber, emailAddress)
        {
            #region Person
            this.PersonID = personId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            #endregion

            #region Customer
            this.CustomerNumber = customerNumber;
            this.LastPurchaseDate = lastPurchaseDate;
            #endregion
        }
    }
}
