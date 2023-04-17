using H1ERPSystem2023;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1_ERP_System_2023.Screens
{
    public class SalesOrderHeadersScreen : Screen
    {
        public override string Title { get; set; } = "Sales Order Headers";
        private SalesOrderModel? SelectedSaleOrder { get; set; }

        private List<SalesOrderModel> _salesOrdersList = new();
        private List<CustomerModel> _customersList = new();

        protected override void Draw()
        {
            //Make sure to put in loop so user can always select
            do
            {
                //Clear the screen at the start to avoid other text
                Clear(this);

                ListPage<SalesOrderModel?> salesOrderList = new();

                foreach (SalesOrderModel saleOrder in Database.Instance.GetSalesOrder())
                    salesOrderList.Add(saleOrder);

                salesOrderList.AddColumn("Order Number", "OrderNumber");
                salesOrderList.AddColumn("Date", "CreationDate");
                salesOrderList.AddColumn("Custommer Number", "CustomerID");
                salesOrderList.AddColumn("First and Last Name", "");
                salesOrderList.AddColumn("Amount", "Amount");


                //Gives the user the option to Select between the companies when called, make sure to check for not null. That will tell it's been selected with enter
                SelectedSaleOrder = salesOrderList.Select();
                if (SelectedSaleOrder != null)
                    Screen.Display(new CompanyDetailScreen());
                else
                {
                    Quit();
                    return;
                }

                salesOrderList.Draw();
                Console.ReadLine();
            } while (Show);
        }
    }
}