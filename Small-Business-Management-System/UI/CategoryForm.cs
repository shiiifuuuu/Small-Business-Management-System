using Small_Business_Management_System.MODEL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Small_Business_Management_System.MANAGER;

namespace Small_Business_Management_System
{
    public partial class CategoryForm : Form
    {
        CategoryManager _categoryManager = new CategoryManager();

        private Category _category = new Category();

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {
            DisplayCategories(GetRecords());
            deleteButton.Visible = false;
            cancelButton.Visible = false;
        }

        //BUTTONS
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _category.Code = codeTextBox.Text;
                _category.Name = nameTextBox.Text;

                if (IsValid(_category.Code, _category.Name))
                {
                    if (saveButton.Text == "Save")
                    {
                        if (AddCategory(_category)) //ADDED SUCCESSFULLY
                        {
                            confirmLabel.Text = "Category Saved Successfully!";
                            DisplayCategories(GetRecords());
                            CleanAll();
                        }
                    }
                    else if (saveButton.Text == "Modify")
                    {
                        if(ModifyCategory(_category)) //MODIFIED SUCCESSFULLY
                        {
                            confirmLabel.Text = "Category Modified Successfully!";
                            DisplayCategories(GetRecords());
                            CleanAll();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DeleteCategory(_category)) //DELETED SUCCESSFULLY
                {
                    confirmLabel.Text = "Category Deleted Successfully!";
                    DisplayCategories(GetRecords());
                    CleanAll();
                }
            }catch(Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(searchTextBox.Text))
            {
                searchErrorLabel.Text = "Search box is empty!!";
                return;
            }
            try
            {
                string searchText = searchTextBox.Text;
                List<Category> searchList = SearchCategory(searchText);

                if (searchList != null) //SEARCH SUCCESSFULL
                {
                    DisplayCategories(searchList);

                    confirmLabel.Text = searchList.Count.ToString() + " Result Found!";
                }
            }catch(Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            CleanAll();
        }


        //CRUD FUNCTIONS
        private bool AddCategory(Category _category)
        {
            return _categoryManager.AddCategory(_category);
        }

        private bool ModifyCategory(Category _category)
        {
            return _categoryManager.ModifyCategory(_category);
        }

        private bool DeleteCategory(Category _category)
        {
            return _categoryManager.DeleteCategory(_category);
        }

        private List<Category> SearchCategory(string searchText)
        {
            return _categoryManager.SearchCategory(searchText);
        }

        private List<Category> GetRecords()
        {
            return _categoryManager.GetRecords();
        }

        private void DisplayCategories(List<Category> categories)
        {
            try
            {
                showCategoriesGridView.ReadOnly = true;
                showCategoriesGridView.DataSource = categories;

                showCategoriesGridView.Columns["idColumn"].Visible = false;
                SetSerialNumber(showCategoriesGridView);
                SetActionColumn(showCategoriesGridView);
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }


        //VALIDATION
        private bool IsValid(string code, string name)
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(_category.Code))
            {
                codeErrorLabel.Text = "code field can not be empty!";
                isValid = false;
            }else if (!CodeLengthValidation())
            {
                isValid = false;
            }
            if (String.IsNullOrEmpty(_category.Name))
            {
                nameErrorLabel.Text = "name field can not be empty!";
                isValid = false;
            }else
            {
                nameErrorLabel.Text = null;
            }
            
            if (!IsUnique(_category))
            {
                isValid = false;
                codeErrorLabel.Text = "This Code already Exist!";
            }

            return isValid;
        }

        private bool IsUnique(Category _category)
        {
            return _categoryManager.IsUnique(_category);
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            CodeLengthValidation();
        }

        private bool CodeLengthValidation()
        {
            bool valid = false;
            if (codeTextBox.TextLength.Equals(4))
            {
                codeErrorLabel.Text = null;
                codeTextBox.MaxLength = 4;
                valid = true ;
            }
            if (codeTextBox.TextLength < 4 && !String.IsNullOrEmpty(codeTextBox.Text))
            {
                codeErrorLabel.Text = "Length must be 4 character!!";
            }
            return valid;
        }

        //GRID CLICK FUNCTION
        private void showCategoriesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 4 && e.RowIndex != -1)
                {
                    if (showCategoriesGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        codeTextBox.Text = showCategoriesGridView.Rows[e.RowIndex].Cells["codeColumn"].Value.ToString();
                        nameTextBox.Text = showCategoriesGridView.Rows[e.RowIndex].Cells["nameColumn"].Value.ToString();

                        _category.Id = int.Parse(showCategoriesGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString());

                        saveButton.Text = "Modify";
                        deleteButton.Visible = true;
                        cancelButton.Visible = true;
                    }
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void SetActionColumn(DataGridView dgv)
        {
            foreach (DataGridViewRow rows in dgv.Rows)
            {
                rows.Cells["actionColumn"].Value = "Edit";
            }

            dgv.Columns["actionColumn"].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            dgv.Columns["actionColumn"].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Underline);
        }

        private void SetSerialNumber(DataGridView dgv)
        {
            int i = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells["snColumn"].Value = i;
                i++;
            }
        }

        //COMMON
        private void CleanAll()
        {
            codeTextBox.Text = null;
            nameTextBox.Text = null;

            saveButton.Text = "Save";
            deleteButton.Visible = false;
            cancelButton.Visible = false;
        }
        private void ExceptionMessage(Exception error)
        {
            MessageBox.Show(error.Message);
            _categoryManager.CloseConnection();
        }

    }
}
