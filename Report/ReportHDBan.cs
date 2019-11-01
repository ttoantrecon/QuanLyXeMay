using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeMay.Report
{
    public partial class ReportHDBan : Form
    {
        string maHDBan = "";
        string ngayN = "";
        public ReportHDBan(string maHDBanInput, string ngayNInput)
        {
            InitializeComponent();

            maHDBan = maHDBanInput;
            ngayN = ngayNInput;
        }

        private void ReportHDBan_Load(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=.;Initial Catalog=QuanLyXeMay;Integrated Security=True";
            string query = "EXEC dbo.ViewCTHDBan @maHDBan = '" + maHDBan + "'";
            SqlConnection con = new SqlConnection(connectionSTR);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable("DataSetHDBan");
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSetHDBan", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();

            //ReportParameterCollection reportPara = new ReportParameterCollection();
            //reportPara.Add(new ReportParameter("TenHDBan", maHDBan));
            //this.reportViewer1.LocalReport.SetParameters(reportPara);

            //this.reportViewer1.RefreshReport();

            label1.Text = "Ngày: " + ngayN;
            label2.Text = "Hóa Đơn: " + maHDBan;
        }
    }
}
