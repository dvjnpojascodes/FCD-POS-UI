
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
            this.loginLogoBox = new System.Windows.Forms.PictureBox();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.usernameLoginLbl = new System.Windows.Forms.Label();
            this.pwdLoginLbl = new System.Windows.Forms.Label();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.loginBtn = new System.Windows.Forms.Button();
            this.serverSettingBtn = new System.Windows.Forms.Button();
            this.loginIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loginLogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLogoBox
            // 
            this.loginLogoBox.Image = ((System.Drawing.Image)(resources.GetObject("loginLogoBox.Image")));
            this.loginLogoBox.InitialImage = ((System.Drawing.Image)(resources.GetObject("loginLogoBox.InitialImage")));
            this.loginLogoBox.Location = new System.Drawing.Point(38, -22);
            this.loginLogoBox.Name = "loginLogoBox";
            this.loginLogoBox.Size = new System.Drawing.Size(585, 264);
            this.loginLogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginLogoBox.TabIndex = 0;
            this.loginLogoBox.TabStop = false;
            // 
            // usernameLogin
            // 
            this.usernameLogin.Location = new System.Drawing.Point(309, 223);
            this.usernameLogin.Margin = new System.Windows.Forms.Padding(5);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(314, 26);
            this.usernameLogin.TabIndex = 1;
            // 
            // password
            // 
            this.password.Location = new System.Drawing.Point(309, 270);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(314, 26);
            this.password.TabIndex = 2;
            // 
            // usernameLoginLbl
            // 
            this.usernameLoginLbl.AutoSize = true;
            this.usernameLoginLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginLbl.Location = new System.Drawing.Point(206, 227);
            this.usernameLoginLbl.Name = "usernameLoginLbl";
            this.usernameLoginLbl.Size = new System.Drawing.Size(92, 18);
            this.usernameLoginLbl.TabIndex = 3;
            this.usernameLoginLbl.Text = "Username :";
            // 
            // pwdLoginLbl
            // 
            this.pwdLoginLbl.AutoSize = true;
            this.pwdLoginLbl.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLoginLbl.Location = new System.Drawing.Point(206, 275);
            this.pwdLoginLbl.Name = "pwdLoginLbl";
            this.pwdLoginLbl.Size = new System.Drawing.Size(90, 18);
            this.pwdLoginLbl.TabIndex = 4;
            this.pwdLoginLbl.Text = "Password :";
            // 
            // cancelBtn
            // 
            this.cancelBtn.BackColor = System.Drawing.SystemColors.HighlightText;
            this.cancelBtn.FlatAppearance.BorderSize = 0;
            this.cancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelBtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.cancelBtn.Location = new System.Drawing.Point(485, 341);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(136, 43);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = false;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginBtn.Location = new System.Drawing.Point(309, 341);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(136, 43);
            this.loginBtn.TabIndex = 6;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // serverSettingBtn
            // 
            this.serverSettingBtn.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.serverSettingBtn.FlatAppearance.BorderSize = 0;
            this.serverSettingBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.serverSettingBtn.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverSettingBtn.Location = new System.Drawing.Point(38, 341);
            this.serverSettingBtn.Name = "serverSettingBtn";
            this.serverSettingBtn.Size = new System.Drawing.Size(178, 43);
            this.serverSettingBtn.TabIndex = 7;
            this.serverSettingBtn.Text = "Server Settings";
            this.serverSettingBtn.UseVisualStyleBackColor = false;
            // 
            // loginIcon
            // 
            this.loginIcon.Image = ((System.Drawing.Image)(resources.GetObject("loginIcon.Image")));
            this.loginIcon.Location = new System.Drawing.Point(38, 176);
            this.loginIcon.Name = "loginIcon";
            this.loginIcon.Size = new System.Drawing.Size(162, 133);
            this.loginIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginIcon.TabIndex = 8;
            this.loginIcon.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 408);
            this.ControlBox = false;
            this.Controls.Add(this.loginIcon);
            this.Controls.Add(this.serverSettingBtn);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.pwdLoginLbl);
            this.Controls.Add(this.usernameLoginLbl);
            this.Controls.Add(this.password);
            this.Controls.Add(this.usernameLogin);
            this.Controls.Add(this.loginLogoBox);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Future Craft Digital";
            ((System.ComponentModel.ISupportInitialize)(this.loginLogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox loginLogoBox;
        private System.Windows.Forms.TextBox usernameLogin;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label usernameLoginLbl;
        private System.Windows.Forms.Label pwdLoginLbl;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Button serverSettingBtn;
        private System.Windows.Forms.PictureBox loginIcon;
    }
}

