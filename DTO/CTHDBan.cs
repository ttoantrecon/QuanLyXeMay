using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DTO
{
    class CTHDBan
    {
        private string maCTHDBan;
        private string maHDBan;
        private string ma;
        private int soLuong;
        private string ten;

        public CTHDBan(string maCTHDBan, string maHDBan, string ma, int soLuong)
        {
            this.MaCTHDBan = maCTHDBan;
            this.MaHDBan = maHDBan;
            this.Ma = ma;
            this.SoLuong = soLuong;
        }

        public CTHDBan(DataRow row)
        {
            this.MaCTHDBan = row["maCTHDBan"].ToString();
            this.MaHDBan = row["maHDBan"].ToString();
            this.Ten = row["tenSP"].ToString();
            this.SoLuong = (int)row["soLuong"];
        }

        public string MaCTHDBan
        {
            get { return maCTHDBan; }
            set { maCTHDBan = value; }
        }
        public string MaHDBan
        {
            get { return maHDBan; }
            set { maHDBan = value; }
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

        //Thanh Tien
        private int banXe;
        private int banPT;

        public CTHDBan(DataRow row, string xevapt)
        {
            this.MaCTHDBan = row["maCTHDBan"].ToString();
            if (xevapt == "xe")
                this.BanXe = (int)row["banXe"];
            else
                this.BanPT = (int)row["banPT"];
        }

        public int BanXe
        {
            get { return banXe; }
            set { banXe = value; }
        }

        public int BanPT
        {
            get { return banPT; }
            set { banPT = value; }
        }
    }
}
