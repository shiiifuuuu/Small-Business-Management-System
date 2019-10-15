using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System
{
    public static class ServerConnection
    {
        public static SqlConnection Connect()
        {
            //string serverName = @"SHIIIFUUUU";
            string databaseName = @"SmallBusinessManagementSystem";
            string serverName = @"PC-301-21\SQLEXPRESS";

            String connectionString = "Server=" + serverName + "; Database=" + databaseName + "; Integrated Security=true";
            return new SqlConnection(connectionString);
        }
    }
}
