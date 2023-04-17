using H1_ERP_System_2023.Screens;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using H1ERPSystem2023.Screens;
using TECHCOOL.UI;
using static H1_ERP_System_2023.Screens.CustomerListScreen;

namespace H1ERPSystem2023
{
    internal class Program
    {

        public static void Main(string[] args)
        {
            CompaniesListScreen Screen2 = new CompaniesListScreen();
            CustomerListScreen Screen1 = new CustomerListScreen();

            Screen.Display(Screen1);
            
        }
    }
}