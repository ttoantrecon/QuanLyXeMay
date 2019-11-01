using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DTO
{
    class HoaDonNhap
    {
        private string ma;
        private string maNV;
        private string nhaCC;
        private DateTime ngayNhap;

        public HoaDonNhap(string ma, string maNV, string nhaCC, DateTime ngayNhap)
        {
            this.Ma = ma;
            this.MaNV = maNV;
            this.NhaCC = nhaCC;
            this.NgayNhap = ngayNhap;
        }

        public HoaDonNhap(DataRow row)
        {
            this.Ma = row["ma"].ToString();
            this.MaNV = row["maNV"].ToString();
            this.NhaCC = row["nhaCC"].ToString();
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
        public string NhaCC
        {
            get { return nhaCC; }
            set { nhaCC = value; }
        }
        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }
    }
}
