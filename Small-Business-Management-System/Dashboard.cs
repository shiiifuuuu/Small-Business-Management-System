using Small_Business_Management_System.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Small_Business_Management_System
{
    public partial class DashboardForm : MaterialSkin.Controls.MaterialForm
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void category_Click(object sender, EventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm() /*{ Dock = DockStyle.Fill, TopLevel = false, TopMost = true }*/;
            //categoryForm.FormBorderStyle = (FormBorderStyle) BorderStyle.None;
            //this.formContainer.Controls.Add(categoryForm);
            //categoryForm.Show();


            categoryForm.ShowDialog();
        }

        private void product_Click(object sender, EventArgs e)
        {
            ProductForm productForm = new ProductForm();
            productForm.ShowDialog();
        }

        private void customer_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void supplier_Click(object sender, EventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void purchase_Click(object sender, EventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
        }

        private void sales_Click(object sender, EventArgs e)
        {
            SalesForm salesForm = new SalesForm();
            salesForm.ShowDialog();
        }

        private void stockSearch_Click(object sender, EventArgs e)
        {

        }

        private void reportOnSales_Click(object sender, EventArgs e)
        {
            ReportingSalesForm reportingSalesForm = new ReportingSalesForm();
            reportingSalesForm.ShowDialog();
        }

        private void reportOnPurchase_Click(object sender, EventArgs e)
        {
            ReportingPurchaseForm reportingPurchaseForm = new ReportingPurchaseForm();
            reportingPurchaseForm.ShowDialog();
        }
    }
}
