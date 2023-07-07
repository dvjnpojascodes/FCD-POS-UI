using System;
using System.Threading;
using System.Windows.Forms;
using Future_Craft_Digital.FCDForms;

namespace Future_Craft_Digital
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();


            Home homeForm = new Home();
            homeForm.Enabled = false; 
            homeForm.Show(); 

            Login loginForm = new Login(homeForm);
            DialogResult result = loginForm.ShowDialog(homeForm);

            if (result == DialogResult.OK)
            {
                // If logged in, allow user interaction with the Home form
                homeForm.Enabled = true;
                Application.Run(homeForm);
            }
            else
            {
                homeForm.Close();
            }
        }
    }
}
