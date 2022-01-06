using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using QLKSThangLong.Model;

namespace QLKSThangLong.Reports
{
    public partial class frptHoaDon : Form
    {
        public frptHoaDon()
        {
            InitializeComponent();
        }
        DbContextQLKS db = new DbContextQLKS();

        private void frptHoaDon_Load(object sender, EventArgs e)
        {
            List<HOADON> listHoaDon = db.HOADONs.ToList(); 
            this.reportViewer1.LocalReport.ReportPath = "Reports/rptHoaDon.rdlc";
            var reportDataSource = new ReportDataSource("DataSetHD", listHoaDon);
            this.reportViewer1.LocalReport.DataSources.Clear();  
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            this.reportViewer1.RefreshReport(); 

        }
    }
}
