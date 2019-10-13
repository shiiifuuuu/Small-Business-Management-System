using Small_Business_Management_System.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.REPOSITORY
{
    class PurchaseRepository
    {
        SqlConnection sqlConnection;
        //string serverName = @"SHIIIFUUUU";
        //string databaseName = @"SmallBusinessManagementSystem";
        string serverName = @"PC-301-21\SQLEXPRESS";
        string databaseName = @"SmallBusinessManagementSystem";

        public PurchaseRepository()
        {
            String connectionString = "Server=" + serverName + "; Database=" + databaseName + "; Integrated Security=true";
            sqlConnection = new SqlConnection(connectionString);
        }

        internal List<Supplier> SupplierComboLoad()
        {
            List<Supplier> suppliers = new List<Supplier>();
            String commandString = @"SELECT Id, Name FROM Supplier";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.Id = int.Parse(dataReader["Id"].ToString());
                supplier.Name = dataReader["Name"].ToString();

                suppliers.Add(supplier);
            }

            sqlConnection.Close();

            return suppliers;
        }
    }
}
