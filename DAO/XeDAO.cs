using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    public class XeDAO
    {
        private static XeDAO instance;

        public static XeDAO Instance
        {
            get { if (instance == null) instance = new XeDAO(); return XeDAO.instance; }
            private set { XeDAO.instance = value; }
        }

        private XeDAO() { }

        public List<Xe> GetXeByID(string ma)
        {
            List<Xe> list = new List<Xe>();

            string query = "SELECT * FROM dbo.Xe WHERE Ma = '" + ma + "'";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item);
                list.Add(xe);
            }

            return list;
        }

        public List<Xe> GetListXe()
        {
            List<Xe> list = new List<Xe>();

            string query = "SELECT * FROM dbo.Xe";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item);
                list.Add(xe);
            }

            return list;
        }

        public List<Xe> SearchXe(string ten)
        {
            List<Xe> list = new List<Xe>();

            string query = string.Format("SELECT * FROM dbo.Xe " +
                " WHERE dbo.fuConvertToUnsign1(Ma) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(Ten) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(Loai) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(DonGia) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(Mau) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(Hang) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(DungTich) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' " +
                " OR dbo.fuConvertToUnsign1(SoLuongTonKho) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", ten);

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Xe xe = new Xe(item);
                list.Add(xe);
            }

            return list;
        }

        public bool InsertXe(string ma, string ten, string loai, int donGia, string mau, string hang, string dungTich, int soLuongTonKho)
        {
            string query = string.Format("INSERT INTO dbo.Xe(Ma, Ten, Loai, DonGia, Mau, Hang, DungTich, SoLuongTonKho) VALUES('{0}', N'{1}', N'{2}', N'{3}', N'{4}', N'{5}', N'{6}', {7})", ma, ten, loai, donGia, mau, hang, dungTich, soLuongTonKho);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateXe(string ma, string ten, string loai, int donGia, string mau, string hang, string dungTich, int soLuongTonKho)
        {
            string query = string.Format("UPDATE dbo.Xe SET Ten = N'{1}', Loai = N'{2}', DonGia = N'{3}', Mau = N'{4}', Hang = N'{5}', DungTich = N'{6}', SoLuongTonKho = {7} WHERE Ma = '{0}'", ma, ten, loai, donGia, mau, hang, dungTich, soLuongTonKho);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteXe(string ma)
        {
            string query = string.Format("DELETE dbo.Xe WHERE Ma = '{0}'", ma);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        //Update Gia
        public bool UpdateGiaXe(string ma, int donGia)
        {
            string query = string.Format("UPDATE dbo.Xe SET DonGia = N'{1}' WHERE Ma = '{0}'", ma, donGia);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
