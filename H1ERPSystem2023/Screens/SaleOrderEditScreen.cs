using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TECHCOOL.UI;

namespace H1ERPSystem2023.Screens
{
    public class SaleOrderEditScreen : Screen
    {
        public override string Title { get; set; } = "Edit Sales Orders";
        public SalesOrderModel SalesOrder { get; set; } = new();

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
        void Create()
        {
            Form<SalesOrderModel> editor = new();

            editor.TextBox("Name", "FirstName");
            editor.TextBox("Last Name", "LastName");
            editor.TextBox("Street", "Street");
            editor.TextBox("Street Number", "StreetNumber");
            editor.TextBox("ZipCode", "PostalCode");
            editor.TextBox("City", "City");
            editor.TextBox("Phone Number", "PhoneNumber");
            editor.TextBox("Email Address", "EmailAddress");
            editor.Edit(SalesOrder);
        }

        protected override void Draw()
        {
            if (IsCreate)
            {
                Create();
                Database.Instance.AddSaleOrder(SalesOrder);
            }
            else
            {
                Clear(this);

                Form<SalesOrderModel> editor = new();

                editor.TextBox("Name", "FullName");
                editor.TextBox("Street", "Street");
                editor.TextBox("Street Number", "StreetNumber");
                editor.TextBox("Postal Code", "PostalCode");
                editor.TextBox("City", "City");
                editor.TextBox("Phone Number", "PhoneNumber");
                editor.TextBox("Email Address", "EmailAddress");

                editor.Edit(SalesOrder);
                Database.Instance.UpdateSalesOrders(SalesOrder);
            }
        }
    }
}
