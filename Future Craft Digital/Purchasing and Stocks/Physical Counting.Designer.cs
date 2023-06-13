namespace Future_Craft_Digital.Purchasing_and_Stocks
{
    partial class Physical_Counting
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
            groupBox1 = new GroupBox();
            listViewPhysicalCounting = new ListView();
            id = new ColumnHeader();
            date = new ColumnHeader();
            username = new ColumnHeader();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            dateToPhysicalCounting = new DateTimePicker();
            label3 = new Label();
            dateFromPhysicalCounting = new DateTimePicker();
            label7 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(listViewPhysicalCounting);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Location = new Point(12, 70);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1025, 575);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // listViewPhysicalCounting
            // 
            listViewPhysicalCounting.Columns.AddRange(new ColumnHeader[] { id, date, username });
            listViewPhysicalCounting.Dock = DockStyle.Fill;
            listViewPhysicalCounting.FullRowSelect = true;
            listViewPhysicalCounting.GridLines = true;
            listViewPhysicalCounting.Location = new Point(3, 19);
            listViewPhysicalCounting.Name = "listViewPhysicalCounting";
            listViewPhysicalCounting.Size = new Size(1019, 553);
            listViewPhysicalCounting.TabIndex = 13;
            listViewPhysicalCounting.UseCompatibleStateImageBehavior = false;
            listViewPhysicalCounting.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 50;
            // 
            // date
            // 
            date.Text = "Date";
            date.Width = 200;
            // 
            // username
            // 
            username.Text = "Username";
            username.Width = 200;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(213, 19);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(0, 14);
            label6.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(72, 19);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(0, 14);
            label5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(6, 19);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(0, 14);
            label4.TabIndex = 11;
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
            label2.Location = new Point(80, 43);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(331, 14);
            label2.TabIndex = 15;
            label2.Text = "Current physical count of all products products by category";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(78, 19);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(198, 25);
            label1.TabIndex = 16;
            label1.Text = "Physical Counting";
            // 
            // dateToPhysicalCounting
            // 
            dateToPhysicalCounting.Location = new Point(134, 42);
            dateToPhysicalCounting.Name = "dateToPhysicalCounting";
            dateToPhysicalCounting.Size = new Size(245, 23);
            dateToPhysicalCounting.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(66, 48);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(62, 14);
            label3.TabIndex = 20;
            label3.Text = "Date to :";
            // 
            // dateFromPhysicalCounting
            // 
            dateFromPhysicalCounting.Location = new Point(134, 13);
            dateFromPhysicalCounting.Name = "dateFromPhysicalCounting";
            dateFromPhysicalCounting.Size = new Size(245, 23);
            dateFromPhysicalCounting.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(51, 19);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(77, 14);
            label7.TabIndex = 22;
            label7.Text = "Date from :";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(dateFromPhysicalCounting);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateToPhysicalCounting);
            panel1.Location = new Point(655, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(382, 69);
            panel1.TabIndex = 23;
            // 
            // Physical_Counting
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1049, 657);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Physical_Counting";
            Text = "Physical_Counting";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listViewPhysicalCounting;
        private ColumnHeader id;
        private ColumnHeader date;
        private ColumnHeader username;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private DateTimePicker dateToPhysicalCounting;
        private Label label3;
        private DateTimePicker dateFromPhysicalCounting;
        private Label label7;
        private Panel panel1;
    }
}