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
    public class SalesEditScreen : Screen
    {
        public override string Title { get; set; } = "Edit Sales Orders";

        protected override void Draw()
        {
            Clear(this);
            ListPage<SalesOrderModel> SalesList = new();
            Form<SalesOrderModel> editor = new();
            SalesOrderModel sales;

            foreach (SalesOrderModel SalesModel in Database.Instance.GetSalesOrder())
                SalesList.Add(SalesModel);

            SalesList.AddColumn("name", "Name");

            sales = SalesList.Select();

            editor.TextBox("First Name", "Name");
            editor.TextBox("Last Name", "LastName");
            editor.TextBox("Road", "Road");
            editor.TextBox("House Number", "HouseNumber");
            editor.TextBox("Zip Code", "ZipCode");
            editor.TextBox("City", "City");
            editor.TextBox("Phone Number", "PhoneNumber");
            editor.TextBox("Email Address", "EmailAddress");


            editor.Edit(sales);
            Console.ReadLine();
        }
    }
}