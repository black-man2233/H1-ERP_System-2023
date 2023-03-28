using H1ERPSystem2023.Screens;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;

namespace H1ERPSystem2023
{
    internal class Program
    {
        static void Main()
        {
            //Screen Related
            Screen.Display(new MenuScreen());

            Database d = new();

            SalesOrder o = new();
            o.OrderNumber = 1;
            o.CustomerID = 12;

            d.UpdateSalesOrders(o);
        }
    }
}