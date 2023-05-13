using H1ERPSystem2023.Screens;
using H1ERPSystem2023.Databasefiles;
using TECHCOOL.UI;
using Microsoft.Data.SqlClient;

namespace H1ERPSystem2023
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Database db = new();

            Screen.Display(new MenuScreen());
        }
    }
}