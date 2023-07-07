
namespace Future_Craft_Digital
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            loginLogoBox = new PictureBox();
            usernameLogin = new TextBox();
            password = new TextBox();
            usernameLoginLbl = new Label();
            pwdLoginLbl = new Label();
            BtnCancel = new Button();
            BtnLogin = new Button();
            BtnServerSetting = new Button();
            loginIcon = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)loginLogoBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)loginIcon).BeginInit();
            SuspendLayout();
            // 
            // loginLogoBox
            // 
            loginLogoBox.Image = (Image)resources.GetObject("loginLogoBox.Image");
            loginLogoBox.InitialImage = (Image)resources.GetObject("loginLogoBox.InitialImage");
            loginLogoBox.Location = new Point(38, -22);
            loginLogoBox.Name = "loginLogoBox";
            loginLogoBox.Size = new Size(585, 264);
            loginLogoBox.SizeMode = PictureBoxSizeMode.StretchImage;
            loginLogoBox.TabIndex = 0;
            loginLogoBox.TabStop = false;
            // 
            // usernameLogin
            // 
            usernameLogin.Location = new Point(309, 223);
            usernameLogin.Margin = new Padding(5);
            usernameLogin.Name = "usernameLogin";
            usernameLogin.Size = new Size(314, 26);
            usernameLogin.TabIndex = 1;
            // 
            // password
            // 
            password.Location = new Point(309, 270);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(314, 26);
            password.TabIndex = 2;
            // 
            // usernameLoginLbl
            // 
            usernameLoginLbl.AutoSize = true;
            usernameLoginLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            usernameLoginLbl.Location = new Point(206, 227);
            usernameLoginLbl.Name = "usernameLoginLbl";
            usernameLoginLbl.Size = new Size(92, 18);
            usernameLoginLbl.TabIndex = 3;
            usernameLoginLbl.Text = "Username :";
            // 
            // pwdLoginLbl
            // 
            pwdLoginLbl.AutoSize = true;
            pwdLoginLbl.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            pwdLoginLbl.Location = new Point(206, 275);
            pwdLoginLbl.Name = "pwdLoginLbl";
            pwdLoginLbl.Size = new Size(90, 18);
            pwdLoginLbl.TabIndex = 4;
            pwdLoginLbl.Text = "Password :";
            // 
            // BtnCancel
            // 
            BtnCancel.BackColor = SystemColors.HighlightText;
            BtnCancel.FlatAppearance.BorderSize = 0;
            BtnCancel.FlatStyle = FlatStyle.Flat;
            BtnCancel.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnCancel.ForeColor = SystemColors.ControlText;
            BtnCancel.Location = new Point(485, 341);
            BtnCancel.Name = "BtnCancel";
            BtnCancel.Size = new Size(136, 43);
            BtnCancel.TabIndex = 5;
            BtnCancel.Text = "Cancel";
            BtnCancel.UseVisualStyleBackColor = false;
            BtnCancel.Click += cancelBtn_Click;
            // 
            // BtnLogin
            // 
            BtnLogin.BackColor = SystemColors.MenuHighlight;
            BtnLogin.FlatAppearance.BorderSize = 0;
            BtnLogin.FlatStyle = FlatStyle.Flat;
            BtnLogin.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnLogin.ForeColor = SystemColors.ButtonHighlight;
            BtnLogin.Location = new Point(309, 341);
            BtnLogin.Name = "BtnLogin";
            BtnLogin.Size = new Size(136, 43);
            BtnLogin.TabIndex = 6;
            BtnLogin.Text = "Login";
            BtnLogin.UseVisualStyleBackColor = false;
            BtnLogin.Click += loginBtn_Click;
            // 
            // BtnServerSetting
            // 
            BtnServerSetting.BackColor = SystemColors.ControlLightLight;
            BtnServerSetting.FlatAppearance.BorderSize = 0;
            BtnServerSetting.FlatStyle = FlatStyle.Flat;
            BtnServerSetting.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point);
            BtnServerSetting.Location = new Point(38, 341);
            BtnServerSetting.Name = "BtnServerSetting";
            BtnServerSetting.Size = new Size(178, 43);
            BtnServerSetting.TabIndex = 7;
            BtnServerSetting.Text = "Server Settings";
            BtnServerSetting.UseVisualStyleBackColor = false;
            // 
            // loginIcon
            // 
            loginIcon.Image = (Image)resources.GetObject("loginIcon.Image");
            loginIcon.Location = new Point(38, 176);
            loginIcon.Name = "loginIcon";
            loginIcon.Size = new Size(162, 133);
            loginIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            loginIcon.TabIndex = 8;
            loginIcon.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(662, 408);
            ControlBox = false;
            Controls.Add(loginIcon);
            Controls.Add(BtnServerSetting);
            Controls.Add(BtnLogin);
            Controls.Add(BtnCancel);
            Controls.Add(pwdLoginLbl);
            Controls.Add(usernameLoginLbl);
            Controls.Add(password);
            Controls.Add(usernameLogin);
            Controls.Add(loginLogoBox);
            Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Future Craft Digital";
            ((System.ComponentModel.ISupportInitialize)loginLogoBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)loginIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox loginLogoBox;
        private TextBox usernameLogin;
        private TextBox password;
        private Label usernameLoginLbl;
        private Label pwdLoginLbl;
        private Button BtnCancel;
        private Button BtnLogin;
        private Button BtnServerSetting;
        private PictureBox loginIcon;
    }
}

