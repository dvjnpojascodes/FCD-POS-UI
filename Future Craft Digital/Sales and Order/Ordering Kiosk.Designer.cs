namespace Future_Craft_Digital.Sales_and_Order
{
    partial class Ordering_Kiosk
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordering_Kiosk));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            groupBox1 = new GroupBox();
            listViewOrderingKiosk = new ListView();
            orderNo = new ColumnHeader();
            orderDate = new ColumnHeader();
            totalCost = new ColumnHeader();
            label3 = new Label();
            dateOrderingKiosk = new DateTimePicker();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(78, 11);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(279, 33);
            label1.TabIndex = 0;
            label1.Text = "Order Module Form";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 45);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(81, 43);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(220, 18);
            label2.TabIndex = 0;
            label2.Text = "State current and previous order";
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(listViewOrderingKiosk);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1019, 616);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // listViewOrderingKiosk
            // 
            listViewOrderingKiosk.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            listViewOrderingKiosk.Columns.AddRange(new ColumnHeader[] { orderNo, orderDate, totalCost });
            listViewOrderingKiosk.FullRowSelect = true;
            listViewOrderingKiosk.GridLines = true;
            listViewOrderingKiosk.Location = new Point(3, 22);
            listViewOrderingKiosk.Name = "listViewOrderingKiosk";
            listViewOrderingKiosk.Size = new Size(1010, 588);
            listViewOrderingKiosk.TabIndex = 0;
            listViewOrderingKiosk.UseCompatibleStateImageBehavior = false;
            listViewOrderingKiosk.View = View.Details;
            // 
            // orderNo
            // 
            orderNo.Text = "Order No.";
            orderNo.Width = 100;
            // 
            // orderDate
            // 
            orderDate.Text = "Order Date";
            orderDate.Width = 250;
            // 
            // totalCost
            // 
            totalCost.Text = "Total Cost";
            totalCost.Width = 100;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(8, 18);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(52, 18);
            label3.TabIndex = 0;
            label3.Text = "Date :";
            // 
            // dateOrderingKiosk
            // 
            dateOrderingKiosk.Anchor = AnchorStyles.Right;
            dateOrderingKiosk.Location = new Point(58, 13);
            dateOrderingKiosk.Name = "dateOrderingKiosk";
            dateOrderingKiosk.Size = new Size(245, 26);
            dateOrderingKiosk.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(dateOrderingKiosk);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(709, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 47);
            panel1.TabIndex = 4;
            // 
            // Ordering_Kiosk
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 692);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1037, 692);
            Name = "Ordering_Kiosk";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ordering_Kiosk";
            WindowState = FormWindowState.Maximized;
            Load += Ordering_Kiosk_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private GroupBox groupBox1;
        private ListView listViewOrderingKiosk;
        private ColumnHeader orderNo;
        private ColumnHeader orderDate;
        private ColumnHeader totalCost;
        private Label label3;
        private DateTimePicker dateOrderingKiosk;
        private Panel panel1;
    }
}