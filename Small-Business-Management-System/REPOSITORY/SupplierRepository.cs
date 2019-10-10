﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Small_Business_Management_System.MODEL;

namespace Small_Business_Management_System.REPOSITORY
{
    public class SupplierRepository
    {
        SqlConnection sqlConnection;
        //string serverName = @"SHIIIFUUUU";
        //string databaseName = @"SmallBusinessManagementSystem";
        string serverName = @"PC-301-21\SQLEXPRESS";
        string databaseName = @"SmallBusinessManagementSystem";

        public SupplierRepository()
        {
            String connectionString = "Server=" + serverName + "; Database=" + databaseName + "; Integrated Security=true";
            sqlConnection = new SqlConnection(connectionString);
        }

        internal List<Supplier> GetRecords()
        {
            String commandString = @"SELECT * FROM Supplier";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Supplier> suppliers = new List<Supplier>();
            while (dataReader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.Id = int.Parse(dataReader["Id"].ToString());
                supplier.Code = dataReader["Code"].ToString();
                supplier.Name = dataReader["Name"].ToString();
                supplier.Address = dataReader["Address"].ToString();
                supplier.Email = dataReader["Email"].ToString();
                supplier.Contact = dataReader["Contact"].ToString();
                supplier.ContactPerson = dataReader["ContactPerson"].ToString();

                suppliers.Add(supplier);
            }
            sqlConnection.Close();
            return suppliers;
        }

        internal bool IsEmailUnique(Supplier supplier)
        {
            bool isUnique = false;
            string searchString = null;
            String commandString = "SELECT Email FROM Supplier " +
                "WHERE Email = '" + supplier.Email + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                searchString = dataReader["Email"].ToString();
            }
            if (String.IsNullOrEmpty(searchString))
            {
                isUnique = true;
            }
            sqlConnection.Close();
            return isUnique;
        }

        internal bool IsContactUnique(Supplier supplier)
        {
            bool isUnique = false;
            string searchString = null;
            String commandString = "SELECT Contact FROM Supplier " +
                "WHERE Contact = '" + supplier.Contact + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                searchString = dataReader["Contact"].ToString();
            }
            if (String.IsNullOrEmpty(searchString))
            {
                isUnique = true;
            }
            sqlConnection.Close();
            return isUnique;
        }

        internal bool IsCodeUnique(Supplier supplier)
        {
            bool isUnique = false;
            string searchString = null;
            String commandString = "SELECT Code FROM Supplier " +
                "WHERE Code = '" + supplier.Code + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                searchString = dataReader["Code"].ToString();
            }
            if (String.IsNullOrEmpty(searchString))
            {
                isUnique = true;
            }
            sqlConnection.Close();
            return isUnique;
        }

        internal void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception) { }
        }

        internal bool AddSupplier(Supplier supplier)
        {
            bool isAdded = false;
            String commandString = @"INSERT INTO Supplier (Code,Name,Address,Email,Contact,ContactPerson) 
                VALUES ('"+ supplier.Code+"', '"+supplier.Name+"','"+supplier.Address+"','"+supplier.Email+"','"+supplier.Contact+"','"+supplier.ContactPerson+"')";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isAdded = true;
            }
            sqlConnection.Close();
            return isAdded;
        }
    }
}
