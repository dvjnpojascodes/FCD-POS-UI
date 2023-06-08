
namespace Future_Craft_Digital.FCDForms
{
    partial class ManageSupplier
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
            this.supplierProdBtn = new System.Windows.Forms.RadioButton();
            this.supplierListBtn = new System.Windows.Forms.RadioButton();
            this.prodListingDesc = new System.Windows.Forms.Label();
            this.supplierListingLabel = new System.Windows.Forms.Label();
            this.supplierProfile = new System.Windows.Forms.ListView();
            this.supplierID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.supplierName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contact = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contactPerson = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prodListIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodListIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierProdBtn
            // 
            this.supplierProdBtn.AutoSize = true;
            this.supplierProdBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierProdBtn.Location = new System.Drawing.Point(811, 57);
            this.supplierProdBtn.Name = "supplierProdBtn";
            this.supplierProdBtn.Size = new System.Drawing.Size(184, 22);
            this.supplierProdBtn.TabIndex = 15;
            this.supplierProdBtn.TabStop = true;
            this.supplierProdBtn.Text = "Suppliers Product(s)";
            this.supplierProdBtn.UseVisualStyleBackColor = true;
            // 
            // supplierListBtn
            // 
            this.supplierListBtn.AutoSize = true;
            this.supplierListBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierListBtn.Location = new System.Drawing.Point(673, 57);
            this.supplierListBtn.Name = "supplierListBtn";
            this.supplierListBtn.Size = new System.Drawing.Size(132, 22);
            this.supplierListBtn.TabIndex = 14;
            this.supplierListBtn.TabStop = true;
            this.supplierListBtn.Text = "Suppliers List";
            this.supplierListBtn.UseVisualStyleBackColor = true;
            // 
            // prodListingDesc
            // 
            this.prodListingDesc.AutoSize = true;
            this.prodListingDesc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodListingDesc.Location = new System.Drawing.Point(84, 61);
            this.prodListingDesc.Name = "prodListingDesc";
            this.prodListingDesc.Size = new System.Drawing.Size(346, 18);
            this.prodListingDesc.TabIndex = 10;
            this.prodListingDesc.Text = "Add, Edit Account profile and listing of their products";
            // 
            // supplierListingLabel
            // 
            this.supplierListingLabel.AutoSize = true;
            this.supplierListingLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierListingLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.supplierListingLabel.Location = new System.Drawing.Point(83, 29);
            this.supplierListingLabel.Name = "supplierListingLabel";
            this.supplierListingLabel.Size = new System.Drawing.Size(245, 34);
            this.supplierListingLabel.TabIndex = 9;
            this.supplierListingLabel.Text = "Suppliers Profile";
            // 
            // supplierProfile
            // 
            this.supplierProfile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.supplierID,
            this.supplierName,
            this.address,
            this.contact,
            this.contactPerson});
            this.supplierProfile.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supplierProfile.GridLines = true;
            this.supplierProfile.HideSelection = false;
            this.supplierProfile.Location = new System.Drawing.Point(10, 102);
            this.supplierProfile.Name = "supplierProfile";
            this.supplierProfile.Size = new System.Drawing.Size(968, 435);
            this.supplierProfile.TabIndex = 16;
            this.supplierProfile.UseCompatibleStateImageBehavior = false;
            this.supplierProfile.View = System.Windows.Forms.View.Details;
            // 
            // supplierID
            // 
            this.supplierID.Text = "Supplier ID";
            this.supplierID.Width = 150;
            // 
            // supplierName
            // 
            this.supplierName.Text = "Supplier Name";
            this.supplierName.Width = 200;
            // 
            // address
            // 
            this.address.Text = "Address";
            this.address.Width = 250;
            // 
            // contact
            // 
            this.contact.Text = "Contact No.";
            this.contact.Width = 180;
            // 
            // contactPerson
            // 
            this.contactPerson.Text = "Contact Person";
            this.contactPerson.Width = 180;
            // 
            // prodListIcon
            // 
            this.prodListIcon.Location = new System.Drawing.Point(10, 12);
            this.prodListIcon.Name = "prodListIcon";
            this.prodListIcon.Size = new System.Drawing.Size(68, 72);
            this.prodListIcon.TabIndex = 17;
            this.prodListIcon.TabStop = false;
            // 
            // ManageSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 545);
            this.Controls.Add(this.prodListIcon);
            this.Controls.Add(this.supplierProfile);
            this.Controls.Add(this.supplierProdBtn);
            this.Controls.Add(this.supplierListBtn);
            this.Controls.Add(this.prodListingDesc);
            this.Controls.Add(this.supplierListingLabel);
            this.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManageSupplier";
            this.Text = "SuppliersProfile";
            ((System.ComponentModel.ISupportInitialize)(this.prodListIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton supplierProdBtn;
        private System.Windows.Forms.RadioButton supplierListBtn;
        private System.Windows.Forms.Label prodListingDesc;
        private System.Windows.Forms.Label supplierListingLabel;
        private System.Windows.Forms.ListView supplierProfile;
        private System.Windows.Forms.ColumnHeader supplierID;
        private System.Windows.Forms.ColumnHeader supplierName;
        private System.Windows.Forms.ColumnHeader address;
        private System.Windows.Forms.ColumnHeader contact;
        private System.Windows.Forms.ColumnHeader contactPerson;
        private System.Windows.Forms.PictureBox prodListIcon;
    }
}