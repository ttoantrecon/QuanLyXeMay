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
    public partial class UC_HoaDonNhap : UserControl
    {
        public UC_HoaDonNhap()
        {
            InitializeComponent();
        }

        private void UC_HoaDonNhap_Load(object sender, EventArgs e)
        {
            LoadListHoaDonNhap();
        }

        private void ShowHoaDonNhap(List<HoaDonNhap> listHoaDonNhap)
        {
            lsvHoaDonNhap.Items.Clear();

            foreach (HoaDonNhap item in listHoaDonNhap)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.MaNV);
                lsvItem.SubItems.Add(item.NhaCC);
                lsvItem.SubItems.Add(item.NgayNhap.ToString("dd/MM/yyyy"));

                lsvHoaDonNhap.Items.Add(lsvItem);
            }
        }

        public void LoadListHoaDonNhap()
        {
            List<HoaDonNhap> listHoaDonNhap = HoaDonNhapDAO.Instance.GetListHoaDonNhap();

            ShowHoaDonNhap(listHoaDonNhap);

            lsvHoaDonNhap.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvHoaDonNhap.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            LoadComboBox();
        }

        private void LoadComboBox()
        {
            cbxMaNV.DataSource = NhanVienDAO.Instance.GetListNhanVien();
            cbxMaNV.DisplayMember = "Ma";
        }

        private void LsvHoaDonNhap_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvHoaDonNhap.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvHoaDonNhap.SelectedItems[0];
                txbMa.Text = item.SubItems[0].Text;
                cbxMaNV.SelectedIndex = cbxMaNV.FindStringExact(item.SubItems[1].Text);
                txbNhaCC.Text = item.SubItems[2].Text;
                string[] NgayNhap = item.SubItems[3].Text.Split(' ');
                string[] NgayThangNam = NgayNhap[0].Split('/');
                dtpNgayNhap.Value = new DateTime(Convert.ToInt32(NgayThangNam[2]), Convert.ToInt32(NgayThangNam[1]), Convert.ToInt32(NgayThangNam[0]));

            }
            else
            {
                txbMa.Text = string.Empty;
                cbxMaNV.SelectedIndex = 0;
                txbNhaCC.Text = string.Empty;
                dtpNgayNhap.Value = DateTime.Now;
            }
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string maNV = (cbxMaNV.SelectedItem as NhanVien).Ma;
            string nhaCC = txbNhaCC.Text;
            DateTime ngayNhap = dtpNgayNhap.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma, nhaCC) == "")
            {
                //Check Mã có bị trùng chưa
                if (CheckMa(ma))
                {
                    //Check có Insert được không
                    if (HoaDonNhapDAO.Instance.InsertHoaDonNhap(ma, maNV, nhaCC, ngayNhap))
                    {
                        MessageBox.Show("Thêm hóa đơn nhập thành công!");
                        LoadListHoaDonNhap();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm hóa đơn nhập!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, nhaCC) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;

            if (HoaDonNhapDAO.Instance.DeleteHoaDonNhap(ma))
            {
                MessageBox.Show("Xóa hóa đơn nhập thành công!");
                LoadListHoaDonNhap();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa hóa đơn nhập!");
            }
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string maNV = (cbxMaNV.SelectedItem as NhanVien).Ma;
            string nhaCC = txbNhaCC.Text;
            DateTime ngayNhap = dtpNgayNhap.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma, nhaCC) == "")
            {
                //Check có Update được không
                if (HoaDonNhapDAO.Instance.UpdateHoaDonNhap(ma, maNV, nhaCC, ngayNhap))
                {
                    MessageBox.Show("Sửa hóa đơn nhập thành công!");
                    LoadListHoaDonNhap();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa hóa đơn nhập!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, nhaCC) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private bool CheckMa(string ma)
        {
            List<HoaDonNhap> HoaDonNhap = HoaDonNhapDAO.Instance.GetListHoaDonNhap();
            foreach (HoaDonNhap item in HoaDonNhap)
            {
                if (item.Ma == ma)
                {
                    return false;
                }
            }
            return true;
        }

        private string CheckInput(string ma, string nhaCC)
        {
            string result = "";
            if (ma == string.Empty)
            {
                result += "mã, ";
            }
            if (nhaCC == string.Empty)
            {
                result += "nhà CC, ";
            }

            return result;
        }
        #endregion

        //Event Click Button Xem
        private void BtnShow_Click(object sender, EventArgs e)
        {
            if (lsvHoaDonNhap.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvHoaDonNhap.SelectedItems[0];
                string hoaDonNhap = item.SubItems[0].Text;
                string NgayN = item.SubItems[3].Text;
                fCTHDNhap f = new fCTHDNhap(hoaDonNhap, NgayN);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để xem CTHD!");
            }
        }

        //Event Double Click on List View
        private void LsvHoaDonNhap_DoubleClick(object sender, EventArgs e)
        {
            if (lsvHoaDonNhap.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvHoaDonNhap.SelectedItems[0];
                string hoaDonNhap = item.SubItems[0].Text;
                string NgayN = item.SubItems[3].Text;
                fCTHDNhap f = new fCTHDNhap(hoaDonNhap, NgayN);
                f.ShowDialog();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn 1 hóa đơn để xem CTHD!");
            }
        }

        private void TxbSearchHDNhap_TextChanged(object sender, EventArgs e)
        {
            List<HoaDonNhap> listHDNhap = HoaDonNhapDAO.Instance.SearchHDNhap(txbSearchHDNhap.Text);
            ShowHoaDonNhap(listHDNhap);
        }

        private void TxbSearchHDNhap_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Clear();
            txbSearchHDNhap.ForeColor = Color.Black;
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            string query = "SELECT * FROM dbo.HoaDonNhap";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            excel.ExportHoaDonNhap(data, "Danh sach HDN", "DANH SÁCH HÓA ĐƠN NHẬP");
        }
    }
}
