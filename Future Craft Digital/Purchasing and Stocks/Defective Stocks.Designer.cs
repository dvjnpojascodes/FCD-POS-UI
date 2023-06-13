﻿namespace Future_Craft_Digital.Purchasing_and_Stocks
{
    partial class Defective_Stocks
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
            listViewDefectiveStocks = new ListView();
            id = new ColumnHeader();
            purchaseNo = new ColumnHeader();
            supplierName = new ColumnHeader();
            deliveryItem = new ColumnHeader();
            address = new ColumnHeader();
            pendingId = new ColumnHeader();
            returnedRadioButton = new RadioButton();
            defectiveRadioButton = new RadioButton();
            pendingRadioButton = new RadioButton();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            dateDefectiveStocks = new DateTimePicker();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(listViewDefectiveStocks);
            groupBox1.Location = new Point(7, 100);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(997, 533);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            // 
            // listViewDefectiveStocks
            // 
            listViewDefectiveStocks.Columns.AddRange(new ColumnHeader[] { id, purchaseNo, supplierName, deliveryItem, address, pendingId });
            listViewDefectiveStocks.Dock = DockStyle.Fill;
            listViewDefectiveStocks.FullRowSelect = true;
            listViewDefectiveStocks.GridLines = true;
            listViewDefectiveStocks.Location = new Point(3, 19);
            listViewDefectiveStocks.Name = "listViewDefectiveStocks";
            listViewDefectiveStocks.Size = new Size(991, 511);
            listViewDefectiveStocks.TabIndex = 13;
            listViewDefectiveStocks.UseCompatibleStateImageBehavior = false;
            listViewDefectiveStocks.View = View.Details;
            // 
            // id
            // 
            id.Text = "ID";
            id.Width = 100;
            // 
            // purchaseNo
            // 
            purchaseNo.Text = "Purchase No.";
            purchaseNo.Width = 100;
            // 
            // supplierName
            // 
            supplierName.Text = "Supplier Name";
            supplierName.Width = 200;
            // 
            // deliveryItem
            // 
            deliveryItem.Text = "Delivery Item";
            deliveryItem.Width = 200;
            // 
            // address
            // 
            address.Text = "Address";
            address.Width = 200;
            // 
            // pendingId
            // 
            pendingId.Text = "Pending ID";
            pendingId.Width = 100;
            // 
            // returnedRadioButton
            // 
            returnedRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            returnedRadioButton.AutoSize = true;
            returnedRadioButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            returnedRadioButton.Location = new Point(309, 56);
            returnedRadioButton.Name = "returnedRadioButton";
            returnedRadioButton.Size = new Size(83, 18);
            returnedRadioButton.TabIndex = 14;
            returnedRadioButton.TabStop = true;
            returnedRadioButton.Text = "Returned";
            returnedRadioButton.UseVisualStyleBackColor = true;
            returnedRadioButton.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // defectiveRadioButton
            // 
            defectiveRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            defectiveRadioButton.AutoSize = true;
            defectiveRadioButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            defectiveRadioButton.Location = new Point(221, 56);
            defectiveRadioButton.Name = "defectiveRadioButton";
            defectiveRadioButton.Size = new Size(82, 18);
            defectiveRadioButton.TabIndex = 3;
            defectiveRadioButton.TabStop = true;
            defectiveRadioButton.Text = "Defective";
            defectiveRadioButton.UseVisualStyleBackColor = true;
            defectiveRadioButton.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pendingRadioButton
            // 
            pendingRadioButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pendingRadioButton.AutoSize = true;
            pendingRadioButton.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pendingRadioButton.Location = new Point(140, 56);
            pendingRadioButton.Name = "pendingRadioButton";
            pendingRadioButton.Size = new Size(75, 18);
            pendingRadioButton.TabIndex = 2;
            pendingRadioButton.TabStop = true;
            pendingRadioButton.Text = "Pending";
            pendingRadioButton.UseVisualStyleBackColor = true;
            pendingRadioButton.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(219, 83);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(186, 14);
            label6.TabIndex = 12;
            label6.Text = "Black for not not processed item";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(78, 83);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(134, 14);
            label5.TabIndex = 11;
            label5.Text = "Red for processed item";
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
            // dateDefectiveStocks
            // 
            dateDefectiveStocks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            dateDefectiveStocks.Location = new Point(147, 7);
            dateDefectiveStocks.Name = "dateDefectiveStocks";
            dateDefectiveStocks.Size = new Size(245, 23);
            dateDefectiveStocks.TabIndex = 11;
            dateDefectiveStocks.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(35, 12);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(106, 14);
            label3.TabIndex = 15;
            label3.Text = "Returned Date :";
            label3.Click += label3_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 45);
            pictureBox1.TabIndex = 14;
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
            label2.Size = new Size(232, 14);
            label2.TabIndex = 12;
            label2.Text = "List of returned stocks and their quantity";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(78, 21);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(333, 25);
            label1.TabIndex = 13;
            label1.Text = "Defective and Returned Stocks";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.Controls.Add(returnedRadioButton);
            panel1.Controls.Add(dateDefectiveStocks);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pendingRadioButton);
            panel1.Controls.Add(defectiveRadioButton);
            panel1.Location = new Point(603, 21);
            panel1.Name = "panel1";
            panel1.Size = new Size(401, 76);
            panel1.TabIndex = 17;
            // 
            // Defective_Stocks
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
            Name = "Defective_Stocks";
            Text = "Defective_Stocks";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private ListView listViewDefectiveStocks;
        private ColumnHeader id;
        private ColumnHeader purchaseNo;
        private ColumnHeader supplierName;
        private ColumnHeader deliveryItem;
        private ColumnHeader address;
        private RadioButton defectiveRadioButton;
        private RadioButton pendingRadioButton;
        private Label label6;
        private Label label5;
        private Label label4;
        private DateTimePicker dateDefectiveStocks;
        private Label label3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private RadioButton returnedRadioButton;
        private ColumnHeader pendingId;
        private Panel panel1;
    }
}