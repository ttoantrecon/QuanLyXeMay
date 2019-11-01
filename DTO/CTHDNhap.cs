using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DTO
{
    class CTHDNhap
    {
        private string maCTHDNhap;
        private string maHDNhap;
        private string ma;
        private int soLuong;
        private string ten;

        public CTHDNhap(string maCTHDNhap, string maHDNhap, string ma, int soLuong)
        {
            this.MaCTHDNhap = maCTHDNhap;
            this.MaHDNhap = maHDNhap;
            this.Ma = ma;
            this.SoLuong = soLuong;
        }

        public CTHDNhap(DataRow row)
        {
            this.MaCTHDNhap = row["maCTHDNhap"].ToString();
            this.MaHDNhap = row["maHDNhap"].ToString();
            this.Ten = row["tenSP"].ToString();
            this.SoLuong = (int)row["soLuong"];
        }
        
        public string MaCTHDNhap
        {
            get { return maCTHDNhap; }
            set { maCTHDNhap = value; }
        }
        public string MaHDNhap
        {
            get { return maHDNhap; }
            set { maHDNhap = value; }
        }
        public string Ma
        {
            get { return ma; }
            set { ma = value; }
        }
        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }
        public string Ten
        {
            get { return ten; }
            set { ten = value; }
        }
        //Thanh Tien CTHDNhap
        private int nhapXe;
        private int nhapPT;

        public CTHDNhap(DataRow row, string nhap)
        {
            this.MaCTHDNhap = row["maCTHDNhap"].ToString();
            if(nhap == "xe")
                this.NhapXe = (int)row["nhapXe"];
            else
                this.NhapPT = (int)row["nhapPT"];
        }

        public int NhapXe
        {
            get { return nhapXe; }
            set { nhapXe = value; }
        }

        public int NhapPT
        {
            get { return nhapPT; }
            set { nhapPT = value; }
        }
    }
}
