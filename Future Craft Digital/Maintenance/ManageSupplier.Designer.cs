
namespace Future_Craft_Digital.Maintenance
{
    partial class ManageSupplierForm
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
            rbSupplierProd = new RadioButton();
            rbSupplierList = new RadioButton();
            prodListingDesc = new Label();
            supplierListingLabel = new Label();
            supplierProfileListView = new ListView();
            supplierID = new ColumnHeader();
            supplierName = new ColumnHeader();
            address = new ColumnHeader();
            contact = new ColumnHeader();
            contactPerson = new ColumnHeader();
            prodListIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)prodListIcon).BeginInit();
            SuspendLayout();
            // 
            // rbSupplierProd
            // 
            rbSupplierProd.AutoSize = true;
            rbSupplierProd.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbSupplierProd.Location = new Point(798, 57);
            rbSupplierProd.Name = "rbSupplierProd";
            rbSupplierProd.Size = new Size(184, 22);
            rbSupplierProd.TabIndex = 15;
            rbSupplierProd.TabStop = true;
            rbSupplierProd.Text = "Suppliers Product(s)";
            rbSupplierProd.UseVisualStyleBackColor = true;
            // 
            // rbSupplierList
            // 
            rbSupplierList.AutoSize = true;
            rbSupplierList.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbSupplierList.Location = new Point(642, 57);
            rbSupplierList.Name = "rbSupplierList";
            rbSupplierList.Size = new Size(132, 22);
            rbSupplierList.TabIndex = 14;
            rbSupplierList.TabStop = true;
            rbSupplierList.Text = "Suppliers List";
            rbSupplierList.UseVisualStyleBackColor = true;
            // 
            // prodListingDesc
            // 
            prodListingDesc.AutoSize = true;
            prodListingDesc.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            prodListingDesc.Location = new Point(84, 58);
            prodListingDesc.Name = "prodListingDesc";
            prodListingDesc.Size = new Size(346, 18);
            prodListingDesc.TabIndex = 10;
            prodListingDesc.Text = "Add, Edit Account profile and listing of their products";
            // 
            // supplierListingLabel
            // 
            supplierListingLabel.AutoSize = true;
            supplierListingLabel.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            supplierListingLabel.ForeColor = SystemColors.MenuHighlight;
            supplierListingLabel.Location = new Point(83, 19);
            supplierListingLabel.Name = "supplierListingLabel";
            supplierListingLabel.Size = new Size(245, 34);
            supplierListingLabel.TabIndex = 9;
            supplierListingLabel.Text = "Suppliers Profile";
            // 
            // supplierProfileListView
            // 
            supplierProfileListView.Columns.AddRange(new ColumnHeader[] { supplierID, supplierName, address, contact, contactPerson });
            supplierProfileListView.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            supplierProfileListView.GridLines = true;
            supplierProfileListView.Location = new Point(10, 102);
            supplierProfileListView.Name = "supplierProfileListView";
            supplierProfileListView.Size = new Size(968, 481);
            supplierProfileListView.TabIndex = 16;
            supplierProfileListView.UseCompatibleStateImageBehavior = false;
            supplierProfileListView.View = View.Details;
            // 
            // supplierID
            // 
            supplierID.Text = "Supplier ID";
            supplierID.Width = 150;
            // 
            // supplierName
            // 
            supplierName.Text = "Supplier Name";
            supplierName.Width = 200;
            // 
            // address
            // 
            address.Text = "Address";
            address.Width = 250;
            // 
            // contact
            // 
            contact.Text = "Contact No.";
            contact.Width = 180;
            // 
            // contactPerson
            // 
            contactPerson.Text = "Contact Person";
            contactPerson.Width = 180;
            // 
            // prodListIcon
            // 
            prodListIcon.Location = new Point(10, 12);
            prodListIcon.Name = "prodListIcon";
            prodListIcon.Size = new Size(68, 67);
            prodListIcon.TabIndex = 17;
            prodListIcon.TabStop = false;
            // 
            // ManageSupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 595);
            Controls.Add(prodListIcon);
            Controls.Add(supplierProfileListView);
            Controls.Add(rbSupplierProd);
            Controls.Add(rbSupplierList);
            Controls.Add(prodListingDesc);
            Controls.Add(supplierListingLabel);
            Font = new Font("Tahoma", 7.8F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ManageSupplierForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Suppliers Profile";
            ((System.ComponentModel.ISupportInitialize)prodListIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbSupplierProd;
        private RadioButton rbSupplierList;
        private Label prodListingDesc;
        private Label supplierListingLabel;
        private ListView supplierProfileListView;
        private ColumnHeader supplierID;
        private ColumnHeader supplierName;
        private ColumnHeader address;
        private ColumnHeader contact;
        private ColumnHeader contactPerson;
        private PictureBox prodListIcon;
    }
}