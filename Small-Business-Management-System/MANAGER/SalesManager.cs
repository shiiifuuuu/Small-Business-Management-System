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
        internal bool SubmitAll(Sales sales)
        {
            return salesRepository.SubmitAll(sales);
        }
        internal bool Modify(Sales sales)
        {
            return salesRepository.Modify(sales);
        }
        public int GetAvailableQuantity()
        {
            return salesRepository.GetAvailableQuantity();
        }

        internal bool Delete(Sales sales)
        {
            return salesRepository.Delete(sales);
        }
        internal void CloseConnection()
        {
            salesRepository.CloseConnection();
        }
        internal List<Sales> Search(string sales)
        {
            return salesRepository.Search(sales);
        }
        
       

        internal double DiscountAmount(Sales sales)
        {
            sales.DiscountAmount = sales.GrandTotal * sales.Discount;
            return sales.DiscountAmount;
        }

        internal double PayableAmount(Sales sales)
        {
            sales.PayableAmount = sales.GrandTotal - sales.DiscountAmount;
            return sales.PayableAmount;
        }
    }
}
