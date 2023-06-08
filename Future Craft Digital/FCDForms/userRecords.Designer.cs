
namespace Future_Craft_Digital.FCDForms
{
    partial class userRecords
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
            this.systemUserIcon = new System.Windows.Forms.PictureBox();
            this.userLbl = new System.Windows.Forms.Label();
            this.userDesc = new System.Windows.Forms.Label();
            this.UserGroupBox = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.profileAccNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profileUserName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.profileAccess = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.userSearchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.userAddBtn = new System.Windows.Forms.Button();
            this.userRemoveBtn = new System.Windows.Forms.Button();
            this.userEditBtn = new System.Windows.Forms.Button();
            this.userCloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.systemUserIcon)).BeginInit();
            this.UserGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // systemUserIcon
            // 
            this.systemUserIcon.Location = new System.Drawing.Point(12, 12);
            this.systemUserIcon.Name = "systemUserIcon";
            this.systemUserIcon.Size = new System.Drawing.Size(79, 68);
            this.systemUserIcon.TabIndex = 1;
            this.systemUserIcon.TabStop = false;
            // 
            // userLbl
            // 
            this.userLbl.AutoSize = true;
            this.userLbl.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLbl.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.userLbl.Location = new System.Drawing.Point(97, 15);
            this.userLbl.Name = "userLbl";
            this.userLbl.Size = new System.Drawing.Size(304, 34);
            this.userLbl.TabIndex = 3;
            this.userLbl.Text = "System User Profiles";
            // 
            // userDesc
            // 
            this.userDesc.AutoSize = true;
            this.userDesc.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userDesc.Location = new System.Drawing.Point(103, 51);
            this.userDesc.Name = "userDesc";
            this.userDesc.Size = new System.Drawing.Size(305, 18);
            this.userDesc.TabIndex = 4;
            this.userDesc.Text = "Add, Edit, Delete Existing User Profile Account";
            // 
            // UserGroupBox
            // 
            this.UserGroupBox.Controls.Add(this.listView1);
            this.UserGroupBox.Controls.Add(this.userSearchBtn);
            this.UserGroupBox.Controls.Add(this.textBox1);
            this.UserGroupBox.Font = new System.Drawing.Font("Tahoma", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGroupBox.Location = new System.Drawing.Point(15, 94);
            this.UserGroupBox.Name = "UserGroupBox";
            this.UserGroupBox.Size = new System.Drawing.Size(773, 359);
            this.UserGroupBox.TabIndex = 6;
            this.UserGroupBox.TabStop = false;
            this.UserGroupBox.Text = "Select User Below";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.profileAccNo,
            this.profileUserName,
            this.profileAccess});
            this.listView1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 83);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(744, 255);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // profileAccNo
            // 
            this.profileAccNo.Text = "Account No.";
            this.profileAccNo.Width = 170;
            // 
            // profileUserName
            // 
            this.profileUserName.Text = "Username";
            this.profileUserName.Width = 220;
            // 
            // profileAccess
            // 
            this.profileAccess.Text = "Profile Access Type";
            this.profileAccess.Width = 220;
            // 
            // userSearchBtn
            // 
            this.userSearchBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSearchBtn.Location = new System.Drawing.Point(424, 26);
            this.userSearchBtn.Name = "userSearchBtn";
            this.userSearchBtn.Size = new System.Drawing.Size(199, 42);
            this.userSearchBtn.TabIndex = 7;
            this.userSearchBtn.Text = "Search";
            this.userSearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(394, 40);
            this.textBox1.TabIndex = 0;
            // 
            // userAddBtn
            // 
            this.userAddBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.userAddBtn.FlatAppearance.BorderSize = 0;
            this.userAddBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userAddBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAddBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.userAddBtn.Location = new System.Drawing.Point(62, 475);
            this.userAddBtn.Name = "userAddBtn";
            this.userAddBtn.Size = new System.Drawing.Size(143, 42);
            this.userAddBtn.TabIndex = 9;
            this.userAddBtn.Text = "Add";
            this.userAddBtn.UseVisualStyleBackColor = false;
            // 
            // userRemoveBtn
            // 
            this.userRemoveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userRemoveBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userRemoveBtn.FlatAppearance.BorderSize = 0;
            this.userRemoveBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userRemoveBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userRemoveBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userRemoveBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userRemoveBtn.Location = new System.Drawing.Point(233, 475);
            this.userRemoveBtn.Name = "userRemoveBtn";
            this.userRemoveBtn.Size = new System.Drawing.Size(143, 42);
            this.userRemoveBtn.TabIndex = 10;
            this.userRemoveBtn.Text = "Remove";
            this.userRemoveBtn.UseVisualStyleBackColor = false;
            this.userRemoveBtn.Click += new System.EventHandler(this.button2_Click);
            // 
            // userEditBtn
            // 
            this.userEditBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userEditBtn.FlatAppearance.BorderSize = 0;
            this.userEditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userEditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userEditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userEditBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userEditBtn.Location = new System.Drawing.Point(406, 475);
            this.userEditBtn.Name = "userEditBtn";
            this.userEditBtn.Size = new System.Drawing.Size(143, 42);
            this.userEditBtn.TabIndex = 11;
            this.userEditBtn.Text = "Edit";
            this.userEditBtn.UseVisualStyleBackColor = false;
            // 
            // userCloseBtn
            // 
            this.userCloseBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCloseBtn.FlatAppearance.BorderSize = 0;
            this.userCloseBtn.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCloseBtn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userCloseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userCloseBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userCloseBtn.Location = new System.Drawing.Point(577, 475);
            this.userCloseBtn.Name = "userCloseBtn";
            this.userCloseBtn.Size = new System.Drawing.Size(143, 42);
            this.userCloseBtn.TabIndex = 13;
            this.userCloseBtn.Text = "Cancel";
            this.userCloseBtn.UseVisualStyleBackColor = false;
            this.userCloseBtn.Click += new System.EventHandler(this.userCloseBtn_Click);
            // 
            // userRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.userCloseBtn);
            this.Controls.Add(this.userEditBtn);
            this.Controls.Add(this.userRemoveBtn);
            this.Controls.Add(this.userAddBtn);
            this.Controls.Add(this.UserGroupBox);
            this.Controls.Add(this.userDesc);
            this.Controls.Add(this.userLbl);
            this.Controls.Add(this.systemUserIcon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "userRecords";
            this.Text = "userRecords";
            ((System.ComponentModel.ISupportInitialize)(this.systemUserIcon)).EndInit();
            this.UserGroupBox.ResumeLayout(false);
            this.UserGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox systemUserIcon;
        private System.Windows.Forms.Label userLbl;
        private System.Windows.Forms.Label userDesc;
        private System.Windows.Forms.GroupBox UserGroupBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader profileAccNo;
        private System.Windows.Forms.ColumnHeader profileUserName;
        private System.Windows.Forms.ColumnHeader profileAccess;
        private System.Windows.Forms.Button userSearchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button userAddBtn;
        private System.Windows.Forms.Button userRemoveBtn;
        private System.Windows.Forms.Button userEditBtn;
        private System.Windows.Forms.Button userCloseBtn;
    }
}