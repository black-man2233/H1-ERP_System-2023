﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace H1ERPSystem2023.Database
{
    internal partial class Database
    {
        public static Database Instance { get; }

        static Database()
        {
            Instance = new Database();
        }// !!Hvis jeg sætter metoden til privat får jeg fejl!!

        private static SqlConnection GetConnection()
        {
            SqlConnectionStringBuilder sb = new()
            {
                DataSource = "docker.data.techcollege.dk",
                InitialCatalog = "H1PD021123_Gruppe5",
                UserID = "H1PD021123_Gruppe5",
                Password = "H1PD021123_Gruppe5"
            };
            string connectionString = sb.ToString();
            SqlConnection connection = new(connectionString);
            return connection;
        }

    }
}