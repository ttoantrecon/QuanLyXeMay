using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class CTHDBanDAO
    {
        private static CTHDBanDAO instance;

        public static CTHDBanDAO Instance
        {
            get { if (instance == null) instance = new CTHDBanDAO(); return CTHDBanDAO.instance; }
            private set { CTHDBanDAO.instance = value; }
        }

        private CTHDBanDAO() { }

        public List<CTHDBan> GetListCTHDBan()
        {
            List<CTHDBan> list = new List<CTHDBan>();

            string query = "SELECT * FROM dbo.CTHDBan";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTHDBan CTHDBan = new CTHDBan(item);
                list.Add(CTHDBan);
            }

            return list;
        }

        public List<CTHDBan> GetCTHDBanByHoaDonBan(string maHDBan)
        {
            List<CTHDBan> list = new List<CTHDBan>();

            string query = "SELECT MaCTHDBan, MaHDBan, TenSP, SoLuong FROM dbo.CTHDBan INNER JOIN dbo.SanPham ON CTHDBan.Ma = SanPham.MaSP WHERE MaHDBan = '" + maHDBan + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTHDBan CTHDBan = new CTHDBan(item);
                list.Add(CTHDBan);
            }

            return list;
        }


        //Thanh Tien
        public long GetBanXe()
        {
            long result = 0;

            List<CTHDBan> list = new List<CTHDBan>();

            string query = "SELECT MaCTHDBan, SoLuong * DonGia as BanXe FROM dbo.CTHDBan JOIN dbo.Xe ON CTHDBan.Ma = Xe.Ma";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTHDBan CTHDBan = new CTHDBan(item, "xe");
                list.Add(CTHDBan);
            }

            foreach (CTHDBan item in list)
            {
                result += item.BanXe;
            }

            return result;
        }

        public long GetBanPT()
        {
            long result = 0;

            List<CTHDBan> list = new List<CTHDBan>();

            string query = "SELECT MaCTHDBan, SoLuong * DonGia as BanPT FROM dbo.CTHDBan JOIN dbo.PhuTung ON CTHDBan.Ma = PhuTung.Ma";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                CTHDBan CTHDBan = new CTHDBan(item, "pt");
                list.Add(CTHDBan);
            }

            foreach (CTHDBan item in list)
            {
                result += item.BanPT;
            }

            return result;
        }

        public bool InsertCTHDBan(string maHDBan, string ma, int soLuong)
        {
            string query = string.Format("EXEC InsertCTHDBan {0}, {1}, {2}", maHDBan, ma, soLuong);
            //string query = string.Format("INSERT INTO dbo.CTHDBan(MaHDBan, Ma, SoLuong) VALUES('{0}', '{1}', '{2}')", maHDBan, ma, soLuong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCTHDBan(string maCTHDBan, string maHDBan, string ma, int soLuong)
        {
            string query = string.Format("UPDATE dbo.CTHDBan SET MaHDBan = '{1}', Ma = '{2}', SoLuong = {3} WHERE MaCTHDBan = '{0}'", maCTHDBan, maHDBan, ma, soLuong);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCTHDBan(string maCTHDBan)
        {
            string query = string.Format("DELETE dbo.CTHDBan WHERE MaCTHDBan = '{0}'", maCTHDBan);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
