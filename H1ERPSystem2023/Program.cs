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
            try
            {
            Database db = new();

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

            //Screen.Display(new MenuScreen());
        }
    }
}