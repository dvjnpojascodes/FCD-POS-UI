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

            // Enable visual styles
            Application.EnableVisualStyles();

            // Create an instance of the Home form
            Home homeForm = new Home();
            homeForm.Enabled = false; // Set the form as non-clickable
            homeForm.Show(); // Show the Home form

            // Create an instance of the Login form
            Login loginForm = new Login(homeForm);

            // Show the Login form as a modal dialog on top of the Home form
            DialogResult result = loginForm.ShowDialog(homeForm);

            // Check if the login was successful
            if (result == DialogResult.OK)
            {
                // Once the user logs in successfully, allow user interaction with the Home form
                homeForm.Enabled = true;

                // Run the Application's message loop
                Application.Run(homeForm);
            }
            else
            {
                // If the login is not successful or canceled, close the Home form and stop the program
                homeForm.Close();
            }
        }
    }
}
