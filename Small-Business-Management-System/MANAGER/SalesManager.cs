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
    }
}
