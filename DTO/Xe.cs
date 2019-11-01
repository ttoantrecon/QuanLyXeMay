using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeMay.DTO
{
    public class Xe
    {
        private string ma;
        private string ten;
        private string loai;
        private int donGia;
        private string mau;
        private string hang;
        private string dungTich;
        private int soLuongTonKho;

        public Xe(string ma, string ten, string loai, int donGia, string mau, string hang, string dungTich, int soLuongTonKho)
        {
            this.Ma = ma;
            this.Ten = ten;
            this.Loai = loai;
            this.DonGia = donGia;
            this.Mau = mau;
            this.Hang = hang;
            this.DungTich = dungTich;
            this.SoLuongTonKho = soLuongTonKho;
        }

        public Xe(DataRow row)
        {
            this.Ma = row["ma"].ToString();
            this.Ten = row["ten"].ToString();
            this.Loai = row["loai"].ToString();
            this.DonGia = Convert.ToInt32(row["donGia"]);
            this.Mau = row["mau"].ToString();
            this.Hang = row["hang"].ToString();
            this.DungTich = row["dungTich"].ToString();
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
        public string Loai
        {
            get { return loai; }
            set { loai = value; }
        }
        public int DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
        public string Mau
        {
            get { return mau; }
            set { mau = value; }
        }
        public string Hang
        {
            get { return hang; }
            set { hang = value; }
        }
        public string DungTich
        {
            get { return dungTich; }
            set { dungTich = value; }
        }
        public int SoLuongTonKho
        {
            get { return soLuongTonKho; }
            set { soLuongTonKho = value; }
        }
    }
}
