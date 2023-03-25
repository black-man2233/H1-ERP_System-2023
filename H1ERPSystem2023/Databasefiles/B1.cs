using H1_ERP_System_2023.Domain_Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1ERPSystem2023.Databasefiles
{
    internal class B1
    {
        private SqlConnection getConnection()
        {
            SqlConnectionStringBuilder sb = new();
            sb.DataSource = "docker.data.techcollege.dk";
            sb.InitialCatalog = "H1PD021123_Gruppe5";
            sb.UserID = "H1PD021123_Gruppe5";
            sb.Password = "H1PD021123_Gruppe5";
            string connectionString = sb.ToString();
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }


    }
}
