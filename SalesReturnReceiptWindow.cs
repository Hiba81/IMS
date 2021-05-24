using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ims
{
    public partial class SalesReturnReceiptWindow : Form
    {
        public SalesReturnReceiptWindow()
        {
            InitializeComponent();
        }
        retrieval r = new retrieval();
        ReportDocument rd = new ReportDocument();
        private void SalesReturnReceiptWindow_Load(object sender, EventArgs e)
        {
            rd= new ReportDocument();
            r.showReport("RefundInvoiceReport.rpt",rd, crystalReportViewer2, "st_getrefundInvoice","@saleid","3456");
        }
    }
}
