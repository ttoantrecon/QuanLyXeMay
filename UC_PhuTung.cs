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
    public partial class UC_PhuTung : UserControl
    {
        public UC_PhuTung()
        {
            InitializeComponent();
        }

        private void UC_PhuTung_Load(object sender, EventArgs e)
        {
            LoadListPhuTung();
        }

        private void ShowPhuTung(List<PhuTung> listPhuTung)
        {
            lsvPhuTung.Items.Clear();

            foreach (PhuTung item in listPhuTung)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.DonGia.ToString("C0"));
                lsvItem.SubItems.Add(item.SoLuongTonKho.ToString());

                lsvPhuTung.Items.Add(lsvItem);
            }
        }

        public void LoadListPhuTung()
        {
            List<PhuTung> listPhuTung = PhuTungDAO.Instance.GetListPhuTung();

            ShowPhuTung(listPhuTung);

            lsvPhuTung.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvPhuTung.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LsvPhuTung_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvPhuTung.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvPhuTung.SelectedItems[0];
                txbMa.Text = item.SubItems[0].Text;
                txbTen.Text = item.SubItems[1].Text;
                nmDonGia.Value = int.Parse(item.SubItems[2].Text, NumberStyles.Currency);
                nmSoLuongTonKho.Value = Convert.ToInt32(item.SubItems[3].Text);

            }
            else
            {
                txbMa.Text = string.Empty;
                txbTen.Text = string.Empty;
                nmDonGia.Value = 0;
                nmSoLuongTonKho.Value = 0;
            }
        }

        #region Button Them + Xoa + Sua
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string ten = txbTen.Text;
            int donGia = (int)nmDonGia.Value;
            int soLuongTonKho = (int)nmSoLuongTonKho.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma, ten) == "")
            {
                //Check Mã có bị trùng chưa
                if (CheckMa(ma))
                {
                    //Check có Insert được không
                    if (PhuTungDAO.Instance.InsertPhuTung(ma, ten, donGia, soLuongTonKho))
                    {
                        MessageBox.Show("Thêm phụ tùng thành công!");
                        LoadListPhuTung();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi khi thêm phụ tùng!");
                    }
                }
                else
                {
                    MessageBox.Show("Mã đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, ten) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            string ma = txbMa.Text;

            if (PhuTungDAO.Instance.DeletePhuTung(ma))
            {
                MessageBox.Show("Xóa phụ tùng thành công!");
                LoadListPhuTung();
            }
            else
            {
                MessageBox.Show("Có lỗi khi xóa phụ tùng!");
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string ma = txbMa.Text;
            string ten = txbTen.Text;
            int donGia = (int)nmDonGia.Value;
            int soLuongTonKho = (int)nmSoLuongTonKho.Value;

            //Check có thiếu trường nào không
            if (CheckInput(ma, ten) == "")
            {
                //Check có Update được không
                if (PhuTungDAO.Instance.UpdatePhuTung(ma, ten, donGia, soLuongTonKho))
                {
                    MessageBox.Show("Sửa phụ tùng thành công!");
                    LoadListPhuTung();
                }
                else
                {
                    MessageBox.Show("Có lỗi khi sửa phụ tùng!");
                }
            }
            else
            {
                MessageBox.Show("Thiếu " + CheckInput(ma, ten) + "\nVui Lòng Nhập Đầy Đủ!");
            }
        }

        private bool CheckMa(string ma)
        {
            List<PhuTung> phuTung = PhuTungDAO.Instance.GetListPhuTung();
            foreach (PhuTung item in phuTung)
            {
                if (item.Ma == ma)
                {
                    return false;
                }
            }
            return true;
        }

        private string CheckInput(string ma, string ten)
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

            return result;
        }
        #endregion

        private void TxbSearchPhuTung_TextChanged(object sender, EventArgs e)
        {
            List<PhuTung> listPhuTung = PhuTungDAO.Instance.SearchPhuTung(txbSearchPhuTung.Text);
            ShowPhuTung(listPhuTung);
        }

        private void TxbSearchPhuTung_Click(object sender, EventArgs e)
        {
            (sender as TextBox).Clear();
            txbSearchPhuTung.ForeColor = Color.Black;
        }

        private void BtnShow_Click(object sender, EventArgs e)
        {
            ReportPhuTung f = new ReportPhuTung();
            f.ShowDialog();
        }

        private void BtnExport_Click(object sender, EventArgs e)
        {
            ExportToExcel excel = new ExportToExcel();

            string query = "SELECT * FROM dbo.PhuTung";

            System.Data.DataTable data = DataProvider.Instance.ExecuteQuery(query);

            excel.ExportPhuTung(data, "Danh sach PT", "DANH SÁCH PHỤ TÙNG");
        }
    }
}
