﻿namespace Small_Business_Management_System
{
    partial class IndexForm
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
            this.categoryFormLink = new System.Windows.Forms.LinkLabel();
            this.customerFormLink = new System.Windows.Forms.LinkLabel();
            this.supplierFormLink = new System.Windows.Forms.LinkLabel();
            this.productForm = new System.Windows.Forms.LinkLabel();
            this.purchaseFormLink = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // categoryFormLink
            // 
            this.categoryFormLink.AutoSize = true;
            this.categoryFormLink.Location = new System.Drawing.Point(203, 68);
            this.categoryFormLink.Name = "categoryFormLink";
            this.categoryFormLink.Size = new System.Drawing.Size(75, 13);
            this.categoryFormLink.TabIndex = 0;
            this.categoryFormLink.TabStop = true;
            this.categoryFormLink.Text = "Category Form";
            this.categoryFormLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.categoryFormLink_LinkClicked);
            // 
            // customerFormLink
            // 
            this.customerFormLink.AutoSize = true;
            this.customerFormLink.Location = new System.Drawing.Point(203, 119);
            this.customerFormLink.Name = "customerFormLink";
            this.customerFormLink.Size = new System.Drawing.Size(77, 13);
            this.customerFormLink.TabIndex = 1;
            this.customerFormLink.TabStop = true;
            this.customerFormLink.Text = "Customer Form";
            this.customerFormLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.customerFormLink_LinkClicked);
            // 
            // supplierFormLink
            // 
            this.supplierFormLink.AutoSize = true;
            this.supplierFormLink.Location = new System.Drawing.Point(203, 143);
            this.supplierFormLink.Name = "supplierFormLink";
            this.supplierFormLink.Size = new System.Drawing.Size(71, 13);
            this.supplierFormLink.TabIndex = 2;
            this.supplierFormLink.TabStop = true;
            this.supplierFormLink.Text = "Supplier Form";
            this.supplierFormLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.supplierFormLink_LinkClicked);
            // 
            // productForm
            // 
            this.productForm.AutoSize = true;
            this.productForm.Location = new System.Drawing.Point(203, 94);
            this.productForm.Name = "productForm";
            this.productForm.Size = new System.Drawing.Size(70, 13);
            this.productForm.TabIndex = 3;
            this.productForm.TabStop = true;
            this.productForm.Text = "Product Form";
            this.productForm.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.productForm_LinkClicked);
            // 
            // purchaseFormLink
            // 
            this.purchaseFormLink.AutoSize = true;
            this.purchaseFormLink.Location = new System.Drawing.Point(203, 181);
            this.purchaseFormLink.Name = "purchaseFormLink";
            this.purchaseFormLink.Size = new System.Drawing.Size(78, 13);
            this.purchaseFormLink.TabIndex = 4;
            this.purchaseFormLink.TabStop = true;
            this.purchaseFormLink.Text = "Purchase Form";
            this.purchaseFormLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.purchaseFormLink_LinkClicked);
            // 
            // IndexForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 386);
            this.Controls.Add(this.purchaseFormLink);
            this.Controls.Add(this.productForm);
            this.Controls.Add(this.supplierFormLink);
            this.Controls.Add(this.customerFormLink);
            this.Controls.Add(this.categoryFormLink);
            this.Name = "IndexForm";
            this.Text = "Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel categoryFormLink;
        private System.Windows.Forms.LinkLabel customerFormLink;
        private System.Windows.Forms.LinkLabel supplierFormLink;
        private System.Windows.Forms.LinkLabel productForm;
        private System.Windows.Forms.LinkLabel purchaseFormLink;
    }
}