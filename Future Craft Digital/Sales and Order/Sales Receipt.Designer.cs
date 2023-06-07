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
            groupBox1 = new GroupBox();
            checkBox1 = new CheckBox();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            groupBox2 = new GroupBox();
            listView1 = new ListView();
            receiptNo = new ColumnHeader();
            orderNo = new ColumnHeader();
            id = new ColumnHeader();
            vatabale = new ColumnHeader();
            totalSale = new ColumnHeader();
            amountDue = new ColumnHeader();
            _void = new ColumnHeader();
            groupBox3 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            label5 = new Label();
            dateTimePicker3 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(15, 14);
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
            label2.Location = new Point(81, 46);
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
            label1.Location = new Point(81, 23);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(195, 25);
            label1.TabIndex = 6;
            label1.Text = "Sales Receipt List";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(775, 113);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            checkBox1.Location = new Point(15, 76);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(138, 18);
            checkBox1.TabIndex = 8;
            checkBox1.Text = "Display by Collector :";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = Color.White;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(158, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(161, 23);
            comboBox1.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(430, 46);
            label3.Name = "label3";
            label3.Padding = new Padding(0, 5, 0, 5);
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(70, 24);
            label3.TabIndex = 10;
            label3.Text = "Date from :";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(443, 70);
            label4.Name = "label4";
            label4.Padding = new Padding(0, 5, 0, 5);
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(57, 24);
            label4.TabIndex = 10;
            label4.Text = "Date to :";
            label4.Click += label3_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(506, 47);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(242, 23);
            dateTimePicker1.TabIndex = 11;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(506, 72);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(242, 23);
            dateTimePicker2.TabIndex = 11;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(groupBox3);
            groupBox2.Controls.Add(listView1);
            groupBox2.Location = new Point(12, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(894, 445);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { orderNo, receiptNo, id, vatabale, totalSale, amountDue, _void });
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.Location = new Point(13, 19);
            listView1.Name = "listView1";
            listView1.Size = new Size(869, 366);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // receiptNo
            // 
            receiptNo.Text = "Receipt no.";
            receiptNo.Width = 150;
            // 
            // orderNo
            // 
            orderNo.Text = "Order no.";
            orderNo.Width = 100;
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
            // groupBox3
            // 
            groupBox3.Controls.Add(dateTimePicker3);
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(10, 395);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(656, 46);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(6, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 27);
            button1.TabIndex = 0;
            button1.Text = "Void";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(87, 13);
            button2.Name = "button2";
            button2.Size = new Size(111, 27);
            button2.TabIndex = 0;
            button2.Text = "View / Return";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(361, 16);
            label5.Name = "label5";
            label5.Padding = new Padding(0, 5, 0, 5);
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(46, 24);
            label5.TabIndex = 10;
            label5.Text = "DATE :";
            label5.Click += label3_Click;
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(408, 16);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(242, 23);
            dateTimePicker3.TabIndex = 11;
            // 
            // Sales_Receipt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 612);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Sales_Receipt";
            Text = "Sales_Receipt";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private Label label3;
        private ComboBox comboBox1;
        private CheckBox checkBox1;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView listView1;
        private ColumnHeader orderNo;
        private ColumnHeader receiptNo;
        private ColumnHeader id;
        private ColumnHeader vatabale;
        private ColumnHeader totalSale;
        private ColumnHeader amountDue;
        private ColumnHeader _void;
        private DateTimePicker dateTimePicker3;
        private Button button2;
        private Button button1;
        private Label label5;
    }
}