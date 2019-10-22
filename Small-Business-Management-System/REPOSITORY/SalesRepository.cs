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
    }
}
