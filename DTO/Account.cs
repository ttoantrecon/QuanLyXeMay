using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyXeMay.DTO
{
    class Account
    {
        private string tenDN;
        private string matKhau;
        private string loaiTaiKhoan;

        public Account(string tenDN, string matKhau, string loaiTaiKhoan)
        {
            this.TenDN = tenDN;
            this.MatKhau = matKhau;
            this.LoaiTaiKhoan = loaiTaiKhoan;
        }

        public Account(DataRow row)
        {
            this.TenDN = row["tenDN"].ToString();
            this.MatKhau = row["matKhau"].ToString();
            this.LoaiTaiKhoan = row["loaiTaiKhoan"].ToString();
        }

        public string TenDN
        {
            get { return tenDN; }
            set { tenDN = value; }
        }
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        public string LoaiTaiKhoan
        {
            get { return loaiTaiKhoan; }
            set { loaiTaiKhoan = value; }
        }
    }
}
