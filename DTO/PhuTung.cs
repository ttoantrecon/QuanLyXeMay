using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DTO
{
    class PhuTung
    {
        private string ma;
        private string ten;
        private int donGia;
        private int soLuongTonKho;

        public PhuTung(string ma, string ten, int donGia, int soLuongTonKho)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.DonGia = donGia;
            this.SoLuongTonKho = soLuongTonKho;
        }

        public PhuTung(DataRow row)
        {
            this.Ma = row["ma"].ToString();
            this.Ten = row["ten"].ToString();
            this.DonGia = (int)row["donGia"];
            this.SoLuongTonKho = (int)row["soLuongTonKho"];
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
        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public int SoLuongTonKho
        {
            get { return soLuongTonKho; }
            set { soLuongTonKho = value; }
        }
    }
}
