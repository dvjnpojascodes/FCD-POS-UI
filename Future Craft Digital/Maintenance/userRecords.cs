using System;
using System.Windows.Forms;

namespace Future_Craft_Digital.Maintenance
{
    public partial class userRecords : Form
    {
        public userRecords()
        {
            InitializeComponent();
        }

        private void userCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void userAddBtn_Click(object sender, EventArgs e)
        {
            AddUserAccountForm addUser = new AddUserAccountForm();
            addUser.Show();
        }

        private void userRemoveBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this profile?", "System User Profile", MessageBoxButtons.YesNo);
        }
    }
}
