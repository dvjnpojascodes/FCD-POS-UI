
namespace Future_Craft_Digital.FCDForms
{
    partial class ProductListing
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
            this.prodListingLabel = new System.Windows.Forms.Label();
            this.prodListingDesc = new System.Windows.Forms.Label();
            this.productListView = new System.Windows.Forms.ListView();
            this.brandBtn = new System.Windows.Forms.RadioButton();
            this.categoryBtn = new System.Windows.Forms.RadioButton();
            this.itemByCategoryBtn = new System.Windows.Forms.RadioButton();
            this.listItemFileProdBtn = new System.Windows.Forms.RadioButton();
            this.prodListIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.prodListIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // prodListingLabel
            // 
            this.prodListingLabel.AutoSize = true;
            this.prodListingLabel.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodListingLabel.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.prodListingLabel.Location = new System.Drawing.Point(92, 29);
            this.prodListingLabel.Name = "prodListingLabel";
            this.prodListingLabel.Size = new System.Drawing.Size(227, 34);
            this.prodListingLabel.TabIndex = 2;
            this.prodListingLabel.Text = "Product Listing";
            // 
            // prodListingDesc
            // 
            this.prodListingDesc.AutoSize = true;
            this.prodListingDesc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prodListingDesc.Location = new System.Drawing.Point(96, 62);
            this.prodListingDesc.Name = "prodListingDesc";
            this.prodListingDesc.Size = new System.Drawing.Size(281, 18);
            this.prodListingDesc.TabIndex = 3;
            this.prodListingDesc.Text = "Allow to categorize each kind of properties";
            this.prodListingDesc.Click += new System.EventHandler(this.prodListingDesc_Click);
            // 
            // productListView
            // 
            this.productListView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListView.GridLines = true;
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(12, 102);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(1106, 431);
            this.productListView.TabIndex = 4;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            // 
            // brandBtn
            // 
            this.brandBtn.AutoSize = true;
            this.brandBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brandBtn.Location = new System.Drawing.Point(532, 63);
            this.brandBtn.Name = "brandBtn";
            this.brandBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.brandBtn.Size = new System.Drawing.Size(89, 22);
            this.brandBtn.TabIndex = 5;
            this.brandBtn.TabStop = true;
            this.brandBtn.Text = "By Brand";
            this.brandBtn.UseVisualStyleBackColor = true;
            this.brandBtn.CheckedChanged += new System.EventHandler(this.brandBtn_CheckedChanged);
            // 
            // categoryBtn
            // 
            this.categoryBtn.AutoSize = true;
            this.categoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryBtn.Location = new System.Drawing.Point(642, 62);
            this.categoryBtn.Name = "categoryBtn";
            this.categoryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.categoryBtn.Size = new System.Drawing.Size(110, 22);
            this.categoryBtn.TabIndex = 6;
            this.categoryBtn.TabStop = true;
            this.categoryBtn.Text = "By Category";
            this.categoryBtn.UseVisualStyleBackColor = true;
            this.categoryBtn.CheckedChanged += new System.EventHandler(this.categoryBtn_CheckedChanged);
            // 
            // itemByCategoryBtn
            // 
            this.itemByCategoryBtn.AutoSize = true;
            this.itemByCategoryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemByCategoryBtn.Location = new System.Drawing.Point(772, 62);
            this.itemByCategoryBtn.Name = "itemByCategoryBtn";
            this.itemByCategoryBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.itemByCategoryBtn.Size = new System.Drawing.Size(142, 22);
            this.itemByCategoryBtn.TabIndex = 7;
            this.itemByCategoryBtn.TabStop = true;
            this.itemByCategoryBtn.Text = "Item By Category";
            this.itemByCategoryBtn.UseVisualStyleBackColor = true;
            this.itemByCategoryBtn.CheckedChanged += new System.EventHandler(this.itemByCategoryBtn_CheckedChanged);
            // 
            // listItemFileProdBtn
            // 
            this.listItemFileProdBtn.AutoSize = true;
            this.listItemFileProdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listItemFileProdBtn.Location = new System.Drawing.Point(932, 62);
            this.listItemFileProdBtn.Name = "listItemFileProdBtn";
            this.listItemFileProdBtn.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listItemFileProdBtn.Size = new System.Drawing.Size(186, 22);
            this.listItemFileProdBtn.TabIndex = 8;
            this.listItemFileProdBtn.TabStop = true;
            this.listItemFileProdBtn.Text = "List all item file products";
            this.listItemFileProdBtn.UseVisualStyleBackColor = true;
            this.listItemFileProdBtn.CheckedChanged += new System.EventHandler(this.listItemFileProdBtn_CheckedChanged);
            // 
            // prodListIcon
            // 
            this.prodListIcon.Location = new System.Drawing.Point(12, 12);
            this.prodListIcon.Name = "prodListIcon";
            this.prodListIcon.Size = new System.Drawing.Size(78, 72);
            this.prodListIcon.TabIndex = 9;
            this.prodListIcon.TabStop = false;
            // 
            // ProductListing
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(1130, 545);
            this.Controls.Add(this.prodListIcon);
            this.Controls.Add(this.listItemFileProdBtn);
            this.Controls.Add(this.itemByCategoryBtn);
            this.Controls.Add(this.categoryBtn);
            this.Controls.Add(this.brandBtn);
            this.Controls.Add(this.productListView);
            this.Controls.Add(this.prodListingDesc);
            this.Controls.Add(this.prodListingLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProductListing";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "ProductListing";
            ((System.ComponentModel.ISupportInitialize)(this.prodListIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label prodListingLabel;
        private System.Windows.Forms.Label prodListingDesc;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.RadioButton brandBtn;
        private System.Windows.Forms.RadioButton categoryBtn;
        private System.Windows.Forms.RadioButton itemByCategoryBtn;
        private System.Windows.Forms.RadioButton listItemFileProdBtn;
        private System.Windows.Forms.PictureBox prodListIcon;
    }
}