namespace Future_Craft_Digital
{
    partial class Critical_products
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
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            listViewCriticalProducts = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            decription = new ColumnHeader();
            price = new ColumnHeader();
            reorderPoint = new ColumnHeader();
            currentStocks = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 45);
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(80, 44);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(175, 14);
            label2.TabIndex = 15;
            label2.Text = "List of products on critical level";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(78, 21);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(174, 25);
            label1.TabIndex = 16;
            label1.Text = "Critical Product";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(219, 83);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(161, 14);
            label6.TabIndex = 12;
            label6.Text = "Black for more than 0 count";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(78, 83);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(127, 14);
            label5.TabIndex = 11;
            label5.Text = "Red for 0 stock count";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 83);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(60, 14);
            label4.TabIndex = 11;
            label4.Text = "Legend :";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(listViewCriticalProducts);
            groupBox1.Location = new Point(7, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1002, 539);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // listViewCriticalProducts
            // 
            listViewCriticalProducts.Columns.AddRange(new ColumnHeader[] { id, name, decription, price, reorderPoint, currentStocks });
            listViewCriticalProducts.Dock = DockStyle.Fill;
            listViewCriticalProducts.FullRowSelect = true;
            listViewCriticalProducts.GridLines = true;
            listViewCriticalProducts.Location = new Point(3, 19);
            listViewCriticalProducts.Name = "listViewCriticalProducts";
            listViewCriticalProducts.Size = new Size(996, 517);
            listViewCriticalProducts.TabIndex = 13;
            listViewCriticalProducts.UseCompatibleStateImageBehavior = false;
            listViewCriticalProducts.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 50;
            // 
            // name
            // 
            name.Text = "Name";
            name.Width = 200;
            // 
            // decription
            // 
            decription.Text = "Description/ Item number";
            decription.Width = 200;
            // 
            // price
            // 
            price.Text = "Price";
            price.Width = 100;
            // 
            // reorderPoint
            // 
            reorderPoint.Text = "Reorder Point";
            reorderPoint.Width = 100;
            // 
            // currentStocks
            // 
            currentStocks.Text = "Current Stocks";
            currentStocks.Width = 100;
            // 
            // Critical_products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 653);
            Controls.Add(pictureBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            MinimumSize = new Size(1037, 692);
            Name = "Critical_products";
            Text = "Critical_products";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private GroupBox groupBox1;
        private ListView listViewCriticalProducts;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader decription;
        private ColumnHeader price;
        private ColumnHeader reorderPoint;
        private ColumnHeader currentStocks;
    }
}