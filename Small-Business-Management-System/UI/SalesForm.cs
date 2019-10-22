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

        private void addButton_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void SalesForm_Load(object sender, EventArgs e)
        {
            categoryComboBox.DataSource = _salesManager.CategoryComboLoad();
            categoryComboBox.Text = "-Select-";

            customerComboBox.DataSource = _salesManager.CustomerComboLoad();
            customerComboBox.Text = "-Select-";

            productComboBox.DataSource = _salesManager.ProductComboLoad();
            productComboBox.Text = "-Select-";
        }
    }
}
