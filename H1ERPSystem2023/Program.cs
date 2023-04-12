using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using H1ERPSystem2023.Screens;
using TECHCOOL.UI;

namespace H1ERPSystem2023
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");
            Database db = new Database();
            SalesOrderModel salesOrder = new()
            {
                OrderNumber = 1,
                CreationDate = new DateTime(),
                CompleteDate = new DateTime(),
                CustomerID = 1,
                Condition = Condition.Created
            };
            db.AddSaleOrder(salesOrder);
            //Screen Related
            Screen.Display(new MenuScreen());



        }
    }
}