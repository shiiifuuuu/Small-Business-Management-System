using Small_Business_Management_System.MANAGER;
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

namespace Small_Business_Management_System.UI
{
    public partial class PurchaseForm : Form
    {
        PurchaseManager _purchaseManager = new PurchaseManager();
        Purchase _purchase = new Purchase();
        List<Purchase> _purchases = new List<Purchase>();

        public PurchaseForm()
        {
            InitializeComponent();
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            supplierComboBox.DataSource = _purchaseManager.SupplierComboLoad();
            supplierComboBox.Text = "-Select-";

            categoryComboBox.DataSource = _purchaseManager.CategoryComboLoad();
            categoryComboBox.Text = "-Select-";

            productsComboBox.Enabled = false;
            productsComboBox.Text = "-Select-";

            ResetErrorLabels();
            deleteButton.Visible = false;
            cancelButton.Visible = false;

            DisplayRecords(_purchases, _itemList);
        }

        //COMBO BOX DATA INITIALIZE
        List<Product> products = new List<Product>();
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                products = _purchaseManager.SearchProducts(categoryComboBox.Text);
                if (products.Count <= 0)
                {
                    productsComboBox.Enabled = false;
                    productsComboBox.Text = "-Select-";
                }
                else
                {
                    productsComboBox.Enabled = true;
                    productsComboBox.DataSource = products;
                    productsComboBox.Text = "-Select-";
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void productsComboBox_TextChanged(object sender, EventArgs e)
        {
            if (productsComboBox.Text != "-Select-")
            {
                if (products.Count != 0)
                {
                    foreach (Product product in products)
                    {
                        if (productsComboBox.Text == product.Name)
                        {
                            productCodeTextBox.Text = product.Code;
                        }
                    }
                }
            }
            else
            {
                productCodeTextBox.Text = null;
            }
        }

        //Previous VALUES INITIALIZE
        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            availableQuantityTextBox.Text = SetAvailableQuantity(productCodeTextBox.Text);
            previousUnitPriceTextBox.Text = SetPreviousValues("UnitPrice");
            previousMrpTextBox.Text = SetPreviousValues("MRP");
        }

        private string SetAvailableQuantity(string productCode)
        {
            return _purchaseManager.GetAvailableQuantity(productCode);
        }

        private string SetPreviousValues(string columnName)
        {
            string previoiusValue = _purchaseManager.GetPrevious(columnName, productCodeTextBox.Text);

            if (String.IsNullOrEmpty(previoiusValue))
            {
                previoiusValue = 0 + "";
            }

            return previoiusValue;
        }

        //Validation
        private bool IsUnique(Purchase purchase)
        {
            bool isUnique = true;

            if (!_purchaseManager.IsUnique(purchase.InvoiceNo, "InvoiceNo"))
            {
                isUnique = false;
                invoiceError.Text = "Invoice No. exist!";
            }

            return isUnique;
        }

        private bool IsValid(Purchase purchase)
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(purchase.InvoiceNo))
            {
                isValid = false;
                invoiceError.Text = "Invoice no. is empty!";
            }
            if (supplierComboBox.Text.Equals("-Select-"))
            {
                isValid = false;
                supplierError.Text = "Select a supplier!";
            }
            if (categoryComboBox.Text.Equals("-Select-"))
            {
                isValid = false;
                categoryError.Text = "Select a category!";
            }
            if (productsComboBox.Text.Equals("-Select-"))
            {
                isValid = false;
                productsError.Text = "Select a product";
            }
            if (String.IsNullOrEmpty(quantityTextBox.Text))
            {
                isValid = false;
                quantityError.Text = "Insert item quantity";
            }
            if (String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                isValid = false;
                unitPriceError.Text = "Insert item unit price";
            }
            if (String.IsNullOrEmpty(mrpTextBox.Text))
            {
                isValid = false;
                mrpError.Text = "Insert item MRP";
            }

            return isValid;
        }

        private bool samePurchase(string productCode, List<Purchase> purchaseList)
        {
            bool purchaseExist = false;

            foreach (Purchase purchase in purchaseList)
            {
                if (productCode == purchase.ProductCode)
                {
                    purchaseExist = true;
                    confirmationLabel.Text = "This product is already in your purchase list";
                }
            }

            return purchaseExist;
        }

        //Buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (addButton.Text.Equals("Add"))
                {
                    _purchase = new Purchase();

                    _purchase.Date = Convert.ToDateTime(supplierDate.Text);
                    _purchase.InvoiceNo = invoiceTextBox.Text;
                    _purchase.Supplier = supplierComboBox.Text;
                    _purchase.Category = categoryComboBox.Text;
                    _purchase.Product = productsComboBox.Text;
                    _purchase.ProductCode = productCodeTextBox.Text;
                    
                    _purchase.ManufactureDate = manufacturedDate.Text;
                    _purchase.ExpireDate = expireDate.Text;
                    _purchase.Quantity = int.Parse(quantityTextBox.Text);
                    _purchase.UnitPrice = double.Parse(unitPriceTextBox.Text);
                    _purchase.TotalPrice = double.Parse(totalPriceTextBox.Text);
                    _purchase.PreviousUnitPrice = double.Parse(previousUnitPriceTextBox.Text);
                    _purchase.PreviousMRP = double.Parse(previousMrpTextBox.Text);
                    _purchase.MRP = double.Parse(mrpTextBox.Text);
                    _purchase.Remarks = remarksTextBox.Text;

                    if (!IsValid(_purchase))
                    {
                        return;
                    }
                    if (!IsUnique(_purchase))
                    {
                        return;
                    }
                    if (samePurchase(_purchase.ProductCode, _purchases))
                    {
                        return;
                    }

                    _purchases.Add(_purchase);

                    ResetInputs();
                    ResetErrorLabels();

                    DisplayRecords(_purchases, _itemList);
                }
                else if (addButton.Text.Equals("Modify"))
                {

                }
            }catch(Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            foreach (Purchase purchase in _purchases)
            {
                Add(purchase);

                showDataGridView.DataSource = null;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ResetAll();
        }

        private void showPurchaseButton_Click(object sender, EventArgs e)
        {
            DisplayRecords(GetRecords(), _database);
            cancelButton.Visible = true;
        }

        //CRUD Functions
        private bool Add(Purchase purchase)
        {
            return _purchaseManager.Add(purchase);
        }

        private List<Purchase> GetRecords()
        {
            return _purchaseManager.GetRecords();
        }

        private const int _itemList = 0;
        private const int _database = 1;
        private void DisplayRecords(List<Purchase> purchases, int check)
        {
            try
            {
                showDataGridView.ReadOnly = true;

                if (check == 0)
                {
                    BindingSource purchaseTable = new BindingSource {DataSource = purchases};
                    showDataGridView.DataSource = purchaseTable;

                    SetSerialNumber(showDataGridView);
                    SetActionColumn(showDataGridView);
                    showDataGridView.Columns["actionColumn"].Visible = true;
                }
                else if (check == 1)
                {
                    showDataGridView.DataSource = purchases;

                    Helper.SetSerialNumber(showDataGridView);
                    showDataGridView.Columns["actionColumn"].Visible = false;
                }

                showDataGridView.Columns["idColumn"].Visible = false;
                showDataGridView.Columns["codeColumn"].Visible = false;
                showDataGridView.Columns["dateColumn"].Visible = false;
                showDataGridView.Columns["invoiceNoColumn"].Visible = false;
                showDataGridView.Columns["supplierColumn"].Visible = false;
                showDataGridView.Columns["categoryColumn"].Visible = false;
                showDataGridView.Columns["productColumn"].Visible = false;
                //showDataGridView.Columns["availableQuantityColumn"].Visible = false;
                showDataGridView.Columns["previousUnitPriceColumn"].Visible = false;
                showDataGridView.Columns["previousMRPColumn"].Visible = false;

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

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }
        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text) && !String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                totalPriceTextBox.Text = (int.Parse(quantityTextBox.Text) * double.Parse(unitPriceTextBox.Text)) + "";

                double unitPrice = double.Parse(unitPriceTextBox.Text);
                mrpTextBox.Text = (unitPrice + (unitPrice * 25 / 100)) + "";
            }
        }

        private void ExceptionMessage(Exception error)
        {
            MessageBox.Show(error.Message);
            _purchaseManager.CloseConnection();
        }

        private void ResetErrorLabels()
        {
            productsError.Text = null;
            mrpError.Text = null;
            unitPriceError.Text = null;
            quantityError.Text = null;
            categoryError.Text = null;
            supplierError.Text = null;
            invoiceError.Text = null;
            confirmationLabel.Text = null;
        }

        private void ResetInputs()
        {
            supplierDate.Format = DateTimePickerFormat.Short;
            invoiceTextBox.Clear();
            supplierComboBox.Text = "-Select-";
            categoryComboBox.Text = "-Select-";
            productsComboBox.Text = "-Select-";
            productsComboBox.Enabled = false;
            productCodeTextBox.Clear();
            manufacturedDate.Format = DateTimePickerFormat.Short;
            expireDate.Format = DateTimePickerFormat.Short;
            quantityTextBox.Text = 0+"";
            unitPriceTextBox.Text = 0 + "";
            totalPriceTextBox.Text = 0 + "";
            previousUnitPriceTextBox.Text = 0 + "";
            previousMrpTextBox.Text = 0 + "";
            mrpTextBox.Text = 0 + "";
            remarksTextBox.Clear();

            cancelButton.Visible = false;
            deleteButton.Visible = false;
            addButton.Text = "Add";
        }

        private void ResetAll()
        {
            supplierDate.Format = DateTimePickerFormat.Short;
            invoiceTextBox.Clear();
            supplierComboBox.Text = "-Select-";
            categoryComboBox.Text = "-Select-";
            productsComboBox.Text = "-Select-";
            productsComboBox.Enabled = false;
            productCodeTextBox.Clear();
            manufacturedDate.Format = DateTimePickerFormat.Short;
            expireDate.Format = DateTimePickerFormat.Short;
            quantityTextBox.Text = 0 + "";
            unitPriceTextBox.Text = 0 + "";
            totalPriceTextBox.Text = 0 + "";
            previousUnitPriceTextBox.Text = 0 + "";
            previousMrpTextBox.Text = 0 + "";
            mrpTextBox.Text = 0 + "";
            remarksTextBox.Clear();

            productsError.Text = null;
            mrpError.Text = null;
            unitPriceError.Text = null;
            quantityError.Text = null;
            categoryError.Text = null;
            supplierError.Text = null;
            invoiceError.Text = null;
            confirmationLabel.Text = null;

            cancelButton.Visible = false;
            deleteButton.Visible = false;
            addButton.Text = "Add";

            showDataGridView.DataSource = null;
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

                        _purchase.Id = int.Parse(showDataGridView.Rows[e.RowIndex].Cells["idColumn"].Value.ToString());

                        addButton.Text = "Modify";
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

    }
}
