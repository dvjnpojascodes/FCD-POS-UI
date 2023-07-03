using Future_Craft_Digital.FCDForms;
using Future_Craft_Digital.Maintenance;
using Future_Craft_Digital.Purchasing_and_Stocks;
using Future_Craft_Digital.Sales_and_Order;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future_Craft_Digital
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            UpdateTimeLabel();
            UpdateDateLabel();
        }


        private void productListingBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();

            ProductListingForm prodListingDisplay = new ProductListingForm();
            contentPanel.Controls.Clear();
            prodListingDisplay.TopLevel = false;
            contentPanel.Controls.Add(prodListingDisplay);
            prodListingDisplay.Show();
        }

        private void manageSuppliersBtn_Click(object sender, EventArgs e)
        {
            contentPanel.Controls.Clear();

            ManageSupplierForm manageSuppliersDisplay = new ManageSupplierForm();
            contentPanel.Controls.Clear();
            manageSuppliersDisplay.TopLevel = false;
            contentPanel.Controls.Add(manageSuppliersDisplay);
            manageSuppliersDisplay.Show();
        }

        private void userRecordsBtn_Click(object sender, EventArgs e)
        {
            userRecords userRecordsDisplay = new userRecords();
            userRecordsDisplay.Show();
        }

        private void userLogBtn_Click(object sender, EventArgs e)
        {
            UserLogForm userLogDisplay = new UserLogForm();
            contentPanel.Controls.Clear();
            userLogDisplay.TopLevel = false;
            contentPanel.Controls.Add(userLogDisplay);
            userLogDisplay.Show();
        }

        private void BusinessInfoBtn_Click(object sender, EventArgs e)
        {
            BusinessInfoForm BusinessInfoDisplay = new BusinessInfoForm();
            BusinessInfoDisplay.Show();
        }

        private void OrderAndReceiveBtn_Click(object sender, EventArgs e)
        {
            Order_and_Receive order_ReceiveDisplay = new Order_and_Receive();
            contentPanel.Controls.Clear();
            order_ReceiveDisplay.TopLevel = false;
            contentPanel.Controls.Add(order_ReceiveDisplay);
            order_ReceiveDisplay.Show();
        }

        private void stockMonitorBtn_Click(object sender, EventArgs e)
        {
            Stock_Monitoring stockMonitoringDisplay = new Stock_Monitoring();
            contentPanel.Controls.Clear();
            stockMonitoringDisplay.TopLevel = false;
            contentPanel.Controls.Add(stockMonitoringDisplay);
            stockMonitoringDisplay.Show();
        }

        private void PhysicalCountBtn_Click(object sender, EventArgs e)
        {
            Physical_Counting physicalCountDisplay = new Physical_Counting();
            contentPanel.Controls.Clear();
            physicalCountDisplay.TopLevel = false;
            contentPanel.Controls.Add(physicalCountDisplay);
            physicalCountDisplay.Show();
        }

        private void criticalProductsBtn_Click(object sender, EventArgs e)
        {
            Critical_products criticalProdDisplay = new Critical_products();
            contentPanel.Controls.Clear();
            criticalProdDisplay.TopLevel = false;
            contentPanel.Controls.Add(criticalProdDisplay);
            criticalProdDisplay.Show();
        }

        private void defectivestocksBtn_Click(object sender, EventArgs e)
        {
            Defective_Stocks defectiveStockDisplay = new Defective_Stocks();
            contentPanel.Controls.Clear();
            defectiveStockDisplay.TopLevel = false;
            contentPanel.Controls.Add(defectiveStockDisplay);
            defectiveStockDisplay.Show();
        }

        private void orderingKioskBtn_Click(object sender, EventArgs e)
        {
            Ordering_Kiosk orderKioskDisplay = new Ordering_Kiosk();
            contentPanel.Controls.Clear();
            orderKioskDisplay.TopLevel = false;
            contentPanel.Controls.Add(orderKioskDisplay);
            orderKioskDisplay.Show();
        }

        private void CashieringBtn_Click(object sender, EventArgs e)
        {
            Cashiering cashieringDisplay = new Cashiering();
            contentPanel.Controls.Clear();
            cashieringDisplay.TopLevel = false;
            contentPanel.Controls.Add(cashieringDisplay);
            cashieringDisplay.Show();
        }

        private void salesReceiptBtn_Click(object sender, EventArgs e)
        {
            Sales_Receipt saleReceiptDisplay = new Sales_Receipt();
            contentPanel.Controls.Clear();
            saleReceiptDisplay.TopLevel = false;
            contentPanel.Controls.Add(saleReceiptDisplay);
            saleReceiptDisplay.Show();
        }

        private void OrderAndReceiveBtn_Click_1(object sender, EventArgs e)
        {
            Order_and_Receive orderReceiveDisplay = new Order_and_Receive();
            contentPanel.Controls.Clear();
            orderReceiveDisplay.TopLevel = false;
            contentPanel.Controls.Add(orderReceiveDisplay);
            orderReceiveDisplay.Show();
        }

        private void stockMonitorBtn_Click_1(object sender, EventArgs e)
        {
            Stock_Monitoring stockMonitoringDisplay = new Stock_Monitoring();
            contentPanel.Controls.Clear();
            stockMonitoringDisplay.TopLevel = false;
            contentPanel.Controls.Add(stockMonitoringDisplay);
            stockMonitoringDisplay.Show();
        }

        private void criticalProductsBtn_Click_1(object sender, EventArgs e)
        {
            Critical_products criticalProdDisplay = new Critical_products();
            contentPanel.Controls.Clear();
            criticalProdDisplay.TopLevel = false;
            contentPanel.Controls.Add(criticalProdDisplay);
            criticalProdDisplay.Show();
        }

        private void defectivestocksBtn_Click_1(object sender, EventArgs e)
        {
            Defective_Stocks defectStockDisplay = new Defective_Stocks();
            contentPanel.Controls.Clear();
            defectStockDisplay.TopLevel = false;
            contentPanel.Controls.Add(defectStockDisplay);
            defectStockDisplay.Show();
        }

        private void orderingKioskBtn_Click_1(object sender, EventArgs e)
        {
            Ordering_Kiosk orderingKioskDisplay = new Ordering_Kiosk();
            contentPanel.Controls.Clear();
            orderingKioskDisplay.TopLevel = false;
            contentPanel.Controls.Add(orderingKioskDisplay);
            orderingKioskDisplay.Show();
        }

        private void CashieringBtn_Click_1(object sender, EventArgs e)
        {
            Cashiering CashieringDisplay = new Cashiering();
            contentPanel.Controls.Clear();
            CashieringDisplay.TopLevel = false;
            contentPanel.Controls.Add(CashieringDisplay);
            CashieringDisplay.Show();
        }

        private void salesReceiptBtn_Click_1(object sender, EventArgs e)
        {
            Sales_Receipt salesReceiptDisplay = new Sales_Receipt();
            contentPanel.Controls.Clear();
            salesReceiptDisplay.TopLevel = false;
            contentPanel.Controls.Add(salesReceiptDisplay);
            salesReceiptDisplay.Show();
        }

        private void UpdateTimeLabel()
        {
            DateTime currentTime = DateTime.Now;
            string formattedTime = currentTime.ToString("h:mm:ss tt");
            timeLbl.Text = formattedTime;
        }

        private void UpdateDateLabel()
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dddd, MMMM dd, yyyy");
            dateLbl.Text = formattedDate;
        }
    }
}
