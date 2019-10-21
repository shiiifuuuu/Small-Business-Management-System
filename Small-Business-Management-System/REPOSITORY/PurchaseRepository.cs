﻿using Small_Business_Management_System.MODEL;
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

        public PurchaseRepository()
        {
            sqlConnection = ServerConnection.Connect();
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

        internal double GetPrevious(string columnName, Purchase purchase)
        {
            String commandString = @"SELECT * FROM Purchase WHERE Category = '" + purchase.Category + "' AND Product = '" +
                purchase.Product + "' AND Code = '" + purchase.Code + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();

            double previous = 0;
            while (dataReader.Read())
            {
                previous = double.Parse(dataReader[columnName].ToString()); //UnitPrice or MRP
            }

            sqlConnection.Close();

            return previous;
        }

        internal List<Product> SearchProducts(string category)
        {
            List<Product> products = new List<Product>();
            String commandString = @"SELECT * FROM Product WHERE Category = '"+category+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Product product = new Product();
                product.Id = int.Parse(dataReader["Id"].ToString());
                product.Name = dataReader["Name"].ToString();
                product.Code = dataReader["Code"].ToString();
                product.ReorderLevel = dataReader["ReorderLevel"].ToString();

                products.Add(product);
            }

            sqlConnection.Close();

            return products;
        }

        internal List<Product> ProductComboLoad()
        {
            List<Product> products = new List<Product>();
            String commandString = @"SELECT Id, Name FROM Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Product product = new Product();
                product.Id = int.Parse(dataReader["Id"].ToString());
                product.Name = dataReader["Name"].ToString();

                products.Add(product);
            }

            sqlConnection.Close();

            return products;
        }

        internal List<Category> CategoryComboLoad()
        {
            List<Category> categories = new List<Category>();
            String commandString = @"SELECT Id, Name FROM Category";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Category category = new Category();
                category.Id = int.Parse(dataReader["Id"].ToString());
                category.Name = dataReader["Name"].ToString();

                categories.Add(category);
            }

            sqlConnection.Close();

            return categories;
        }
    }
}
