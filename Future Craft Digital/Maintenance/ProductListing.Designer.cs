
namespace Future_Craft_Digital.Maintenance
{
    partial class ProductListingForm
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
            prodListingLabel = new Label();
            prodListingDesc = new Label();
            productListView = new ListView();
            rbByBrand = new RadioButton();
            rbByCategory = new RadioButton();
            rbItemByCategory = new RadioButton();
            rbListItemFileProd = new RadioButton();
            prodListIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)prodListIcon).BeginInit();
            SuspendLayout();
            // 
            // prodListingLabel
            // 
            prodListingLabel.AutoSize = true;
            prodListingLabel.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            prodListingLabel.ForeColor = SystemColors.MenuHighlight;
            prodListingLabel.Location = new Point(92, 18);
            prodListingLabel.Name = "prodListingLabel";
            prodListingLabel.Size = new Size(227, 34);
            prodListingLabel.TabIndex = 2;
            prodListingLabel.Text = "Product Listing";
            // 
            // prodListingDesc
            // 
            prodListingDesc.AutoSize = true;
            prodListingDesc.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            prodListingDesc.Location = new Point(96, 58);
            prodListingDesc.Name = "prodListingDesc";
            prodListingDesc.Size = new Size(281, 18);
            prodListingDesc.TabIndex = 3;
            prodListingDesc.Text = "Allow to categorize each kind of properties";
            prodListingDesc.Click += prodListingDesc_Click;
            // 
            // productListView
            // 
            productListView.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            productListView.GridLines = true;
            productListView.Location = new Point(12, 102);
            productListView.Name = "productListView";
            productListView.Size = new Size(1106, 431);
            productListView.TabIndex = 4;
            productListView.UseCompatibleStateImageBehavior = false;
            productListView.View = View.Details;
            // 
            // rbByBrand
            // 
            rbByBrand.AutoSize = true;
            rbByBrand.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbByBrand.Location = new Point(532, 63);
            rbByBrand.Name = "rbByBrand";
            rbByBrand.RightToLeft = RightToLeft.No;
            rbByBrand.Size = new Size(89, 22);
            rbByBrand.TabIndex = 5;
            rbByBrand.TabStop = true;
            rbByBrand.Text = "By Brand";
            rbByBrand.UseVisualStyleBackColor = true;
            rbByBrand.CheckedChanged += brandBtn_CheckedChanged;
            // 
            // rbByCategory
            // 
            rbByCategory.AutoSize = true;
            rbByCategory.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbByCategory.Location = new Point(642, 62);
            rbByCategory.Name = "rbByCategory";
            rbByCategory.RightToLeft = RightToLeft.No;
            rbByCategory.Size = new Size(110, 22);
            rbByCategory.TabIndex = 6;
            rbByCategory.TabStop = true;
            rbByCategory.Text = "By Category";
            rbByCategory.UseVisualStyleBackColor = true;
            rbByCategory.CheckedChanged += categoryBtn_CheckedChanged;
            // 
            // rbItemByCategory
            // 
            rbItemByCategory.AutoSize = true;
            rbItemByCategory.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbItemByCategory.Location = new Point(772, 62);
            rbItemByCategory.Name = "rbItemByCategory";
            rbItemByCategory.RightToLeft = RightToLeft.No;
            rbItemByCategory.Size = new Size(147, 22);
            rbItemByCategory.TabIndex = 7;
            rbItemByCategory.TabStop = true;
            rbItemByCategory.Text = "Item By Category";
            rbItemByCategory.UseVisualStyleBackColor = true;
            rbItemByCategory.CheckedChanged += itemByCategoryBtn_CheckedChanged;
            // 
            // rbListItemFileProd
            // 
            rbListItemFileProd.AutoSize = true;
            rbListItemFileProd.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rbListItemFileProd.Location = new Point(932, 62);
            rbListItemFileProd.Name = "rbListItemFileProd";
            rbListItemFileProd.RightToLeft = RightToLeft.No;
            rbListItemFileProd.Size = new Size(183, 22);
            rbListItemFileProd.TabIndex = 8;
            rbListItemFileProd.TabStop = true;
            rbListItemFileProd.Text = "List all item file products";
            rbListItemFileProd.UseVisualStyleBackColor = true;
            rbListItemFileProd.CheckedChanged += listItemFileProdBtn_CheckedChanged;
            // 
            // prodListIcon
            // 
            prodListIcon.Location = new Point(12, 12);
            prodListIcon.Name = "prodListIcon";
            prodListIcon.Size = new Size(78, 72);
            prodListIcon.TabIndex = 9;
            prodListIcon.TabStop = false;
            // 
            // ProductListingForm
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            ClientSize = new Size(1130, 545);
            Controls.Add(prodListIcon);
            Controls.Add(rbListItemFileProd);
            Controls.Add(rbItemByCategory);
            Controls.Add(rbByCategory);
            Controls.Add(rbByBrand);
            Controls.Add(productListView);
            Controls.Add(prodListingDesc);
            Controls.Add(prodListingLabel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ProductListingForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Product Listing";
            ((System.ComponentModel.ISupportInitialize)prodListIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label prodListingLabel;
        private Label prodListingDesc;
        private ListView productListView;
        private RadioButton rbByBrand;
        private RadioButton rbByCategory;
        private RadioButton rbItemByCategory;
        private RadioButton rbListItemFileProd;
        private PictureBox prodListIcon;
    }
}