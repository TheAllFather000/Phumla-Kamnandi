using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phumla.Presentation
{
    public partial class BankDetailsControl : UserControl
    {
        public event EventHandler GoBack;
        public BankDetailsControl()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ShowTime");
            GoBack?.Invoke(this, EventArgs.Empty); // Fires the event to the parent
        }
    }
}
