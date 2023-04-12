using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using H1ERPSystem2023.Screens;
using TECHCOOL.UI;
using static H1ERPSystem2023.Databasefiles.Database;

namespace H1ERPSystem2023
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            Database d = new();
            d._addCustomers();

            TodoListScreen ListScreen = new TodoListScreen();
            MyFirstScreen firstScreen = new MyFirstScreen();
            Screen.Display(ListScreen);



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





        }
    }
}