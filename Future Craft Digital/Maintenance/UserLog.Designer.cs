
namespace Future_Craft_Digital.Maintenance
{
    partial class UserLogForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserLogForm));
            userlogIcon = new PictureBox();
            usersLogDesc = new Label();
            usersLogLbl = new Label();
            userlogIcon2 = new PictureBox();
            usersLogGroupBox = new GroupBox();
            userLogListView = new ListView();
            userActions = new ColumnHeader();
            actionDate = new ColumnHeader();
            actionTime = new ColumnHeader();
            userLogLogin = new ColumnHeader();
            userLogLogout = new ColumnHeader();
            userLogToDate = new DateTimePicker();
            userLogFromDate = new DateTimePicker();
            label3 = new Label();
            label2 = new Label();
            unLogComboBox = new ComboBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)userlogIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)userlogIcon2).BeginInit();
            usersLogGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // userlogIcon
            // 
            userlogIcon.Image = (Image)resources.GetObject("userlogIcon.Image");
            userlogIcon.Location = new Point(12, 16);
            userlogIcon.Margin = new Padding(3, 4, 3, 4);
            userlogIcon.Name = "userlogIcon";
            userlogIcon.Size = new Size(78, 90);
            userlogIcon.SizeMode = PictureBoxSizeMode.Zoom;
            userlogIcon.TabIndex = 12;
            userlogIcon.TabStop = false;
            // 
            // usersLogDesc
            // 
            usersLogDesc.AutoSize = true;
            usersLogDesc.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersLogDesc.Location = new Point(160, 70);
            usersLogDesc.Name = "usersLogDesc";
            usersLogDesc.Size = new Size(181, 18);
            usersLogDesc.TabIndex = 11;
            usersLogDesc.Text = "Trailing records of all users";
            // 
            // usersLogLbl
            // 
            usersLogLbl.AutoSize = true;
            usersLogLbl.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            usersLogLbl.ForeColor = SystemColors.MenuHighlight;
            usersLogLbl.Location = new Point(156, 29);
            usersLogLbl.Name = "usersLogLbl";
            usersLogLbl.Size = new Size(152, 34);
            usersLogLbl.TabIndex = 10;
            usersLogLbl.Text = "Users Log";
            // 
            // userlogIcon2
            // 
            userlogIcon2.Image = (Image)resources.GetObject("userlogIcon2.Image");
            userlogIcon2.Location = new Point(96, 32);
            userlogIcon2.Margin = new Padding(3, 4, 3, 4);
            userlogIcon2.Name = "userlogIcon2";
            userlogIcon2.Size = new Size(51, 60);
            userlogIcon2.SizeMode = PictureBoxSizeMode.Zoom;
            userlogIcon2.TabIndex = 13;
            userlogIcon2.TabStop = false;
            // 
            // usersLogGroupBox
            // 
            usersLogGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            usersLogGroupBox.Controls.Add(userLogListView);
            usersLogGroupBox.Controls.Add(userLogToDate);
            usersLogGroupBox.Controls.Add(userLogFromDate);
            usersLogGroupBox.Controls.Add(label3);
            usersLogGroupBox.Controls.Add(label2);
            usersLogGroupBox.Controls.Add(unLogComboBox);
            usersLogGroupBox.Controls.Add(label1);
            usersLogGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usersLogGroupBox.Location = new Point(12, 114);
            usersLogGroupBox.Margin = new Padding(3, 4, 3, 4);
            usersLogGroupBox.Name = "usersLogGroupBox";
            usersLogGroupBox.Padding = new Padding(3, 4, 3, 4);
            usersLogGroupBox.Size = new Size(1108, 428);
            usersLogGroupBox.TabIndex = 14;
            usersLogGroupBox.TabStop = false;
            // 
            // userLogListView
            // 
            userLogListView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userLogListView.BorderStyle = BorderStyle.FixedSingle;
            userLogListView.Columns.AddRange(new ColumnHeader[] { userActions, actionDate, actionTime, userLogLogin, userLogLogout });
            userLogListView.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userLogListView.GridLines = true;
            userLogListView.Location = new Point(7, 87);
            userLogListView.Margin = new Padding(3, 4, 3, 4);
            userLogListView.Name = "userLogListView";
            userLogListView.Size = new Size(1093, 333);
            userLogListView.TabIndex = 20;
            userLogListView.UseCompatibleStateImageBehavior = false;
            userLogListView.View = View.Details;
            // 
            // userActions
            // 
            userActions.Text = "Actions";
            userActions.Width = 170;
            // 
            // actionDate
            // 
            actionDate.Text = "Date";
            actionDate.TextAlign = HorizontalAlignment.Center;
            actionDate.Width = 120;
            // 
            // actionTime
            // 
            actionTime.Text = "Time";
            actionTime.TextAlign = HorizontalAlignment.Center;
            actionTime.Width = 120;
            // 
            // userLogLogin
            // 
            userLogLogin.Text = "LOG IN";
            userLogLogin.TextAlign = HorizontalAlignment.Center;
            userLogLogin.Width = 120;
            // 
            // userLogLogout
            // 
            userLogLogout.Text = "LOG OUT";
            userLogLogout.TextAlign = HorizontalAlignment.Center;
            userLogLogout.Width = 120;
            // 
            // userLogToDate
            // 
            userLogToDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userLogToDate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userLogToDate.Location = new Point(822, 31);
            userLogToDate.Margin = new Padding(3, 4, 3, 4);
            userLogToDate.Name = "userLogToDate";
            userLogToDate.Size = new Size(278, 26);
            userLogToDate.TabIndex = 19;
            // 
            // userLogFromDate
            // 
            userLogFromDate.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            userLogFromDate.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userLogFromDate.Location = new Point(487, 31);
            userLogFromDate.Margin = new Padding(3, 4, 3, 4);
            userLogFromDate.Name = "userLogFromDate";
            userLogFromDate.Size = new Size(279, 26);
            userLogFromDate.TabIndex = 18;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(785, 35);
            label3.Name = "label3";
            label3.Size = new Size(35, 18);
            label3.TabIndex = 17;
            label3.Text = "To :";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(430, 35);
            label2.Name = "label2";
            label2.Size = new Size(55, 18);
            label2.TabIndex = 16;
            label2.Text = "From :";
            // 
            // unLogComboBox
            // 
            unLogComboBox.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            unLogComboBox.FormattingEnabled = true;
            unLogComboBox.Items.AddRange(new object[] { "9 - admin", "12 - cashier", "14 - sales", "13 - stock" });
            unLogComboBox.Location = new Point(113, 31);
            unLogComboBox.Margin = new Padding(3, 4, 3, 4);
            unLogComboBox.Name = "unLogComboBox";
            unLogComboBox.Size = new Size(193, 26);
            unLogComboBox.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(4, 34);
            label1.Name = "label1";
            label1.Size = new Size(106, 18);
            label1.TabIndex = 15;
            label1.Text = "USERNAME : ";
            // 
            // UserLogForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 555);
            ControlBox = false;
            Controls.Add(usersLogGroupBox);
            Controls.Add(userlogIcon2);
            Controls.Add(userlogIcon);
            Controls.Add(usersLogDesc);
            Controls.Add(usersLogLbl);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserLogForm";
            Text = "User Log";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)userlogIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)userlogIcon2).EndInit();
            usersLogGroupBox.ResumeLayout(false);
            usersLogGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox userlogIcon;
        private Label usersLogDesc;
        private Label usersLogLbl;
        private PictureBox userlogIcon2;
        private GroupBox usersLogGroupBox;
        private DateTimePicker userLogToDate;
        private DateTimePicker userLogFromDate;
        private Label label3;
        private Label label2;
        private ComboBox unLogComboBox;
        private Label label1;
        private ListView userLogListView;
        private ColumnHeader userActions;
        private ColumnHeader actionDate;
        private ColumnHeader actionTime;
        private ColumnHeader userLogLogin;
        private ColumnHeader userLogLogout;
    }
}