
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userRecords));
            systemUserIcon = new PictureBox();
            userLbl = new Label();
            userDesc = new Label();
            UserGroupBox = new GroupBox();
            listView1 = new ListView();
            profileAccNo = new ColumnHeader();
            profileUserName = new ColumnHeader();
            profileAccess = new ColumnHeader();
            BtnUserSearch = new Button();
            txtBoxUserSearch = new TextBox();
            BtnUserAdd = new Button();
            BtnUserRemove = new Button();
            BtnUserEdit = new Button();
            userCloseBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)systemUserIcon).BeginInit();
            UserGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // systemUserIcon
            // 
            systemUserIcon.Image = (Image)resources.GetObject("systemUserIcon.Image");
            systemUserIcon.Location = new Point(12, 15);
            systemUserIcon.Margin = new Padding(3, 4, 3, 4);
            systemUserIcon.Name = "systemUserIcon";
            systemUserIcon.Size = new Size(79, 85);
            systemUserIcon.SizeMode = PictureBoxSizeMode.Zoom;
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
            UserGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            UserGroupBox.Controls.Add(listView1);
            UserGroupBox.Controls.Add(BtnUserSearch);
            UserGroupBox.Controls.Add(txtBoxUserSearch);
            UserGroupBox.Font = new Font("Tahoma", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
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
            listView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listView1.Columns.AddRange(new ColumnHeader[] { profileAccNo, profileUserName, profileAccess });
            listView1.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
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
            // BtnUserSearch
            // 
            BtnUserSearch.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUserSearch.Location = new Point(558, 36);
            BtnUserSearch.Margin = new Padding(3, 4, 3, 4);
            BtnUserSearch.Name = "BtnUserSearch";
            BtnUserSearch.Size = new Size(199, 41);
            BtnUserSearch.TabIndex = 7;
            BtnUserSearch.Text = "Search";
            BtnUserSearch.UseVisualStyleBackColor = true;
            // 
            // txtBoxUserSearch
            // 
            txtBoxUserSearch.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            txtBoxUserSearch.Location = new Point(12, 36);
            txtBoxUserSearch.Margin = new Padding(3, 4, 3, 4);
            txtBoxUserSearch.Multiline = true;
            txtBoxUserSearch.Name = "txtBoxUserSearch";
            txtBoxUserSearch.Size = new Size(522, 37);
            txtBoxUserSearch.TabIndex = 0;
            // 
            // BtnUserAdd
            // 
            BtnUserAdd.BackColor = SystemColors.MenuHighlight;
            BtnUserAdd.Cursor = Cursors.Hand;
            BtnUserAdd.FlatAppearance.BorderSize = 0;
            BtnUserAdd.FlatStyle = FlatStyle.Flat;
            BtnUserAdd.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUserAdd.ForeColor = SystemColors.HighlightText;
            BtnUserAdd.Location = new Point(62, 594);
            BtnUserAdd.Margin = new Padding(3, 4, 3, 4);
            BtnUserAdd.Name = "BtnUserAdd";
            BtnUserAdd.Size = new Size(143, 52);
            BtnUserAdd.TabIndex = 9;
            BtnUserAdd.Text = "Add";
            BtnUserAdd.UseVisualStyleBackColor = false;
            BtnUserAdd.Click += userAddBtn_Click;
            // 
            // BtnUserRemove
            // 
            BtnUserRemove.BackColor = SystemColors.ButtonHighlight;
            BtnUserRemove.Cursor = Cursors.Hand;
            BtnUserRemove.FlatAppearance.BorderColor = SystemColors.ButtonHighlight;
            BtnUserRemove.FlatAppearance.BorderSize = 0;
            BtnUserRemove.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            BtnUserRemove.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            BtnUserRemove.FlatStyle = FlatStyle.Flat;
            BtnUserRemove.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUserRemove.Location = new Point(233, 594);
            BtnUserRemove.Margin = new Padding(3, 4, 3, 4);
            BtnUserRemove.Name = "BtnUserRemove";
            BtnUserRemove.Size = new Size(143, 52);
            BtnUserRemove.TabIndex = 10;
            BtnUserRemove.Text = "Remove";
            BtnUserRemove.UseVisualStyleBackColor = false;
            BtnUserRemove.Click += userRemoveBtn_Click;
            // 
            // BtnUserEdit
            // 
            BtnUserEdit.BackColor = SystemColors.ButtonHighlight;
            BtnUserEdit.Cursor = Cursors.Hand;
            BtnUserEdit.FlatAppearance.BorderSize = 0;
            BtnUserEdit.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            BtnUserEdit.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            BtnUserEdit.FlatStyle = FlatStyle.Flat;
            BtnUserEdit.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnUserEdit.Location = new Point(406, 594);
            BtnUserEdit.Margin = new Padding(3, 4, 3, 4);
            BtnUserEdit.Name = "BtnUserEdit";
            BtnUserEdit.Size = new Size(143, 52);
            BtnUserEdit.TabIndex = 11;
            BtnUserEdit.Text = "Edit";
            BtnUserEdit.UseVisualStyleBackColor = false;
            // 
            // userCloseBtn
            // 
            userCloseBtn.BackColor = SystemColors.ButtonHighlight;
            userCloseBtn.Cursor = Cursors.Hand;
            userCloseBtn.FlatAppearance.BorderSize = 0;
            userCloseBtn.FlatAppearance.MouseDownBackColor = SystemColors.ButtonHighlight;
            userCloseBtn.FlatAppearance.MouseOverBackColor = SystemColors.ButtonHighlight;
            userCloseBtn.FlatStyle = FlatStyle.Flat;
            userCloseBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
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
            ControlBox = false;
            Controls.Add(userCloseBtn);
            Controls.Add(BtnUserEdit);
            Controls.Add(BtnUserRemove);
            Controls.Add(BtnUserAdd);
            Controls.Add(UserGroupBox);
            Controls.Add(userDesc);
            Controls.Add(userLbl);
            Controls.Add(systemUserIcon);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            Name = "userRecords";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button BtnUserSearch;
        private TextBox txtBoxUserSearch;
        private Button BtnUserAdd;
        private Button BtnUserRemove;
        private Button BtnUserEdit;
        private Button userCloseBtn;
    }
}