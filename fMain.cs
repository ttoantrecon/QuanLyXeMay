using QuanLyXeMay.DAO;
using QuanLyXeMay.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyXeMay
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();

            //Round Form
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            //Hide cac UserControl -> bam button moi hien len
            uC_Account1.Hide();
            uC_PhuTung1.Hide();
            uC_KhachHang1.Hide();
            uC_NhanVien1.Hide();
            uC_HoaDonBan1.Hide();
            uC_HoaDonNhap1.Hide();
            uC_TaiChinh1.Hide();

            //Phân Quyền
            if (fLogin.LoaiTaiKhoan == "Staff" || fLogin.LoaiTaiKhoan == "staff")
            {
                btnAccount.Enabled = false;
                btnNhanVien.Enabled = false;
                btnTaiChinh.Enabled = false;
            }

            //Test
            byte[] temp = ASCIIEncoding.ASCII.GetBytes("1");
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            //MessageBox.Show(hasPass);
        }

        private void FMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        #region Cach 1 Hide + Show
        private void BtnXe_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(uC_Xe1);

            panelLeft.Height = btnXe.Height;
            panelLeft.Top = btnXe.Top;

            uC_Xe1.LoadListXe();
        }

        private void BtnPhuTung_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(uC_PhuTung1);

            panelLeft.Height = btnPhuTung.Height;
            panelLeft.Top = btnPhuTung.Top;

            uC_PhuTung1.LoadListPhuTung();
        }

        private void BtnKhachHang_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(uC_KhachHang1);

            panelLeft.Height = btnKhachHang.Height;
            panelLeft.Top = btnKhachHang.Top;

            uC_KhachHang1.LoadListKhachHang();
        }

        private void BtnHoaDonBan_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(uC_HoaDonBan1);

            panelLeft.Height = btnHoaDonBan.Height;
            panelLeft.Top = btnHoaDonBan.Top;

            uC_HoaDonBan1.LoadListHoaDonBan();
        }

        private void BtnHoaDonNhap_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(uC_HoaDonNhap1);

            panelLeft.Height = btnHoaDonNhap.Height;
            panelLeft.Top = btnHoaDonNhap.Top;

            uC_HoaDonNhap1.LoadListHoaDonNhap();
        }

        private void BtnNhanVien_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(uC_NhanVien1);

            panelLeft.Height = btnNhanVien.Height;
            panelLeft.Top = btnNhanVien.Top;

            uC_NhanVien1.LoadListNhanVien();
        }

        private void BtnAccount_Click_1(object sender, EventArgs e)
        {
            ShowUserControl(uC_Account1);

            panelLeft.Height = btnAccount.Height;
            panelLeft.Top = btnAccount.Top;

            uC_Account1.LoadListAccount();
        }


        private void BtnTaiChinh_Click(object sender, EventArgs e)
        {
            ShowUserControl(uC_TaiChinh1);

            panelLeft.Height = btnTaiChinh.Height;
            panelLeft.Top = btnTaiChinh.Top;

            uC_TaiChinh1.LoadTaiChinh();
        }

        private void BtnDangXuat_Click(object sender, EventArgs e)
        {
            //Mở form Login
            fLogin f = new fLogin();
            this.Hide();
            f.Show();
        }

        //Ham Hide + Show
        void ShowUserControl(UserControl uc)
        {
            uC_Xe1.Hide();
            uC_Account1.Hide();
            uC_PhuTung1.Hide();
            uC_KhachHang1.Hide();
            uC_NhanVien1.Hide();
            uC_HoaDonBan1.Hide();
            uC_HoaDonNhap1.Hide();
            uC_TaiChinh1.Hide();

            uc.Show();
            uc.BringToFront();
        }
        #endregion

        #region Giao diện
        //Hàm di chuyển form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void PnlLogo_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        //Hàm bo tròn góc form
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        //Event đổi màu button khi hover + leave
        private void BtnXe_MouseEnter(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.FromArgb(229, 126, 49);
        }

        private void BtnXe_MouseLeave(object sender, EventArgs e)
        {
            (sender as Button).ForeColor = Color.White;
        }

        //Button minimize và close application
        private void Label3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo thoát!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        //Hàm Esc để tắt form
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                DialogResult dialogResult = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thông báo thoát!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Application.Exit();
                    //this.Close();
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion
    }
}
