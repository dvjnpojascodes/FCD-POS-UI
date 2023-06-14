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
            pictureBox1.Location = new Point(14, 16);
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
            label2.Location = new Point(89, 59);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(175, 18);
            label2.TabIndex = 5;
            label2.Text = "All transation sales receipt";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(89, 28);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(252, 33);
            label1.TabIndex = 6;
            label1.Text = "Sales Receipt List";
            // 
            // dateToSalesReceipt
            // 
            dateToSalesReceipt.Anchor = AnchorStyles.Right;
            dateToSalesReceipt.Location = new Point(89, 48);
            dateToSalesReceipt.Margin = new Padding(3, 4, 3, 4);
            dateToSalesReceipt.Name = "dateToSalesReceipt";
            dateToSalesReceipt.Size = new Size(276, 27);
            dateToSalesReceipt.TabIndex = 4;
            // 
            // dateFromSalesReceipt
            // 
            dateFromSalesReceipt.Anchor = AnchorStyles.Right;
            dateFromSalesReceipt.Location = new Point(89, 15);
            dateFromSalesReceipt.Margin = new Padding(3, 4, 3, 4);
            dateFromSalesReceipt.Name = "dateFromSalesReceipt";
            dateFromSalesReceipt.Size = new Size(276, 27);
            dateFromSalesReceipt.TabIndex = 3;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(17, 45);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 7, 0, 7);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(67, 32);
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
            label3.Location = new Point(2, 13);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 7, 0, 7);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(85, 32);
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
            displayByComboBox.Location = new Point(167, 8);
            displayByComboBox.Margin = new Padding(3, 4, 3, 4);
            displayByComboBox.Name = "displayByComboBox";
            displayByComboBox.Size = new Size(183, 28);
            displayByComboBox.TabIndex = 2;
            // 
            // displayByCheckBox
            // 
            displayByCheckBox.Anchor = AnchorStyles.Left;
            displayByCheckBox.AutoSize = true;
            displayByCheckBox.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            displayByCheckBox.Location = new Point(3, 13);
            displayByCheckBox.Margin = new Padding(3, 4, 3, 4);
            displayByCheckBox.Name = "displayByCheckBox";
            displayByCheckBox.Size = new Size(165, 22);
            displayByCheckBox.TabIndex = 1;
            displayByCheckBox.Text = "Display by Collector :";
            displayByCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(listViewSalesReceipt);
            groupBox2.Location = new Point(14, 157);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1158, 696);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // listViewSalesReceipt
            // 
            listViewSalesReceipt.Columns.AddRange(new ColumnHeader[] { orderNo, receiptNo, id, vatabale, totalSale, amountDue, _void });
            listViewSalesReceipt.Dock = DockStyle.Fill;
            listViewSalesReceipt.FullRowSelect = true;
            listViewSalesReceipt.GridLines = true;
            listViewSalesReceipt.Location = new Point(3, 24);
            listViewSalesReceipt.Margin = new Padding(3, 4, 3, 4);
            listViewSalesReceipt.Name = "listViewSalesReceipt";
            listViewSalesReceipt.Size = new Size(1152, 668);
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
            dateSalesReceipt.Location = new Point(463, 8);
            dateSalesReceipt.Margin = new Padding(3, 4, 3, 4);
            dateSalesReceipt.Name = "dateSalesReceipt";
            dateSalesReceipt.Size = new Size(276, 27);
            dateSalesReceipt.TabIndex = 7;
            // 
            // viewButton
            // 
            viewButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            viewButton.Location = new Point(96, 4);
            viewButton.Margin = new Padding(3, 4, 3, 4);
            viewButton.Name = "viewButton";
            viewButton.Size = new Size(127, 36);
            viewButton.TabIndex = 6;
            viewButton.Text = "View / Return";
            viewButton.UseVisualStyleBackColor = true;
            // 
            // voidButton
            // 
            voidButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            voidButton.Location = new Point(3, 4);
            voidButton.Margin = new Padding(3, 4, 3, 4);
            voidButton.Name = "voidButton";
            voidButton.Size = new Size(86, 36);
            voidButton.TabIndex = 5;
            voidButton.Text = "Void";
            voidButton.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(409, 8);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 7, 0, 7);
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(55, 32);
            label5.TabIndex = 10;
            label5.Text = "DATE :";
            label5.Click += label3_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(displayByComboBox);
            panel1.Controls.Add(displayByCheckBox);
            panel1.Location = new Point(14, 103);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(360, 47);
            panel1.TabIndex = 12;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel2.Controls.Add(dateFromSalesReceipt);
            panel2.Controls.Add(dateToSalesReceipt);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(802, 60);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(369, 89);
            panel2.TabIndex = 13;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom;
            panel3.Controls.Add(dateSalesReceipt);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(viewButton);
            panel3.Controls.Add(voidButton);
            panel3.Location = new Point(23, 861);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(749, 45);
            panel3.TabIndex = 14;
            // 
            // Sales_Receipt
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 923);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(groupBox2);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1183, 907);
            Name = "Sales_Receipt";
            StartPosition = FormStartPosition.CenterScreen;
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