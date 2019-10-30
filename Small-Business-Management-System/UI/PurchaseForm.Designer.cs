namespace Small_Business_Management_System.UI
{
    partial class PurchaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.supplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.supplierError = new System.Windows.Forms.Label();
            this.invoiceError = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.expireDate = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.remarksTextBox = new System.Windows.Forms.RichTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.manufacturedDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.previousMrpTextBox = new System.Windows.Forms.TextBox();
            this.productCodeTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.previousUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.productsError = new System.Windows.Forms.Label();
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.mrpError = new System.Windows.Forms.Label();
            this.unitPriceError = new System.Windows.Forms.Label();
            this.quantityError = new System.Windows.Forms.Label();
            this.categoryError = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.siColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceNoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufactureDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expireDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousUnitPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.previousMRPColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mrpColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarksColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showPurchaseButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.supplierComboBox);
            this.groupBox1.Controls.Add(this.invoiceTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.supplierDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.supplierError);
            this.groupBox1.Controls.Add(this.invoiceError);
            this.groupBox1.Location = new System.Drawing.Point(137, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(574, 82);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataSource = this.supplierBindingSource;
            this.supplierComboBox.DisplayMember = "Name";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(433, 27);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(121, 21);
            this.supplierComboBox.TabIndex = 4;
            this.supplierComboBox.ValueMember = "Id";
            // 
            // invoiceTextBox
            // 
            this.invoiceTextBox.Location = new System.Drawing.Point(252, 28);
            this.invoiceTextBox.Name = "invoiceTextBox";
            this.invoiceTextBox.Size = new System.Drawing.Size(121, 20);
            this.invoiceTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Supplier:";
            // 
            // supplierDate
            // 
            this.supplierDate.CustomFormat = "";
            this.supplierDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.supplierDate.Location = new System.Drawing.Point(56, 29);
            this.supplierDate.Name = "supplierDate";
            this.supplierDate.Size = new System.Drawing.Size(121, 20);
            this.supplierDate.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill/Invoice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // supplierError
            // 
            this.supplierError.AutoSize = true;
            this.supplierError.ForeColor = System.Drawing.Color.Red;
            this.supplierError.Location = new System.Drawing.Point(399, 55);
            this.supplierError.Name = "supplierError";
            this.supplierError.Size = new System.Drawing.Size(28, 13);
            this.supplierError.TabIndex = 0;
            this.supplierError.Text = "error";
            // 
            // invoiceError
            // 
            this.invoiceError.AutoSize = true;
            this.invoiceError.ForeColor = System.Drawing.Color.Red;
            this.invoiceError.Location = new System.Drawing.Point(194, 55);
            this.invoiceError.Name = "invoiceError";
            this.invoiceError.Size = new System.Drawing.Size(28, 13);
            this.invoiceError.TabIndex = 0;
            this.invoiceError.Text = "error";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteButton);
            this.groupBox2.Controls.Add(this.cancelButton);
            this.groupBox2.Controls.Add(this.expireDate);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.remarksTextBox);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.manufacturedDate);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.mrpTextBox);
            this.groupBox2.Controls.Add(this.productsComboBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.availableQuantityTextBox);
            this.groupBox2.Controls.Add(this.previousMrpTextBox);
            this.groupBox2.Controls.Add(this.productCodeTextBox);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.previousUnitPriceTextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.totalPriceTextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.unitPriceTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.productsError);
            this.groupBox2.Controls.Add(this.confirmationLabel);
            this.groupBox2.Controls.Add(this.mrpError);
            this.groupBox2.Controls.Add(this.unitPriceError);
            this.groupBox2.Controls.Add(this.quantityError);
            this.groupBox2.Controls.Add(this.categoryError);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 203);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 256);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(592, 222);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(511, 222);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 29;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // expireDate
            // 
            this.expireDate.CustomFormat = " ";
            this.expireDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.expireDate.Location = new System.Drawing.Point(112, 189);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(156, 20);
            this.expireDate.TabIndex = 28;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(673, 222);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(147, 23);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // remarksTextBox
            // 
            this.remarksTextBox.Location = new System.Drawing.Point(602, 74);
            this.remarksTextBox.Name = "remarksTextBox";
            this.remarksTextBox.Size = new System.Drawing.Size(213, 94);
            this.remarksTextBox.TabIndex = 24;
            this.remarksTextBox.Text = "";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(319, 77);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Quantity";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(290, 117);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Unit Price (Tk)";
            // 
            // manufacturedDate
            // 
            this.manufacturedDate.CustomFormat = " ";
            this.manufacturedDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.manufacturedDate.Location = new System.Drawing.Point(112, 163);
            this.manufacturedDate.Name = "manufacturedDate";
            this.manufacturedDate.Size = new System.Drawing.Size(156, 20);
            this.manufacturedDate.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(285, 162);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Price (Tk)";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.categoryBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(112, 22);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(156, 21);
            this.categoryComboBox.TabIndex = 5;
            this.categoryComboBox.ValueMember = "Id";
            this.categoryComboBox.SelectedIndexChanged += new System.EventHandler(this.categoryComboBox_SelectedIndexChanged);
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(371, 185);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(155, 20);
            this.mrpTextBox.TabIndex = 23;
            // 
            // productsComboBox
            // 
            this.productsComboBox.DataSource = this.productBindingSource;
            this.productsComboBox.DisplayMember = "Name";
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(112, 66);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(156, 21);
            this.productsComboBox.TabIndex = 6;
            this.productsComboBox.ValueMember = "Id";
            this.productsComboBox.TextChanged += new System.EventHandler(this.productsComboBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(424, 22);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Previous Unit Price (Tk)";
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(113, 137);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.ReadOnly = true;
            this.availableQuantityTextBox.Size = new System.Drawing.Size(155, 20);
            this.availableQuantityTextBox.TabIndex = 15;
            this.availableQuantityTextBox.Text = "<View>";
            // 
            // previousMrpTextBox
            // 
            this.previousMrpTextBox.Location = new System.Drawing.Point(587, 38);
            this.previousMrpTextBox.Name = "previousMrpTextBox";
            this.previousMrpTextBox.ReadOnly = true;
            this.previousMrpTextBox.Size = new System.Drawing.Size(155, 20);
            this.previousMrpTextBox.TabIndex = 22;
            this.previousMrpTextBox.Text = "<View>";
            // 
            // productCodeTextBox
            // 
            this.productCodeTextBox.Location = new System.Drawing.Point(113, 111);
            this.productCodeTextBox.Name = "productCodeTextBox";
            this.productCodeTextBox.ReadOnly = true;
            this.productCodeTextBox.Size = new System.Drawing.Size(155, 20);
            this.productCodeTextBox.TabIndex = 14;
            this.productCodeTextBox.Text = "<View>";
            this.productCodeTextBox.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(611, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Previous MRP (Tk)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(547, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Remarks";
            // 
            // previousUnitPriceTextBox
            // 
            this.previousUnitPriceTextBox.Location = new System.Drawing.Point(405, 38);
            this.previousUnitPriceTextBox.Name = "previousUnitPriceTextBox";
            this.previousUnitPriceTextBox.ReadOnly = true;
            this.previousUnitPriceTextBox.Size = new System.Drawing.Size(155, 20);
            this.previousUnitPriceTextBox.TabIndex = 21;
            this.previousUnitPriceTextBox.Text = "<View>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Expire Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(312, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "MRP (Tk)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Manufactured Date";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(371, 159);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(155, 20);
            this.totalPriceTextBox.TabIndex = 20;
            this.totalPriceTextBox.Text = "<View>";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Available Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(371, 74);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(155, 20);
            this.quantityTextBox.TabIndex = 18;
            this.quantityTextBox.TextChanged += new System.EventHandler(this.quantityTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Code";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(371, 114);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(155, 20);
            this.unitPriceTextBox.TabIndex = 19;
            this.unitPriceTextBox.TextChanged += new System.EventHandler(this.unitPriceTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Products";
            // 
            // productsError
            // 
            this.productsError.AutoSize = true;
            this.productsError.ForeColor = System.Drawing.Color.Red;
            this.productsError.Location = new System.Drawing.Point(27, 91);
            this.productsError.Name = "productsError";
            this.productsError.Size = new System.Drawing.Size(28, 13);
            this.productsError.TabIndex = 0;
            this.productsError.Text = "error";
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.confirmationLabel.Location = new System.Drawing.Point(51, 227);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(64, 13);
            this.confirmationLabel.TabIndex = 0;
            this.confirmationLabel.Text = "confirmation";
            // 
            // mrpError
            // 
            this.mrpError.AutoSize = true;
            this.mrpError.ForeColor = System.Drawing.Color.Red;
            this.mrpError.Location = new System.Drawing.Point(336, 210);
            this.mrpError.Name = "mrpError";
            this.mrpError.Size = new System.Drawing.Size(28, 13);
            this.mrpError.TabIndex = 0;
            this.mrpError.Text = "error";
            // 
            // unitPriceError
            // 
            this.unitPriceError.AutoSize = true;
            this.unitPriceError.ForeColor = System.Drawing.Color.Red;
            this.unitPriceError.Location = new System.Drawing.Point(336, 137);
            this.unitPriceError.Name = "unitPriceError";
            this.unitPriceError.Size = new System.Drawing.Size(28, 13);
            this.unitPriceError.TabIndex = 0;
            this.unitPriceError.Text = "error";
            // 
            // quantityError
            // 
            this.quantityError.AutoSize = true;
            this.quantityError.ForeColor = System.Drawing.Color.Red;
            this.quantityError.Location = new System.Drawing.Point(336, 99);
            this.quantityError.Name = "quantityError";
            this.quantityError.Size = new System.Drawing.Size(28, 13);
            this.quantityError.TabIndex = 0;
            this.quantityError.Text = "error";
            // 
            // categoryError
            // 
            this.categoryError.AutoSize = true;
            this.categoryError.ForeColor = System.Drawing.Color.Red;
            this.categoryError.Location = new System.Drawing.Point(27, 45);
            this.categoryError.Name = "categoryError";
            this.categoryError.Size = new System.Drawing.Size(28, 13);
            this.categoryError.TabIndex = 0;
            this.categoryError.Text = "error";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // showDataGridView
            // 
            this.showDataGridView.AutoGenerateColumns = false;
            this.showDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.showDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.siColumn,
            this.idColumn,
            this.codeColumn,
            this.dateColumn,
            this.invoiceNoColumn,
            this.supplierColumn,
            this.categoryColumn,
            this.productColumn,
            this.productCodeColumn,
            this.manufactureDateColumn,
            this.expireDateColumn,
            this.quantityColumn,
            this.unitPriceColumn,
            this.totalPriceColumn,
            this.previousUnitPriceColumn,
            this.previousMRPColumn,
            this.mrpColumn,
            this.remarksColumn,
            this.actionColumn});
            this.showDataGridView.DataSource = this.purchaseBindingSource;
            this.showDataGridView.Location = new System.Drawing.Point(12, 465);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(835, 180);
            this.showDataGridView.TabIndex = 2;
            this.showDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showDataGridView_CellContentClick);
            // 
            // siColumn
            // 
            this.siColumn.HeaderText = "SI";
            this.siColumn.Name = "siColumn";
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            // 
            // codeColumn
            // 
            this.codeColumn.DataPropertyName = "Code";
            this.codeColumn.HeaderText = "Code";
            this.codeColumn.Name = "codeColumn";
            // 
            // dateColumn
            // 
            this.dateColumn.DataPropertyName = "Date";
            this.dateColumn.HeaderText = "Date";
            this.dateColumn.Name = "dateColumn";
            // 
            // invoiceNoColumn
            // 
            this.invoiceNoColumn.DataPropertyName = "InvoiceNo";
            this.invoiceNoColumn.HeaderText = "InvoiceNo";
            this.invoiceNoColumn.Name = "invoiceNoColumn";
            // 
            // supplierColumn
            // 
            this.supplierColumn.DataPropertyName = "Supplier";
            this.supplierColumn.HeaderText = "Supplier";
            this.supplierColumn.Name = "supplierColumn";
            // 
            // categoryColumn
            // 
            this.categoryColumn.DataPropertyName = "Category";
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.Name = "categoryColumn";
            // 
            // productColumn
            // 
            this.productColumn.DataPropertyName = "Product";
            this.productColumn.HeaderText = "Product";
            this.productColumn.Name = "productColumn";
            // 
            // productCodeColumn
            // 
            this.productCodeColumn.DataPropertyName = "ProductCode";
            this.productCodeColumn.HeaderText = "ProductCode";
            this.productCodeColumn.Name = "productCodeColumn";
            // 
            // manufactureDateColumn
            // 
            this.manufactureDateColumn.DataPropertyName = "ManufactureDate";
            this.manufactureDateColumn.HeaderText = "ManufactureDate";
            this.manufactureDateColumn.Name = "manufactureDateColumn";
            // 
            // expireDateColumn
            // 
            this.expireDateColumn.DataPropertyName = "ExpireDate";
            this.expireDateColumn.HeaderText = "ExpireDate";
            this.expireDateColumn.Name = "expireDateColumn";
            // 
            // quantityColumn
            // 
            this.quantityColumn.DataPropertyName = "Quantity";
            this.quantityColumn.HeaderText = "Quantity";
            this.quantityColumn.Name = "quantityColumn";
            // 
            // unitPriceColumn
            // 
            this.unitPriceColumn.DataPropertyName = "UnitPrice";
            this.unitPriceColumn.HeaderText = "UnitPrice";
            this.unitPriceColumn.Name = "unitPriceColumn";
            // 
            // totalPriceColumn
            // 
            this.totalPriceColumn.DataPropertyName = "TotalPrice";
            this.totalPriceColumn.HeaderText = "TotalPrice";
            this.totalPriceColumn.Name = "totalPriceColumn";
            // 
            // previousUnitPriceColumn
            // 
            this.previousUnitPriceColumn.DataPropertyName = "PreviousUnitPrice";
            this.previousUnitPriceColumn.HeaderText = "PreviousUnitPrice";
            this.previousUnitPriceColumn.Name = "previousUnitPriceColumn";
            // 
            // previousMRPColumn
            // 
            this.previousMRPColumn.DataPropertyName = "PreviousMRP";
            this.previousMRPColumn.HeaderText = "PreviousMRP";
            this.previousMRPColumn.Name = "previousMRPColumn";
            // 
            // mrpColumn
            // 
            this.mrpColumn.DataPropertyName = "MRP";
            this.mrpColumn.HeaderText = "MRP";
            this.mrpColumn.Name = "mrpColumn";
            // 
            // remarksColumn
            // 
            this.remarksColumn.DataPropertyName = "Remarks";
            this.remarksColumn.HeaderText = "Remarks";
            this.remarksColumn.Name = "remarksColumn";
            // 
            // actionColumn
            // 
            this.actionColumn.HeaderText = "Action";
            this.actionColumn.Name = "actionColumn";
            // 
            // purchaseBindingSource
            // 
            this.purchaseBindingSource.DataSource = typeof(Small_Business_Management_System.MODEL.Purchase);
            // 
            // submitButton
            // 
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.Location = new System.Drawing.Point(737, 662);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(109, 23);
            this.submitButton.TabIndex = 26;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.showPurchaseButton);
            this.groupBox3.Controls.Add(this.searchButton);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(254, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(359, 97);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Search";
            // 
            // showPurchaseButton
            // 
            this.showPurchaseButton.Location = new System.Drawing.Point(16, 66);
            this.showPurchaseButton.Name = "showPurchaseButton";
            this.showPurchaseButton.Size = new System.Drawing.Size(328, 23);
            this.showPurchaseButton.TabIndex = 1;
            this.showPurchaseButton.Text = "Show Purchase History";
            this.showPurchaseButton.UseVisualStyleBackColor = true;
            this.showPurchaseButton.Click += new System.EventHandler(this.showPurchaseButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(269, 23);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 1;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(247, 20);
            this.textBox1.TabIndex = 0;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(859, 697);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "PurchaseForm";
            this.Text = "Purchase";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseBindingSource)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.TextBox invoiceTextBox;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.TextBox previousMrpTextBox;
        private System.Windows.Forms.TextBox previousUnitPriceTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.TextBox productCodeTextBox;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox productsComboBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox remarksTextBox;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker manufacturedDate;
        private System.Windows.Forms.DateTimePicker expireDate;
        private System.Windows.Forms.DateTimePicker supplierDate;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button showPurchaseButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label productsError;
        private System.Windows.Forms.Label mrpError;
        private System.Windows.Forms.Label unitPriceError;
        private System.Windows.Forms.Label quantityError;
        private System.Windows.Forms.Label categoryError;
        private System.Windows.Forms.Label supplierError;
        private System.Windows.Forms.Label invoiceError;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.BindingSource purchaseBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn siColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceNoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufactureDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn expireDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousUnitPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn previousMRPColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mrpColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarksColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionColumn;
    }
}