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
    public partial class fCTHDBan : Form
    {
        string maCTHDBan = "";
        string maHDBan = "";
        string ngayN = "";

        public fCTHDBan(string hoaDonBan, string ngayNInput)
        {
            InitializeComponent();

            lblHoaDonBan.Text = "Chi tiết hóa đơn bán: " + hoaDonBan;
            maHDBan = hoaDonBan;
            ngayN = ngayNInput;
        }

        private void FCTHDBan_Load(object sender, EventArgs e)
        {
            LoadListCTHDBan();
        }

        private void ShowCTHDBan()
        {
            lsvCTHDBan.Items.Clear();

            List<CTHDBan> listCTHDBan = CTHDBanDAO.Instance.GetCTHDBanByHoaDonBan(maHDBan);

            foreach (CTHDBan item in listCTHDBan)
            {
                ListViewItem lsvItem = new ListViewItem(item.MaCTHDBan);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.SoLuong.ToString());

                lsvCTHDBan.Items.Add(lsvItem);
            }
        }

        private void LoadListCTHDBan()
        {
            ShowCTHDBan();

            lsvCTHDBan.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvCTHDBan.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbxMa.DataSource = SanPhamDAO.Instance.GetListSP();
            cbxMa.DisplayMember = "Ten";
        }

        private void LsvCTHDBan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvCTHDBan.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvCTHDBan.SelectedItems[0];

                cbxMa.SelectedIndex = cbxMa.FindStringExact(item.SubItems[1].Text);

                nmSoLuong.Value = Convert.ToInt32(item.SubItems[2].Text);

                maCTHDBan = item.SubItems[0].Text;
            }
            else
            {
                cbxMa.SelectedIndex = 0;

                maCTHDBan = string.Empty;
            }
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string ma = (cbxMa.SelectedItem as SanPham).Ma;

            int soLuong = (int)nmSoLuong.Value;

            //Check So Luong > 0 < 1000
            if (soLuong > 0 && soLuong < 1000)
            {
                //Check có Insert được không
                if (CTHDBanDAO.Instance.InsertCTHDBan(maHDBan, ma, soLuong))
                {
                    MessageBox.Show("Thêm chi tiết hóa đơn bán thành công!");
                    LoadListCTHDBan();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi thêm chi tiết hóa đơn bán!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số lượng trong khoảng 0 -> 100!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CTHDBanDAO.Instance.DeleteCTHDBan(maCTHDBan))
            {
                MessageBox.Show("Xóa chi tiết hóa đơn bán thành công!");
                LoadListCTHDBan();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa chi tiết hóa đơn bán!");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string ma = (cbxMa.SelectedItem as SanPham).Ma;

            int soLuong = (int)nmSoLuong.Value;

            if (soLuong > 0 && soLuong < 1000)
            {
                //Check có Update được không
                if (CTHDBanDAO.Instance.UpdateCTHDBan(maCTHDBan, maHDBan, ma, soLuong))
                {
                    MessageBox.Show("Sửa chi tiết hóa đơn bán thành công!");
                    LoadListCTHDBan();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa chi tiết hóa đơn bán!");
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

        private void LblExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ReportHDBan f = new ReportHDBan(maHDBan, ngayN);
            f.ShowDialog();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            string query = "SELECT * FROM dbo.CTHDBan";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            excel.ExportCTHDBan(data, "Danh sach CTHDBan", "HÓA ĐƠN BÁN: " + maHDBan);
        }
    }
}
