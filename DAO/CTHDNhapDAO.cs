using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class CTHDNhapDAO
    {
        private static CTHDNhapDAO instance;

        public static CTHDNhapDAO Instance
        {
            get { if (instance == null) instance = new CTHDNhapDAO(); return CTHDNhapDAO.instance; }
            private set { CTHDNhapDAO.instance = value; }
        }

        private CTHDNhapDAO() { }

        public List<CTHDNhap> GetListCTHDNhap()
        {
            List<CTHDNhap> list = new List<CTHDNhap>();

            string query = "SELECT * FROM dbo.CTHDNhap";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTHDNhap cthdNhap = new CTHDNhap(item);
                list.Add(cthdNhap);
            }

            return list;
        }

        public List<CTHDNhap> GetCTHDNhapByHoaDonNhap(string maHDNhap)
        {
            List<CTHDNhap> list = new List<CTHDNhap>();

            string query = "SELECT MaCTHDNhap, MaHDNhap, TenSP, SoLuong FROM dbo.CTHDNhap INNER JOIN dbo.SanPham ON CTHDNhap.Ma = SanPham.MaSP WHERE MaHDNhap = '" + maHDNhap + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTHDNhap cthdNhap = new CTHDNhap(item);
                list.Add(cthdNhap);
            }

            return list;
        }

        //Thanh Tien
        public long GetNhapXe()
        {
            long result = 0;

            List<CTHDNhap> list = new List<CTHDNhap>();

            string query = "SELECT MaCTHDNhap, SoLuong * DonGia as NhapXe FROM dbo.CTHDNhap JOIN dbo.Xe ON CTHDNhap.Ma = Xe.Ma";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTHDNhap cthdNhap = new CTHDNhap(item, "xe");
                list.Add(cthdNhap);
            }

            foreach (CTHDNhap item in list)
            {
                result += item.NhapXe;
            }

            return result;
        }

        public long GetNhapPT()
        {
            long result = 0;

            List<CTHDNhap> list = new List<CTHDNhap>();

            string query = "SELECT MaCTHDNhap, SoLuong * DonGia as NhapPT FROM dbo.CTHDNhap JOIN dbo.PhuTung ON CTHDNhap.Ma = PhuTung.Ma";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTHDNhap cthdNhap = new CTHDNhap(item, "pt");
                list.Add(cthdNhap);
            }

            foreach (CTHDNhap item in list)
            {
                result += item.NhapPT;
            }

            return result;
        }

        public bool InsertCTHDNhap(string maHDNhap, string ma, int soLuong)
        {
            string query = string.Format("EXEC InsertCTHDNhap {0}, {1}, {2}", maHDNhap, ma, soLuong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCTHDNhap(string maCTHDNhap, string maHDNhap, string ma, int soLuong)
        {
            string query = string.Format("UPDATE dbo.CTHDNhap SET MaHDNhap = '{1}', Ma = '{2}', SoLuong = {3} WHERE MaCTHDNhap = '{0}'", maCTHDNhap, maHDNhap, ma, soLuong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCTHDNhap(string maCTHDNhap)
        {
            string query = string.Format("DELETE dbo.CTHDNhap WHERE MaCTHDNhap = '{0}'", maCTHDNhap);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
