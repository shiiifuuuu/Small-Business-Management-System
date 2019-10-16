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
        //Purchase _purchase = new Purchase();

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

            //productsComboBox.DataSource = _purchaseManager.ProductComboLoad();
            //productsComboBox.Text = "-Select-";
        }

        private void addButton_Click(object sender, EventArgs e)
        {

        }
    }
}
