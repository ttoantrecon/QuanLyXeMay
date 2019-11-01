using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class HoaDonNhapDAO
    {
        private static HoaDonNhapDAO instance;

        public static HoaDonNhapDAO Instance
        {
            get { if (instance == null) instance = new HoaDonNhapDAO(); return HoaDonNhapDAO.instance; }
            private set { HoaDonNhapDAO.instance = value; }
        }

        private HoaDonNhapDAO() { }

        public List<HoaDonNhap> GetListHoaDonNhap()
        {
            List<HoaDonNhap> list = new List<HoaDonNhap>();

            string query = "SELECT * FROM dbo.HoaDonNhap";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDonNhap hoaDonNhap = new HoaDonNhap(item);
                list.Add(hoaDonNhap);
            }

            return list;
        }

        public List<HoaDonNhap> SearchHDNhap(string ten)
        {
            List<HoaDonNhap> list = new List<HoaDonNhap>();

            string query = string.Format("SELECT * FROM dbo.HoaDonNhap " +
                " WHERE dbo.fuConvertToUnsign1(Ma) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(MaNV) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(NhaCC) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(NgayNhap) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDonNhap hoaDonNhap = new HoaDonNhap(item);
                list.Add(hoaDonNhap);
            }

            return list;
        }

        public bool InsertHoaDonNhap(string ma, string maNV, string nhaCC, DateTime ngayNhap)
        {
            string query = string.Format("INSERT INTO dbo.HoaDonNhap(Ma, MaNV, NhaCC, NgayNhap)VALUES('{0}', '{1}', '{2}', '{3}')", ma, maNV, nhaCC, ngayNhap.ToString("yyyy-MM-dd"));
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateHoaDonNhap(string ma, string maNV, string nhaCC, DateTime ngayNhap)
        {
            string query = string.Format("UPDATE dbo.HoaDonNhap SET MaNV = '{1}', NhaCC = '{2}', NgayNhap = '{3}' WHERE Ma = '{0}'", ma, maNV, nhaCC, ngayNhap.ToString("yyyy-MM-dd"));
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteHoaDonNhap(string ma)
        {
            string query = string.Format("DELETE dbo.HoaDonNhap WHERE Ma = '{0}'", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
