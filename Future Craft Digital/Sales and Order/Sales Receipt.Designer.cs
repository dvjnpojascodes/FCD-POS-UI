namespace Future_Craft_Digital.Sales_and_Order
{
    partial class Sales_Receipt
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
            dateToSalesReceipt = new DateTimePicker();
            dateFromSalesReceipt = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            displayByComboBox = new ComboBox();
            displayByCheckBox = new CheckBox();
            groupBox2 = new GroupBox();
            listViewSalesReceipt = new ListView();
            orderNo = new ColumnHeader();
            receiptNo = new ColumnHeader();
            id = new ColumnHeader();
            vatabale = new ColumnHeader();
            totalSale = new ColumnHeader();
            amountDue = new ColumnHeader();
            _void = new ColumnHeader();
            dateSalesReceipt = new DateTimePicker();
            viewButton = new Button();
            voidButton = new Button();
            label5 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
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
            label2.Location = new Point(78, 44);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(148, 14);
            label2.TabIndex = 5;
            label2.Text = "All transation sales receipt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(78, 21);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(195, 25);
            label1.TabIndex = 6;
            label1.Text = "Sales Receipt List";
            // 
            // dateToSalesReceipt
            // 
            dateToSalesReceipt.Anchor = AnchorStyles.Right;
            dateToSalesReceipt.Location = new Point(78, 36);
            dateToSalesReceipt.Name = "dateToSalesReceipt";
            dateToSalesReceipt.Size = new Size(242, 23);
            dateToSalesReceipt.TabIndex = 4;
            // 
            // dateFromSalesReceipt
            // 
            dateFromSalesReceipt.Anchor = AnchorStyles.Right;
            dateFromSalesReceipt.Location = new Point(78, 11);
            dateFromSalesReceipt.Name = "dateFromSalesReceipt";
            dateFromSalesReceipt.Size = new Size(242, 23);
            dateFromSalesReceipt.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(15, 34);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 5, 0, 5);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(57, 24);
            label4.TabIndex = 10;
            label4.Text = "Date to :";
            label4.Click += label3_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(2, 10);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 5);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(70, 24);
            label3.TabIndex = 10;
            label3.Text = "Date from :";
            label3.Click += label3_Click;
            // 
            // displayByComboBox
            // 
            displayByComboBox.Anchor = AnchorStyles.Left;
            displayByComboBox.BackColor = Color.White;
            displayByComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            displayByComboBox.FormattingEnabled = true;
            displayByComboBox.Location = new Point(146, 6);
            displayByComboBox.Name = "displayByComboBox";
            displayByComboBox.Size = new Size(161, 23);
            displayByComboBox.TabIndex = 2;
            // 
            // displayByCheckBox
            // 
            displayByCheckBox.Anchor = AnchorStyles.Left;
            displayByCheckBox.AutoSize = true;
            displayByCheckBox.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            displayByCheckBox.Location = new Point(3, 10);
            displayByCheckBox.Name = "displayByCheckBox";
            displayByCheckBox.Size = new Size(138, 18);
            displayByCheckBox.TabIndex = 1;
            displayByCheckBox.Text = "Display by Collector :";
            displayByCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(listViewSalesReceipt);
            groupBox2.Location = new Point(12, 118);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1013, 522);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // listViewSalesReceipt
            // 
            listViewSalesReceipt.Columns.AddRange(new ColumnHeader[] { orderNo, receiptNo, id, vatabale, totalSale, amountDue, _void });
            listViewSalesReceipt.Dock = DockStyle.Fill;
            listViewSalesReceipt.FullRowSelect = true;
            listViewSalesReceipt.GridLines = true;
            listViewSalesReceipt.Location = new Point(3, 19);
            listViewSalesReceipt.Name = "listViewSalesReceipt";
            listViewSalesReceipt.Size = new Size(1007, 500);
            listViewSalesReceipt.TabIndex = 0;
            listViewSalesReceipt.UseCompatibleStateImageBehavior = false;
            listViewSalesReceipt.View = View.Details;
            // 
            // orderNo
            // 
            orderNo.Text = "Order no.";
            orderNo.Width = 100;
            // 
            // receiptNo
            // 
            receiptNo.Text = "Receipt no.";
            receiptNo.Width = 150;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 80;
            // 
            // vatabale
            // 
            vatabale.Text = "Vatable";
            vatabale.Width = 100;
            // 
            // totalSale
            // 
            totalSale.Text = "Total sale";
            totalSale.Width = 100;
            // 
            // amountDue
            // 
            amountDue.Text = "Amount Due";
            amountDue.Width = 150;
            // 
            // _void
            // 
            _void.Text = "Void";
            _void.Width = 100;
            // 
            // dateSalesReceipt
            // 
            dateSalesReceipt.Location = new Point(405, 6);
            dateSalesReceipt.Name = "dateSalesReceipt";
            dateSalesReceipt.Size = new Size(242, 23);
            dateSalesReceipt.TabIndex = 7;
            // 
            // viewButton
            // 
            viewButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            viewButton.Location = new Point(84, 3);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(111, 27);
            viewButton.TabIndex = 6;
            viewButton.Text = "View / Return";
            viewButton.UseVisualStyleBackColor = true;
            // 
            // voidButton
            // 
            voidButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            voidButton.Location = new Point(3, 3);
            voidButton.Name = "voidButton";
            voidButton.Size = new Size(75, 27);
            voidButton.TabIndex = 5;
            voidButton.Text = "Void";
            voidButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(358, 6);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 5, 0, 5);
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(46, 24);
            label5.TabIndex = 10;
            label5.Text = "DATE :";
            label5.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(displayByComboBox);
            panel1.Controls.Add(displayByCheckBox);
            panel1.Location = new Point(12, 77);
            panel1.Name = "panel1";
            panel1.Size = new Size(315, 35);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(dateFromSalesReceipt);
            panel2.Controls.Add(dateToSalesReceipt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(702, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 67);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.Controls.Add(dateSalesReceipt);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(viewButton);
            panel3.Controls.Add(voidButton);
            panel3.Location = new Point(20, 646);
            panel3.Name = "panel3";
            panel3.Size = new Size(655, 34);
            panel3.TabIndex = 14;
            // 
            // Sales_Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 692);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            MinimumSize = new Size(1037, 692);
            Name = "Sales_Receipt";
            Text = "Sales_Receipt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Label label3;
        private ComboBox displayByComboBox;
        private CheckBox displayByCheckBox;
        private DateTimePicker dateFromSalesReceipt;
        private DateTimePicker dateToSalesReceipt;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView listViewSalesReceipt;
        private ColumnHeader orderNo;
        private ColumnHeader receiptNo;
        private ColumnHeader id;
        private ColumnHeader vatabale;
        private ColumnHeader totalSale;
        private ColumnHeader amountDue;
        private ColumnHeader _void;
        private DateTimePicker dateSalesReceipt;
        private Button viewButton;
        private Button voidButton;
        private Label label5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}