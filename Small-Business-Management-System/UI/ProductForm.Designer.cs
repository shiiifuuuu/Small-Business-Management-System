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
            this.categorycomboBox = new System.Windows.Forms.ComboBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.codetextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.reordertextBox = new System.Windows.Forms.TextBox();
            this.descriptiontextBox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reorderLevelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmationlabel = new System.Windows.Forms.Label();
            this.searchtextBox = new System.Windows.Forms.TextBox();
            this.searchbutton = new System.Windows.Forms.Button();
            this.searcherrorlabel = new System.Windows.Forms.Label();
            this.codeerrorlabel = new System.Windows.Forms.Label();
            this.nameerrorlabel = new System.Windows.Forms.Label();
            this.reordererrorlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // categorylabel
            // 
            this.categorylabel.AutoSize = true;
            this.categorylabel.Location = new System.Drawing.Point(216, 92);
            this.categorylabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.categorylabel.Name = "categorylabel";
            this.categorylabel.Size = new System.Drawing.Size(65, 17);
            this.categorylabel.TabIndex = 0;
            this.categorylabel.Text = "Category";
            // 
            // codelabel
            // 
            this.codelabel.AutoSize = true;
            this.codelabel.Location = new System.Drawing.Point(220, 146);
            this.codelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.codelabel.Name = "codelabel";
            this.codelabel.Size = new System.Drawing.Size(41, 17);
            this.codelabel.TabIndex = 1;
            this.codelabel.Text = "Code";
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.Location = new System.Drawing.Point(220, 197);
            this.namelabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(45, 17);
            this.namelabel.TabIndex = 2;
            this.namelabel.Text = "Name";
            // 
            // reorderlabel
            // 
            this.reorderlabel.AutoSize = true;
            this.reorderlabel.Location = new System.Drawing.Point(220, 245);
            this.reorderlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.reorderlabel.Name = "reorderlabel";
            this.reorderlabel.Size = new System.Drawing.Size(98, 17);
            this.reorderlabel.TabIndex = 3;
            this.reorderlabel.Text = "Reorder Level";
            // 
            // descriptionlabel
            // 
            this.descriptionlabel.AutoSize = true;
            this.descriptionlabel.Location = new System.Drawing.Point(220, 297);
            this.descriptionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionlabel.Name = "descriptionlabel";
            this.descriptionlabel.Size = new System.Drawing.Size(79, 17);
            this.descriptionlabel.TabIndex = 4;
            this.descriptionlabel.Text = "Description";
            // 
            // categorycomboBox
            // 
            this.categorycomboBox.DataSource = this.productBindingSource;
            this.categorycomboBox.DisplayMember = "Category";
            this.categorycomboBox.FormattingEnabled = true;
            this.categorycomboBox.Location = new System.Drawing.Point(398, 89);
            this.categorycomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.categorycomboBox.Name = "categorycomboBox";
            this.categorycomboBox.Size = new System.Drawing.Size(159, 24);
            this.categorycomboBox.TabIndex = 5;
            this.categorycomboBox.ValueMember = "Id";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(Small_Business_Management_System.MODEL.Product);
            // 
            // codetextBox
            // 
            this.codetextBox.Location = new System.Drawing.Point(398, 141);
            this.codetextBox.Margin = new System.Windows.Forms.Padding(4);
            this.codetextBox.Name = "codetextBox";
            this.codetextBox.Size = new System.Drawing.Size(159, 22);
            this.codetextBox.TabIndex = 6;
            this.codetextBox.TextChanged += new System.EventHandler(this.codetextBox_TextChanged_1);
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(398, 194);
            this.nametextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(159, 22);
            this.nametextBox.TabIndex = 7;
            // 
            // reordertextBox
            // 
            this.reordertextBox.Location = new System.Drawing.Point(398, 245);
            this.reordertextBox.Margin = new System.Windows.Forms.Padding(4);
            this.reordertextBox.Name = "reordertextBox";
            this.reordertextBox.Size = new System.Drawing.Size(159, 22);
            this.reordertextBox.TabIndex = 8;
            // 
            // descriptiontextBox
            // 
            this.descriptiontextBox.Location = new System.Drawing.Point(398, 297);
            this.descriptiontextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descriptiontextBox.Multiline = true;
            this.descriptiontextBox.Name = "descriptiontextBox";
            this.descriptiontextBox.Size = new System.Drawing.Size(159, 142);
            this.descriptiontextBox.TabIndex = 9;
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(477, 447);
            this.savebutton.Margin = new System.Windows.Forms.Padding(4);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(80, 28);
            this.savebutton.TabIndex = 10;
            this.savebutton.Text = "Save";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryDataGridViewTextBoxColumn,
            this.codeDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.reorderLevelDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.productBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(39, 541);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(796, 197);
            this.dataGridView.TabIndex = 11;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // codeDataGridViewTextBoxColumn
            // 
            this.codeDataGridViewTextBoxColumn.DataPropertyName = "Code";
            this.codeDataGridViewTextBoxColumn.HeaderText = "Code";
            this.codeDataGridViewTextBoxColumn.Name = "codeDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // reorderLevelDataGridViewTextBoxColumn
            // 
            this.reorderLevelDataGridViewTextBoxColumn.DataPropertyName = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.HeaderText = "ReorderLevel";
            this.reorderLevelDataGridViewTextBoxColumn.Name = "reorderLevelDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // confirmationlabel
            // 
            this.confirmationlabel.AutoSize = true;
            this.confirmationlabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.confirmationlabel.Location = new System.Drawing.Point(220, 447);
            this.confirmationlabel.Name = "confirmationlabel";
            this.confirmationlabel.Size = new System.Drawing.Size(87, 17);
            this.confirmationlabel.TabIndex = 12;
            this.confirmationlabel.Text = "Confirmation";
            // 
            // searchtextBox
            // 
            this.searchtextBox.Location = new System.Drawing.Point(219, 21);
            this.searchtextBox.Name = "searchtextBox";
            this.searchtextBox.Size = new System.Drawing.Size(262, 22);
            this.searchtextBox.TabIndex = 13;
            // 
            // searchbutton
            // 
            this.searchbutton.Location = new System.Drawing.Point(521, 21);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(75, 27);
            this.searchbutton.TabIndex = 14;
            this.searchbutton.Text = "Search";
            this.searchbutton.UseVisualStyleBackColor = true;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // searcherrorlabel
            // 
            this.searcherrorlabel.AutoSize = true;
            this.searcherrorlabel.ForeColor = System.Drawing.Color.Red;
            this.searcherrorlabel.Location = new System.Drawing.Point(220, 46);
            this.searcherrorlabel.Name = "searcherrorlabel";
            this.searcherrorlabel.Size = new System.Drawing.Size(39, 17);
            this.searcherrorlabel.TabIndex = 15;
            this.searcherrorlabel.Text = "error";
            // 
            // codeerrorlabel
            // 
            this.codeerrorlabel.AutoSize = true;
            this.codeerrorlabel.ForeColor = System.Drawing.Color.Red;
            this.codeerrorlabel.Location = new System.Drawing.Point(399, 167);
            this.codeerrorlabel.Name = "codeerrorlabel";
            this.codeerrorlabel.Size = new System.Drawing.Size(39, 17);
            this.codeerrorlabel.TabIndex = 17;
            this.codeerrorlabel.Text = "error";
            // 
            // nameerrorlabel
            // 
            this.nameerrorlabel.AutoSize = true;
            this.nameerrorlabel.ForeColor = System.Drawing.Color.Red;
            this.nameerrorlabel.Location = new System.Drawing.Point(399, 220);
            this.nameerrorlabel.Name = "nameerrorlabel";
            this.nameerrorlabel.Size = new System.Drawing.Size(39, 17);
            this.nameerrorlabel.TabIndex = 18;
            this.nameerrorlabel.Text = "error";
            // 
            // reordererrorlabel
            // 
            this.reordererrorlabel.AutoSize = true;
            this.reordererrorlabel.ForeColor = System.Drawing.Color.Red;
            this.reordererrorlabel.Location = new System.Drawing.Point(399, 271);
            this.reordererrorlabel.Name = "reordererrorlabel";
            this.reordererrorlabel.Size = new System.Drawing.Size(39, 17);
            this.reordererrorlabel.TabIndex = 19;
            this.reordererrorlabel.Text = "error";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 751);
            this.Controls.Add(this.reordererrorlabel);
            this.Controls.Add(this.nameerrorlabel);
            this.Controls.Add(this.codeerrorlabel);
            this.Controls.Add(this.searcherrorlabel);
            this.Controls.Add(this.searchbutton);
            this.Controls.Add(this.searchtextBox);
            this.Controls.Add(this.confirmationlabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.descriptiontextBox);
            this.Controls.Add(this.reordertextBox);
            this.Controls.Add(this.nametextBox);
            this.Controls.Add(this.codetextBox);
            this.Controls.Add(this.categorycomboBox);
            this.Controls.Add(this.descriptionlabel);
            this.Controls.Add(this.reorderlabel);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.codelabel);
            this.Controls.Add(this.categorylabel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductForm";
            this.Text = "Product";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label categorylabel;
        private System.Windows.Forms.Label codelabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label reorderlabel;
        private System.Windows.Forms.Label descriptionlabel;
        private System.Windows.Forms.ComboBox categorycomboBox;
        private System.Windows.Forms.TextBox codetextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.TextBox reordertextBox;
        private System.Windows.Forms.TextBox descriptiontextBox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label confirmationlabel;
        private System.Windows.Forms.TextBox searchtextBox;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Label searcherrorlabel;
        private System.Windows.Forms.Label codeerrorlabel;
        private System.Windows.Forms.Label nameerrorlabel;
        private System.Windows.Forms.Label reordererrorlabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reorderLevelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource productBindingSource;
    }
}