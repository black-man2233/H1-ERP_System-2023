using H1ERPSystem2023.Screens;
using H1ERPSystem2023.Databasefiles;
using H1ERPSystem2023.DomainModel;
using TECHCOOL.UI;
using static H1ERPSystem2023.Screens.CustomerListScreen;
using System.Runtime.ExceptionServices;

namespace H1ERPSystem2023
{
    internal class Program
    {
       
        public static void Main(string[] args)
        {
            CompanyEditScreen SC1 = new CompanyEditScreen();
            Screen.Display(SC1);

        }
    }
}