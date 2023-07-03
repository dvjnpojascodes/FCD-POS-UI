namespace Future_Craft_Digital.Purchasing_and_Stocks
{
    partial class Stock_Monitoring
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stock_Monitoring));
            groupBox1 = new GroupBox();
            listViewStockMonitoring = new ListView();
            id = new ColumnHeader();
            name = new ColumnHeader();
            decription = new ColumnHeader();
            barcode = new ColumnHeader();
            reorderPoint = new ColumnHeader();
            priceNoVat = new ColumnHeader();
            priceVat = new ColumnHeader();
            quantity = new ColumnHeader();
            total = new ColumnHeader();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(listViewStockMonitoring);
            groupBox1.Location = new Point(9, 133);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1139, 444);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // listViewStockMonitoring
            // 
            listViewStockMonitoring.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewStockMonitoring.Columns.AddRange(new ColumnHeader[] { id, name, decription, barcode, reorderPoint, priceNoVat, priceVat, quantity, total });
            listViewStockMonitoring.FullRowSelect = true;
            listViewStockMonitoring.GridLines = true;
            listViewStockMonitoring.Location = new Point(3, 24);
            listViewStockMonitoring.Margin = new Padding(3, 4, 3, 4);
            listViewStockMonitoring.Name = "listViewStockMonitoring";
            listViewStockMonitoring.Size = new Size(1133, 412);
            listViewStockMonitoring.TabIndex = 13;
            listViewStockMonitoring.UseCompatibleStateImageBehavior = false;
            listViewStockMonitoring.View = View.Details;
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
            // barcode
            // 
            barcode.Text = "Barcode";
            barcode.Width = 100;
            // 
            // reorderPoint
            // 
            reorderPoint.Text = "Reorder Point";
            reorderPoint.Width = 100;
            // 
            // priceNoVat
            // 
            priceNoVat.Text = "Price w/o VAT";
            priceNoVat.Width = 100;
            // 
            // priceVat
            // 
            priceVat.Text = "Price w/ VAT";
            priceVat.Width = 100;
            // 
            // quantity
            // 
            quantity.Text = "Quantity";
            // 
            // total
            // 
            total.Text = "Total";
            total.Width = 100;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(246, 111);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(150, 18);
            label6.TabIndex = 12;
            label6.Text = "Black for > 0 quantity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(85, 111);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(126, 18);
            label5.TabIndex = 11;
            label5.Text = "Red for 0 quantity";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(9, 111);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(71, 18);
            label4.TabIndex = 11;
            label4.Text = "Legend :";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(15, 13);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(93, 56);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(393, 18);
            label2.TabIndex = 11;
            label2.Text = "Monitor current supplies, can also add, edit and delete item";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(90, 25);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(246, 33);
            label1.TabIndex = 12;
            label1.Text = "Stock Monitoring";
            // 
            // Stock_Monitoring
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1157, 593);
            ControlBox = false;
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Stock_Monitoring";
            Text = "Stock_Monitoring";
            WindowState = FormWindowState.Maximized;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listViewStockMonitoring;
        private ColumnHeader id;
        private ColumnHeader name;
        private ColumnHeader decription;
        private ColumnHeader barcode;
        private ColumnHeader reorderPoint;
        private ColumnHeader priceNoVat;
        private ColumnHeader priceVat;
        private ColumnHeader quantity;
        private ColumnHeader total;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
    }
}