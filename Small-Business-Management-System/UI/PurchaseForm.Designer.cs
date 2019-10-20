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
            this.billTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.supplierDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.expireDate = new System.Windows.Forms.DateTimePicker();
            this.addButton = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.manufacturedDate = new System.Windows.Forms.DateTimePicker();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productsComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mrpTextBox = new System.Windows.Forms.TextBox();
            this.previousMrpTextBox = new System.Windows.Forms.TextBox();
            this.previousUnitPriceTextBox = new System.Windows.Forms.TextBox();
            this.totalPriceTextBox = new System.Windows.Forms.TextBox();
            this.unitPriceTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.availableQuantityTextBox = new System.Windows.Forms.TextBox();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.submitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.supplierBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.supplierComboBox);
            this.groupBox1.Controls.Add(this.billTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.supplierDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(189, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 142);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Supplier";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.DataSource = this.supplierBindingSource;
            this.supplierComboBox.DisplayMember = "Name";
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(101, 93);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(121, 21);
            this.supplierComboBox.TabIndex = 4;
            this.supplierComboBox.ValueMember = "Id";
            // 
            // billTextBox
            // 
            this.billTextBox.Location = new System.Drawing.Point(101, 64);
            this.billTextBox.Name = "billTextBox";
            this.billTextBox.Size = new System.Drawing.Size(121, 20);
            this.billTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Supplier:";
            // 
            // supplierDate
            // 
            this.supplierDate.CustomFormat = " ";
            this.supplierDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.supplierDate.Location = new System.Drawing.Point(101, 34);
            this.supplierDate.Name = "supplierDate";
            this.supplierDate.Size = new System.Drawing.Size(121, 20);
            this.supplierDate.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bill/Invoice:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.expireDate);
            this.groupBox2.Controls.Add(this.addButton);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Controls.Add(this.manufacturedDate);
            this.groupBox2.Controls.Add(this.categoryComboBox);
            this.groupBox2.Controls.Add(this.productsComboBox);
            this.groupBox2.Controls.Add(this.mrpTextBox);
            this.groupBox2.Controls.Add(this.previousMrpTextBox);
            this.groupBox2.Controls.Add(this.previousUnitPriceTextBox);
            this.groupBox2.Controls.Add(this.totalPriceTextBox);
            this.groupBox2.Controls.Add(this.unitPriceTextBox);
            this.groupBox2.Controls.Add(this.quantityTextBox);
            this.groupBox2.Controls.Add(this.availableQuantityTextBox);
            this.groupBox2.Controls.Add(this.codeTextBox);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 311);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Products";
            // 
            // expireDate
            // 
            this.expireDate.CustomFormat = " ";
            this.expireDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDate.Location = new System.Drawing.Point(111, 152);
            this.expireDate.Name = "expireDate";
            this.expireDate.Size = new System.Drawing.Size(157, 20);
            this.expireDate.TabIndex = 28;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(536, 280);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 25;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(112, 178);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(496, 96);
            this.richTextBox1.TabIndex = 24;
            this.richTextBox1.Text = "";
            // 
            // manufacturedDate
            // 
            this.manufacturedDate.CustomFormat = " ";
            this.manufacturedDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.manufacturedDate.Location = new System.Drawing.Point(111, 126);
            this.manufacturedDate.Name = "manufacturedDate";
            this.manufacturedDate.Size = new System.Drawing.Size(157, 20);
            this.manufacturedDate.TabIndex = 27;
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
            // productsComboBox
            // 
            this.productsComboBox.DataSource = this.productBindingSource;
            this.productsComboBox.DisplayMember = "Name";
            this.productsComboBox.FormattingEnabled = true;
            this.productsComboBox.Location = new System.Drawing.Point(112, 48);
            this.productsComboBox.Name = "productsComboBox";
            this.productsComboBox.Size = new System.Drawing.Size(156, 21);
            this.productsComboBox.TabIndex = 6;
            this.productsComboBox.ValueMember = "Id";
            // 
            // mrpTextBox
            // 
            this.mrpTextBox.Location = new System.Drawing.Point(453, 152);
            this.mrpTextBox.Name = "mrpTextBox";
            this.mrpTextBox.Size = new System.Drawing.Size(155, 20);
            this.mrpTextBox.TabIndex = 23;
            // 
            // previousMrpTextBox
            // 
            this.previousMrpTextBox.Location = new System.Drawing.Point(453, 126);
            this.previousMrpTextBox.Name = "previousMrpTextBox";
            this.previousMrpTextBox.ReadOnly = true;
            this.previousMrpTextBox.Size = new System.Drawing.Size(155, 20);
            this.previousMrpTextBox.TabIndex = 22;
            this.previousMrpTextBox.Text = "<View>";
            // 
            // previousUnitPriceTextBox
            // 
            this.previousUnitPriceTextBox.Location = new System.Drawing.Point(453, 100);
            this.previousUnitPriceTextBox.Name = "previousUnitPriceTextBox";
            this.previousUnitPriceTextBox.ReadOnly = true;
            this.previousUnitPriceTextBox.Size = new System.Drawing.Size(155, 20);
            this.previousUnitPriceTextBox.TabIndex = 21;
            this.previousUnitPriceTextBox.Text = "<View>";
            // 
            // totalPriceTextBox
            // 
            this.totalPriceTextBox.Location = new System.Drawing.Point(453, 74);
            this.totalPriceTextBox.Name = "totalPriceTextBox";
            this.totalPriceTextBox.ReadOnly = true;
            this.totalPriceTextBox.Size = new System.Drawing.Size(155, 20);
            this.totalPriceTextBox.TabIndex = 20;
            this.totalPriceTextBox.Text = "<View>";
            // 
            // unitPriceTextBox
            // 
            this.unitPriceTextBox.Location = new System.Drawing.Point(453, 48);
            this.unitPriceTextBox.Name = "unitPriceTextBox";
            this.unitPriceTextBox.Size = new System.Drawing.Size(155, 20);
            this.unitPriceTextBox.TabIndex = 19;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(453, 22);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(155, 20);
            this.quantityTextBox.TabIndex = 18;
            // 
            // availableQuantityTextBox
            // 
            this.availableQuantityTextBox.Location = new System.Drawing.Point(112, 100);
            this.availableQuantityTextBox.Name = "availableQuantityTextBox";
            this.availableQuantityTextBox.ReadOnly = true;
            this.availableQuantityTextBox.Size = new System.Drawing.Size(156, 20);
            this.availableQuantityTextBox.TabIndex = 15;
            this.availableQuantityTextBox.Text = "<View>";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(112, 74);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.ReadOnly = true;
            this.codeTextBox.Size = new System.Drawing.Size(156, 20);
            this.codeTextBox.TabIndex = 14;
            this.codeTextBox.Text = "<View>";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Remarks";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(327, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "MRP (Tk)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(327, 129);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Previous MRP (Tk)";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(327, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Previous Unit Price (Tk)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(327, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 13);
            this.label13.TabIndex = 8;
            this.label13.Text = "Total Price (Tk)";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(327, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Unit Price (Tk)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(327, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Quantity";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 155);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Expire Date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Manufactured Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Available Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Products";
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 477);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 141);
            this.dataGridView1.TabIndex = 2;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(554, 624);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 26;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 653);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dataGridView1);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.TextBox billTextBox;
        private System.Windows.Forms.TextBox mrpTextBox;
        private System.Windows.Forms.TextBox previousMrpTextBox;
        private System.Windows.Forms.TextBox previousUnitPriceTextBox;
        private System.Windows.Forms.TextBox totalPriceTextBox;
        private System.Windows.Forms.TextBox unitPriceTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.TextBox availableQuantityTextBox;
        private System.Windows.Forms.TextBox codeTextBox;
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
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker manufacturedDate;
        private System.Windows.Forms.DateTimePicker expireDate;
        private System.Windows.Forms.DateTimePicker supplierDate;
        private System.Windows.Forms.BindingSource supplierBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}