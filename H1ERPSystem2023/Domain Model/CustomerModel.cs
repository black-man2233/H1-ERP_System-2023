#pragma warning disable
namespace H1ERPSystem2023.DomainModel
{
    public class CustomerModel : PersonModel
    {
        public string PersonID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime? LastPurchaseDate { get; set; }
        public string CustomerFullName { get { return FirstName + " " +  LastName; } }

        /// <summary>
        /// Creates a new Customer With a Person Parameters
        /// </summary>
        public CustomerModel(string PersonID, string firstName, string lastName, AddressModel? address, string phoneNumber, string emailAddress, DateTime? lastPurchaseDate) : base(PersonID, firstName, lastName, address, phoneNumber, emailAddress)
        {
            #region Person
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
            #endregion

            #region Customer
            this.PersonID = PersonID;
            this.LastPurchaseDate = lastPurchaseDate;
            #endregion
        }


    }
}
