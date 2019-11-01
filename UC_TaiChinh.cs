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
using LiveCharts;
using LiveCharts.Wpf;
using System.Globalization;

namespace QuanLyXeMay
{
    public partial class UC_TaiChinh : UserControl
    {
        string maXe = "";
        string maPT = "";
        string maNV = "";

        long luong = NhanVienDAO.Instance.GetLuong();

        long banXe = CTHDBanDAO.Instance.GetBanXe();
        long banPT = CTHDBanDAO.Instance.GetBanPT();

        long nhapXe = CTHDNhapDAO.Instance.GetNhapXe();
        long nhapPT = CTHDNhapDAO.Instance.GetNhapPT();

        public UC_TaiChinh()
        {
            InitializeComponent();
        }

        private void UC_TaiChinh_Load(object sender, EventArgs e)
        {
            LoadTaiChinh();
        }

        //Hàm tổng hợp các hàm load
        public void LoadTaiChinh()
        {
            LoadListXe();

            LoadListPhuTung();

            LoadListNhanVien();

            LoadPieChart();
        }

        #region Các hàm của listview Xe
        private void ShowPhuTung(List<PhuTung> listPhuTung)
        {
            lsvPhuTung.Items.Clear();

            foreach (PhuTung item in listPhuTung)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.DonGia.ToString("C0"));

                lsvPhuTung.Items.Add(lsvItem);
            }
        }

        private void LoadListPhuTung()
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
                ListViewItem item2 = lsvPhuTung.SelectedItems[0];
                maPT = item2.SubItems[0].Text;
                nmDonGiaPT.Value = int.Parse(item2.SubItems[2].Text, NumberStyles.Currency);

            }
            else
            {
                nmDonGiaPT.Value = 0;
            }
        }

        private void BtnEditPT_Click(object sender, EventArgs e)
        {
            string maPhuTung = maPT;
            int donGiaPhuTung = (int)nmDonGiaPT.Value;

            if (PhuTungDAO.Instance.UpdateGiaPhuTung(maPhuTung, donGiaPhuTung))
            {
                MessageBox.Show("Sửa phụ tùng thành công!");
                LoadListPhuTung();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa phụ tùng!");
            }
        }
        #endregion

        #region Các hàm của listview Xe
        private void ShowXe(List<Xe> listXe)
        {
            lsvXe.Items.Clear();

            foreach (Xe item in listXe)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.DonGia.ToString("C0"));

                lsvXe.Items.Add(lsvItem);
            }
        }

        private void LoadListXe()
        {
            List<Xe> listXe = XeDAO.Instance.GetListXe();

            ShowXe(listXe);

            lsvXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvXe.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LsvXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvXe.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvXe.SelectedItems[0];
                maXe = item.SubItems[0].Text;
                nmDonGia.Value = int.Parse(item.SubItems[2].Text, NumberStyles.Currency);

            }
            else
            {
                nmDonGia.Value = 0;
            }
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            string ma = maXe;
            int donGia = (int)nmDonGia.Value;

            if (XeDAO.Instance.UpdateGiaXe(ma, donGia))
            {
                MessageBox.Show("Sửa tài khoản thành công!");
                LoadListXe();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa tài khoản!");
            }
        }
        #endregion

        #region Các hàm của listview Nhân Viên
        private void ShowNhanVien(List<NhanVien> listNhanVien)
        {
            lsvNhanVien.Items.Clear();

            foreach (NhanVien item in listNhanVien)
            {
                ListViewItem lsvItem = new ListViewItem(item.Ma);
                lsvItem.SubItems.Add(item.Ten);
                lsvItem.SubItems.Add(item.Luong.ToString("C0"));

                lsvNhanVien.Items.Add(lsvItem);
            }
        }

        private void LoadListNhanVien()
        {
            List<NhanVien> listNhanVien = NhanVienDAO.Instance.GetListNhanVien();

            ShowNhanVien(listNhanVien);

            lsvNhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lsvNhanVien.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void LsvNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsvNhanVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvNhanVien.SelectedItems[0];
                maNV = item.SubItems[0].Text;
                nmLuong.Value = int.Parse(item.SubItems[2].Text, NumberStyles.Currency);
            }
            else
            {
                nmLuong.Value = 0;
            }
        }

        private void BtnEditNV_Click(object sender, EventArgs e)
        {
            long luong = (long)nmLuong.Value;

            if (NhanVienDAO.Instance.UpdateLuongNhanVien(maNV, luong))
            {
                MessageBox.Show("Sửa nhân viên thành công!");
                LoadListNhanVien();
            }
            else
            {
                MessageBox.Show("Có lỗi khi sửa nhân viên!");
            }
        }
        #endregion

        #region Các hàm của Quản Lý Tài Chính
        private void LoadPieChart()
        {
            LoadLabels();

            LoadPieChartThu();

            LoadPieChartChi();
        }

        private void LoadLabels()
        {
            lblTongThu.Text = "Tổng Thu: " + string.Format("{0:N0}", (banXe + banPT)) + " Đ";
            lblTongChi.Text = "Tổng Chi: " + string.Format("{0:N0}", (luong + nhapXe + nhapPT)) + " Đ";
        }

        private void LoadPieChartThu()
        {
            //Load Lại tiền sau khi chỉnh sữa ở các page khác
            banXe = CTHDBanDAO.Instance.GetBanXe();
            banPT = CTHDBanDAO.Instance.GetBanPT();

            Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0}, ({1:P})", chartpoint.Y, chartpoint.Participation);

            pieChartThu.LegendLocation = LegendLocation.Bottom;

            SeriesCollection series = new SeriesCollection();
            bieuDo bdBanXe = new bieuDo("Bán Xe", banXe);
            bieuDo bdBanPT = new bieuDo("Bán Phụ Tùng", banPT);
            bieuDo[] test = new bieuDo[] { bdBanXe, bdBanPT };
            foreach (var obj in test)
            {
                series.Add(new PieSeries()
                {
                    Title = obj.ten,
                    Values = new ChartValues<int> { (int)(obj.gia) },
                    DataLabels = true,
                    LabelPoint = labelPoint
                });
            }
            pieChartThu.Series = series;
        }

        private void LoadPieChartChi()
        {
            //Load Lại tiền sau khi chỉnh sữa ở các page khác
            luong = NhanVienDAO.Instance.GetLuong();
            nhapXe = CTHDNhapDAO.Instance.GetNhapXe();
            nhapPT = CTHDNhapDAO.Instance.GetNhapPT();

            Func<ChartPoint, string> labelPoint2 = chartpoint2 => string.Format("{0}, ({1:P})", chartpoint2.Y, chartpoint2.Participation);

            pieChartChi.LegendLocation = LegendLocation.Bottom;

            SeriesCollection series2 = new SeriesCollection();
            bieuDo bdLuong = new bieuDo("Lương", luong);
            bieuDo bdNhapXe = new bieuDo("Nhập Xe", nhapXe);
            bieuDo bdNhapPT = new bieuDo("Nhập Phụ Tùng", nhapPT);
            bieuDo[] test2 = new bieuDo[] { bdLuong, bdNhapXe, bdNhapPT };
            foreach (var obj in test2)
            {
                series2.Add(new PieSeries()
                {
                    Title = obj.ten,
                    Values = new ChartValues<int> { (int)(obj.gia) },
                    DataLabels = true,
                    LabelPoint = labelPoint2
                });
            }
            pieChartChi.Series = series2;
        }
        #endregion
        
        //Event chọn tab
        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            LoadTaiChinh();
        }
    }

    class bieuDo
    {
        public string ten;
        public long gia;

        public bieuDo(string a, long b)
        {
            ten = a;
            gia = b;
        }
    }
}
