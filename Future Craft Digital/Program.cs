using Future_Craft_Digital.Purchasing_and_Stocks;
using Future_Craft_Digital.Sales_and_Order;

namespace Future_Craft_Digital
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Cashiering());
        }
    }
}