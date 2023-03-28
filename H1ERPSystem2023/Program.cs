using H1_ERP_System_2023.Databasefiles;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.Domain_Model;
using TECHCOOL.UI;

namespace H1ERPSystem2023
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            MyFirstScreen firstScreen = new MyFirstScreen();
            Screen.Display(firstScreen);

            //Console.WriteLine("Hello, World!");
            //Database db = new Database();
            //SalesOrder salesOrder = new SalesOrder()
            //{
            //    OrderNumber = 1,
            //    CreationDate = new DateTime(),
            //    CompleteDate = new DateTime(),
            //    CustomerID = 1,
            //    Condition = Condition.Created
            //};
            //db.AddSaleOrder(salesOrder);


            Database d = new();

            SalesOrder o = new();
            o.OrderNumber = 1;
            o.CustomerID = 12;

            d.UpdateSalesOrders(o);
        }
    }
}