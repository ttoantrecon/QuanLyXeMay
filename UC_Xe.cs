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
using Microsoft.Office.Interop.Excel;
using System.Globalization;

namespace QuanLyXeMay
{
    public partial class UC_Xe : UserControl
    {
        public UC_Xe()
        {
            InitializeComponent();
        }

        private void UC_Xe_Load(object sender, EventArgs e)
        {
            LoadListXe();
        }

        private void ShowXe(List<Xe> listXe)
        {
            lsvXe.Items.Clear();

            foreach (Xe item in listXe)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.Loai);
                lsvItem.SubItems.Add(item.DonGia.ToString("C0"));
                lsvItem.SubItems.Add(item.Mau);
                lsvItem.SubItems.Add(item.Hang);
                lsvItem.SubItems.Add(item.DungTich);
                lsvItem.SubItems.Add(item.SoLuongTonKho.ToString());

                lsvXe.Items.Add(lsvItem);
            }
        }

        public void LoadListXe()
        {
            List<Xe> listXe = XeDAO.Instance.GetListXe();

            ShowXe(listXe);

            lsvXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            cbxLoai.SelectedIndex = 0;
        }

        private void LsvXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvXe.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvXe.SelectedItems[0];
                txbMa.Text = item.SubItems[0].Text;
                txbTen.Text = item.SubItems[1].Text;
                cbxLoai.SelectedIndex = cbxLoai.FindStringExact(item.SubItems[2].Text);
                nmDonGia.Value = int.Parse(item.SubItems[3].Text, NumberStyles.Currency);
                txbMau.Text = item.SubItems[4].Text;
                txbHang.Text = item.SubItems[5].Text;
                nmDungTich.Value = Convert.ToInt32(item.SubItems[6].Text.Substring(0, item.SubItems[6].Text.Length - 2));
                nmSoLuongTonKho.Value = Convert.ToInt32(item.SubItems[7].Text);

            }
            else
            {
                txbMa.Text = string.Empty;
                txbTen.Text = string.Empty;
                cbxLoai.SelectedItem = null;
                nmDonGia.Value = 0;
                txbMau.Text = string.Empty;
                txbHang.Text = string.Empty;
                nmDungTich.Value = 0;
                nmSoLuongTonKho.Value = 0;
            }
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string ten = txbTen.Text;
            string loai = cbxLoai.SelectedItem.ToString();
            int donGia = (int)nmDonGia.Value;
            string mau = txbMau.Text;
            string hang = txbHang.Text;
            int dungTich = (int)nmDungTich.Value;
            int soLuongTonKho = (int)nmSoLuongTonKho.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma, ten, loai, mau, hang) == "")
            {
                //Check Mã có bị trùng chưa
                if (CheckTenDN(ma))
                {
                    //Check có Insert được không
                    if (XeDAO.Instance.InsertXe(ma, ten, loai, donGia, mau, hang, dungTich.ToString() + "cc", soLuongTonKho))
                    {
                        MessageBox.Show("Thêm tài khoản thành công!");
                        LoadListXe();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm tài khoản!");
                    }
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, ten, loai, mau, hang) + "\nVui Lòng Nhập Đầy Đủ!");
            }
            
        }

        private void BtnDelete_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;

            if (XeDAO.Instance.DeleteXe(ma))
            {
                MessageBox.Show("Xóa tài khoản thành công!");
                LoadListXe();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa tài khoản!");
            }
        }

        private void BtnEdit_Click_1(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string ten = txbTen.Text;
            string loai = cbxLoai.SelectedItem.ToString();
            int donGia = (int)nmDonGia.Value;
            string mau = txbMau.Text;
            string hang = txbHang.Text;
            int dungTich = (int)nmDungTich.Value;
            int soLuongTonKho = (int)nmSoLuongTonKho.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma, ten, loai, mau, hang) == "")
            {
                //Check có Update được không
                if (XeDAO.Instance.UpdateXe(ma, ten, loai, donGia, mau, hang, dungTich.ToString() + "cc", soLuongTonKho))
                {
                    MessageBox.Show("Sửa tài khoản thành công!");
                    LoadListXe();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa tài khoản!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, ten, loai, mau, hang) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private bool CheckTenDN(string ma)
        {
            List<Xe> xe = XeDAO.Instance.GetListXe();
            foreach (Xe item in xe)
            {
                if (item.Ma == ma)
                {
                    return false;
                }
            }
            return true;
        }

        private string CheckInput(string ma, string ten, string loai, string mau, string hang)
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
            if (loai == null)
            {
                result += "loại, ";
            }
            if (mau == string.Empty)
            {
                result += "màu, ";
            }
            if (hang == string.Empty)
            {
                result += "hãng, ";
            }

            return result;
        }
        #endregion

        private void TxbSearchXe_TextChanged(object sender, EventArgs e)
        {
            List<Xe> listXe = XeDAO.Instance.SearchXe(txbSearchXe.Text);
            ShowXe(listXe);
        }

        private void TxbSearchXe_Click(object sender, EventArgs e)
        {
            (sender as System.Windows.Forms.TextBox).Clear();
            txbSearchXe.ForeColor = Color.Black;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ReportXe f = new ReportXe();
            f.ShowDialog();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();
            // Lấy về nguồn dữ liệu cần Export là 1 DataTable
            // DataTable này mỗi bạn lấy mỗi khác. 
            // Ở đây tôi dùng BindingSouce có tên bs nên tôi ép kiểu như sau:
            // Bạn nào gán trực tiếp vào DataGridView thì ép kiểu DataSource của
            // DataGridView nhé 
            string query = "SELECT * FROM dbo.Xe";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            excel.ExportXe(data, "Danh sach xe", "DANH SÁCH XE");
        }
    }
}
