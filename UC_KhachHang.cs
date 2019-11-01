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

namespace QuanLyXeMay
{
    public partial class UC_KhachHang : UserControl
    {
        public UC_KhachHang()
        {
            InitializeComponent();
        }

        private void UC_KhachHang_Load(object sender, EventArgs e)
        {
            LoadListKhachHang();
        }

        private void ShowKhachHang(List<KhachHang> listKhachHang)
        {
            lsvKhacHang.Items.Clear();

            foreach (KhachHang item in listKhachHang)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.DiaChi);
                lsvItem.SubItems.Add(item.NgaySinh.ToString("dd/MM/yyyy"));
                lsvItem.SubItems.Add(item.GioiTinh);
                lsvItem.SubItems.Add(item.CMND);
                lsvItem.SubItems.Add(item.SDT);

                lsvKhacHang.Items.Add(lsvItem);
            }
        }

        public void LoadListKhachHang()
        {
            List<KhachHang> listKhachHang = KhachHangDAO.Instance.GetListKhachHang();

            ShowKhachHang(listKhachHang);

            lsvKhacHang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvKhacHang.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            cbxGioiTinh.SelectedIndex = 0;
        }

        private void LsvKhacHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvKhacHang.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvKhacHang.SelectedItems[0];
                txbMa.Text = item.SubItems[0].Text;
                txbTen.Text = item.SubItems[1].Text;
                txbDiaChi.Text = item.SubItems[2].Text;
                string[] NgayThangNam = item.SubItems[3].Text.Split('/');
                dtpNgaySinh.Value = new DateTime(Convert.ToInt32(NgayThangNam[2]), Convert.ToInt32(NgayThangNam[1]), Convert.ToInt32(NgayThangNam[0]));
                cbxGioiTinh.SelectedIndex = cbxGioiTinh.FindStringExact(item.SubItems[4].Text);
                txbCMND.Text = item.SubItems[5].Text;
                txbSDT.Text = item.SubItems[6].Text;
            }
            else
            {
                txbMa.Text = string.Empty;
                txbTen.Text = string.Empty;
                txbDiaChi.Text = string.Empty;
                dtpNgaySinh.Value = DateTime.Now;
                cbxGioiTinh.SelectedItem = 0;
                txbCMND.Text = string.Empty;
                txbSDT.Text = string.Empty;
            }
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string ten = txbTen.Text;
            string diaChi = txbDiaChi.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = cbxGioiTinh.SelectedItem.ToString();
            string cmnd = txbCMND.Text;
            string sdt = txbSDT.Text;

            //Check có thiếu trường nào không
            if (CheckInput(ma, ten, diaChi, cmnd, sdt) == "")
            {
                //Check Mã có bị trùng chưa
                if (CheckMa(ma))
                {
                    //Check có Insert được không
                    if (KhachHangDAO.Instance.InsertKhachHang(ma, ten, diaChi, ngaySinh, gioiTinh, cmnd, sdt))
                    {
                        MessageBox.Show("Thêm khách hàng thành công!");
                        LoadListKhachHang();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm khách hàng!");
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string ma = txbMa.Text;

            if (KhachHangDAO.Instance.DeleteKhachHang(ma))
            {
                MessageBox.Show("Xóa khách hàng thành công!");
                LoadListKhachHang();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa khách hàng!");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string ten = txbTen.Text;
            string diaChi = txbDiaChi.Text;
            DateTime ngaySinh = dtpNgaySinh.Value;
            string gioiTinh = cbxGioiTinh.SelectedItem.ToString();
            string cmnd = txbCMND.Text;
            string sdt = txbSDT.Text;

            //Check có thiếu trường nào không
            if (CheckInput(ma, ten, diaChi, cmnd, sdt) == "")
            {
                //Check có Update được không
                if (KhachHangDAO.Instance.UpdateKhachHang(ma, ten, diaChi, ngaySinh, gioiTinh, cmnd, sdt))
                {
                    MessageBox.Show("Sửa khách hàng thành công!");
                    LoadListKhachHang();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa khách hàng!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, ten, diaChi, cmnd, sdt) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private bool CheckMa(string ma)
        {
            List<KhachHang> khachHang = KhachHangDAO.Instance.GetListKhachHang();
            foreach (KhachHang item in khachHang)
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

        private void TxbSearchKhachHang_TextChanged(object sender, EventArgs e)
        {
            List<KhachHang> listKH = KhachHangDAO.Instance.SearchKhachHang(txbSearchKhachHang.Text);
            ShowKhachHang(listKH);
        }

        private void TxbSearchKhachHang_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Clear();
            txbSearchKhachHang.ForeColor = Color.Black;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ReportKhachHang f = new ReportKhachHang();
            f.ShowDialog();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            string query = "SELECT * FROM dbo.KhachHang";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            excel.ExportKhachHang(data, "Danh sach KH", "DANH SÁCH KHÁCH HÀNG");
        }
    }
}
