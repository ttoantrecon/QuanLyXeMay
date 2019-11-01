using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class KhachHangDAO
    {
        private static KhachHangDAO instance;

        public static KhachHangDAO Instance
        {
            get { if (instance == null) instance = new KhachHangDAO(); return KhachHangDAO.instance; }
            private set { KhachHangDAO.instance = value; }
        }

        private KhachHangDAO() { }

        public List<KhachHang> GetListKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = "SELECT * FROM dbo.KhachHang";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang khachHang = new KhachHang(item);
                list.Add(khachHang);
            }

            return list;
        }

        public List<KhachHang> SearchKhachHang(string ten)
        {
            List<KhachHang> list = new List<KhachHang>();

            string query = string.Format("SELECT * FROM dbo.KhachHang " +
                " WHERE dbo.fuConvertToUnsign1(Ma) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(Ten) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(DiaChi) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(NgaySinh) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(GioiTinh) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(CMND) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(SDT) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                KhachHang khachHang = new KhachHang(item);
                list.Add(khachHang);
            }

            return list;
        }

        public bool InsertKhachHang(string ma, string ten, string diaChi, DateTime ngaySinh, string gioiTinh, string cmnd, string sdt)
        {
            string query = string.Format("INSERT INTO dbo.KhachHang(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT) VALUES('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}')", ma, ten, diaChi, ngaySinh.ToString("yyyy-MM-dd"), gioiTinh, cmnd, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateKhachHang(string ma, string ten, string diaChi, DateTime ngaySinh, string gioiTinh, string cmnd, string sdt)
        {
            string query = string.Format("UPDATE dbo.KhachHang SET Ten = N'{1}', DiaChi = N'{2}', NgaySinh = '{3}', GioiTinh = N'{4}', CMND = N'{5}', SDT = N'{6}' WHERE Ma = '{0}'", ma, ten, diaChi, ngaySinh.ToString("yyyy-MM-dd"), gioiTinh, cmnd, sdt);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteKhachHang(string ma)
        {
            string query = string.Format("DELETE dbo.KhachHang WHERE Ma = '{0}'", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
