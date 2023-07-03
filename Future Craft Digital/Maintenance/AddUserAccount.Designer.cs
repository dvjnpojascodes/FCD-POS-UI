namespace Future_Craft_Digital
{
    partial class AddUserAccountForm
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
            userDesc = new Label();
            useAddLbl = new Label();
            systemUserIcon = new PictureBox();
            UserGroupBox = new GroupBox();
            localNumLbl = new Label();
            localNumTxt = new TextBox();
            accTypeDropComboBox = new ComboBox();
            accTypeLbl = new Label();
            confirmPassLbl = new Label();
            confirmPassTxt = new TextBox();
            addPassLbl = new Label();
            addPassTxt = new TextBox();
            addUNlbl = new Label();
            addUsernameTxt = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            addressLbl = new Label();
            addAddressTxt = new TextBox();
            label2 = new Label();
            addMNameTxt = new TextBox();
            label1 = new Label();
            addFNameTxt = new TextBox();
            addAccNameLbl = new Label();
            addLNameTxt = new TextBox();
            userUpdateBtn = new Button();
            userRemoveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)systemUserIcon).BeginInit();
            UserGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // userDesc
            // 
            userDesc.AutoSize = true;
            userDesc.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            userDesc.Location = new Point(107, 66);
            userDesc.Name = "userDesc";
            userDesc.Size = new Size(305, 18);
            userDesc.TabIndex = 7;
            userDesc.Text = "Add, Edit, Delete Existing User Profile Account";
            // 
            // useAddLbl
            // 
            useAddLbl.AutoSize = true;
            useAddLbl.Font = new Font("Tahoma", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            useAddLbl.ForeColor = SystemColors.MenuHighlight;
            useAddLbl.Location = new Point(101, 21);
            useAddLbl.Name = "useAddLbl";
            useAddLbl.Size = new Size(290, 34);
            useAddLbl.TabIndex = 6;
            useAddLbl.Text = "System User Profile";
            // 
            // systemUserIcon
            // 
            systemUserIcon.Location = new Point(16, 17);
            systemUserIcon.Margin = new Padding(3, 4, 3, 4);
            systemUserIcon.Name = "systemUserIcon";
            systemUserIcon.Size = new Size(79, 85);
            systemUserIcon.TabIndex = 5;
            systemUserIcon.TabStop = false;
            // 
            // UserGroupBox
            // 
            UserGroupBox.Controls.Add(localNumLbl);
            UserGroupBox.Controls.Add(localNumTxt);
            UserGroupBox.Controls.Add(accTypeDropComboBox);
            UserGroupBox.Controls.Add(accTypeLbl);
            UserGroupBox.Controls.Add(confirmPassLbl);
            UserGroupBox.Controls.Add(confirmPassTxt);
            UserGroupBox.Controls.Add(addPassLbl);
            UserGroupBox.Controls.Add(addPassTxt);
            UserGroupBox.Controls.Add(addUNlbl);
            UserGroupBox.Controls.Add(addUsernameTxt);
            UserGroupBox.Controls.Add(label3);
            UserGroupBox.Controls.Add(textBox1);
            UserGroupBox.Controls.Add(addressLbl);
            UserGroupBox.Controls.Add(addAddressTxt);
            UserGroupBox.Controls.Add(label2);
            UserGroupBox.Controls.Add(addMNameTxt);
            UserGroupBox.Controls.Add(label1);
            UserGroupBox.Controls.Add(addFNameTxt);
            UserGroupBox.Controls.Add(addAccNameLbl);
            UserGroupBox.Controls.Add(addLNameTxt);
            UserGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            UserGroupBox.Location = new Point(16, 118);
            UserGroupBox.Margin = new Padding(3, 4, 3, 4);
            UserGroupBox.Name = "UserGroupBox";
            UserGroupBox.Padding = new Padding(3, 4, 3, 4);
            UserGroupBox.Size = new Size(1003, 332);
            UserGroupBox.TabIndex = 8;
            UserGroupBox.TabStop = false;
            // 
            // localNumLbl
            // 
            localNumLbl.AutoSize = true;
            localNumLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            localNumLbl.Location = new Point(518, 276);
            localNumLbl.Name = "localNumLbl";
            localNumLbl.Size = new Size(120, 18);
            localNumLbl.TabIndex = 19;
            localNumLbl.Text = "Local Number :";
            // 
            // localNumTxt
            // 
            localNumTxt.Location = new Point(648, 274);
            localNumTxt.Name = "localNumTxt";
            localNumTxt.Size = new Size(328, 27);
            localNumTxt.TabIndex = 18;
            // 
            // accTypeDropComboBox
            // 
            accTypeDropComboBox.FormattingEnabled = true;
            accTypeDropComboBox.Location = new Point(648, 160);
            accTypeDropComboBox.Name = "accTypeDropComboBox";
            accTypeDropComboBox.Size = new Size(328, 28);
            accTypeDropComboBox.TabIndex = 17;
            // 
            // accTypeLbl
            // 
            accTypeLbl.AutoSize = true;
            accTypeLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            accTypeLbl.Location = new Point(518, 162);
            accTypeLbl.Name = "accTypeLbl";
            accTypeLbl.Size = new Size(90, 18);
            accTypeLbl.TabIndex = 16;
            accTypeLbl.Text = "Password :";
            // 
            // confirmPassLbl
            // 
            confirmPassLbl.AutoSize = true;
            confirmPassLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            confirmPassLbl.Location = new Point(518, 120);
            confirmPassLbl.Name = "confirmPassLbl";
            confirmPassLbl.Size = new Size(153, 18);
            confirmPassLbl.TabIndex = 15;
            confirmPassLbl.Text = "Confirm  Password:";
            // 
            // confirmPassTxt
            // 
            confirmPassTxt.Location = new Point(677, 118);
            confirmPassTxt.Name = "confirmPassTxt";
            confirmPassTxt.Size = new Size(299, 27);
            confirmPassTxt.TabIndex = 14;
            // 
            // addPassLbl
            // 
            addPassLbl.AutoSize = true;
            addPassLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addPassLbl.Location = new Point(518, 74);
            addPassLbl.Name = "addPassLbl";
            addPassLbl.Size = new Size(90, 18);
            addPassLbl.TabIndex = 13;
            addPassLbl.Text = "Password :";
            // 
            // addPassTxt
            // 
            addPassTxt.Location = new Point(648, 72);
            addPassTxt.Name = "addPassTxt";
            addPassTxt.Size = new Size(328, 27);
            addPassTxt.TabIndex = 12;
            // 
            // addUNlbl
            // 
            addUNlbl.AutoSize = true;
            addUNlbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addUNlbl.Location = new Point(518, 32);
            addUNlbl.Name = "addUNlbl";
            addUNlbl.Size = new Size(95, 18);
            addUNlbl.TabIndex = 11;
            addUNlbl.Text = "User Name:";
            // 
            // addUsernameTxt
            // 
            addUsernameTxt.Location = new Point(648, 30);
            addUsernameTxt.Name = "addUsernameTxt";
            addUsernameTxt.Size = new Size(328, 27);
            addUsernameTxt.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(20, 276);
            label3.Name = "label3";
            label3.Size = new Size(126, 18);
            label3.TabIndex = 9;
            label3.Text = "Phone Number: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(150, 274);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 27);
            textBox1.TabIndex = 8;
            // 
            // addressLbl
            // 
            addressLbl.AutoSize = true;
            addressLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addressLbl.Location = new Point(20, 164);
            addressLbl.Name = "addressLbl";
            addressLbl.Size = new Size(77, 18);
            addressLbl.TabIndex = 7;
            addressLbl.Text = "Address :";
            // 
            // addAddressTxt
            // 
            addAddressTxt.Location = new Point(150, 162);
            addAddressTxt.Multiline = true;
            addAddressTxt.Name = "addAddressTxt";
            addAddressTxt.Size = new Size(328, 88);
            addAddressTxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(20, 120);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 5;
            label2.Text = "Middle Name :";
            // 
            // addMNameTxt
            // 
            addMNameTxt.Location = new Point(150, 118);
            addMNameTxt.Name = "addMNameTxt";
            addMNameTxt.Size = new Size(328, 27);
            addMNameTxt.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(20, 74);
            label1.Name = "label1";
            label1.Size = new Size(103, 18);
            label1.TabIndex = 3;
            label1.Text = "First Name : ";
            // 
            // addFNameTxt
            // 
            addFNameTxt.Location = new Point(150, 72);
            addFNameTxt.Name = "addFNameTxt";
            addFNameTxt.Size = new Size(328, 27);
            addFNameTxt.TabIndex = 2;
            // 
            // addAccNameLbl
            // 
            addAccNameLbl.AutoSize = true;
            addAccNameLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            addAccNameLbl.Location = new Point(20, 32);
            addAccNameLbl.Name = "addAccNameLbl";
            addAccNameLbl.Size = new Size(100, 18);
            addAccNameLbl.TabIndex = 1;
            addAccNameLbl.Text = "Last Name : ";
            // 
            // addLNameTxt
            // 
            addLNameTxt.Location = new Point(150, 30);
            addLNameTxt.Name = "addLNameTxt";
            addLNameTxt.Size = new Size(328, 27);
            addLNameTxt.TabIndex = 0;
            // 
            // userUpdateBtn
            // 
            userUpdateBtn.BackColor = SystemColors.MenuHighlight;
            userUpdateBtn.Cursor = Cursors.Hand;
            userUpdateBtn.FlatAppearance.BorderSize = 0;
            userUpdateBtn.FlatStyle = FlatStyle.Flat;
            userUpdateBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userUpdateBtn.ForeColor = SystemColors.HighlightText;
            userUpdateBtn.Location = new Point(17, 475);
            userUpdateBtn.Margin = new Padding(3, 4, 3, 4);
            userUpdateBtn.Name = "userUpdateBtn";
            userUpdateBtn.Size = new Size(219, 52);
            userUpdateBtn.TabIndex = 10;
            userUpdateBtn.Text = "Update";
            userUpdateBtn.UseVisualStyleBackColor = false;
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
            userRemoveBtn.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            userRemoveBtn.Location = new Point(280, 475);
            userRemoveBtn.Margin = new Padding(3, 4, 3, 4);
            userRemoveBtn.Name = "userRemoveBtn";
            userRemoveBtn.Size = new Size(214, 52);
            userRemoveBtn.TabIndex = 11;
            userRemoveBtn.Text = "Remove";
            userRemoveBtn.UseVisualStyleBackColor = false;
            // 
            // AddUserAccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1031, 545);
            Controls.Add(userRemoveBtn);
            Controls.Add(userUpdateBtn);
            Controls.Add(UserGroupBox);
            Controls.Add(userDesc);
            Controls.Add(useAddLbl);
            Controls.Add(systemUserIcon);
            Name = "AddUserAccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add User Account";
            ((System.ComponentModel.ISupportInitialize)systemUserIcon).EndInit();
            UserGroupBox.ResumeLayout(false);
            UserGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userDesc;
        private Label useAddLbl;
        private PictureBox systemUserIcon;
        private GroupBox UserGroupBox;
        private Label addAccNameLbl;
        private TextBox addLNameTxt;
        private Label addressLbl;
        private TextBox addAddressTxt;
        private Label label2;
        private TextBox addMNameTxt;
        private Label label1;
        private TextBox addFNameTxt;
        private Label addPassLbl;
        private TextBox addPassTxt;
        private Label addUNlbl;
        private TextBox addUsernameTxt;
        private Label label3;
        private TextBox textBox1;
        private Label localNumLbl;
        private TextBox localNumTxt;
        private ComboBox accTypeDropComboBox;
        private Label accTypeLbl;
        private Label confirmPassLbl;
        private TextBox confirmPassTxt;
        private Button userUpdateBtn;
        private Button userRemoveBtn;
    }
}