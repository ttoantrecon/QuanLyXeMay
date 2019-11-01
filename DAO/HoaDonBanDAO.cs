using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class HoaDonBanDAO
    {
        private static HoaDonBanDAO instance;

        public static HoaDonBanDAO Instance
        {
            get { if (instance == null) instance = new HoaDonBanDAO(); return HoaDonBanDAO.instance; }
            private set { HoaDonBanDAO.instance = value; }
        }

        private HoaDonBanDAO() { }

        public List<HoaDonBan> GetListHoaDonBan()
        {
            List<HoaDonBan> list = new List<HoaDonBan>();

            string query = "SELECT * FROM dbo.HoaDonBan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDonBan hoaDonBan = new HoaDonBan(item);
                list.Add(hoaDonBan);
            }

            return list;
        }

        public List<HoaDonBan> SearchHDBan(string ten)
        {
            List<HoaDonBan> list = new List<HoaDonBan>();

            string query = string.Format("SELECT * FROM dbo.HoaDonBan " +
                " WHERE dbo.fuConvertToUnsign1(Ma) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(MaNV) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(MaKH) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(NgayNhap) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                HoaDonBan hoaDonBan = new HoaDonBan(item);
                list.Add(hoaDonBan);
            }

            return list;
        }

        public bool InsertHoaDonBan(string ma, string maNV, string maKH, DateTime ngayNhap)
        {
            string query = string.Format("INSERT INTO dbo.HoaDonBan(Ma, MaNV, MaKH, NgayNhap)VALUES('{0}', '{1}', '{2}', '{3}')", ma, maNV, maKH, ngayNhap.ToString("yyyy-MM-dd"));
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateHoaDonBan(string ma, string maNV, string maKH, DateTime ngayNhap)
        {
            string query = string.Format("UPDATE dbo.HoaDonBan SET MaNV = '{1}', MaKH = '{2}', NgayNhap = '{3}' WHERE Ma = '{0}'", ma, maNV, maKH, ngayNhap.ToString("yyyy-MM-dd"));
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteHoaDonBan(string ma)
        {
            string query = string.Format("DELETE dbo.HoaDonBan WHERE Ma = '{0}'", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
