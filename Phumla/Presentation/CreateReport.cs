using Phumla.Business;
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
    public partial class CreateReport : Form
    {
        public CreateReport()
        {
            InitializeComponent();
        }

        private void CreateReport_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string period1 = dtpStartDate.Value.ToString();
            string period2 = dtpEndDate.Value.ToString();
            SummaryReport r = new SummaryReport(period1, period2);
            r.GenerateSummaryReport();
        }

        private void btnCreateReport_Click(object sender, EventArgs e)
        {
            string period1 = dtpStartDate.Value.ToString();
            string period2 = dtpEndDate.Value.ToString();
            SummaryReport r = new SummaryReport(period1, period2);
            r.GenerateOccupancyReport();
        }

        private void CreateReport_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            new HomePage();
        }
    }
}
