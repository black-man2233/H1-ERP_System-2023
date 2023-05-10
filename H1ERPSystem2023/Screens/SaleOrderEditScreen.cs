using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class SaleOrderEditScreen : Screen
    {
        public override string Title { get; set; } = "Edit SalesOrders";
        private SalesOrderModel SalesOrder { get; set; }

        public SaleOrderEditScreen(Object? O)
        {
            if (O is SalesOrderModel salesOrder)
                this.SalesOrder = new(salesOrder);
        }

        public bool IsCreate { get; set; }
        public SaleOrderEditScreen()
        {
            IsCreate = true;
        }
        private void Create()
        {
            Form<SalesOrderModel> editor = new();

            editor.TextBox("Name", "CustomerName");
            editor.TextBox("Street", "CustomerStreet");
            editor.IntBox("Street Number", "CustomerStreetNumber");
            editor.IntBox("ZipCode", "CustomerPostalCode");
            editor.TextBox("City", "CustomerCity");
            editor.TextBox("Phone Number", "CustomerPhoneNumbers");
            editor.TextBox("Email Address", "CustomerEmailAddress");

            SalesOrder = new();
            editor.Edit(SalesOrder);
        }

        protected override void Draw()
        {
            Clear();
            Console.Clear();
            if (IsCreate)
            {
                Create();
                Database.Instance.AddSaleOrder(SalesOrder);
            }
            else
            {
                Clear(this);

                Form<SalesOrderModel> editor = new();

                editor.TextBox("Name", "CustomerName");
                editor.TextBox("Street", "CustomerStreet");
                editor.TextBox("Street Number", "CustomerStreetNumber");
                editor.TextBox("ZipCode", "CustomerPostalCode");
                editor.TextBox("City", "CustomerCity");
                editor.TextBox("Phone Number", "CustomerPhoneNumbers");
                editor.TextBox("Email Address", "CustomerEmailAddress");

                editor.Edit(SalesOrder);
                Database.Instance.UpdateSalesOrders(SalesOrder);
            }
        }
    }
}
