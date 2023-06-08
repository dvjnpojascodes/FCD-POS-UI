using System;
using System.Windows.Forms;

namespace Future_Craft_Digital.FCDForms
{
    partial class Ordering_Kiosk : Form
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
            this.orderModLbl = new System.Windows.Forms.Label();
            this.orderModIcon = new System.Windows.Forms.PictureBox();
            this.orderModDesc = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.orderModuleListView = new System.Windows.Forms.ListView();
            this.orderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.orderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.totalCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateLbl = new System.Windows.Forms.Label();
            this.orderModDateTimePicker = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.orderModIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderModLbl
            // 
            this.orderModLbl.AutoSize = true;
            this.orderModLbl.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold);
            this.orderModLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.orderModLbl.Location = new System.Drawing.Point(78, 20);
            this.orderModLbl.Name = "orderModLbl";
            this.orderModLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderModLbl.Size = new System.Drawing.Size(279, 33);
            this.orderModLbl.TabIndex = 0;
            this.orderModLbl.Text = "Order Module Form";
            // 
            // orderModIcon
            // 
            this.orderModIcon.Location = new System.Drawing.Point(12, 11);
            this.orderModIcon.Name = "orderModIcon";
            this.orderModIcon.Size = new System.Drawing.Size(60, 45);
            this.orderModIcon.TabIndex = 1;
            this.orderModIcon.TabStop = false;
            // 
            // orderModDesc
            // 
            this.orderModDesc.AutoSize = true;
            this.orderModDesc.Font = new System.Drawing.Font("Tahoma", 9F);
            this.orderModDesc.ForeColor = System.Drawing.Color.Black;
            this.orderModDesc.Location = new System.Drawing.Point(78, 43);
            this.orderModDesc.Name = "orderModDesc";
            this.orderModDesc.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.orderModDesc.Size = new System.Drawing.Size(220, 18);
            this.orderModDesc.TabIndex = 0;
            this.orderModDesc.Text = "State current and previous order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderModuleListView);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(889, 487);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // orderModuleListView
            // 
            this.orderModuleListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.orderNo,
            this.orderDate,
            this.totalCost});
            this.orderModuleListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.orderModuleListView.FullRowSelect = true;
            this.orderModuleListView.GridLines = true;
            this.orderModuleListView.HideSelection = false;
            this.orderModuleListView.Location = new System.Drawing.Point(3, 22);
            this.orderModuleListView.Name = "orderModuleListView";
            this.orderModuleListView.Size = new System.Drawing.Size(883, 462);
            this.orderModuleListView.TabIndex = 0;
            this.orderModuleListView.UseCompatibleStateImageBehavior = false;
            this.orderModuleListView.View = System.Windows.Forms.View.Details;
            // 
            // orderNo
            // 
            this.orderNo.Text = "Order No.";
            this.orderNo.Width = 100;
            // 
            // orderDate
            // 
            this.orderDate.Text = "Order Date";
            this.orderDate.Width = 250;
            // 
            // totalCost
            // 
            this.totalCost.Text = "Total Cost";
            this.totalCost.Width = 100;
            // 
            // dateLbl
            // 
            this.dateLbl.AutoSize = true;
            this.dateLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.dateLbl.ForeColor = System.Drawing.Color.Black;
            this.dateLbl.Location = new System.Drawing.Point(603, 42);
            this.dateLbl.Name = "dateLbl";
            this.dateLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateLbl.Size = new System.Drawing.Size(52, 18);
            this.dateLbl.TabIndex = 0;
            this.dateLbl.Text = "Date :";
            // 
            // orderModDateTimePicker
            // 
            this.orderModDateTimePicker.Location = new System.Drawing.Point(653, 37);
            this.orderModDateTimePicker.Name = "orderModDateTimePicker";
            this.orderModDateTimePicker.Size = new System.Drawing.Size(245, 26);
            this.orderModDateTimePicker.TabIndex = 3;
            // 
            // Ordering_Kiosk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 576);
            this.Controls.Add(this.orderModDateTimePicker);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.orderModIcon);
            this.Controls.Add(this.dateLbl);
            this.Controls.Add(this.orderModDesc);
            this.Controls.Add(this.orderModLbl);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "Ordering_Kiosk";
            this.Text = "Ordering_Kiosk";
            ((System.ComponentModel.ISupportInitialize)(this.orderModIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Ordering_Kiosk_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label orderModLbl;
        private PictureBox orderModIcon;
        private System.Windows.Forms.Label orderModDesc;
        private GroupBox groupBox1;
        private ListView orderModuleListView;
        private ColumnHeader orderNo;
        private ColumnHeader orderDate;
        private ColumnHeader totalCost;
        private System.Windows.Forms.Label dateLbl;
        private DateTimePicker orderModDateTimePicker;
    }
}