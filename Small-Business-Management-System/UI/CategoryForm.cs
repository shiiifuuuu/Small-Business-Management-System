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

namespace Small_Business_Management_System
{
    public partial class CategoryForm : Form
    {
        private bool codeValid=false;
        private bool nameValid = false;
        private Category category = new Category();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            codeValid = false;
            if (codeTextBox.TextLength.Equals(4))
            {
                codeErrorLabel.Text = null;
                codeTextBox.MaxLength = 4;
                codeValid = true;
            }
            if (codeTextBox.TextLength < 4)
            {
                codeErrorLabel.Text = "Length must be 4 character!!";
            }
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (codeValid&&nameValid)
            {
                category.Code = codeTextBox.Text;
                category.Name = nameTextBox.Text;
                MessageBox.Show("Valid!!");
            }
        }

        private void nameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            nameValid = false;
            if (!Helper.IsInputLetterOrDigit(e))
            {
                nameErrorLabel.Text = "Name can contain only letters or digits";
            }
            else
            {
                nameErrorLabel.Text = null;
                nameValid = true;
            }
        }
    }
}
