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
using QuanLyXeMay.Report;
using System.Globalization;

namespace QuanLyXeMay
{
    public partial class UC_NhanVien : UserControl
    {
        public UC_NhanVien()
        {
            InitializeComponent();
        }

        private void UC_NhanVien_Load(object sender, EventArgs e)
        {
            LoadListNhanVien();
        }

        private void ShowNhanVien(List<NhanVien> listNhanVien)
        {
            lsvNhanVien.Items.Clear();

            foreach (NhanVien item in listNhanVien)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.DiaChi);
                lsvItem.SubItems.Add(item.NgaySinh.ToString("dd/MM/yyyy"));
                lsvItem.SubItems.Add(item.GioiTinh);
                lsvItem.SubItems.Add(item.CMND);
                lsvItem.SubItems.Add(item.SDT);
                lsvItem.SubItems.Add(item.Luong.ToString("C0"));

                lsvNhanVien.Items.Add(lsvItem);
            }
        }

        public void LoadListNhanVien()
        {
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.GetListNhanVien();

            ShowNhanVien(listNhanVien);

            lsvNhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvNhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            cbxGioiTinh.SelectedIndex = 0;
        }

        private void LsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvNhanVien.SelectedItems[0];
                txbMa.Text = item.SubItems[0].Text;
                txbTen.Text = item.SubItems[1].Text;
                txbDiaChi.Text = item.SubItems[2].Text;
                string[] NgayThangNam = item.SubItems[3].Text.Split('/');
                dtpNgaySinh.Value = new DateTime(Convert.ToInt32(NgayThangNam[2]), Convert.ToInt32(NgayThangNam[1]), Convert.ToInt32(NgayThangNam[0]));
                cbxGioiTinh.SelectedIndex = cbxGioiTinh.FindStringExact(item.SubItems[4].Text);
                txbCMND.Text = item.SubItems[5].Text;
                txbSDT.Text = item.SubItems[6].Text;
                nmLuong.Value = int.Parse(item.SubItems[7].Text, NumberStyles.Currency);
            }
            else
            {
                txbMa.Text = string.Empty;
                txbTen.Text = string.Empty;
                txbDiaChi.Text = string.Empty;
                dtpNgaySinh.Value = DateTime.Now;
                cbxGioiTinh.SelectedIndex = 0;
                txbCMND.Text = string.Empty;
                txbSDT.Text = string.Empty;
                nmLuong.Value = 0;
            }
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string ten = txbTen.Text;
            string diaChi = txbDiaChi.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = cbxGioiTinh.SelectedItem.ToString();
            string cmnd = txbCMND.Text;
            string sdt = txbSDT.Text;
            long luong = (long)nmLuong.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma, ten, diaChi, cmnd, sdt) == "")
            {
                //Check Mã có bị trùng chưa
                if (CheckMa(ma))
                {
                    //Check có Insert được không
                    if (NhanVienDAO.Instance.InsertNhanVien(ma, ten, diaChi, ngaySinh, gioiTinh, cmnd, sdt, luong))
                    {
                        MessageBox.Show("Thêm nhân viên thành công!");
                        LoadListNhanVien();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm nhân viên!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, ten, diaChi, cmnd, sdt) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;

            if (NhanVienDAO.Instance.DeleteNhanVien(ma))
            {
                MessageBox.Show("Xóa nhân viên thành công!");
                LoadListNhanVien();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa nhân viên!");
            }
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string ten = txbTen.Text;
            string diaChi = txbDiaChi.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = cbxGioiTinh.SelectedItem.ToString();
            string cmnd = txbCMND.Text;
            string sdt = txbSDT.Text;
            long luong = (long)nmLuong.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma, ten, diaChi, cmnd, sdt) == "")
            {
                //Check có Update được không
                if (NhanVienDAO.Instance.UpdateNhanVien(ma, ten, diaChi, ngaySinh, gioiTinh, cmnd, sdt, luong))
                {
                    MessageBox.Show("Sửa nhân viên thành công!");
                    LoadListNhanVien();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa nhân viên!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, ten, diaChi, cmnd, sdt) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private bool CheckMa(string ma)
        {
            List<NhanVien> nhanVien = NhanVienDAO.Instance.GetListNhanVien();
            foreach (NhanVien item in nhanVien)
            {
                if (item.Ma == ma)
                {
                    return false;
                }
            }
            return true;
        }

        private string CheckInput(string ma, string ten, string diaChi, string cmnd, string sdt)
        {
            string result = "";
            if (ma == string.Empty)
            {
                result += "mã, ";
            }
            if (ten == string.Empty)
            {
                result += "tên, ";
            }
            if (diaChi == string.Empty)
            {
                result += "địa chỉ, ";
            }
            if (cmnd == string.Empty)
            {
                result += "cmnd, ";
            }
            if (sdt == string.Empty)
            {
                result += "sdt, ";
            }

            return result;
        }
        #endregion

        //Hàm chỉ cho nhấn số trong textbox
        private void TxbCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TxbSearchNV_TextChanged(object sender, EventArgs e)
        {
            List<NhanVien> listNV = NhanVienDAO.Instance.SearchNhanVien(txbSearchNV.Text);
            ShowNhanVien(listNV);
        }

        private void TxbSearchNV_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Clear();
            txbSearchNV.ForeColor = Color.Black;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ReportNhanVien f = new ReportNhanVien();
            f.ShowDialog();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            string query = "SELECT * FROM dbo.NhanVien";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            excel.ExportNhanVien(data, "Danh sach NV", "DANH SÁCH NHÂN VIÊN");
        }
    }
}
