using Small_Business_Management_System.MODEL;
using Small_Business_Management_System.REPOSITORY;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Business_Management_System.MANAGER
{
    public class SalesManager
    {
        SalesRepository salesRepository = new SalesRepository();
        internal bool IsUnique(string inputString, string columnName)
        {
            return salesRepository.IsUnique(inputString, columnName);
        }
        internal List<Category> CategoryComboLoad()
        {
            return salesRepository.CategoryComboLoad();
        }
        internal List<Customer> CustomerComboLoad()
        {
            return salesRepository.CustomerComboLoad();
        }
        internal List<Product> ProductComboLoad()
        {
            return salesRepository.ProductComboLoad();
        }
        internal string SalesCode(string code)
        {
            return salesRepository.SalesCode( code);
        }
        //internal bool SubmitAll(Sales sales)
        //{
        //    return salesRepository.SubmitAll(sales);
        //}
        internal bool Modify(Sales sales)
        {
            return salesRepository.Modify(sales);
        }
       

        //internal bool Delete(Sales sales)
        //{
        //    return salesRepository.Delete(sales);
        //}
        internal void CloseConnection()
        {
            salesRepository.CloseConnection();
        }
        internal List<Sales> Search(string sales)
        {
            return salesRepository.Search(sales);
        }
        internal int GetLoyalityPoint(int custerId)
        {
            return salesRepository.LoyatityPoint(custerId);
        }

        internal List<Product> ProductComboLoadByCategory(int categoryId)
        {
            return salesRepository.ProductComboLoadByCategory(categoryId);
        }

        internal string GetAvailableQuantity(string product)
        {
            return salesRepository.GetAvailableQuantity(product);
        }
        internal string GetMRP(string product)
        {
            return salesRepository.GetMRP(product);
        }

        internal bool Add(Sales sales)
        {
            return salesRepository.Add(sales);
        }
    }
}
