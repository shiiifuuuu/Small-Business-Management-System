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
                purchase.Product + "' AND ProductCode = '" + purchase.ProductCode + "'";
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
            String commandString = @"SELECT * FROM Product WHERE Category = '"+category+"' ";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Product product = new Product();
                product.Id = int.Parse(dataReader["Id"].ToString());
                product.Name = dataReader["Name"].ToString();
                product.Code = dataReader["Code"].ToString();

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

        public int GetAvailableQuantity(string code)
        {
            int availableQuantity = 0;
            string commandString = @"SELECT AvailableQuantity FROM Purchase WHERE ProductCode = '"+code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                if (String.IsNullOrEmpty(dataReader["AvailableQuantity"].ToString()))
                {
                    availableQuantity = int.Parse(dataReader["AvailableQuantity"].ToString());
                }
            }

            sqlConnection.Close();

            return availableQuantity;
        }

        public void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        internal bool Add(Purchase purchase)
        {
            bool isAdded = false;

            string commandString = @"INSERT INTO Purchase(PurchaseDate, InvoiceNo, Supplier, Category, Product, ProductCode, AvailableQuantity,
ManufactureDate, ExpireDate, Quantity, UnitPrice, TotalPrice, PreviousUnitPrice, PreviousMRP, MRP, Remarks)
VALUES('" + purchase.PurchaseDate + "','" + purchase.InvoiceNo + "','" + purchase.Supplier + "','" + purchase.Category + "','" + purchase.Product
+ "','" + purchase.ProductCode + "'," + purchase.AvailableQuantity + ",'" + purchase.ManufactureDate + "','" + purchase.ExpireDate
+ "'," + purchase.Quantity + "," + purchase.UnitPrice + "," + purchase.TotalPrice + "," + purchase.PreviousUnitPrice
+ "," + purchase.PreviousMRP + "," + purchase.MRP + ",'" + purchase.Remarks + "')";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isAdded = true;
            }

            sqlConnection.Close();

            return isAdded;
        }

        internal List<Purchase> GetRecords()
        {
            String commandString = @"SELECT * FROM Purchase";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Purchase> purchases = new List<Purchase>();
            while (dataReader.Read())
            {
                Purchase purchase = new Purchase();
                purchase.Id = int.Parse(dataReader["Id"].ToString());
                purchase.PurchaseDate = Convert.ToDateTime(dataReader["PurchaseDate"].ToString());
                purchase.InvoiceNo = dataReader["InvoiceNo"].ToString();
                purchase.Supplier = dataReader["Supplier"].ToString();
                purchase.Category = dataReader["Category"].ToString();
                purchase.Product = dataReader["Product"].ToString();
                purchase.ProductCode = dataReader["ProductCode"].ToString();
                purchase.AvailableQuantity = int.Parse(dataReader["AvailableQuantity"].ToString());
                purchase.ManufactureDate = dataReader["ManufactureDate"].ToString();
                purchase.ExpireDate = dataReader["ExpireDate"].ToString();
                purchase.Quantity = int.Parse(dataReader["Quantity"].ToString());
                purchase.UnitPrice = double.Parse(dataReader["UnitPrice"].ToString());
                purchase.TotalPrice = double.Parse(dataReader["TotalPrice"].ToString());
                purchase.PreviousUnitPrice = double.Parse(dataReader["PreviousUnitPrice"].ToString());
                purchase.PreviousMRP = double.Parse(dataReader["PreviousMRP"].ToString());
                purchase.MRP = double.Parse(dataReader["MRP"].ToString());
                purchase.Remarks = dataReader["Remarks"].ToString();

                purchases.Add(purchase);
            }
            sqlConnection.Close();
            return purchases;
        }
    }
}
