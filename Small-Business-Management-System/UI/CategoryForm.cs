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
            DisplayCategories();
        }

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
                        if (AddCategory(_category.Code, _category.Name)) //ADDED SUCCESSFULLY
                        {
                            confirmLabel.Text = "Category Saved Successfully!";
                            DisplayCategories();
                        }
                    }
                    else if (saveButton.Text == "Modify")
                    {
                        if(ModifyCategory(_category.Code, _category.Name, _category.Id))
                        {
                            confirmLabel.Text = "Category Modified Successfully!";
                            DisplayCategories();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private bool AddCategory(string code, string name)
        {
            return _categoryManager.AddCategory(code, name);
        }

        private bool ModifyCategory(string code, string name, int id)
        {
            return _categoryManager.ModifyCategory(code, name, id);
        }

        private void DisplayCategories()
        {
            try
            {
                showCategoriesGridView.ReadOnly = true;
                showCategoriesGridView.DataSource = _categoryManager.DisplayCategories();

                showCategoriesGridView.Columns["idColumn"].Visible = false;
                SetSerialNumber(showCategoriesGridView);
                SetActionColumn(showCategoriesGridView);
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {

            }
        }


        private bool IsValid(string code, string name)
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(_category.Code))
            {
                codeErrorLabel.Text = "code field can not be empty!";
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
            if (!CodeLengthValidation())
            {
                isValid = false;
            }
            if (!IsUnique(code))
            {
                isValid = false;
                codeErrorLabel.Text = "This Code already Exist!";
            }

            return isValid;
        }

        private bool IsUnique(string code)
        {
            return _categoryManager.IsUnique(code);
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
            if (codeTextBox.TextLength < 4)
            {
                codeErrorLabel.Text = "Length must be 4 character!!";
            }
            return valid;
        }

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
                        //MessageBox.Show(_category.Id + "");
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
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
    }
}
