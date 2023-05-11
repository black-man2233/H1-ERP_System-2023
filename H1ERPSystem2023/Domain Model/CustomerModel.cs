#pragma warning disable
namespace H1ERPSystem2023.DomainModel
{
    public class CustomerModel : PersonModel
    {
        public string CustomerNumber { get; set; }
        public DateTime? LastPurchaseDate { get; set; }

        public string Street
        {
            get { return this.Address.Street; }
            set { this.Address.Street = value; }
        }

        public string StreetNumber
        {
            get { return this.Address.StreetNumber; }
            set { this.Address.StreetNumber = value; }
        }

        public string PostalCode
        {
            get { return this.Address.PostalCode; }
            set { this.Address.PostalCode = value; }
        }

        public string City
        {
            get { return this.Address.City; }
            set { this.Address.City = value; }
        }
        public CustomerModel() : base() { }

        public CustomerModel(CustomerModel customer) : base(customer.FirstName, customer.LastName, customer.Address, customer.PhoneNumber, customer.EmailAddress)
        { 
            CustomerNumber = customer.CustomerNumber;
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
        public CustomerModel(string firstName, string lastName, AddressModel address, string phoneNumber, string emailAddress, string customerNumber, DateTime? lastPurchaseDate) 
            : base(firstName, lastName, address, phoneNumber, emailAddress)
        {
            #region Person
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
