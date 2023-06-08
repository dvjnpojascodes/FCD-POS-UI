
namespace Future_Craft_Digital.FCDForms
{
    partial class UserLog
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
            this.userlogIcon = new System.Windows.Forms.PictureBox();
            this.usersLogDesc = new System.Windows.Forms.Label();
            this.usersLogLbl = new System.Windows.Forms.Label();
            this.userlogIcon2 = new System.Windows.Forms.PictureBox();
            this.usersLogGroupBox = new System.Windows.Forms.GroupBox();
            this.productListView = new System.Windows.Forms.ListView();
            this.userActions = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.actionTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userLogLogin = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userLogLogout = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userDropDown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userlogIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlogIcon2)).BeginInit();
            this.usersLogGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userlogIcon
            // 
            this.userlogIcon.Location = new System.Drawing.Point(12, 13);
            this.userlogIcon.Name = "userlogIcon";
            this.userlogIcon.Size = new System.Drawing.Size(78, 72);
            this.userlogIcon.TabIndex = 12;
            this.userlogIcon.TabStop = false;
            // 
            // usersLogDesc
            // 
            this.usersLogDesc.AutoSize = true;
            this.usersLogDesc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLogDesc.Location = new System.Drawing.Point(160, 56);
            this.usersLogDesc.Name = "usersLogDesc";
            this.usersLogDesc.Size = new System.Drawing.Size(181, 18);
            this.usersLogDesc.TabIndex = 11;
            this.usersLogDesc.Text = "Trailing records of all users";
            // 
            // usersLogLbl
            // 
            this.usersLogLbl.AutoSize = true;
            this.usersLogLbl.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLogLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.usersLogLbl.Location = new System.Drawing.Point(156, 23);
            this.usersLogLbl.Name = "usersLogLbl";
            this.usersLogLbl.Size = new System.Drawing.Size(152, 34);
            this.usersLogLbl.TabIndex = 10;
            this.usersLogLbl.Text = "Users Log";
            // 
            // userlogIcon2
            // 
            this.userlogIcon2.Location = new System.Drawing.Point(96, 26);
            this.userlogIcon2.Name = "userlogIcon2";
            this.userlogIcon2.Size = new System.Drawing.Size(51, 48);
            this.userlogIcon2.TabIndex = 13;
            this.userlogIcon2.TabStop = false;
            // 
            // usersLogGroupBox
            // 
            this.usersLogGroupBox.Controls.Add(this.productListView);
            this.usersLogGroupBox.Controls.Add(this.dateTimePicker2);
            this.usersLogGroupBox.Controls.Add(this.dateTimePicker1);
            this.usersLogGroupBox.Controls.Add(this.label3);
            this.usersLogGroupBox.Controls.Add(this.label2);
            this.usersLogGroupBox.Controls.Add(this.userDropDown);
            this.usersLogGroupBox.Controls.Add(this.label1);
            this.usersLogGroupBox.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersLogGroupBox.Location = new System.Drawing.Point(12, 91);
            this.usersLogGroupBox.Name = "usersLogGroupBox";
            this.usersLogGroupBox.Size = new System.Drawing.Size(1106, 501);
            this.usersLogGroupBox.TabIndex = 14;
            this.usersLogGroupBox.TabStop = false;
            // 
            // productListView
            // 
            this.productListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.userActions,
            this.actionDate,
            this.actionTime,
            this.userLogLogin,
            this.userLogLogout});
            this.productListView.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListView.GridLines = true;
            this.productListView.HideSelection = false;
            this.productListView.Location = new System.Drawing.Point(7, 76);
            this.productListView.Name = "productListView";
            this.productListView.Size = new System.Drawing.Size(1093, 419);
            this.productListView.TabIndex = 20;
            this.productListView.UseCompatibleStateImageBehavior = false;
            this.productListView.View = System.Windows.Forms.View.Details;
            // 
            // userActions
            // 
            this.userActions.Text = "Actions";
            this.userActions.Width = 170;
            // 
            // actionDate
            // 
            this.actionDate.Text = "Date";
            this.actionDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.actionDate.Width = 120;
            // 
            // actionTime
            // 
            this.actionTime.Text = "Time";
            this.actionTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.actionTime.Width = 120;
            // 
            // userLogLogin
            // 
            this.userLogLogin.Text = "LOG IN";
            this.userLogLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userLogLogin.Width = 120;
            // 
            // userLogLogout
            // 
            this.userLogLogout.Text = "LOG OUT";
            this.userLogLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.userLogLogout.Width = 120;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(822, 25);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(278, 26);
            this.dateTimePicker2.TabIndex = 19;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(487, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(279, 26);
            this.dateTimePicker1.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(781, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "To :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(426, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "From :";
            // 
            // userDropDown
            // 
            this.userDropDown.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDropDown.FormattingEnabled = true;
            this.userDropDown.Items.AddRange(new object[] {
            "9 - admin",
            "12 - cashier",
            "14 - sales",
            "13 - stock"});
            this.userDropDown.Location = new System.Drawing.Point(113, 25);
            this.userDropDown.Name = "userDropDown";
            this.userDropDown.Size = new System.Drawing.Size(193, 26);
            this.userDropDown.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "USERNAME : ";
            // 
            // UserLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 604);
            this.Controls.Add(this.usersLogGroupBox);
            this.Controls.Add(this.userlogIcon2);
            this.Controls.Add(this.userlogIcon);
            this.Controls.Add(this.usersLogDesc);
            this.Controls.Add(this.usersLogLbl);
            this.Name = "UserLog";
            this.Text = "UserLog";
            ((System.ComponentModel.ISupportInitialize)(this.userlogIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userlogIcon2)).EndInit();
            this.usersLogGroupBox.ResumeLayout(false);
            this.usersLogGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox userlogIcon;
        private System.Windows.Forms.Label usersLogDesc;
        private System.Windows.Forms.Label usersLogLbl;
        private System.Windows.Forms.PictureBox userlogIcon2;
        private System.Windows.Forms.GroupBox usersLogGroupBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox userDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView productListView;
        private System.Windows.Forms.ColumnHeader userActions;
        private System.Windows.Forms.ColumnHeader actionDate;
        private System.Windows.Forms.ColumnHeader actionTime;
        private System.Windows.Forms.ColumnHeader userLogLogin;
        private System.Windows.Forms.ColumnHeader userLogLogout;
    }
}