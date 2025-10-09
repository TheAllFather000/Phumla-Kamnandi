using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Presentation
{
    public partial class BankingDetails : Form
    {
        public BankingDetails()
        {
            InitializeComponent();
        }

        private void lblAddGuest_Click(object sender, EventArgs e)
        {
        }

        private void lblSurname_Click(object sender, EventArgs e)
        {

        }

        private void BankingDetails_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void btnGoBackToAddGuest_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFinaliseGuestAccount_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "You will be returned to the Home Page", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                HomePage homePage = new HomePage();
                homePage.ShowDialog();
                this.Hide();
            }
        }

        private void btnFinaliseGuestAccount_Click_1(object sender, EventArgs e)
        {

        }
    }
}
