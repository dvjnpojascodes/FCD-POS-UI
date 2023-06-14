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
            rbOrderReceived = new RadioButton();
            rbOrderPurchased = new RadioButton();
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
            pictureBox1.Location = new Point(22, 23);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 60);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(101, 65);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(307, 18);
            label2.TabIndex = 5;
            label2.Text = "List of order purchased and products received";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(97, 32);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(502, 33);
            label1.TabIndex = 6;
            label1.Text = "Purchasing Order and Receive Form";
            // 
            // dateOrderAndReceive
            // 
            dateOrderAndReceive.Anchor = AnchorStyles.Right;
            dateOrderAndReceive.Location = new Point(82, 9);
            dateOrderAndReceive.Margin = new Padding(3, 4, 3, 4);
            dateOrderAndReceive.MaximumSize = new Size(278, 23);
            dateOrderAndReceive.Name = "dateOrderAndReceive";
            dateOrderAndReceive.Size = new Size(278, 23);
            dateOrderAndReceive.TabIndex = 1;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(25, 11);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(52, 18);
            label3.TabIndex = 8;
            label3.Text = "Date :";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(listViewOrderAndReceive);
            groupBox1.Location = new Point(16, 137);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1130, 711);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            // 
            // listViewOrderAndReceive
            // 
            listViewOrderAndReceive.Columns.AddRange(new ColumnHeader[] { idPurchase, supplierName, deliveryItem, purchaseDate, approved });
            listViewOrderAndReceive.Dock = DockStyle.Fill;
            listViewOrderAndReceive.FullRowSelect = true;
            listViewOrderAndReceive.GridLines = true;
            listViewOrderAndReceive.Location = new Point(3, 24);
            listViewOrderAndReceive.Margin = new Padding(3, 4, 3, 4);
            listViewOrderAndReceive.Name = "listViewOrderAndReceive";
            listViewOrderAndReceive.Size = new Size(1124, 683);
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
            // rbOrderReceived
            // 
            rbOrderReceived.Anchor = AnchorStyles.Right;
            rbOrderReceived.AutoSize = true;
            rbOrderReceived.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbOrderReceived.Location = new Point(213, 59);
            rbOrderReceived.Margin = new Padding(3, 4, 3, 4);
            rbOrderReceived.Name = "rbOrderReceived";
            rbOrderReceived.Size = new Size(146, 22);
            rbOrderReceived.TabIndex = 3;
            rbOrderReceived.TabStop = true;
            rbOrderReceived.Text = "Order Received";
            rbOrderReceived.UseVisualStyleBackColor = true;
            // 
            // rbOrderPurchased
            // 
            rbOrderPurchased.Anchor = AnchorStyles.Right;
            rbOrderPurchased.AutoSize = true;
            rbOrderPurchased.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rbOrderPurchased.Location = new Point(26, 59);
            rbOrderPurchased.Margin = new Padding(3, 4, 3, 4);
            rbOrderPurchased.Name = "rbOrderPurchased";
            rbOrderPurchased.Size = new Size(154, 22);
            rbOrderPurchased.TabIndex = 2;
            rbOrderPurchased.TabStop = true;
            rbOrderPurchased.Text = "Order purchased";
            rbOrderPurchased.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(253, 115);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(195, 18);
            label6.TabIndex = 12;
            label6.Text = "Black for not approved order";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(91, 115);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(161, 18);
            label5.TabIndex = 11;
            label5.Text = "Red for approved order";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 115);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(71, 18);
            label4.TabIndex = 11;
            label4.Text = "Legend :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Right;
            panel1.Controls.Add(dateOrderAndReceive);
            panel1.Controls.Add(rbOrderPurchased);
            panel1.Controls.Add(rbOrderReceived);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(784, 47);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(362, 87);
            panel1.TabIndex = 13;
            // 
            // Order_and_Receive
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 871);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1183, 907);
            Name = "Order_and_Receive";
            StartPosition = FormStartPosition.CenterScreen;
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
        private RadioButton rbOrderPurchased;
        private Label label6;
        private RadioButton rbOrderReceived;
        private ListView listViewOrderAndReceive;
        private ColumnHeader idPurchase;
        private ColumnHeader supplierName;
        private ColumnHeader deliveryItem;
        private ColumnHeader purchaseDate;
        private ColumnHeader approved;
        private Panel panel1;
    }
}