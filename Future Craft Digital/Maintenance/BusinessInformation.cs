using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Future_Craft_Digital.FCDForms
{
    public partial class BusinessInfoForm : Form
    {
        public BusinessInfoForm()
        {
            InitializeComponent();
        }

        private void BusinessInformation_Load(object sender, EventArgs e)
        {

        }

        private void businessInfoCloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
