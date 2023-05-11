#pragma warning disable

namespace H1ERPSystem2023.DomainModel
{
    public abstract class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel? Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }

        public string GetFullAdress
        {
            get
            {

                if (this.Address is not null)
                {
                    return this.Address.GetFullAdress;
                }
                else
                    return string.Empty;
        
            }
        }

        public PersonModel()
        {
            this.Address = new AddressModel();
        }

        public PersonModel(string firstName, string lastName, AddressModel address, string phoneNumber, string emailAddress)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = new(address);
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
        }
    }
}
