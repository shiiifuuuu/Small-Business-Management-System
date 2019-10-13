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
    public partial class IndexForm : Form
    {
        public IndexForm()
        {
            InitializeComponent();
        }

        private void categoryFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CategoryForm categoryForm = new CategoryForm();
            categoryForm.ShowDialog();
        }

        private void productForm_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void customerFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();
            customerForm.ShowDialog();
        }

        private void supplierFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SupplierForm supplierForm = new SupplierForm();
            supplierForm.ShowDialog();
        }

        private void purchaseFormLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PurchaseForm purchaseForm = new PurchaseForm();
            purchaseForm.ShowDialog();
        }
    }
}
