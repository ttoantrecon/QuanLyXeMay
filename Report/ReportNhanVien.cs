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
    public partial class ReportNhanVien : Form
    {
        public ReportNhanVien()
        {
            InitializeComponent();
        }

        private void ReportNhanVien_Load(object sender, EventArgs e)
        {
            string connectionSTR = @"Data Source=.;Initial Catalog=QuanLyXeMay;Integrated Security=True";
            string query = "SELECT * FROM dbo.NhanVien";
            SqlConnection con = new SqlConnection(connectionSTR);
            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable("DataSetNV");
            da.Fill(dt);
            ReportDataSource rds = new ReportDataSource("DataSetNV", dt);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }
    }
}
