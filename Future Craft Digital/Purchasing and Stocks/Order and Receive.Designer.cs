namespace Future_Craft_Digital.Purchasing_and_Stocks
{
    partial class Order_and_Receive
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
            dateOrderAndReceive = new DateTimePicker();
            label3 = new Label();
            groupBox1 = new GroupBox();
            listViewOrderAndReceive = new ListView();
            idPurchase = new ColumnHeader();
            supplierName = new ColumnHeader();
            deliveryItem = new ColumnHeader();
            purchaseDate = new ColumnHeader();
            approved = new ColumnHeader();
            receivedRadioButton = new RadioButton();
            purchasedRadioButton = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(19, 17);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 45);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(88, 49);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(259, 14);
            label2.TabIndex = 5;
            label2.Text = "List of order purchased and products received";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(85, 24);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(384, 25);
            label1.TabIndex = 6;
            label1.Text = "Purchasing Order and Receive Form";
            // 
            // dateOrderAndReceive
            // 
            dateOrderAndReceive.Anchor = AnchorStyles.Right;
            dateOrderAndReceive.Location = new Point(72, 3);
            dateOrderAndReceive.MaximumSize = new Size(244, 23);
            dateOrderAndReceive.Name = "dateOrderAndReceive";
            dateOrderAndReceive.Size = new Size(244, 23);
            dateOrderAndReceive.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(22, 8);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(44, 14);
            label3.TabIndex = 8;
            label3.Text = "Date :";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(listViewOrderAndReceive);
            groupBox1.Location = new Point(14, 103);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(989, 533);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // listViewOrderAndReceive
            // 
            listViewOrderAndReceive.Columns.AddRange(new ColumnHeader[] { idPurchase, supplierName, deliveryItem, purchaseDate, approved });
            listViewOrderAndReceive.Dock = DockStyle.Fill;
            listViewOrderAndReceive.FullRowSelect = true;
            listViewOrderAndReceive.GridLines = true;
            listViewOrderAndReceive.Location = new Point(3, 19);
            listViewOrderAndReceive.Name = "listViewOrderAndReceive";
            listViewOrderAndReceive.Size = new Size(983, 511);
            listViewOrderAndReceive.TabIndex = 13;
            listViewOrderAndReceive.UseCompatibleStateImageBehavior = false;
            listViewOrderAndReceive.View = View.Details;
            // 
            // idPurchase
            // 
            idPurchase.Text = "Purchase ID";
            idPurchase.Width = 150;
            // 
            // supplierName
            // 
            supplierName.Text = "Supplier Name";
            supplierName.Width = 200;
            // 
            // deliveryItem
            // 
            deliveryItem.Text = "DeliveryItem";
            deliveryItem.Width = 200;
            // 
            // purchaseDate
            // 
            purchaseDate.Text = "Purchase Date";
            purchaseDate.Width = 200;
            // 
            // approved
            // 
            approved.Text = "Approved";
            approved.Width = 150;
            // 
            // receivedRadioButton
            // 
            receivedRadioButton.Anchor = AnchorStyles.Right;
            receivedRadioButton.AutoSize = true;
            receivedRadioButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            receivedRadioButton.Location = new Point(197, 44);
            receivedRadioButton.Name = "receivedRadioButton";
            receivedRadioButton.Size = new Size(117, 18);
            receivedRadioButton.TabIndex = 3;
            receivedRadioButton.TabStop = true;
            receivedRadioButton.Text = "Order Received";
            receivedRadioButton.UseVisualStyleBackColor = true;
            // 
            // purchasedRadioButton
            // 
            purchasedRadioButton.Anchor = AnchorStyles.Right;
            purchasedRadioButton.AutoSize = true;
            purchasedRadioButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            purchasedRadioButton.Location = new Point(65, 44);
            purchasedRadioButton.Name = "purchasedRadioButton";
            purchasedRadioButton.Size = new Size(126, 18);
            purchasedRadioButton.TabIndex = 2;
            purchasedRadioButton.TabStop = true;
            purchasedRadioButton.Text = "Order purchased";
            purchasedRadioButton.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(221, 86);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(164, 14);
            label6.TabIndex = 12;
            label6.Text = "Black for not approved order";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(80, 86);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(135, 14);
            label5.TabIndex = 11;
            label5.Text = "Red for approved order";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(14, 86);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(60, 14);
            label4.TabIndex = 11;
            label4.Text = "Legend :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(dateOrderAndReceive);
            panel1.Controls.Add(purchasedRadioButton);
            panel1.Controls.Add(receivedRadioButton);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(686, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 65);
            panel1.TabIndex = 13;
            // 
            // Order_and_Receive
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1021, 653);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            MinimumSize = new Size(1037, 692);
            Name = "Order_and_Receive";
            Text = "Order_and_Receive";
            Load += Order_and_Receive_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateOrderAndReceive;
        private Label label3;
        private GroupBox groupBox1;
        private Label label5;
        private Label label4;
        private RadioButton purchasedRadioButton;
        private Label label6;
        private RadioButton receivedRadioButton;
        private ListView listViewOrderAndReceive;
        private ColumnHeader idPurchase;
        private ColumnHeader supplierName;
        private ColumnHeader deliveryItem;
        private ColumnHeader purchaseDate;
        private ColumnHeader approved;
        private Panel panel1;
    }
}