using QuanLyXeMay.DAO;
using QuanLyXeMay.DTO;
using QuanLyXeMay.Report;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeMay
{
    public partial class fCTHDNhap : Form
    {
        string maCTHDNhap = "";
        string maHDNhap = "";
        string NgayN = "";

        public fCTHDNhap(string hoaDonNhap, string NgayNInput)
        {
            InitializeComponent();

            lblHoaDonNhap.Text = "Chi tiết hóa đơn nhập: " + hoaDonNhap;
            maHDNhap = hoaDonNhap;
            NgayN = NgayNInput;
        }

        private void FCTHDNhap_Load_1(object sender, EventArgs e)
        {
            LoadListCTHDNhap();
        }

        private void ShowCTHDNhap()
        {
            lsvCTHDNhap.Items.Clear();

            List<CTHDNhap> listCTHDNhap = CTHDNhapDAO.Instance.GetCTHDNhapByHoaDonNhap(maHDNhap);

            foreach (CTHDNhap item in listCTHDNhap)
            {
                ListViewItem lsvItem = new ListViewItem(item.MaCTHDNhap);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.SoLuong.ToString());

                lsvCTHDNhap.Items.Add(lsvItem);
            }
        }

        private void LoadListCTHDNhap()
        {
            ShowCTHDNhap();

            lsvCTHDNhap.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvCTHDNhap.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbxMa.DataSource = SanPhamDAO.Instance.GetListSP();
            cbxMa.DisplayMember = "Ten";
        }

        private void LsvCTHDNhap_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lsvCTHDNhap.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvCTHDNhap.SelectedItems[0];

                cbxMa.SelectedIndex = cbxMa.FindStringExact(item.SubItems[1].Text);

                nmSoLuong.Value = Convert.ToInt32(item.SubItems[2].Text);

                maCTHDNhap = item.SubItems[0].Text;
            }
            else
            {
                cbxMa.SelectedIndex = 0;

                maCTHDNhap = string.Empty;
            }
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            string ma = (cbxMa.SelectedItem as SanPham).Ma;

            int soLuong = (int)nmSoLuong.Value;

            //Check So Luong > 0 < 1000
            if (soLuong > 0 && soLuong < 1000)
            {
                //Check có Insert được không
                if (CTHDNhapDAO.Instance.InsertCTHDNhap(maHDNhap, ma, soLuong))
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn nhập thành công!");
                    LoadListCTHDNhap();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm chi tiết hóa đơn nhập!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng trong khoảng 0 -> 100!");
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            //Check có Delete được không
            if (CTHDNhapDAO.Instance.DeleteCTHDNhap(maCTHDNhap))
            {
                MessageBox.Show("Xóa chi tiết hóa đơn nhập thành công!");
                LoadListCTHDNhap();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa chi tiết hóa đơn nhập!");
            }
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            string ma = (cbxMa.SelectedItem as SanPham).Ma;

            int soLuong = (int)nmSoLuong.Value;

            if (soLuong > 0 && soLuong < 1000)
            {
                //Check có Update được không
                if (CTHDNhapDAO.Instance.UpdateCTHDNhap(maCTHDNhap, maHDNhap, ma, soLuong))
                {
                    MessageBox.Show("Sửa chi tiết hóa đơn nhập thành công!");
                    LoadListCTHDNhap();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa chi tiết hóa đơn nhập!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng trong khoảng 0 -> 100!");
            }
        }
        #endregion

        #region Giao diện
        //Hàm di chuyển form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PnlLogo_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        #endregion

        //Hàm Esc để tắt form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Button minimize và close application
        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ReportHDNhap f = new ReportHDNhap(maHDNhap, NgayN);
            f.ShowDialog();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            string query = "SELECT * FROM dbo.CTHDNhap";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            excel.ExportCTHDNhap(data, "Danh sach CTHDNhap", "HÓA ĐƠN NHẬP: " + maHDNhap);
        }
    }
}
