using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DTO
{
    class HoaDonBan
    {
        private string ma;
        private string maNV;
        private string maKH;
        private DateTime ngayNhap;

        public HoaDonBan(string ma, string maNV, string maKH, DateTime ngayNhap)
        {
            this.Ma = ma;
            this.MaNV = maNV;
            this.MaKH = maKH;
            this.NgayNhap = ngayNhap;
        }

        public HoaDonBan(DataRow row)
        {
            this.Ma = row["ma"].ToString();
            this.MaNV = row["maNV"].ToString();
            this.MaKH = row["maKH"].ToString();
            this.NgayNhap = DateTime.Parse(row["ngayNhap"].ToString());
        }

        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public string MaNV
        {
            get { return maNV; }
            set { maNV = value; }
        }
        public string MaKH
        {
            get { return maKH; }
            set { maKH = value; }
        }
        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
    }
}
