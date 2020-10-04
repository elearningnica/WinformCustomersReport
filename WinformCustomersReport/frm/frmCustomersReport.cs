using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformCustomersReport.frm
{
    public partial class frmCustomersReport : Form
    {
        public frmCustomersReport()
        {
            InitializeComponent();
        }

        private void btnExportToPDF_Click(object sender, EventArgs e)
        {
            rpt.rptCustomers report = new rpt.rptCustomers();
            report.RequestParameters = false;
            report.ExportToPdf("Customers.pdf"); //export to pdf on the debug folder
        }
    }
}
