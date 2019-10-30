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
                    code = DateTime.Now.Year+"-"+ a.ToString().PadLeft(4, '0');
                }
            }

            sqlConnection.Close();

            return code;
        }

        

        internal List<Product> ProductComboLoadByCategory(int categoryId)
        {
            List<Product> products = new List<Product>();
            String commandString = @"SELECT Id, Name FROM Product";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                Product product = new Product();
                product.Id =Convert.ToInt32(dataReader["Id"].ToString());
                product.Name = dataReader["Name"].ToString();

                products.Add(product);
            }

            sqlConnection.Close();

            return products;
        }

        internal string GetAvailableQuantity(string product)
        {
            int availableQuantity = 0;
            string commandString = @"SELECT Quantity FROM Purchase WHERE Product = '" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                if (!String.IsNullOrEmpty(dataReader["Quantity"].ToString()))
                {
                    availableQuantity += int.Parse(dataReader["Quantity"].ToString());
                }

                //if (!String.IsNullOrEmpty(availableQuantity.ToString()))
                //{
                //    if (availableQuantity > 0)
                //    {
                //        availableQuantity -= int.Parse(dataReader["Quantity"].ToString());
                //    }
                //}
            }

            sqlConnection.Close();

            return availableQuantity+"" ;
        }
        internal string GetMRP(string product)
        {
            double mrp = 0;
            String commandString = @"SELECT MRP FROM Purchase Where Product = '" + product + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                if (!String.IsNullOrEmpty(dataReader["MRP"].ToString()))
                {
                    mrp = Convert.ToDouble(dataReader["MRP"].ToString());
                }
               
            }

            sqlConnection.Close();

            return mrp+"";
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

        internal int LoyatityPoint(int custerId)
        {
            int loyalityPoint = 0;
            String commandString = @"SELECT LoyaltyPoint FROM Customer Where Id = '" + custerId + "'";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            if (dataReader.Read())
            {
                loyalityPoint = Convert.ToInt32(dataReader[0].ToString());
            }

            sqlConnection.Close();

            return loyalityPoint;
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
                //_sales.Code = dataReader["Code"].ToString();
                //_sales.Customer = dataReader["Customer"].ToString();
                _sales.Product = dataReader["Product"].ToString();
                _sales.Quantity = Convert.ToInt32(dataReader["Quantity"]);
                _sales.MRP = Convert.ToDouble(dataReader["MRP"]);
                _sales.TotalMRP = Convert.ToDouble(dataReader["TotalMRP"]);

                sales.Add(_sales);
            }
            sqlConnection.Close();

            return sales;
        }


        internal bool Add(Sales sales)
        {
            bool isAdded = false;

            string commandString = @"INSERT INTO Sales(CustomerId, Code,Customer,SalesDate, LoyalityPoint, Category, Product, AvabileQuantity, 
                 Quantity, MRP, TotalMRP, GrandTotal, Discount, DiscountAmount, PayableAmount)
                VALUES('" + sales.CustomerId + "','" + sales.Code + "','" +sales.Customer + "','" + sales.SelasDate + "','" + sales.LoyalityPoint + "','" + sales.Category + "','" + sales.Product + "','" +
                sales.AvabileQuantity + "', '" + sales.Quantity + "','" + sales.MRP + "','" +sales.TotalMRP+ "','" +
                sales.GrandTotal + "','" + sales.Discount + "','" + sales.DiscountAmount + "','" + sales.PayableAmount + "')";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isAdded = true;
            }

            sqlConnection.Close();

            return isAdded;
        }

        internal bool Modify(Sales sales)
        {
            bool isModified = false;

            String commandString = @"UPDATE Purchase SET  Customer = '" + sales.Customer + "',SalesDate='" + sales.SelasDate
                + "',LoyatityPoint='" + sales.LoyalityPoint + "',Category='" + sales.Category + "',Product='" + sales.Product
                + "',AvabileQuantity='" + sales.AvabileQuantity  + "', Quantity=" + sales.Quantity + ", MRP=" + sales.MRP 
                +",TotalMRP=" + sales.TotalMRP + ",GrandTotal=" + sales.GrandTotal + ",Discount=" + sales.Discount
                + ",DiscountAmount=" + sales.DiscountAmount + ",PayableAmount='" +sales.PayableAmount + "' Where Id = " + sales.Id + "";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isModified = true;
            }
            sqlConnection.Close();

            return isModified;
        }

        internal List<Sales> GetRecords()
        {
            String commandString = @"SELECT * FROM Sales";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Sales> _sales = new List<Sales>();
            while (dataReader.Read())
            {
                Sales sales = new Sales();
                sales.Id = int.Parse(dataReader["Id"].ToString());
                sales.Code = (dataReader["Code"].ToString());
                sales.Customer =(dataReader["Customer"].ToString());
                sales.SelasDate = Convert.ToDateTime(dataReader["SalesDate"].ToString());
                sales.LoyalityPoint = double.Parse(dataReader["Supplier"].ToString());
                sales.Category = dataReader["Category"].ToString();
                sales.Product = dataReader["Product"].ToString();
                sales.AvabileQuantity = int.Parse(dataReader["AvabileQuantity"].ToString());
                sales.Quantity = int.Parse(dataReader["Quantity"].ToString());
                sales.MRP = double.Parse(dataReader["MRP"].ToString());
                sales.TotalMRP = double.Parse(dataReader["TotalMRP"].ToString());
                sales.GrandTotal = double.Parse(dataReader["GrandTotal"].ToString());
                sales.Discount = double.Parse(dataReader["Discount"].ToString());
                sales.DiscountAmount = double.Parse(dataReader["DiscountAmount"].ToString());
                sales.PayableAmount = double.Parse(dataReader["PayableAmount"].ToString());

                _sales.Add(sales);
            }
            sqlConnection.Close();
            return _sales;
        }
        internal List<Sales> GetSubmitall()
        {
            String commandString = @"INSERT INTO FROM Sales";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Sales> _sales = new List<Sales>();
            while (dataReader.Read())
            {
                Sales sales = new Sales();
                sales.Id = int.Parse(dataReader["Id"].ToString());
                sales.Code = (dataReader["Code"].ToString());
                sales.Customer = (dataReader["Customer"].ToString());
                sales.SelasDate = Convert.ToDateTime(dataReader["SalesDate"].ToString());
                sales.LoyalityPoint = double.Parse(dataReader["Supplier"].ToString());
                sales.Category = dataReader["Category"].ToString();
                sales.Product = dataReader["Product"].ToString();
                sales.AvabileQuantity = int.Parse(dataReader["AvabileQuantity"].ToString());
                sales.Quantity = int.Parse(dataReader["Quantity"].ToString());
                sales.MRP = double.Parse(dataReader["MRP"].ToString());
                sales.TotalMRP = double.Parse(dataReader["TotalMRP"].ToString());
                sales.GrandTotal = double.Parse(dataReader["GrandTotal"].ToString());
                sales.Discount = double.Parse(dataReader["Discount"].ToString());
                sales.DiscountAmount = double.Parse(dataReader["DiscountAmount"].ToString());
                sales.PayableAmount = double.Parse(dataReader["PayableAmount"].ToString());

                _sales.Add(sales);
            }
            sqlConnection.Close();
            return _sales;
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
