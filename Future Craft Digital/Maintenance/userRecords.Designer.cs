
namespace Future_Craft_Digital.Maintenance
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
            systemUserIcon = new PictureBox();
            userLbl = new Label();
            userDesc = new Label();
            UserGroupBox = new GroupBox();
            listView1 = new ListView();
            profileAccNo = new ColumnHeader();
            profileUserName = new ColumnHeader();
            profileAccess = new ColumnHeader();
            userSearchBtn = new Button();
            textBox1 = new TextBox();
            userAddBtn = new Button();
            userRemoveBtn = new Button();
            userEditBtn = new Button();
            userCloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)systemUserIcon).BeginInit();
            UserGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // systemUserIcon
            // 
            systemUserIcon.Location = new Point(12, 15);
            systemUserIcon.Margin = new Padding(3, 4, 3, 4);
            systemUserIcon.Name = "systemUserIcon";
            systemUserIcon.Size = new Size(79, 85);
            systemUserIcon.TabIndex = 1;
            systemUserIcon.TabStop = false;
            // 
            // userLbl
            // 
            userLbl.AutoSize = true;
            userLbl.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            userLbl.ForeColor = SystemColors.MenuHighlight;
            userLbl.Location = new Point(97, 19);
            userLbl.Name = "userLbl";
            userLbl.Size = new Size(304, 34);
            userLbl.TabIndex = 3;
            userLbl.Text = "System User Profiles";
            // 
            // userDesc
            // 
            userDesc.AutoSize = true;
            userDesc.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userDesc.Location = new Point(103, 64);
            userDesc.Name = "userDesc";
            userDesc.Size = new Size(179, 18);
            userDesc.TabIndex = 4;
            userDesc.Text = "Add or Edit Account Profile";
            // 
            // UserGroupBox
            // 
            UserGroupBox.Controls.Add(listView1);
            UserGroupBox.Controls.Add(userSearchBtn);
            UserGroupBox.Controls.Add(textBox1);
            UserGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            UserGroupBox.Location = new Point(15, 118);
            UserGroupBox.Margin = new Padding(3, 4, 3, 4);
            UserGroupBox.Name = "UserGroupBox";
            UserGroupBox.Padding = new Padding(3, 4, 3, 4);
            UserGroupBox.Size = new Size(773, 449);
            UserGroupBox.TabIndex = 6;
            UserGroupBox.TabStop = false;
            UserGroupBox.Text = "Select User Below";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { profileAccNo, profileUserName, profileAccess });
            listView1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listView1.GridLines = true;
            listView1.Location = new Point(13, 104);
            listView1.Margin = new Padding(3, 4, 3, 4);
            listView1.Name = "listView1";
            listView1.Size = new Size(744, 318);
            listView1.TabIndex = 8;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // profileAccNo
            // 
            profileAccNo.Text = "Account No.";
            profileAccNo.Width = 170;
            // 
            // profileUserName
            // 
            profileUserName.Text = "Username";
            profileUserName.Width = 220;
            // 
            // profileAccess
            // 
            profileAccess.Text = "Access Type";
            profileAccess.Width = 220;
            // 
            // userSearchBtn
            // 
            userSearchBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userSearchBtn.Location = new Point(558, 36);
            userSearchBtn.Margin = new Padding(3, 4, 3, 4);
            userSearchBtn.Name = "userSearchBtn";
            userSearchBtn.Size = new Size(199, 41);
            userSearchBtn.TabIndex = 7;
            userSearchBtn.Text = "Search";
            userSearchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(12, 36);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(522, 37);
            textBox1.TabIndex = 0;
            // 
            // userAddBtn
            // 
            userAddBtn.BackColor = SystemColors.MenuHighlight;
            userAddBtn.Cursor = Cursors.Hand;
            userAddBtn.FlatAppearance.BorderSize = 0;
            userAddBtn.FlatStyle = FlatStyle.Flat;
            userAddBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userAddBtn.ForeColor = SystemColors.HighlightText;
            userAddBtn.Location = new Point(62, 594);
            userAddBtn.Margin = new Padding(3, 4, 3, 4);
            userAddBtn.Name = "userAddBtn";
            userAddBtn.Size = new Size(143, 52);
            userAddBtn.TabIndex = 9;
            userAddBtn.Text = "Add";
            userAddBtn.UseVisualStyleBackColor = false;
            userAddBtn.Click += userAddBtn_Click;
            // 
            // userRemoveBtn
            // 
            userRemoveBtn.BackColor = SystemColors.ButtonHighlight;
            userRemoveBtn.Cursor = Cursors.Hand;
            userRemoveBtn.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            userRemoveBtn.FlatAppearance.BorderSize = 0;
            userRemoveBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            userRemoveBtn.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            userRemoveBtn.FlatStyle = FlatStyle.Flat;
            userRemoveBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userRemoveBtn.Location = new Point(233, 594);
            userRemoveBtn.Margin = new Padding(3, 4, 3, 4);
            userRemoveBtn.Name = "userRemoveBtn";
            userRemoveBtn.Size = new Size(143, 52);
            userRemoveBtn.TabIndex = 10;
            userRemoveBtn.Text = "Remove";
            userRemoveBtn.UseVisualStyleBackColor = false;
            userRemoveBtn.Click += userRemoveBtn_Click;
            // 
            // userEditBtn
            // 
            userEditBtn.BackColor = SystemColors.ButtonHighlight;
            userEditBtn.Cursor = Cursors.Hand;
            userEditBtn.FlatAppearance.BorderSize = 0;
            userEditBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            userEditBtn.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            userEditBtn.FlatStyle = FlatStyle.Flat;
            userEditBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userEditBtn.Location = new Point(406, 594);
            userEditBtn.Margin = new Padding(3, 4, 3, 4);
            userEditBtn.Name = "userEditBtn";
            userEditBtn.Size = new Size(143, 52);
            userEditBtn.TabIndex = 11;
            userEditBtn.Text = "Edit";
            userEditBtn.UseVisualStyleBackColor = false;
            // 
            // userCloseBtn
            // 
            userCloseBtn.BackColor = SystemColors.ButtonHighlight;
            userCloseBtn.Cursor = Cursors.Hand;
            userCloseBtn.FlatAppearance.BorderSize = 0;
            userCloseBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            userCloseBtn.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            userCloseBtn.FlatStyle = FlatStyle.Flat;
            userCloseBtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userCloseBtn.Location = new Point(577, 594);
            userCloseBtn.Margin = new Padding(3, 4, 3, 4);
            userCloseBtn.Name = "userCloseBtn";
            userCloseBtn.Size = new Size(143, 52);
            userCloseBtn.TabIndex = 13;
            userCloseBtn.Text = "Cancel";
            userCloseBtn.UseVisualStyleBackColor = false;
            userCloseBtn.Click += userCloseBtn_Click;
            // 
            // userRecords
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 661);
            Controls.Add(userCloseBtn);
            Controls.Add(userEditBtn);
            Controls.Add(userRemoveBtn);
            Controls.Add(userAddBtn);
            Controls.Add(UserGroupBox);
            Controls.Add(userDesc);
            Controls.Add(userLbl);
            Controls.Add(systemUserIcon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "userRecords";
            Text = "User Record";
            ((System.ComponentModel.ISupportInitialize)systemUserIcon).EndInit();
            UserGroupBox.ResumeLayout(false);
            UserGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox systemUserIcon;
        private Label userLbl;
        private Label userDesc;
        private GroupBox UserGroupBox;
        private ListView listView1;
        private ColumnHeader profileAccNo;
        private ColumnHeader profileUserName;
        private ColumnHeader profileAccess;
        private Button userSearchBtn;
        private TextBox textBox1;
        private Button userAddBtn;
        private Button userRemoveBtn;
        private Button userEditBtn;
        private Button userCloseBtn;
    }
}