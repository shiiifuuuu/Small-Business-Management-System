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
                            availableQuantityTextBox.Text = product.ReorderLevel;
                        }
                    }
                }
            }
            else
            {
                codeTextBox.Text = null;
                availableQuantityTextBox.Text = null;
            }
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

        //Buttons
        private void addButton_Click(object sender, EventArgs e)
        {

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

        private void quantityTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndGetPrevious();
        }
        private void unitPriceTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculateAndGetPrevious();
        }

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

    }
}
