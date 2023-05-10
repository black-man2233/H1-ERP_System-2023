using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        public static Database Instance { get; }

        static Database()
        {
            Instance = new Database();
            Instance._addCompanies();
            Instance._addProducts();
            Instance._addCustomers();
            Instance._addSalesOrders();
        }

        public static void ReadData()
        {
            string queryString = "Customer";
            switch (queryString)
            {
                case "Customer":
                    queryString = "SELECT TOP(1000) * FROM dbo.Customer;";
                    break;
            }
            SqlCommand cmd = new(queryString, GetConnection());
            cmd.Connection.Open();

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    Console.WriteLine(string.Format("{0}", reader[0]));
                }
            }
            //cmd.ExecuteNonQuery();
        }

        private static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder sb = new()
            {
                DataSource = "docker.data.techcollege.dk",
                InitialCatalog = "H1PD021123_Gruppe5",
                IntegratedSecurity = false,
                UserID = "H1PD021123_Gruppe5",
                Password = "H1PD021123_Gruppe5",
                TrustServerCertificate = true
            };
            string connectionString = sb.ToString();
            SqlConnection connection = new(connectionString);
            return connection;
        }
    }
}