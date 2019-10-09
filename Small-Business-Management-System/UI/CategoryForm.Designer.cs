namespace Small_Business_Management_System
{
    partial class CategoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showCategoriesGridView = new System.Windows.Forms.DataGridView();
            this.snColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.codeErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.showCategoriesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(157, 88);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(165, 20);
            this.codeTextBox.TabIndex = 1;
            this.codeTextBox.TextChanged += new System.EventHandler(this.codeTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(203, 166);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(119, 23);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // showCategoriesGridView
            // 
            this.showCategoriesGridView.AutoGenerateColumns = false;
            this.showCategoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.showCategoriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.snColumn,
            this.idColumn,
            this.codeColumn,
            this.nameColumn,
            this.actionColumn});
            this.showCategoriesGridView.DataSource = this.categoryBindingSource;
            this.showCategoriesGridView.Location = new System.Drawing.Point(12, 233);
            this.showCategoriesGridView.Name = "showCategoriesGridView";
            this.showCategoriesGridView.Size = new System.Drawing.Size(444, 185);
            this.showCategoriesGridView.TabIndex = 3;
            this.showCategoriesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.showCategoriesGridView_CellContentClick);
            // 
            // snColumn
            // 
            this.snColumn.FillWeight = 20F;
            this.snColumn.HeaderText = "SI";
            this.snColumn.Name = "snColumn";
            this.snColumn.ReadOnly = true;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "Id";
            this.idColumn.Name = "idColumn";
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // actionColumn
            // 
            this.actionColumn.HeaderText = "Action";
            this.actionColumn.Name = "actionColumn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(157, 127);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(165, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(131, 28);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(142, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(279, 28);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(92, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchErrorLabel.Location = new System.Drawing.Point(136, 57);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.searchErrorLabel.TabIndex = 0;
            // 
            // codeErrorLabel
            // 
            this.codeErrorLabel.AutoSize = true;
            this.codeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.codeErrorLabel.Location = new System.Drawing.Point(154, 111);
            this.codeErrorLabel.Name = "codeErrorLabel";
            this.codeErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.codeErrorLabel.TabIndex = 0;
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(154, 150);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(0, 13);
            this.nameErrorLabel.TabIndex = 0;
            // 
            // confirmLabel
            // 
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.confirmLabel.Location = new System.Drawing.Point(197, 202);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(0, 13);
            this.confirmLabel.TabIndex = 0;
            this.confirmLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(78, 166);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(119, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(328, 166);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(119, 23);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // codeColumn
            // 
            this.codeColumn.DataPropertyName = "Code";
            this.codeColumn.HeaderText = "Code";
            this.codeColumn.Name = "codeColumn";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(Small_Business_Management_System.MODEL.Category);
            // 
            // CategoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 430);
            this.Controls.Add(this.showCategoriesGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.codeErrorLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.searchErrorLabel);
            this.Controls.Add(this.label1);
            this.Name = "CategoryForm";
            this.Text = "Category";
            this.Load += new System.EventHandler(this.CategoryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.showCategoriesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView showCategoriesGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchErrorLabel;
        private System.Windows.Forms.Label codeErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn snColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
    }
}

