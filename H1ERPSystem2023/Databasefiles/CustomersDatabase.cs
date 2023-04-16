using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        #region Properties

        private List<CustomerModel>? CustomersList { get; set; }

        public List<CustomerModel>? GetCuStomersList() => this.CustomersList;

        #endregion

        #region Methods

        private void _addCustomer()
        {
            for (int rPersonId = 0; rPersonId < 6; rPersonId++)
            {
                CustomerModel customer = new(personId: rPersonId, firstName: $"Kevin {rPersonId}",
                    lastName: "Simp", address: null,
                    phoneNumber: $"+45 {rPersonId} 1428084", emailAddress: $"{rPersonId} @customer.dk",
                    customerNumber: "1",
                    lastPurchaseDate: DateTime.Today);

                CustomersList.Add(customer);
            }
        }

        #endregion
    }
}