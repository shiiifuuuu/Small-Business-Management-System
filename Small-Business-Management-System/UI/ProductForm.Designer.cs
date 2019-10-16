namespace Small_Business_Management_System.UI
{
    partial class ProductForm
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
            this.categorylabel = new System.Windows.Forms.Label();
            this.codelabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.reorderlabel = new System.Windows.Forms.Label();
            this.descriptionlabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.reorderTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.showDataGridView = new System.Windows.Forms.DataGridView();
            this.siColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.confirmationLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchErrorLabel = new System.Windows.Forms.Label();
            this.codeErrorLabel = new System.Windows.Forms.Label();
            this.nameErrorLabel = new System.Windows.Forms.Label();
            this.reorderErrorLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.categoryErrorLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Location = new System.Drawing.Point(159, 75);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(49, 13);
            this.categorylabel.TabIndex = 0;
            this.categorylabel.Text = "Category";
            // 
            // codelabel
            // 
            this.codelabel.AutoSize = true;
            this.codelabel.Location = new System.Drawing.Point(162, 119);
            this.codelabel.Name = "codelabel";
            this.codelabel.Size = new System.Drawing.Size(32, 13);
            this.codelabel.TabIndex = 1;
            this.codelabel.Text = "Code";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(162, 160);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(35, 13);
            this.namelabel.TabIndex = 2;
            this.namelabel.Text = "Name";
            // 
            // reorderlabel
            // 
            this.reorderlabel.AutoSize = true;
            this.reorderlabel.Location = new System.Drawing.Point(162, 199);
            this.reorderlabel.Name = "reorderlabel";
            this.reorderlabel.Size = new System.Drawing.Size(74, 13);
            this.reorderlabel.TabIndex = 3;
            this.reorderlabel.Text = "Reorder Level";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.Location = new System.Drawing.Point(162, 241);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionlabel.TabIndex = 4;
            this.descriptionlabel.Text = "Description";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DataSource = this.productBindingSource;
            this.categoryComboBox.DisplayMember = "Name";
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(295, 72);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(182, 21);
            this.categoryComboBox.TabIndex = 4;
            this.categoryComboBox.ValueMember = "Id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Small_Business_Management_System.MODEL.Product);
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(295, 115);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(182, 20);
            this.codeTextBox.TabIndex = 0;
            this.codeTextBox.TextChanged += new System.EventHandler(this.codetextBox_TextChanged);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(295, 158);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(182, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // reorderTextBox
            // 
            this.reorderTextBox.Location = new System.Drawing.Point(295, 199);
            this.reorderTextBox.Name = "reorderTextBox";
            this.reorderTextBox.Size = new System.Drawing.Size(182, 20);
            this.reorderTextBox.TabIndex = 2;
            this.reorderTextBox.Text = "10";
            this.reorderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.reorderTextBox_KeyPress);
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(295, 241);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(182, 116);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(330, 363);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(122, 23);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.savebutton_Click);
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
            this.nameColumn,
            this.categoryColumn,
            this.reorderColumn,
            this.descriptionColumn,
            this.actionColumn});
            this.showDataGridView.DataSource = this.productBindingSource1;
            this.showDataGridView.Location = new System.Drawing.Point(12, 438);
            this.showDataGridView.Name = "showDataGridView";
            this.showDataGridView.Size = new System.Drawing.Size(622, 203);
            this.showDataGridView.TabIndex = 10;
            this.showDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // siColumn
            // 
            this.siColumn.HeaderText = "SI";
            this.siColumn.Name = "siColumn";
            this.siColumn.ReadOnly = true;
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
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "Name";
            this.nameColumn.HeaderText = "Name";
            this.nameColumn.Name = "nameColumn";
            // 
            // categoryColumn
            // 
            this.categoryColumn.DataPropertyName = "Category";
            this.categoryColumn.HeaderText = "Category";
            this.categoryColumn.Name = "categoryColumn";
            // 
            // reorderColumn
            // 
            this.reorderColumn.DataPropertyName = "ReorderLevel";
            this.reorderColumn.HeaderText = "ReorderLevel";
            this.reorderColumn.Name = "reorderColumn";
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.DataPropertyName = "Description";
            this.descriptionColumn.HeaderText = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            // 
            // actionColumn
            // 
            this.actionColumn.HeaderText = "Action";
            this.actionColumn.Name = "actionColumn";
            this.actionColumn.ReadOnly = true;
            // 
            // productBindingSource1
            // 
            this.productBindingSource1.DataSource = typeof(Small_Business_Management_System.MODEL.Product);
            // 
            // confirmationLabel
            // 
            this.confirmationLabel.AutoSize = true;
            this.confirmationLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.confirmationLabel.Location = new System.Drawing.Point(215, 393);
            this.confirmationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.confirmationLabel.Name = "confirmationLabel";
            this.confirmationLabel.Size = new System.Drawing.Size(65, 13);
            this.confirmationLabel.TabIndex = 12;
            this.confirmationLabel.Text = "Confirmation";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(161, 17);
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(198, 20);
            this.searchTextBox.TabIndex = 8;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(363, 15);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(114, 22);
            this.searchButton.TabIndex = 9;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searchErrorLabel
            // 
            this.searchErrorLabel.AutoSize = true;
            this.searchErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.searchErrorLabel.Location = new System.Drawing.Point(162, 37);
            this.searchErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.searchErrorLabel.Name = "searchErrorLabel";
            this.searchErrorLabel.Size = new System.Drawing.Size(28, 13);
            this.searchErrorLabel.TabIndex = 15;
            this.searchErrorLabel.Text = "error";
            // 
            // codeErrorLabel
            // 
            this.codeErrorLabel.AutoSize = true;
            this.codeErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.codeErrorLabel.Location = new System.Drawing.Point(296, 136);
            this.codeErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.codeErrorLabel.Name = "codeErrorLabel";
            this.codeErrorLabel.Size = new System.Drawing.Size(28, 13);
            this.codeErrorLabel.TabIndex = 17;
            this.codeErrorLabel.Text = "error";
            // 
            // nameErrorLabel
            // 
            this.nameErrorLabel.AutoSize = true;
            this.nameErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.nameErrorLabel.Location = new System.Drawing.Point(296, 179);
            this.nameErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameErrorLabel.Name = "nameErrorLabel";
            this.nameErrorLabel.Size = new System.Drawing.Size(28, 13);
            this.nameErrorLabel.TabIndex = 18;
            this.nameErrorLabel.Text = "error";
            // 
            // reorderErrorLabel
            // 
            this.reorderErrorLabel.AutoSize = true;
            this.reorderErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.reorderErrorLabel.Location = new System.Drawing.Point(296, 220);
            this.reorderErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.reorderErrorLabel.Name = "reorderErrorLabel";
            this.reorderErrorLabel.Size = new System.Drawing.Size(28, 13);
            this.reorderErrorLabel.TabIndex = 19;
            this.reorderErrorLabel.Text = "error";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(202, 363);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(458, 363);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(122, 23);
            this.cancelButton.TabIndex = 7;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // categoryErrorLabel
            // 
            this.categoryErrorLabel.AutoSize = true;
            this.categoryErrorLabel.ForeColor = System.Drawing.Color.Red;
            this.categoryErrorLabel.Location = new System.Drawing.Point(292, 96);
            this.categoryErrorLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.categoryErrorLabel.Name = "categoryErrorLabel";
            this.categoryErrorLabel.Size = new System.Drawing.Size(28, 13);
            this.categoryErrorLabel.TabIndex = 17;
            this.categoryErrorLabel.Text = "error";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 653);
            this.Controls.Add(this.reorderErrorLabel);
            this.Controls.Add(this.nameErrorLabel);
            this.Controls.Add(this.categoryErrorLabel);
            this.Controls.Add(this.codeErrorLabel);
            this.Controls.Add(this.searchErrorLabel);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.confirmationLabel);
            this.Controls.Add(this.showDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.reorderTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.descriptionlabel);
            this.Controls.Add(this.reorderlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.codelabel);
            this.Controls.Add(this.categorylabel);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.showDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Label codelabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label reorderlabel;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox reorderTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView showDataGridView;
        private System.Windows.Forms.Label confirmationLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label searchErrorLabel;
        private System.Windows.Forms.Label codeErrorLabel;
        private System.Windows.Forms.Label nameErrorLabel;
        private System.Windows.Forms.Label reorderErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.BindingSource productBindingSource1;
        private System.Windows.Forms.Label categoryErrorLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn siColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn actionColumn;
    }
}