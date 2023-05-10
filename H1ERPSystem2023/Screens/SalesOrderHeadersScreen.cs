#pragma warning disable
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
        private SalesOrderModel SelectedSaleOrder;

        protected override void Draw()
        {
            //loops so user can always select an item
            do
            {
                //Clear the screen at the start to avoid other text
                Clear(this);
                Console.WriteLine("F1 to create a new sale order");
                Console.WriteLine("F2 to edit a exiting sale order");
                Console.WriteLine("F5 to delete a exiting sale order");

                ListPage<SalesOrderModel> salesOrderList = new();

                foreach (SalesOrderModel saleOrder in Database.Instance.GetAllSalesOrder())
                    salesOrderList.Add(saleOrder);

                salesOrderList.AddColumn("Order Number", "OrderNumber");
                salesOrderList.AddColumn("Order Date", "CreationDateString");
                salesOrderList.AddColumn("Customer Number", "CustomerID");
                salesOrderList.AddColumn("Full Name", "CustomerName");
                salesOrderList.AddColumn("Sum", "Amount");

                salesOrderList.AddKey(ConsoleKey.F1, NewProd);
                salesOrderList.AddKey(ConsoleKey.F2, Edit);
                salesOrderList.AddKey(ConsoleKey.F5, DeleteProd);
                //option to Select between SaleOrders,
                //make sure to check for not null. That will tell it's been selected with enter

                try
                {
                    SelectedSaleOrder = salesOrderList.Select();
                    if (SelectedSaleOrder != null)
                        Screen.Display(new SaleOrderDetailScreen(SelectedSaleOrder));
                    else
                    {
                        Quit();
                        return;
                    }
                }
                catch (Exception)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Select a row above");
                    Console.ForegroundColor = ConsoleColor.White;

                    Console.ReadLine();
                    Console.Clear();
                    Display(new SalesOrderHeadersScreen());
                    Quit();
                }


                salesOrderList.Draw();
            } while (Show);
        }
        void Edit(SalesOrderModel _input)
        {
            Display(new SaleOrderEditScreen(_input));
        }
        void NewProd(Object O)
        {
            Display(new SaleOrderEditScreen());
        }
        void DeleteProd(SalesOrderModel thisSalesOrder)
        {
            Database.Instance.RemoveSaleOrder(thisSalesOrder.OrderNumber);
            Draw();
        }
    }
}