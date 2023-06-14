﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Future_Craft_Digital;
using Future_Craft_Digital.FCDForms;
using Future_Craft_Digital.Maintenance;
using Future_Craft_Digital.Purchasing_and_Stocks;
using Future_Craft_Digital.Sales_and_Order;

namespace Future_Craft_Digital
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e) 
        {
            if (IsValidLogin(usernameLogin.Text, password.Text))
            {
                ///change  the class name of form
                Ordering_Kiosk activeForm = new Ordering_Kiosk();
                activeForm.Show();
                this.Hide();
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
                //SHzrFtrC12rftDgtl$d0
                {"1" , "1" },
                {"cashier" , "dy39TftrCrftDgtl%JKS" },
                {"sales" , "XsdftrCrftDgtl%23S" },
                {"stock" , "U3T43UftrCrftDgtl%Z" },
            };

            if (userCredentials.ContainsKey(username))
            {
                if (userCredentials[username] == password) { return true; }
            }
            return false;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                // Close the form and stop the program
                this.Close();
                Application.Exit();
            }
        }

    }

}