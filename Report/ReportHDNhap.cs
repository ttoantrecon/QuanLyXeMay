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
    public partial class ReportHDNhap : Form
    {
        string maHDNhap = "";
        string ngayN = "";

        public ReportHDNhap(string maHDNhapInput, string ngayNInput)
        {
            InitializeComponent();

            maHDNhap = maHDNhapInput;
            ngayN = ngayNInput;
        }

        private void ReportHDNhap_Load(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=.;Initial Catalog=QuanLyXeMay;Integrated Security=True";
            string query = "EXEC dbo.ViewCTHDNhap @maHDNhap = '" + maHDNhap + "'";
            SqlConnection con = new SqlConnection(connectionSTR);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable("DataSetHDNhap");
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSetHDNhap", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();

            label1.Text = "Ngày: " + ngayN;
            label2.Text = "Hóa Đơn: " + maHDNhap;
        }
    }
}
