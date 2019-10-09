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
            DisplayRecords(GetRecords());
            deleteButton.Visible = false;
            cancelButton.Visible = false;
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

                showDataGridView.Columns["idColumn"].Visible = false;
                Helper.SetSerialNumber(showDataGridView);
                Helper.SetActionColumn(showDataGridView);
            }
            catch (Exception error)
            {
                ExceptionMessage(error);
            }
        }

        private bool IsValid(Supplier supplier)
        {
            throw new NotImplementedException();
        }


        //COMMON
        private void CleanAll()
        {
            codeTextBox.Text = null;
            nameTextBox.Text = null;

            saveButton.Text = "Save";
            deleteButton.Visible = false;
            cancelButton.Visible = false;
        }
        private void ExceptionMessage(Exception error)
        {
            MessageBox.Show(error.Message);
            _supplierManager.CloseConnection();
        }
    }
}
