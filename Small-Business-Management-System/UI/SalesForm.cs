using Small_Business_Management_System.MANAGER;
using Small_Business_Management_System.MODEL;
using Small_Business_Management_System.REPOSITORY;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Business_Management_System.UI
{
    public partial class SalesForm : Form
    {
        Sales sales = new Sales();
        SalesManager _salesManager = new SalesManager();
        public SalesForm()
        {
            InitializeComponent();
        }
        List<Sales> _sales = new List<Sales>();
        double grandTotal = 0;
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                sales.Code = salesCodeTextBox.Text;
                sales.Customer = (customerComboBox.SelectedValue).ToString();
                //sales.SelasDate = DateTime.Parse(dateTimePicker.ToString("MM/dd/yyyy"));
                sales.SelasDate = Convert.ToDateTime(dateTimePicker.Text);
                sales.LoyalityPoint = double.Parse(loyalityPointTextBox.Text);
                sales.Category = (categoryComboBox.SelectedValue).ToString();
                sales.Product = (productComboBox.SelectedValue).ToString();
                AvabileQuantityTextBox.Text = _salesManager.GetAvailableQuantity() + "";
                sales.Quantity = Convert.ToInt32(quantityTextBox.Text);
                sales.MRP = Convert.ToDouble(mrpTextBox.Text);
                sales.TotalMRP = Convert.ToDouble(totalMRPTextBox.Text);

                _sales.Add(sales);

                BindingSource salesTable = new BindingSource();
                salesTable.DataSource = _sales;
                showDataGridView.DataSource = salesTable;
                Helper.SetActionColumn(showDataGridView);
                //Helper.SetSerialNumber(showDataGridView);

                foreach (Sales sales in _sales)
                {
                    grandTotal += sales.TotalMRP;
                }
                grandTotalTextBox.Text = grandTotal + "";
            }
            catch(Exception error)
            {
                ExceptionMessage(error);
            }
            
         }

        
        private void SalesForm_Load(object sender, EventArgs e)
        {
            try
            {
                categoryComboBox.DataSource = _salesManager.CategoryComboLoad();
                categoryComboBox.Text = "-Select-";

                customerComboBox.DataSource = _salesManager.CustomerComboLoad();
                customerComboBox.Text = "-Select-";

                productComboBox.DataSource = _salesManager.ProductComboLoad();
                productComboBox.Text = "-Select-";

                salesCodeTextBox.Text = _salesManager.SalesCode(sales.Code);
            }catch(Exception error)
            {
                ExceptionMessage(error);
            }
        }
        
        
        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                sales.Code = salesCodeTextBox.Text;
                sales.Customer = (customerComboBox.SelectedValue).ToString();
                sales.SelasDate = Convert.ToDateTime( dateTimePicker.Text);
                sales.LoyalityPoint = double.Parse(loyalityPointTextBox.Text); 
                sales.Category = (categoryComboBox.SelectedValue).ToString();
                sales.Product = (productComboBox.SelectedValue).ToString();
                AvabileQuantityTextBox.Text = _salesManager.GetAvailableQuantity()+"";
                sales.Quantity = Convert.ToInt32(quantityTextBox.Text);
                sales.MRP = Convert.ToDouble(mrpTextBox.Text);
                sales.TotalMRP = Convert.ToDouble(totalMRPTextBox.Text);
                sales.GrandTotal= double.Parse(grandTotalTextBox.Text) ;
                sales.Discount = double.Parse(discountTextBox.Text);
                sales.DiscountAmount = double.Parse(discountAmountTextBox.Text);
                sales.PayableAmount = double.Parse(payableAmountTextBox.Text);


                if (IsValid(sales))
                {
                    if (submitButton.Text == "Save")
                    {
                        if (IsUnique(sales))
                        {
                            if (_salesManager.SubmitAll(sales)) //ADDED SUCCESSFULLY
                            {
                                confirmationLabel.Text = "Sales Information Saved Successfully!";
                                
                                ClearInputs();
                            }
                        }

                    }
                    else if (submitButton.Text == "Modify")
                    {
                        if (IsModifiedUnique(sales))
                        {
                            DialogResult dialogResult = MessageBox.Show("Are you sure you want to modify?", "Modify Confirmation", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                if (Modify(sales)) //MODIFIED SUCCESSFULLY
                                {
                                    confirmationLabel.Text = "Product Information Modified Successfully!";
                                    
                                    ClearInputs();
                                }
                            }
                            else if (dialogResult == DialogResult.No)
                            {
                                ClearInputs();
                                ClearErrorLabels();
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
        private bool IsValid(Sales sales)
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(sales.Code))
            {
                codeErrorLabel.Text = "Code can not be empty!!";
                isValid = false;
            }
            else if (!CodeLengthValidation(sales.Code))
            {
                isValid = false;
            }
            else
            {
                codeErrorLabel.Text = null;
            }
            if (productComboBox.Text == "-Select-")
            {
                productErrorLabel.Text = "Select a category";
                
            }
            else
            {
                productErrorLabel.Text = null;
            }
            if (categoryComboBox.Text == "-Select-")
            {
                categoryErrorLabel.Text = "Select a category";
            }
            else
            {
                categoryErrorLabel.Text = null;
            }
            
            return isValid;
        }
        private bool IsUnique(Sales sales)
        {
            bool isUnique = true;
            
            try
            {
                if (!_salesManager.IsUnique(sales.Code, "Code")) //(inputString, columnName)
                {
                    codeErrorLabel.Text = "This code already exists!";
                    isUnique = false;
                }
                else
                {
                    codeErrorLabel.Text = null;
                }
            }
            catch(Exception error)
            {

            }
            
            return isUnique;
        }

        private bool CodeLengthValidation(string codeText)
        {
            bool isValid = false;
            if (codeText.Length == 8)
            {
                codeErrorLabel.Text = null;
                isValid = true;
                salesCodeTextBox.MaxLength = 8;
            }
            else if (codeText.Length <= 8 && !String.IsNullOrEmpty(codeText))
            {
                codeErrorLabel.Text = "Code must contain 8 characters";
            }
            return isValid;
        }


        private bool IsModifiedUnique(Sales sales)
        {
            bool isUnique = true;
            try
            {
                if (!_salesManager.IsUnique(sales.Code, "Code")) //(inputString, columnName)
                {
                    codeErrorLabel.Text = "This code already exists!";
                    isUnique = false;
                }
                else
                {
                    codeErrorLabel.Text = null;
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
            return isUnique;
        }
       
        private void ClearInputs()
        {
            categoryComboBox.Text = "-Select-";
            salesCodeTextBox.Clear();
           
            customerComboBox.Text = "-Select-";
            productComboBox.Text = "-Select-";
            quantityTextBox.Clear();
            mrpTextBox.Clear();
            totalMRPTextBox.Clear();

            submitButton.Text = "Save";
           
        }

        private void ClearErrorLabels()
        {
            categoryErrorLabel.Text = null;
            codeErrorLabel.Text = null;
            searchErrorLabel.Text = null;
            confirmationLabel.Text = null;
        }

        private bool Modify(Sales sales)
        {
            return _salesManager.Modify(sales);
        }
        private List<Sales> Search(string sales)
        {
            return _salesManager.Search(sales);
        }

        private void DisplayRecords(List<Sales> sales)
        {
            try
            {
                showDataGridView.DataSource = sales;

                showDataGridView.Columns["idColumn"].Visible = false;
                Helper.SetSerialNumber(showDataGridView);
                Helper.SetActionColumn(showDataGridView);
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void ExceptionMessage(Exception error)
        {
            MessageBox.Show(error.Message);
            _salesManager.CloseConnection();
        }

        private void showDataGridView_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            showDataGridView.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void salesCodeTextBox_TextChanged(object sender, EventArgs e)
        {
            CodeLengthValidation(salesCodeTextBox.Text);
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
                string sales = searchTextBox.Text;
                List<Sales> searchList = Search(sales);

                if (searchList != null) //SEARCH SUCCESSFULL
                {
                    DisplayRecords(searchList);

                    confirmationLabel.Text = searchList.Count.ToString() + " Result Found!";
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndGetPrevious();
        }

        private void mrpTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndGetPrevious();
        }

        private void CalculateAndGetPrevious()
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text) && !String.IsNullOrEmpty(mrpTextBox.Text))
            {
                totalMRPTextBox.Text = (int.Parse(quantityTextBox.Text) * double.Parse(mrpTextBox.Text)) + "";
            }
        }

        private void grandTotalTextBox_TextChanged(object sender, EventArgs e)
        {
            loyalitycal();
            DiscountAmount();
            PayableAmount();
        }

        private void discountTextBox_TextChanged(object sender, EventArgs e)
        {
            DiscountAmount();
        }

        private void loyalityPointTextBox_TextChanged(object sender, EventArgs e)
        {
            Discount();
        }

        private void discountAmountTextBox_TextChanged(object sender, EventArgs e)
        {
            PayableAmount();
        }
        private void loyalitycal()
        {
            if (!String.IsNullOrEmpty(loyalityPointTextBox.Text))
            {
                loyalityPointTextBox.Text = (Convert.ToDouble(grandTotalTextBox.Text) / 1000) + "";

            }

        }
        internal void Discount()
        {
            if (!String.IsNullOrEmpty(loyalityPointTextBox.Text))
            {
                discountTextBox.Text = (Convert.ToDouble(loyalityPointTextBox.Text) / 10) + ""; 
                loyalityPointTextBox.Text = (Convert.ToDouble(loyalityPointTextBox.Text))-(Convert.ToDouble(loyalityPointTextBox.Text) / 10) + ""; 
            }
  
        }

        internal void DiscountAmount()
        {
            if (!String.IsNullOrEmpty(discountAmountTextBox.Text))
            {
                discountAmountTextBox.Text = (Convert.ToDouble(grandTotalTextBox.Text))*(Convert.ToDouble(discountTextBox.Text)) + ""; 
            }

        }
        internal void PayableAmount()
        {
            if (!String.IsNullOrEmpty(payableAmountTextBox.Text))
            {
                payableAmountTextBox.Text = (Convert.ToDouble(grandTotalTextBox.Text)) - (Convert.ToDouble(discountAmountTextBox.Text)) + "";
            }

        }

        private void showDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
