using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Small_Business_Management_System.MODEL;
using Small_Business_Management_System.REPOSITORY;

namespace Small_Business_Management_System.MANAGER
{
    public class CategoryManager
    {
        CategoryRepository _categoryRepository = new CategoryRepository();
        internal bool IsUnique(string code)
        {
            return _categoryRepository.IsUnique(code);
        }

        internal bool AddCategory(string code, string name)
        {
            return _categoryRepository.AddCategory(code, name);
        }

        internal List<Category> DisplayCategories()
        {
            return _categoryRepository.DisplayCategories();
        }

        internal bool ModifyCategory(string code, string name, int id)
        {
            return _categoryRepository.ModifyCategory(code, name, id);
        }
    }
}
