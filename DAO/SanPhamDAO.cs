using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DAO
{
    class SanPhamDAO
    {
        private static SanPhamDAO instance;

        public static SanPhamDAO Instance
        {
            get { if (instance == null) instance = new SanPhamDAO(); return SanPhamDAO.instance; }
            private set { SanPhamDAO.instance = value; }
        }

        private SanPhamDAO() { }

        public List<SanPham> GetListSP()
        {
            List<SanPham> list = new List<SanPham>();

            string query = "SELECT * FROM dbo.SanPham";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                SanPham sanPham = new SanPham(item);
                list.Add(sanPham);
            }

            return list;
        }
    }
}
