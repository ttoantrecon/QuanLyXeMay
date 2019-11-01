using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return NhanVienDAO.instance; }
            private set { NhanVienDAO.instance = value; }
        }

        private NhanVienDAO() { }

        public List<NhanVien> GetListNhanVien()
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = "SELECT * FROM dbo.NhanVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }

            return list;
        }

        public List<NhanVien> SearchNhanVien(string ten)
        {
            List<NhanVien> list = new List<NhanVien>();

            string query = string.Format("SELECT * FROM dbo.NhanVien " +
                " WHERE dbo.fuConvertToUnsign1(Ma) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(Ten) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(DiaChi) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(NgaySinh) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(GioiTinh) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(CMND) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(SDT) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(Luong) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }

            return list;
        }

        //Hàm tính lương cho form quản lý tài chính
        public long GetLuong()
        {
            long result = 0;

            List<NhanVien> list = new List<NhanVien>();

            string query = "SELECT * FROM dbo.NhanVien";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                NhanVien nhanVien = new NhanVien(item);
                list.Add(nhanVien);
            }

            foreach (NhanVien item in list)
            {
                result += item.Luong;
            }

            return result;
        }

        public bool InsertNhanVien(string ma, string ten, string diaChi, DateTime ngaySinh, string gioiTinh, string cmnd, string sdt, long luong)
        {
            string query = string.Format("INSERT INTO dbo.NhanVien(Ma, Ten, DiaChi, NgaySinh, GioiTinh, CMND, SDT, Luong) VALUES('{0}', N'{1}', N'{2}', '{3}', N'{4}', '{5}', '{6}', '{7}')", ma, ten, diaChi, ngaySinh.ToString("yyyy-MM-dd"), gioiTinh, cmnd, sdt, luong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateNhanVien(string ma, string ten, string diaChi, DateTime ngaySinh, string gioiTinh, string cmnd, string sdt, long luong)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET Ten = N'{1}', DiaChi = N'{2}', NgaySinh = '{3}', GioiTinh = N'{4}', CMND = N'{5}', SDT = N'{6}', Luong = {7} WHERE Ma = '{0}'", ma, ten, diaChi, ngaySinh.ToString("yyyy-MM-dd"), gioiTinh, cmnd, sdt, luong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteNhanVien(string ma)
        {
            string query = string.Format("DELETE dbo.NhanVien WHERE Ma = '{0}'", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateLuongNhanVien(string ma, long luong)
        {
            string query = string.Format("UPDATE dbo.NhanVien SET Luong = {1} WHERE Ma = '{0}'", ma, luong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
