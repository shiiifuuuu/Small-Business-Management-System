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

        //Buttons
        private void addButton_Click(object sender, EventArgs e)
        {
            Purchase purchase = new Purchase();
            purchase.PurchaseDate = Convert.ToDateTime(supplierDate.Text);
            purchase.InvoiceNo = invoiceTextBox.Text;
            purchase.Supplier = supplierComboBox.Text;

            purchase.Category = categoryComboBox.Text;
            purchase.Product = productsComboBox.Text;
            purchase.ProductCode = codeTextBox.Text;
            purchase.AvailableQuantity = int.Parse(availableQuantityTextBox.Text);
            purchase.ManufactureDate = Convert.ToDateTime(manufacturedDate.Text);
            purchase.ExpireDate = Convert.ToDateTime(expireDate.Text);
            purchase.Quantity = int.Parse(quantityTextBox.Text);
            purchase.UnitPrice = double.Parse(unitPriceTextBox.Text);
            purchase.TotalPrice = double.Parse(totalPriceTextBox.Text);
            purchase.PreviousUnitPrice = double.Parse(previousUnitPriceTextBox.Text);
            purchase.PreviousMRP = double.Parse(previousMrpTextBox.Text);
            purchase.MRP = double.Parse(mrpTextBox.Text);

            _purchase.Remarks = remarksTextBox.Text;

            _purchases.Add(purchase);

            DisplayRecords(_purchases, _itemList);
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            foreach (Purchase purchase in _purchases)
            {
                AddPurchase(purchase);
            }
            DisplayRecords(GetRecords(), _database);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {

        }

        //CRUD Functions
        private bool AddPurchase(Purchase purchase)
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
                }
                else if (check == 1)
                {
                    showDataGridView.DataSource = purchases;

                    Helper.SetActionColumn(showDataGridView);
                    Helper.SetSerialNumber(showDataGridView);
                }

                showDataGridView.Columns["idColumn"].Visible = false;
                showDataGridView.Columns["purchaseDateColumn"].Visible = false;
                showDataGridView.Columns["invoiceNoColumn"].Visible = false;
                showDataGridView.Columns["supplierColumn"].Visible = false;
                showDataGridView.Columns["categoryColumn"].Visible = false;
                showDataGridView.Columns["productColumn"].Visible = false;
                showDataGridView.Columns["availableQuantityColumn"].Visible = false;
                showDataGridView.Columns["previousUnitPriceColumn"].Visible = false;
                showDataGridView.Columns["previousMRPColumn"].Visible = false;

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
                if (rows.Index != dgv.Rows.Count - 1)
                {
                    rows.Cells["actionColumn"].Value = "Edit";
                }
            }

            dgv.Columns["actionColumn"].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            dgv.Columns["actionColumn"].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Underline);
        }

        private void SetSerialNumber(DataGridView dgv)
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

        private void ExceptionMessage(Exception error)
        {
            MessageBox.Show(error.Message);
            _purchaseManager.CloseConnection();
        }

        private void showPurchaseButton_Click(object sender, EventArgs e)
        {
            DisplayRecords(GetRecords(), _database);
        }
    }
}
