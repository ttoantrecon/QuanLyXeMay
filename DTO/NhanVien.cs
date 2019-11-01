using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DTO
{
    class NhanVien
    {
        private string ma;
        private string ten;
        private string diaChi;
        private DateTime ngaySinh;
        private string gioiTinh;
        private string cmnd;
        private string sdt;
        private long luong;

        public NhanVien(string ma, string ten, string diaChi, DateTime ngaySinh, string gioiTinh, string cmnd, string sdt, long luong)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.DiaChi = diaChi;
            this.NgaySinh = ngaySinh;
            this.GioiTinh = gioiTinh;
            this.CMND = cmnd;
            this.SDT = sdt;
            this.Luong = luong;
        }

        public NhanVien(DataRow row)
        {
            this.Ma = row["ma"].ToString();
            this.Ten = row["ten"].ToString();
            this.DiaChi = row["diaChi"].ToString();
            this.NgaySinh = DateTime.Parse(row["ngaySinh"].ToString());
            this.GioiTinh = row["gioiTinh"].ToString();
            this.CMND = row["cmnd"].ToString();
            this.SDT = row["sdt"].ToString();
            this.Luong = (int)row["luong"];
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
        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }
        public DateTime NgaySinh
        {
            get { return ngaySinh; }
            set { ngaySinh = value; }
        }
        public string GioiTinh
        {
            get { return gioiTinh; }
            set { gioiTinh = value; }
        }
        public string CMND
        {
            get { return cmnd; }
            set { cmnd = value; }
        }
        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }
        public long Luong
        {
            get { return luong; }
            set { luong = value; }
        }
    }
}
