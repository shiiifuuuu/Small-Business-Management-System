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
        PurchaseManager _purchaseManager = new PurchaseManager();
        Sales sales = new Sales();
        SalesManager _salesManager = new SalesManager();
        public SalesForm()
        {
            InitializeComponent();
        }
        List<Sales> _salesListed = new List<Sales>();
        double grandTotal = 0;
        double discount = 0;
        double discountAmount = 0;
        double payableAmount = 0;

        
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

            loyalityPointTextBox.Text = 0+"";
            AvabileQuantityTextBox.Text = 0 + "";
            mrpTextBox.Text = 0 + "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {

            try
            {
                if (addButton.Text.Equals("Add"))
                {


                    sales.Code = salesCodeTextBox.Text;
                    sales.Customer = customerComboBox.Text;
                    sales.CustomerId = Convert.ToInt32(customerComboBox.SelectedValue);
                    sales.SelasDate = Convert.ToDateTime(dateTimePicker.Text);
                    sales.LoyalityPoint = double.Parse(loyalityPointTextBox.Text);
                    sales.Category = (categoryComboBox.SelectedValue).ToString();
                    sales.Product = (productComboBox.SelectedValue).ToString();
                    AvabileQuantityTextBox.Text = (Convert.ToInt32(AvabileQuantityTextBox.Text))-(Convert.ToInt32(quantityTextBox.Text))+"";
                    sales.Quantity = Convert.ToInt32(quantityTextBox.Text);
                    sales.MRP = Convert.ToDouble(mrpTextBox.Text);
                    sales.TotalMRP = Convert.ToDouble(totalMRPTextBox.Text);
                    

                    if (!IsValid(sales))
                    {
                        return;
                    }
                    if (!IsUnique(sales))
                    {
                        return;
                    }
                    //if (sameSales(sales.Code, _salesListed ))
                    //{
                    //    return;
                    //}

                    _salesListed.Add(sales);

                    //ResetInputs();
                    //ResetErrorLabels();

                    DisplayRecords(_salesListed, _itemList);
                    //GrandTotal Calculation
                    foreach (Sales sales in _salesListed)
                    {
                        grandTotal += sales.TotalMRP;
                    }
                    grandTotalTextBox.Text = grandTotal + "";

                    discountTextBox.Text = (Convert.ToDouble(loyalityPointTextBox.Text) / 10) + "";
                    discountAmountTextBox.Text = (grandTotal * ((Convert.ToDouble(loyalityPointTextBox.Text) / 10)/100)).ToString();
                    //loyalityPointTextBox.Text = (Convert.ToDouble(loyalityPointTextBox.Text)) - (Convert.ToDouble(loyalityPointTextBox.Text) / 10) + "";
                    payableAmountTextBox.Text = (grandTotal - (grandTotal * ((Convert.ToDouble(loyalityPointTextBox.Text) / 10) / 100))).ToString();

                     ResetInputs();

                }
                else if (addButton.Text.Equals("Modify"))
                {

                }
            }

            catch (Exception error)
            {
                ExceptionMessage(error);
            }

        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            List<Sales> salesList = new List<Sales>();
            salesList.Add(sales);

            foreach (Sales sale in salesList)
            {
                Add(sale);
 
            }
            showDataGridView.DataSource = null;
            confirmationLabel.Text = "Successfully Inserted.";
            salesCodeTextBox.Text = _salesManager.SalesCode(sales.Code);
            //ResetInputs();
            ResetAll();
        }

        private bool Add(Sales sales)
        {
            return _salesManager.Add(sales);
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
            if (codeText.Length == 9)
            {
                codeErrorLabel.Text = null;
                isValid = true;
                salesCodeTextBox.MaxLength = 9;
            }
            else if (codeText.Length <= 9 && !String.IsNullOrEmpty(codeText))
            {
                codeErrorLabel.Text = "Code must contain 9 characters";
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
        private const int _itemList = 0;
        private const int _database = 1;
        private void DisplayRecord(List<Sales> salese)
        {
            try
            {
                showDataGridView.DataSource = salese;

                showDataGridView.Columns["idColumn"].Visible = false;
                Helper.SetSerialNumber(showDataGridView);
                Helper.SetActionColumn(showDataGridView);
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
            
        }

        private void DisplayRecords(List<Sales> _sales, int check)
        {
            try
            {
                showDataGridView.ReadOnly = true;

                if (check == 0)
                {
                    BindingSource salesTable = new BindingSource { DataSource = _sales };
                    showDataGridView.DataSource = salesTable;

                    SetSerialNumber(showDataGridView);
                    SetActionColumn(showDataGridView);
                    showDataGridView.Columns["actionColumn"].Visible = true;
                }
                else if (check == 1)
                {
                    showDataGridView.DataSource = _sales;

                    Helper.SetSerialNumber(showDataGridView);
                    showDataGridView.Columns["actionColumn"].Visible = false;
                }

                //showDataGridView.Columns["idColumn"].Visible = false;
                //showDataGridView.Columns["codeColumn"].Visible = false;
                //showDataGridView.Columns["dateColumn"].Visible = false;
                //showDataGridView.Columns["loyalitypointColumn"].Visible = false;
                //showDataGridView.Columns["categoryColumn"].Visible = false;
                //showDataGridView.Columns["availableQuantityColumn"].Visible = false;
                //showDataGridView.Columns["grandtotalColumn"].Visible = false;
                //showDataGridView.Columns["discountColumn"].Visible = false;
                //showDataGridView.Columns["discountamountColumn"].Visible = false;
                //showDataGridView.Columns["payableamountColumn"].Visible = false;

            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void SetActionColumn(DataGridView dgv) //only for this form
        {
            foreach (DataGridViewRow rows in dgv.Rows)
            {
                if (rows.Index != dgv.Rows.Count - 1)
                {
                    rows.Cells["actionColumn"].Value = "Edit";
                }
            }

            dgv.Columns["actionColumn"].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            dgv.Columns["actionColumn"].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Underline);
        }

        private void SetSerialNumber(DataGridView dgv) //only for this form
        {
            int i = 1;
            foreach (DataGridViewRow rows in dgv.Rows)
            {
                if (rows.Index != dgv.Rows.Count - 1)
                {
                    rows.Cells["siColumn"].Value = i;
                    i++;
                }

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
                    DisplayRecord(searchList);

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

            AvabileQuantityTextBox.Text = (Convert.ToInt32(AvabileQuantityTextBox.Text) - Convert.ToInt32(quantityTextBox.Text)).ToString();
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


        internal void DiscountAmount()
        {
            if (!String.IsNullOrEmpty(discountAmountTextBox.Text))
            {
                discountAmountTextBox.Text = "1500";
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
            try
            {
                if (e.ColumnIndex == showDataGridView.Columns["actionColumn"].Index && e.RowIndex != -1)
                {
                    if (showDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                    {
                        //codeTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["codeColumn"].Value.ToString();
                        //nameTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["nameColumn"].Value.ToString();
                        //addressTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["addressColumn"].Value.ToString();
                        //emailTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["emailColumn"].Value.ToString();
                        //contactTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["contactColumn"].Value.ToString();
                        //contactPersonTextBox.Text = showDataGridView.Rows[e.RowIndex].Cells["contactPersonColumn"].Value.ToString();

                        sales.Id = int.Parse(showDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString());

                        addButton.Text = "Modify";
                        
                    }
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void customerComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int custerId = Convert.ToInt32(customerComboBox.SelectedValue);
            int loyalityPoint = _salesManager.GetLoyalityPoint(custerId);
            loyalityPointTextBox.Text = loyalityPoint.ToString();
        }

        List<Product> products = new List<Product>();
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                products = _purchaseManager.SearchProducts(categoryComboBox.Text);
                if (products.Count <= 0)
                {
                    productComboBox.Enabled = false;
                    productComboBox.Text = "-Select-";
                }
                else
                {
                    productComboBox.Enabled = true;
                    productComboBox.DataSource = products;
                    productComboBox.Text = "-Select-";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }

        }

        private bool sameSales(string code, List<Sales> salesList)
        {
            bool salesExist = false;

            foreach (Sales sales in salesList)
            {
                if (code == sales.Code)
                {
                    salesExist = true;
                    confirmationLabel.Text = "This product is already in your sales list";
                }
            }

            return salesExist;
        }

        private void productComboBox_TextChanged(object sender, EventArgs e)
        {
            AvabileQuantityTextBox.Text = SetAvailableQuantity(productComboBox.Text);
            mrpTextBox.Text = SetMRP(productComboBox.Text);
        }

        private string SetMRP(string product)
        {
            return _salesManager.GetMRP(product);
        }

        private string SetAvailableQuantity(string product)
        {
            return _salesManager.GetAvailableQuantity(product);
        }

        private void ResetInputs()
        {

            customerComboBox.Text = "-Select-";
            dateTimePicker.Format = DateTimePickerFormat.Short;
            loyalityPointTextBox.Text = 0 + "";
            categoryComboBox.Text = "-Select-";
            productComboBox.Text = "-Select-";
            productComboBox.Enabled = false;
            AvabileQuantityTextBox.Text = 0 + "";
            quantityTextBox.Text = 0 + "";
            mrpTextBox.Text = 0 + "";
            totalMRPTextBox.Text = 0 + "";
            //grandTotalTextBox.Text = 0 + "";
            //discountTextBox.Text = 0 + "";
            //discountAmountTextBox.Text = 0 + "";
            //payableAmountTextBox.Text = 0 + "";


            addButton.Text = "Add";
            
        }

        private void ResetAll()
        {
                customerComboBox.Text = "-Select-";
                dateTimePicker.Format = DateTimePickerFormat.Short;
                loyalityPointTextBox.Text = 0 + "";
                categoryComboBox.Text = "-Select-";
                productComboBox.Text = "-Select-";
                productComboBox.Enabled = false;
                AvabileQuantityTextBox.Text = 0 + "";
                quantityTextBox.Text = 0 + "";
                mrpTextBox.Text = 0 + "";
                totalMRPTextBox.Text = 0 + "";
                grandTotalTextBox.Text = 0 + "";
                discountTextBox.Text = 0 + "";
                discountAmountTextBox.Text = 0 + "";
                payableAmountTextBox.Text = 0 + "";


                //productError.Text = null;
                //mrpError.Text = null;
                //quantityError.Text = null;
                //categoryError.Text = null;
                //availablQuantityError.Text = null;
                //loyatityPointError.Text = null;
                //confirmationLabel.Text = null;

                
                submitButton.Text = "Add";

                showDataGridView.DataSource = null;
        }

        private void codeErrorLabel_Click(object sender, EventArgs e)
        {
            confirmationLabel.Text = "This Code is already exist!";
        }
        //private void ResetErrorLabels()
        //{
        //    productsError.Text = null;
        //    mrpError.Text = null;
        //    unitPriceError.Text = null;
        //    quantityError.Text = null;
        //    categoryError.Text = null;
        //    supplierError.Text = null;
        //    invoiceError.Text = null;
        //    confirmationLabel.Text = null;
        //}
    }
}
