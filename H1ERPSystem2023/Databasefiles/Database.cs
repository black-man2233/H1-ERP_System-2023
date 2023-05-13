#pragma warning disable
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using H1ERPSystem2023.DomainModel;

namespace H1ERPSystem2023.Databasefiles
{
    public partial class Database
    {
        public static Database Instance { get; }

        static Database()
        {
            Instance = new Database();
            GetAllData();
        }

        
        private static void GetAllData()
        {
            Instance.GetAddressesFromDB(GetConnection());
            Instance.GetCompaniesFromDB(GetConnection());
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