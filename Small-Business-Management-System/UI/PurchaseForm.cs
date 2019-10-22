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
        
        Product _product = new Product();

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
                            codeTextBox.Text = product.Code;
                        }
                    }
                }
            }
            else
            {
                codeTextBox.Text = null;
            }

            availableQuantityTextBox.Text = _purchaseManager.GetAvailableQuantity(codeTextBox.Text)+"";
        }

        //DATE FORMAT SET
        private void supplierDate_ValueChanged(object sender, EventArgs e)
        {
            supplierDate.CustomFormat = "dd-MM-yyyy";
        }
        private void manufacturedDate_ValueChanged(object sender, EventArgs e)
        {
            manufacturedDate.CustomFormat = "dd-MM-yyyy";
        }
        private void expireDate_ValueChanged(object sender, EventArgs e)
        {
            expireDate.CustomFormat = "dd-MM-yyyy";
        }

        List<Purchase> purchases = new List<Purchase>();
        //Buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.PurchaseDate = supplierDate.Text;
            purchase.InvoiceNo = invoiceTextBox.Text;
            purchase.Supplier = supplierComboBox.Text;

            purchase.Category = categoryComboBox.Text;
            purchase.Product = productsComboBox.Text;
            purchase.Code = codeTextBox.Text;
            purchase.AvailableQuantity = int.Parse(availableQuantityTextBox.Text);
            purchase.ManufactureDate = manufacturedDate.Text;
            purchase.ExpireDate = expireDate.Text;
            purchase.Quantity = int.Parse(quantityTextBox.Text);
            purchase.UnitPrice = double.Parse(unitPriceTextBox.Text);
            purchase.TotalPrice = double.Parse(totalPriceTextBox.Text);
            purchase.PreviousUnitPrice = double.Parse(previousUnitPriceTextBox.Text);
            purchase.PreviousMRP = double.Parse(previousMrpTextBox.Text);
            purchase.MRP = double.Parse(mrpTextBox.Text);

            purchase.Remarks = remarksTextBox.Text;

            purchases.Add(purchase);

            showDataGridView.DataSource = purchases;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {

        }

        //CRUD Functions

        //private List<Supplier> GetRecords()
        //{
        //    return _purchaseManager.GetRecords();
        //}

        private void DisplayRecords(List<Purchase> purchases)
        {
            try
            {
                showDataGridView.ReadOnly = true;
                showDataGridView.DataSource = purchases;

                showDataGridView.Columns["idColumn"].Visible = false;
                Helper.SetSerialNumber(showDataGridView);
                Helper.SetActionColumn(showDataGridView);
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
        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndGetPrevious();
        }
        Purchase _purchase = new Purchase();
        private void CalculateAndGetPrevious()
        {
            if (!String.IsNullOrEmpty(quantityTextBox.Text) && !String.IsNullOrEmpty(unitPriceTextBox.Text))
            {
                totalPriceTextBox.Text = (int.Parse(quantityTextBox.Text) * double.Parse(unitPriceTextBox.Text)) + "";

                previousUnitPriceTextBox.Text = _purchaseManager.GetPrevious("UnitPrice", _purchase) + "";
                previousMrpTextBox.Text = _purchaseManager.GetPrevious("MRP", _purchase) + "";

                double unitPrice = double.Parse(unitPriceTextBox.Text);
                mrpTextBox.Text = (unitPrice + (unitPrice * 25 / 100)) + "";
            }
        }

        private void ExceptionMessage(Exception error)
        {
            MessageBox.Show(error.Message);
            _purchaseManager.CloseConnection();
        }
    }
}
