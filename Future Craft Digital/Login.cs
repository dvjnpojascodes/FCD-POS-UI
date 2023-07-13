using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Future_Craft_Digital
{
    public partial class Login : Form
    {
        private Home homeForm; // Reference to the Home form

        public Login(Home homeForm)
        {
            InitializeComponent();
            this.homeForm = homeForm;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (IsValidLogin(txtUsername.Text, txtPassword.Text))
            {
                // Set the DialogResult to OK to indicate a successful login
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }
        }

        private bool IsValidLogin(string username, string password)
        {
            Dictionary<string, string> userCredentials = new Dictionary<string, string>
            {
                {"admin", "SHzrFtrC12rftDgtl$d0"},
                {"cashier", "dy39TftrCrftDgtl%JKS"},
                {"sales", "XsdftrCrftDgtl%23S"},
                {"stock", "U3T43UftrCrftDgtl%Z"},
            };

            if (userCredentials.ContainsKey(username))
            {
                if (userCredentials[username] == password) { return true; }
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Close the form and set the DialogResult to Cancel to indicate an unsuccessful login
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }
    }
}
