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
    public partial class SupplierForm : Form
    {
        SupplierManager _supplierManager = new SupplierManager();
        Supplier _supplier = new Supplier();

        public SupplierForm()
        {
            InitializeComponent();
        }
        private void SupplierForm_Load(object sender, EventArgs e)
        {
            try
            {
                DisplayRecords(GetRecords());
                deleteButton.Visible = false;
                cancelButton.Visible = false;
            }catch(Exception error)
            {
                ExceptionMessage(error);
            }
            
        }

        //BUTTONS
        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                _supplier.Code = codeTextBox.Text;
                _supplier.Name = nameTextBox.Text;
                _supplier.Address = addressTextBox.Text;
                _supplier.Email = emailTextBox.Text;
                _supplier.Contact = contactTextBox.Text;
                _supplier.ContactPerson = contactPersonTextBox.Text;

                if (IsValid(_supplier))
                {
                    if (saveButton.Text == "Save")
                    {
                        if (AddSupplier(_supplier)) //ADDED SUCCESSFULLY
                        {
                            confirmationLabel.Text = "Supplier Information Saved Successfully!";
                            DisplayRecords(GetRecords());
                            CleanAll();
                        }
                    }
                    else if (saveButton.Text == "Modify")
                    {
                        if (ModifyCategory(_supplier)) //MODIFIED SUCCESSFULLY
                        {
                            confirmationLabel.Text = "Supplier Information Modified Successfully!";
                            DisplayRecords(GetRecords());
                            CleanAll();
                        }
                    }
                }
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private bool AddSupplier(Supplier supplier)
        {
            return _supplierManager.AddSupplier(supplier);
        }

        private bool ModifyCategory(Supplier supplier)
        {
            throw new NotImplementedException();
        }
        private List<Supplier> GetRecords()
        {
            return _supplierManager.GetRecords();
        }

        private void DisplayRecords(List<Supplier> suppliers)
        {
            try
            {
                showDataGridView.ReadOnly = true;
                showDataGridView.DataSource = suppliers;

                showDataGridView.Columns["IdColumn"].Visible = false;
                SetSerialNumber(showDataGridView);
                SetActionColumn(showDataGridView);
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
                rows.Cells["ActionColumn"].Value = "Edit";
            }

            dgv.Columns["ActionColumn"].DefaultCellStyle.ForeColor = System.Drawing.Color.Blue;
            dgv.Columns["ActionColumn"].DefaultCellStyle.Font = new Font(dgv.DefaultCellStyle.Font, FontStyle.Underline);
        }

        private void SetSerialNumber(DataGridView dgv)
        {
            int i = 1;
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells["SIColumn"].Value = i;
                i++;
            }
        }

        private bool IsValid(Supplier supplier)
        {
            bool isValid = true;

            if (String.IsNullOrEmpty(supplier.Code))
            {
                codeErrorLabel.Text = "code field can not be empty!";
                isValid = false;
            }
            else if (!CodeLengthValidation())
            {
                isValid = false;
            }
            if (String.IsNullOrEmpty(supplier.Email))
            {
                emailErrorLabel.Text = "Email field can not be empty!";
                isValid = false;
            }
            if (String.IsNullOrEmpty(supplier.Contact))
            {
                contactErrorLabel.Text = "Contact field can not be empty!";
                isValid = false;
            }

            if (!IsCodeUnique(supplier))
            {
                codeErrorLabel.Text = "This Code already Exist!";
                isValid = false;
            }
            if (!IsEmailUnique(supplier))
            {
                emailErrorLabel.Text = "This Email already Exist!";
                isValid = false;
            }
            if (!IsContactUnique(supplier))
            {
                contactErrorLabel.Text = "This Contact already Exist!";
            }

            return isValid;
        }

        private bool IsEmailUnique(Supplier supplier)
        {
            return _supplierManager.IsEmailUnique(supplier);
        }

        private bool IsContactUnique(Supplier supplier)
        {
            return _supplierManager.IsContactUnique(supplier);
        }

        private bool IsCodeUnique(Supplier supplier)
        {
            return _supplierManager.IsCodeUnique(supplier);
        }

        private bool CodeLengthValidation()
        {
            bool valid = false;
            if (codeTextBox.TextLength.Equals(4))
            {
                codeErrorLabel.Text = null;
                codeTextBox.MaxLength = 4;
                valid = true;
            }
            if (codeTextBox.TextLength < 4 && !String.IsNullOrEmpty(codeTextBox.Text))
            {
                codeErrorLabel.Text = "Length must be 4 character!!";
            }
            return valid;
        }


        //COMMON
        private void CleanAll()
        {
            codeTextBox.Text = null;
            nameTextBox.Text = null;
            nameTextBox.Text = null;
            addressTextBox.Text = null;
            emailTextBox.Text = null;
            contactTextBox.Text = null;
            contactPersonTextBox.Text = null;

            saveButton.Text = "Save";
            deleteButton.Visible = false;
            cancelButton.Visible = false;
        }
        private void ExceptionMessage(Exception error)
        {
            MessageBox.Show(error.Message);
            _supplierManager.CloseConnection();
        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {
            CodeLengthValidation();
        }
    }
}
