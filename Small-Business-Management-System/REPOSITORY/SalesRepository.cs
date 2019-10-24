using Small_Business_Management_System.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.REPOSITORY
{
    
    public class SalesRepository
    {
        Sales _sales = new Sales();

        SqlConnection sqlConnection;

        public SalesRepository()
        {
            sqlConnection = ServerConnection.Connect();
        }
        internal bool IsUnique(string inputString, string columnName)
        {
            bool isUnique = false;
            string searchString = null;
            //SELECT * FROM Supplier WHERE Code = '"+supplier.Code+"'
            String commandString = "SELECT * FROM Sales WHERE " + columnName + " = '" + inputString + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                searchString = dataReader[columnName].ToString();
            }
            if (String.IsNullOrEmpty(searchString))
            {
                isUnique = true;
            }
            sqlConnection.Close();
            return isUnique;
        }

        internal  string SalesCode( string code)
        {
            int a = 0;
            String commandString = @"SELECT MAX(Id) FROM Sales";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                string val = dataReader[0].ToString();
                DateTime myDate = DateTime.Now;
                string strTime = myDate.ToString("ddMMyyyy");
                if(val == "")
                {
                    int intValue = a;
                    code = DateTime.Now.Year+"-" + (intValue + 1).ToString().ToString().PadLeft(4, '0');
                }

                else
                {
                    a = Convert.ToInt32(dataReader[0].ToString()) + 1;
                    code = DateTime.Now.Year+"-"+ a.ToString();
                }
            }

            sqlConnection.Close();

            return code;
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
        internal List<Customer> CustomerComboLoad()
        {
            List<Customer> customers = new List<Customer>();
            String commandString = @"SELECT Id, Name FROM Customer";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Customer customer = new Customer();
                customer.Id = int.Parse(dataReader["Id"].ToString());
                customer.Name = dataReader["Name"].ToString();

                customers.Add(customer);
            }

            sqlConnection.Close();

            return customers;
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
        internal List<Sales> Search(string searchText)
        {
            string commandString = @"SELECT * FROM Sales WHERE SalesDate LIKE '%" + searchText + "%' " +
                "OR Code LIKE '%" + searchText + "%' OR Customer LIKE '%" + searchText + "%'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Sales> sales = new List<Sales>();
            while (dataReader.Read())
            {
                Sales _sales = new Sales();
                _sales.Code = dataReader["Code"].ToString();
                _sales.Customer = dataReader["Customer"].ToString();
                _sales.Product = dataReader["Product"].ToString();
                _sales.Quantity = Convert.ToInt32(dataReader["Quantity"]);
                _sales.MRP = Convert.ToDouble(dataReader["MRP"]);
                _sales.TotalMRP = Convert.ToDouble(dataReader["TotalMRP"]);

                sales.Add(_sales);
            }
            sqlConnection.Close();

            return sales;
        }
        internal bool Modify(Sales sales)
        {
            bool isModified = false;
            String commandString = @"UPDATE Sales SET Product = '" + _sales.Product + "', Quantity = '" +
                   _sales.Quantity + "', MRP = '" + _sales.MRP + "', TotalMRP = '" +
                   _sales.TotalMRP + "' WHERE Id = " + _sales.Id + "";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isModified = true;

            }
            sqlConnection.Close();
            return isModified;
        }

        internal bool Delete(Sales sales)
        {
            bool isDeleted = false;
            String commandString = @"DELETE FROM Product WHERE Id = " + sales.Id + "";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isDeleted = true;
            }
            sqlConnection.Close();
            return isDeleted;
        }
        internal bool SubmitAll(Sales sales)
        {
            bool isAdded = false;
            String commandString = @"INSERT INTO Sales (Code,Customer,SalesDate,LoyalityPoint,Category,Product,AvabileQuantity,Quantity,MRP,TotalMRP,Discount,DiscountAmount,PayableAmount) 
                                   VALUES ('" + sales.Code + "', '" + sales.Customer + "','" + sales.SelasDate + "','" + sales.Customer + "', '" + sales.LoyalityPoint + "','" +
                                   sales.Category + "','" + sales.Product + "','" + sales.AvabileQuantity + "','" + sales.Quantity + "','" + sales.MRP + "','" +
                                    +sales.TotalMRP + "','" + sales.GrandTotal + "','" + sales.Discount + "','" + sales.DiscountAmount + "','" + sales.PayableAmount + "')";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isAdded = true;
            }
            sqlConnection.Close();
            return isAdded;
        }
        public int GetAvailableQuantity()
        {
            int availableQuantity = 0;
            string commandString = @"SELECT AvailableQuantity FROM Purchase As 'p', sales As 's' WHERE p.Id = s.PurchaseId";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                if (String.IsNullOrEmpty(dataReader["AvailableQuantity"].ToString()))
                {
                    availableQuantity = int.Parse(dataReader["AvailableQuantity"].ToString());
                }
                if (String.IsNullOrEmpty(dataReader["Quantity"].ToString())) ;
                {
                    availableQuantity -= int.Parse(dataReader["Quantity"].ToString());
                }
            }

            sqlConnection.Close();

            return availableQuantity;
        }

        internal void CloseConnection()
        {
            try
            {
                sqlConnection.Close();
            }
            catch (Exception) { }
        }
    }
}
