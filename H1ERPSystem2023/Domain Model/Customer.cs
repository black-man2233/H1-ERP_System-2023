﻿namespace H1_ERP_System_2023.Domain_Model
{
    internal class Customer : Person
    {
        public string CustomerNumber { get; set; }
        public DateTime LastPurchaseDate { get; set; }

        /// <summary>
        /// Creates a new Customer With a Person Parameters
        /// </summary>
        public Customer(int personId, string firstName, string lastName, Address address, string phoneNumber, string emailAddress, string customerNumber, DateTime lastPurchaseDate) : base(personId, firstName, lastName, address, phoneNumber, emailAddress)
        {
            #region Person
            this.PersonId = personId;
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