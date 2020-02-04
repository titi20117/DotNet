﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DbProvider
{
    class InitConnectionUsersAwards
    {
        private static SqlConnection connection;
        public static SqlConnection InitConnection()
        {
            if (connection == null)
            {
                connection = new SqlConnection(DatabaseConfig.GetConnectionString());
                connection.StateChange += ConnectionStateChange;
            }

            return connection;
        }

        private static void ConnectionStateChange(object sender, StateChangeEventArgs e)
        {
            if (e.CurrentState == ConnectionState.Broken)
                InitConnection();
        }
    }
}