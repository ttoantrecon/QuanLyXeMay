using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyXeMay.DTO;
using QuanLyXeMay.DAO;

namespace QuanLyXeMay
{
    public partial class UC_HoaDonBan : UserControl
    {
        public UC_HoaDonBan()
        {
            InitializeComponent();
        }

        private void UC_HoaDonBan_Load(object sender, EventArgs e)
        {
            LoadListHoaDonBan();
        }

        private void ShowHoaDonBan(List<HoaDonBan> listHoaDonBan)
        {
            lsvHoaDonBan.Items.Clear();

            foreach (HoaDonBan item in listHoaDonBan)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.MaNV);
                lsvItem.SubItems.Add(item.MaKH);
                lsvItem.SubItems.Add(item.NgayNhap.ToString("dd/MM/yyyy"));

                lsvHoaDonBan.Items.Add(lsvItem);
            }
        }

        public void LoadListHoaDonBan()
        {
            List<HoaDonBan> listHoaDonBan = HoaDonBanDAO.Instance.GetListHoaDonBan();

            ShowHoaDonBan(listHoaDonBan);
            
            lsvHoaDonBan.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvHoaDonBan.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbxMaNV.DataSource = NhanVienDAO.Instance.GetListNhanVien();
            cbxMaNV.DisplayMember = "Ma";
            cbxMaKH.DataSource = KhachHangDAO.Instance.GetListKhachHang();
            cbxMaKH.DisplayMember = "Ma";
        }

        private void LsvHoaDonBan_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (lsvHoaDonBan.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvHoaDonBan.SelectedItems[0];
                txbMa.Text = item.SubItems[0].Text;
                cbxMaNV.SelectedIndex = cbxMaNV.FindStringExact(item.SubItems[1].Text);
                cbxMaKH.SelectedIndex = cbxMaKH.FindStringExact(item.SubItems[2].Text);
                string[] NgayNhap = item.SubItems[3].Text.Split(' ');
                string[] NgayThangNam = NgayNhap[0].Split('/');
                dtpNgayNhap.Value = new DateTime(Convert.ToInt32(NgayThangNam[2]), Convert.ToInt32(NgayThangNam[1]), Convert.ToInt32(NgayThangNam[0]));

            }
            else
            {
                txbMa.Text = string.Empty;
                cbxMaNV.SelectedIndex = 0;
                cbxMaKH.SelectedIndex = 0;
                dtpNgayNhap.Value = DateTime.Now;
            }
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string maNV = (cbxMaNV.SelectedItem as NhanVien).Ma;
            string maKH = (cbxMaKH.SelectedItem as KhachHang).Ma;
            DateTime ngayNhap = dtpNgayNhap.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma) == "")
            {
                //Check Mã có bị trùng chưa
                if (CheckMa(ma))
                {
                    //Check có Insert được không
                    if (HoaDonBanDAO.Instance.InsertHoaDonBan(ma, maNV, maKH, ngayNhap))
                    {
                        MessageBox.Show("Thêm hóa đơn bán thành công!");
                        LoadListHoaDonBan();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm hóa đơn bán!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;

            if (HoaDonBanDAO.Instance.DeleteHoaDonBan(ma))
            {
                MessageBox.Show("Xóa hóa đơn bán thành công!");
                LoadListHoaDonBan();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa hóa đơn bán!");
            }
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string maNV = (cbxMaNV.SelectedItem as NhanVien).Ma;
            string maKH = (cbxMaKH.SelectedItem as KhachHang).Ma;
            DateTime ngayNhap = dtpNgayNhap.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma) == "")
            {
                //Check có Update được không
                if (HoaDonBanDAO.Instance.UpdateHoaDonBan(ma, maNV, maKH, ngayNhap))
                {
                    MessageBox.Show("Sửa hóa đơn bán thành công!");
                    LoadListHoaDonBan();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa hóa đơn bán!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private bool CheckMa(string ma)
        {
            List<HoaDonBan> HoaDonBan = HoaDonBanDAO.Instance.GetListHoaDonBan();
            foreach (HoaDonBan item in HoaDonBan)
            {
                if (item.Ma == ma)
                {
                    return false;
                }
            }
            return true;
        }

        private string CheckInput(string ma)
        {
            string result = "";
            if (ma == string.Empty)
            {
                result += "mã, ";
            }

            return result;
        }
        #endregion

        //Event Click Button Xem
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (lsvHoaDonBan.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvHoaDonBan.SelectedItems[0];
                string hoaDonBan = item.SubItems[0].Text;
                string ngayN = item.SubItems[3].Text;
                fCTHDBan f = new fCTHDBan(hoaDonBan, ngayN);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để xem CTHD!");
            }
        }

        //Event Double Click on List View
        private void LsvHoaDonBan_DoubleClick(object sender, EventArgs e)
        {
            if (lsvHoaDonBan.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvHoaDonBan.SelectedItems[0];
                string hoaDonBan = item.SubItems[0].Text;
                string ngayN = item.SubItems[3].Text;
                fCTHDBan f = new fCTHDBan(hoaDonBan, ngayN);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để xem CTHD!");
            }
        }

        private void TxbSearchHDBan_TextChanged(object sender, EventArgs e)
        {
            List<HoaDonBan> listXe = HoaDonBanDAO.Instance.SearchHDBan(txbSearchHDBan.Text);
            ShowHoaDonBan(listXe);
        }

        private void TxbSearchHDBan_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Clear();
            txbSearchHDBan.ForeColor = Color.Black;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            string query = "SELECT * FROM dbo.HoaDonBan";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            excel.ExportHoaDonBan(data, "Danh sach HDB", "DANH SÁCH HÓA ĐƠN BÁN");
        }
    }
}
