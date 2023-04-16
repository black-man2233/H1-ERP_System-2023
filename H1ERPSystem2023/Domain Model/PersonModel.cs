namespace H1ERPSystem2023.DomainModel
{
    public abstract class PersonModel
    {
        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public AddressModel Address { get; set; }
        public string PhoneNumber { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }


        public PersonModel(int personId, string firstName, string lastName, AddressModel address, string phoneNumber,
            string emailAddress)
        {
            this.PersonId = personId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Address = address;
            this.PhoneNumber = phoneNumber;
            this.EmailAddress = emailAddress;
        }
    }
}