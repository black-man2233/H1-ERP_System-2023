using H1ERPSystem2023;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using H1ERPSystem2023.Screens;
using TECHCOOL.UI;

namespace H1_ERP_System_2023.Screens
{
    /// <summary>
    /// Displays All sales orders with their properties
    /// </summary>
    public class SalesOrderHeadersScreen : Screen
    {
        public override string Title { get; set; } = "Sales Order Header";
        private SalesOrderModel? SelectedSaleOrder { get; set; }

        protected override void Draw()
        {
            //loops so user can always select an item
            do
            {
                //Clear the screen at the start to avoid other text
                Clear(this);
                Console.WriteLine("F1 to create a new company");
                Console.WriteLine("F2 to edit a exiting company");

                ListPage<SalesOrderModel?> salesOrderList = new();
                foreach (SalesOrderModel saleOrder in Database.Instance.GetAllSalesOrder())
                    salesOrderList.Add(saleOrder);

                salesOrderList.AddColumn("Order Number", "OrderNumber");
                salesOrderList.AddColumn("Date", "CreationDate");
                salesOrderList.AddColumn("Customer Number", "OrderCustomerNumber");
                salesOrderList.AddColumn("Full Name", "OrderFullName");
                salesOrderList.AddColumn("Sum", "OrderSum");

                salesOrderList.AddKey(ConsoleKey.F1, NewProd);
                salesOrderList.AddKey(ConsoleKey.F2, Edit);
                //option to Select between SaleOrders,
                //make sure to check for not null. That will tell it's been selected with enter
                SelectedSaleOrder = salesOrderList.Select();
                if (SelectedSaleOrder != null)
                    Screen.Display(new SaleOrderDetailScreen(SelectedSaleOrder));
                else
                {
                    Quit();
                    return;
                }

                salesOrderList.Draw();
                Console.ReadLine();
            } while (Show);
        }
        void Edit(SalesOrderModel _input)
        {
            if (_input is SalesOrderModel salesOrder)
                Screen.Display(new SaleOrderEditScreen(salesOrder));
        }
        void NewProd(Object O)
        {
            Display(new SaleOrderEditScreen());
        }
    }
}