using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class PhuTungDAO
    {
        private static PhuTungDAO instance;

        public static PhuTungDAO Instance
        {
            get { if (instance == null) instance = new PhuTungDAO(); return PhuTungDAO.instance; }
            private set { PhuTungDAO.instance = value; }
        }

        private PhuTungDAO() { }

        public List<PhuTung> GetListPhuTung()
        {
            List<PhuTung> list = new List<PhuTung>();

            string query = "SELECT * FROM dbo.PhuTung";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhuTung phuTung = new PhuTung(item);
                list.Add(phuTung);
            }

            return list;
        }

        public List<PhuTung> SearchPhuTung(string ten)
        {
            List<PhuTung> list = new List<PhuTung>();

            string query = string.Format("SELECT * FROM dbo.PhuTung " +
                " WHERE dbo.fuConvertToUnsign1(Ma) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(Ten) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(DonGia) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(SoLuongTonKho) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                PhuTung phuTung = new PhuTung(item);
                list.Add(phuTung);
            }

            return list;
        }

        public bool InsertPhuTung(string ma, string ten, int donGia, int soLuongTonKho)
        {
            string query = string.Format("INSERT INTO dbo.PhuTung(Ma, Ten, DonGia, SoLuongTonKho) VALUES('{0}', N'{1}', '{2}', {3})", ma, ten, donGia, soLuongTonKho);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdatePhuTung(string ma, string ten, int donGia, int soLuongTonKho)
        {
            string query = string.Format("UPDATE dbo.PhuTung SET Ten = N'{1}', DonGia = '{2}', SoLuongTonKho = {3} WHERE Ma = '{0}'", ma, ten, donGia, soLuongTonKho);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeletePhuTung(string ma)
        {
            string query = string.Format("DELETE dbo.PhuTung WHERE Ma = '{0}'", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateGiaPhuTung(string ma, int donGia)
        {
            string query = string.Format("UPDATE dbo.PhuTung SET DonGia = '{1}' WHERE Ma = '{0}'", ma, donGia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
