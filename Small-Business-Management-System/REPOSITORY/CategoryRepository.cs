using Small_Business_Management_System.MODEL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.REPOSITORY
{
    class CategoryRepository
    {
        SqlConnection sqlConnection;
        string serverName = @"SHIIIFUUUU";
        string databaseName = @"SmallBusinessManagementSystem";

        public CategoryRepository()
        {
            String connectionString = "Server="+serverName+"; Database="+databaseName+"; Integrated Security=true";
            sqlConnection = new SqlConnection(connectionString);
        }

        internal bool AddCategory(string code, string name)
        {
            bool isAdded = false;
            String commandString = @"INSERT INTO Category(Code,Name) VALUES ('" + code + "', '" + name + "')";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isAdded = true;
            }
            sqlConnection.Close();
            return isAdded;
        }

        internal bool ModifyCategory(string code, string name, int id)
        {
            bool isModified = false;
            String commandString = @"UPDATE Category SET Code = '" + code + "', Name = '" + name + "'" +
                "WHERE Id = "+id+"";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            if (sqlCommand.ExecuteNonQuery() > 0)
            {
                isModified = true;
            }
            sqlConnection.Close();
            return isModified;
        }

        internal List<Category> DisplayCategories()
        {
            String commandString = @"SELECT * FROM Category";
            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);
            sqlConnection.Open();
            SqlDataReader dataReader = sqlCommand.ExecuteReader();
            List<Category> categories = new List<Category>();
            while (dataReader.Read())
            {
                Category _category = new Category();
                _category.Id = int.Parse(dataReader["Id"].ToString());
                _category.Code = dataReader["Code"].ToString();
                _category.Name = dataReader["Name"].ToString();

                categories.Add(_category);
            }
            sqlConnection.Close();
            return categories;
        }

        internal bool IsUnique(string code)
        {
            bool isUnique = false;
            String searchString = null;
            String commandString = "SELECT Code FROM Category WHERE Code = '"+code+"'";
            SqlCommand sqlCommand = new SqlCommand(commandString,sqlConnection);
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
    }
}
