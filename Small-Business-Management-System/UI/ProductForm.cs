using System;
using Small_Business_Management_System.MANAGER;
using Small_Business_Management_System.MODEL;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Business_Management_System.UI
{
    public partial class ProductForm : Form
    {
        ProductManager _productManager = new ProductManager();
        Product _product = new Product();

        public ProductForm()
        {
            InitializeComponent();
        }


        //Button
        private void savebutton_Click(object sender, EventArgs e)
        {
            try
            {
                _product.Category = categorycomboBox.Text;
                _product.Code = codetextBox.Text;
                _product.Name = nametextBox.Text;
                _product.ReorderLevel = reordertextBox.Text;
                _product.Description = descriptiontextBox.Text;
               

                if (IsValid(_product))
                {
                    if (savebutton.Text == "Save")
                    {
                        if (IsUnique(_product))
                        {
                            if (Add(_product)) //ADDED SUCCESSFULLY
                            {
                                confirmationlabel.Text = "Customer Information Saved Successfully!";
                                DisplayRecords(GetRecords());
                                ClearInputs();
                            }
                        }

                    }
                    else if (savebutton.Text == "Modify")
                    {
                        if (IsModifiedUnique(_product))
                        {
                            if (Modify(_product)) //MODIFIED SUCCESSFULLY
                            {
                                confirmationlabel.Text = "Customer Information Modified Successfully!";
                                DisplayRecords(GetRecords());
                                ClearInputs();
                            }
                        }

                    }
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void searchbutton_Click(object sender, EventArgs e)
        {
            //cancelButton.Visible = true;

            if (String.IsNullOrEmpty(searchtextBox.Text))
            {
                //searchErrorLabel.Text = "Search box is empty!!";
                return;
            }
            try
            {
                string product = searchtextBox.Text;
                List<Product> searchList = Search(product);

                if (searchList != null) //SEARCH SUCCESSFULL
                {
                    DisplayRecords(searchList);

                    confirmationlabel
.Text = searchList.Count.ToString() + " Result Found!";
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        //crud Functions

        private bool Add(Product product)
        {
            return _productManager.Add(product);
        }

        private bool Modify(Product product)
        {
            return _productManager.Modify(product);
        }

        private List<Product> Search(string product)
        {
            return _productManager.Search(product);
        }

        private List<Product> GetRecords()
        {
            return _productManager.GetRecords();
        }

        private void DisplayRecords(List<Product> products)
        {
            try
            {
                dataGridView.DataSource = products;

                dataGridView.Columns["idColumn"].Visible = false;
                Helper.SetSerialNumber(dataGridView);
                Helper.SetActionColumn(dataGridView);
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        //VALIDATION
        private bool IsValid(Product product)
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(product.Code))
            {
                codeerrorlabel.Text = "Code can not be empty!!";
                isValid = false;
            }
            else if (!CodeLengthValidation(product.Code))
            {
                isValid = false;
            }
            else
            {
                ClearErrorLabels();
            }
            if (String.IsNullOrEmpty(product.Name))
            {
                nameerrorlabel.Text = "Must provide supplier name";
                isValid = false;
            }
            else
            {
                ClearErrorLabels();
            }
            if (String.IsNullOrEmpty(product.ReorderLevel))
            {
                reordererrorlabel.Text = "Re OrderLevel can not be empty!!";
                isValid = false;
            }
            else
            {
                ClearErrorLabels();
            }
            //if (String.IsNullOrEmpty(customer.Contact))
            //{
            //    contactErrorLabel.Text = "Contact can not be empty!!";
            //    isValid = false;
            //}
            //else if (!ContactLengthValidation(customer.Contact))
            //{
            //    isValid = false;
            //}
            //else
            //{
            //    ClearErrorLabels();
            //}

            return isValid;
        }

        private bool IsUnique(Product product)
        {
            bool isUnique = true;
            if (!_productManager.IsUnique(product.Code, "Code")) //(inputString, columnName)
            {
                codeerrorlabel.Text = "This code already exists!";
                isUnique = false;
            }
            else
            {
                ClearErrorLabels();
            }
            //if (!_customerManager.IsUnique(customer.Email, "Email"))
            //{
            //    emailErrorLabel.Text = "This email already exists!";
            //    isUnique = false;
            //}
            //else
            //{
            //    ClearErrorLabels();
            //}
            //if (!_customerManager.IsUnique(customer.Contact, "Contact"))
            //{
            //    contactErrorLabel.Text = "This contact already exists!";
            //    isUnique = false;
            //}
            //else
            //{
            //    ClearErrorLabels();
            //}
            return isUnique;
        }

        private bool IsModifiedUnique(Product product)
        {
            bool isUnique = true;
            if (!_productManager.IsUnique(product.Code, "Code", product.Id)) //(inputString, columnName)
            {
                codeerrorlabel.Text = "This code already exists!";
                isUnique = false;
            }
            else
            {
                ClearErrorLabels();
            }
            //if (!_customerManager.IsUnique(customer.Email, "Email", customer.Id))
            //{
            //    emailErrorLabel.Text = "This email already exists!";
            //    isUnique = false;
            //}
            //else
            //{
            //    ClearErrorLabels();
            //}
            //if (!_customerManager.IsUnique(customer.Contact, "Contact", customer.Id))
            //{
            //    contactErrorLabel.Text = "This contact already exists!";
            //    isUnique = false;
            //}
            //else
            //{
            //    ClearErrorLabels();
            //}
            return isUnique;
        }

        private void codetextBox_TextChanged_1(object sender, EventArgs e)
        {
            CodeLengthValidation(codetextBox.Text);
        }

        private bool CodeLengthValidation(string codeText)
        {
            bool isValid = false;
            if (codeText.Length == 4)
            {
                codeerrorlabel.Text = null;
                isValid = true;
            }
            else if (codeText.Length < 4 && !String.IsNullOrEmpty(codeText))
            {
                codeerrorlabel.Text = "Code must contain 4 characters";
            }
            return isValid;
        }

        //COMMON
        private void ClearInputs()
        {
            codetextBox.Clear();
            nametextBox.Clear();
            reordertextBox.Clear();
            descriptiontextBox.Clear();

            savebutton.Text = "Save";
            //deleteButton.Visible = false;
            //cancelButton.Visible = false;
        }

        private void ClearErrorLabels()
        {
            codeerrorlabel.Text = null;
            nameerrorlabel.Text = null;
            reordererrorlabel.Text = null;

            searcherrorlabel.Text = null;
            confirmationlabel.Text = null;
        }

        private void ExceptionMessage(Exception error)
        {
            MessageBox.Show(error.Message);
            _productManager.CloseConnection();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dataGridView.Columns["actionColumn"].Index && e.RowIndex != -1)
                {
                    if (dataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        codetextBox.Text = dataGridView.Rows[e.RowIndex].Cells["codeColumn"].Value.ToString();
                        nametextBox.Text = dataGridView.Rows[e.RowIndex].Cells["nameColumn"].Value.ToString();
                        reordertextBox.Text = dataGridView.Rows[e.RowIndex].Cells["addressColumn"].Value.ToString();
                        descriptiontextBox.Text = dataGridView.Rows[e.RowIndex].Cells["emailColumn"].Value.ToString();
                        //contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["contactColumn"].Value.ToString();
                        //loyaltyPointTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["loyaltyPointColumn"].Value.ToString();

                        _product.Id = int.Parse(dataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString());

                        savebutton.Text = "Modify";
                        //deleteButton.Visible = true;
                        //cancelButton.Visible = true;
                    }
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {
            try
            {
                ClearErrorLabels();
                DisplayRecords(GetRecords());
                
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }
    }
}
