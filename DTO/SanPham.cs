using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DTO
{
    class SanPham
    {
        private string ma;
        private string ten;

        public SanPham(string ma, string ten)
        {
            this.Ma = ma;
            this.Ten = ten;
        }

        public SanPham(DataRow row)
        {
            this.Ma = row["maSP"].ToString();
            this.Ten = row["tenSP"].ToString();
        }

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
    }
}
