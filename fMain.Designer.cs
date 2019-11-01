namespace QuanLyXeMay
{
    partial class fMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.btnTaiChinh = new System.Windows.Forms.Button();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.btnDangXuat = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.btnHoaDonNhap = new System.Windows.Forms.Button();
            this.btnHoaDonBan = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnPhuTung = new System.Windows.Forms.Button();
            this.btnXe = new System.Windows.Forms.Button();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uC_TaiChinh1 = new QuanLyXeMay.UC_TaiChinh();
            this.uC_Xe1 = new QuanLyXeMay.UC_Xe();
            this.uC_PhuTung1 = new QuanLyXeMay.UC_PhuTung();
            this.uC_NhanVien1 = new QuanLyXeMay.UC_NhanVien();
            this.uC_KhachHang1 = new QuanLyXeMay.UC_KhachHang();
            this.uC_HoaDonNhap1 = new QuanLyXeMay.UC_HoaDonNhap();
            this.uC_HoaDonBan1 = new QuanLyXeMay.UC_HoaDonBan();
            this.uC_Account1 = new QuanLyXeMay.UC_Account();
            this.pnlLeft.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLeft
            // 
            this.pnlLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.pnlLeft.Controls.Add(this.panelLeft);
            this.pnlLeft.Controls.Add(this.btnDangXuat);
            this.pnlLeft.Controls.Add(this.btnTaiChinh);
            this.pnlLeft.Controls.Add(this.btnAccount);
            this.pnlLeft.Controls.Add(this.btnNhanVien);
            this.pnlLeft.Controls.Add(this.btnHoaDonNhap);
            this.pnlLeft.Controls.Add(this.btnHoaDonBan);
            this.pnlLeft.Controls.Add(this.btnKhachHang);
            this.pnlLeft.Controls.Add(this.btnPhuTung);
            this.pnlLeft.Controls.Add(this.btnXe);
            this.pnlLeft.Controls.Add(this.pnlLogo);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(236, 789);
            this.pnlLeft.TabIndex = 0;
            // 
            // btnTaiChinh
            // 
            this.btnTaiChinh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnTaiChinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTaiChinh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTaiChinh.FlatAppearance.BorderSize = 0;
            this.btnTaiChinh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTaiChinh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnTaiChinh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTaiChinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaiChinh.ForeColor = System.Drawing.Color.White;
            this.btnTaiChinh.Location = new System.Drawing.Point(0, 640);
            this.btnTaiChinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaiChinh.Name = "btnTaiChinh";
            this.btnTaiChinh.Size = new System.Drawing.Size(236, 80);
            this.btnTaiChinh.TabIndex = 15;
            this.btnTaiChinh.Text = "Tài Chính";
            this.btnTaiChinh.UseVisualStyleBackColor = false;
            this.btnTaiChinh.Click += new System.EventHandler(this.BtnTaiChinh_Click);
            this.btnTaiChinh.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnTaiChinh.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.panelLeft.Location = new System.Drawing.Point(0, 80);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(4);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(9, 86);
            this.panelLeft.TabIndex = 2;
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDangXuat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDangXuat.FlatAppearance.BorderSize = 0;
            this.btnDangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDangXuat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDangXuat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.ForeColor = System.Drawing.Color.White;
            this.btnDangXuat.Location = new System.Drawing.Point(0, 720);
            this.btnDangXuat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(236, 69);
            this.btnDangXuat.TabIndex = 14;
            this.btnDangXuat.Text = "Đăng Xuất";
            this.btnDangXuat.UseVisualStyleBackColor = false;
            this.btnDangXuat.Click += new System.EventHandler(this.BtnDangXuat_Click);
            this.btnDangXuat.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnDangXuat.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // btnAccount
            // 
            this.btnAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnAccount.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.White;
            this.btnAccount.Location = new System.Drawing.Point(0, 560);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(236, 80);
            this.btnAccount.TabIndex = 8;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.UseVisualStyleBackColor = false;
            this.btnAccount.Click += new System.EventHandler(this.BtnAccount_Click_1);
            this.btnAccount.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnAccount.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNhanVien.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.Color.White;
            this.btnNhanVien.Location = new System.Drawing.Point(0, 480);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(236, 80);
            this.btnNhanVien.TabIndex = 11;
            this.btnNhanVien.Text = "Nhân Viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.BtnNhanVien_Click_1);
            this.btnNhanVien.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnNhanVien.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // btnHoaDonNhap
            // 
            this.btnHoaDonNhap.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnHoaDonNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDonNhap.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDonNhap.FlatAppearance.BorderSize = 0;
            this.btnHoaDonNhap.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnHoaDonNhap.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnHoaDonNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonNhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonNhap.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonNhap.Location = new System.Drawing.Point(0, 400);
            this.btnHoaDonNhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoaDonNhap.Name = "btnHoaDonNhap";
            this.btnHoaDonNhap.Size = new System.Drawing.Size(236, 80);
            this.btnHoaDonNhap.TabIndex = 13;
            this.btnHoaDonNhap.Text = "Hóa Đơn Nhập";
            this.btnHoaDonNhap.UseVisualStyleBackColor = false;
            this.btnHoaDonNhap.Click += new System.EventHandler(this.BtnHoaDonNhap_Click_1);
            this.btnHoaDonNhap.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnHoaDonNhap.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // btnHoaDonBan
            // 
            this.btnHoaDonBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnHoaDonBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoaDonBan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoaDonBan.FlatAppearance.BorderSize = 0;
            this.btnHoaDonBan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnHoaDonBan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnHoaDonBan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoaDonBan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoaDonBan.ForeColor = System.Drawing.Color.White;
            this.btnHoaDonBan.Location = new System.Drawing.Point(0, 320);
            this.btnHoaDonBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHoaDonBan.Name = "btnHoaDonBan";
            this.btnHoaDonBan.Size = new System.Drawing.Size(236, 80);
            this.btnHoaDonBan.TabIndex = 12;
            this.btnHoaDonBan.Text = "Hóa Đơn Bán";
            this.btnHoaDonBan.UseVisualStyleBackColor = false;
            this.btnHoaDonBan.Click += new System.EventHandler(this.BtnHoaDonBan_Click_1);
            this.btnHoaDonBan.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnHoaDonBan.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnKhachHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnKhachHang.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.Color.White;
            this.btnKhachHang.Location = new System.Drawing.Point(0, 240);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(236, 80);
            this.btnKhachHang.TabIndex = 10;
            this.btnKhachHang.Text = "Khách Hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            this.btnKhachHang.Click += new System.EventHandler(this.BtnKhachHang_Click_1);
            this.btnKhachHang.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnKhachHang.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // btnPhuTung
            // 
            this.btnPhuTung.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnPhuTung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPhuTung.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPhuTung.FlatAppearance.BorderSize = 0;
            this.btnPhuTung.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnPhuTung.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnPhuTung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhuTung.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPhuTung.ForeColor = System.Drawing.Color.White;
            this.btnPhuTung.Location = new System.Drawing.Point(0, 160);
            this.btnPhuTung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPhuTung.Name = "btnPhuTung";
            this.btnPhuTung.Size = new System.Drawing.Size(236, 80);
            this.btnPhuTung.TabIndex = 9;
            this.btnPhuTung.Text = "Phụ Tùng";
            this.btnPhuTung.UseVisualStyleBackColor = false;
            this.btnPhuTung.Click += new System.EventHandler(this.BtnPhuTung_Click_1);
            this.btnPhuTung.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnPhuTung.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // btnXe
            // 
            this.btnXe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(53)))), ((int)(((byte)(65)))));
            this.btnXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnXe.FlatAppearance.BorderSize = 0;
            this.btnXe.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnXe.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnXe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXe.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXe.ForeColor = System.Drawing.Color.White;
            this.btnXe.Location = new System.Drawing.Point(0, 80);
            this.btnXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXe.Name = "btnXe";
            this.btnXe.Size = new System.Drawing.Size(236, 80);
            this.btnXe.TabIndex = 7;
            this.btnXe.Text = "Xe";
            this.btnXe.UseVisualStyleBackColor = false;
            this.btnXe.Click += new System.EventHandler(this.BtnXe_Click_1);
            this.btnXe.MouseEnter += new System.EventHandler(this.BtnXe_MouseEnter);
            this.btnXe.MouseLeave += new System.EventHandler(this.BtnXe_MouseLeave);
            // 
            // pnlLogo
            // 
            this.pnlLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.pnlLogo.Controls.Add(this.pictureBoxLogo);
            this.pnlLogo.Controls.Add(this.label1);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(236, 80);
            this.pnlLogo.TabIndex = 0;
            this.pnlLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseDown_1);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::QuanLyXeMay.Properties.Resources.logo__transparent;
            this.pictureBoxLogo.Location = new System.Drawing.Point(-3, 9);
            this.pictureBoxLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(85, 62);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo.TabIndex = 1;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseDown_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "K.A.T BIKE";
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseDown_1);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Purple;
            this.pnlTop.Controls.Add(this.label4);
            this.pnlTop.Controls.Add(this.label3);
            this.pnlTop.Controls.Add(this.label2);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(236, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1135, 80);
            this.pnlTop.TabIndex = 1;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseDown_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Purple;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(157, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(688, 37);
            this.label4.TabIndex = 2;
            this.label4.Text = "PHẦN MỀM QUẢN LÝ CỬA HÀNG XE MÁY";
            this.label4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlLogo_MouseDown_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label3.Location = new System.Drawing.Point(1057, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "-";
            this.label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(126)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(1088, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "X";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // uC_TaiChinh1
            // 
            this.uC_TaiChinh1.BackColor = System.Drawing.Color.White;
            this.uC_TaiChinh1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_TaiChinh1.Location = new System.Drawing.Point(236, 80);
            this.uC_TaiChinh1.Name = "uC_TaiChinh1";
            this.uC_TaiChinh1.Size = new System.Drawing.Size(1135, 709);
            this.uC_TaiChinh1.TabIndex = 10;
            // 
            // uC_Xe1
            // 
            this.uC_Xe1.BackColor = System.Drawing.Color.White;
            this.uC_Xe1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Xe1.Location = new System.Drawing.Point(236, 80);
            this.uC_Xe1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Xe1.Name = "uC_Xe1";
            this.uC_Xe1.Size = new System.Drawing.Size(1135, 709);
            this.uC_Xe1.TabIndex = 9;
            // 
            // uC_PhuTung1
            // 
            this.uC_PhuTung1.BackColor = System.Drawing.Color.White;
            this.uC_PhuTung1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_PhuTung1.Location = new System.Drawing.Point(236, 80);
            this.uC_PhuTung1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_PhuTung1.Name = "uC_PhuTung1";
            this.uC_PhuTung1.Size = new System.Drawing.Size(1135, 709);
            this.uC_PhuTung1.TabIndex = 8;
            // 
            // uC_NhanVien1
            // 
            this.uC_NhanVien1.BackColor = System.Drawing.Color.White;
            this.uC_NhanVien1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_NhanVien1.Location = new System.Drawing.Point(236, 80);
            this.uC_NhanVien1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_NhanVien1.Name = "uC_NhanVien1";
            this.uC_NhanVien1.Size = new System.Drawing.Size(1135, 709);
            this.uC_NhanVien1.TabIndex = 7;
            // 
            // uC_KhachHang1
            // 
            this.uC_KhachHang1.BackColor = System.Drawing.Color.White;
            this.uC_KhachHang1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_KhachHang1.Location = new System.Drawing.Point(236, 80);
            this.uC_KhachHang1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_KhachHang1.Name = "uC_KhachHang1";
            this.uC_KhachHang1.Size = new System.Drawing.Size(1135, 709);
            this.uC_KhachHang1.TabIndex = 6;
            // 
            // uC_HoaDonNhap1
            // 
            this.uC_HoaDonNhap1.BackColor = System.Drawing.Color.White;
            this.uC_HoaDonNhap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_HoaDonNhap1.Location = new System.Drawing.Point(236, 80);
            this.uC_HoaDonNhap1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_HoaDonNhap1.Name = "uC_HoaDonNhap1";
            this.uC_HoaDonNhap1.Size = new System.Drawing.Size(1135, 709);
            this.uC_HoaDonNhap1.TabIndex = 5;
            // 
            // uC_HoaDonBan1
            // 
            this.uC_HoaDonBan1.BackColor = System.Drawing.Color.White;
            this.uC_HoaDonBan1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_HoaDonBan1.Location = new System.Drawing.Point(236, 80);
            this.uC_HoaDonBan1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.uC_HoaDonBan1.Name = "uC_HoaDonBan1";
            this.uC_HoaDonBan1.Size = new System.Drawing.Size(1135, 709);
            this.uC_HoaDonBan1.TabIndex = 4;
            // 
            // uC_Account1
            // 
            this.uC_Account1.BackColor = System.Drawing.Color.White;
            this.uC_Account1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uC_Account1.Location = new System.Drawing.Point(236, 80);
            this.uC_Account1.Margin = new System.Windows.Forms.Padding(5);
            this.uC_Account1.Name = "uC_Account1";
            this.uC_Account1.Size = new System.Drawing.Size(1135, 709);
            this.uC_Account1.TabIndex = 3;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1371, 789);
            this.Controls.Add(this.uC_TaiChinh1);
            this.Controls.Add(this.uC_Xe1);
            this.Controls.Add(this.uC_PhuTung1);
            this.Controls.Add(this.uC_NhanVien1);
            this.Controls.Add(this.uC_KhachHang1);
            this.Controls.Add(this.uC_HoaDonNhap1);
            this.Controls.Add(this.uC_HoaDonBan1);
            this.Controls.Add(this.uC_Account1);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FMain_FormClosing);
            this.Load += new System.EventHandler(this.FMain_Load);
            this.pnlLeft.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.pnlLogo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLeft;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnHoaDonNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.Button btnXe;
        private System.Windows.Forms.Button btnPhuTung;
        private System.Windows.Forms.Button btnHoaDonBan;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.Button btnDangXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelLeft;
        private UC_Account uC_Account1;
        private UC_HoaDonBan uC_HoaDonBan1;
        private UC_HoaDonNhap uC_HoaDonNhap1;
        private UC_KhachHang uC_KhachHang1;
        private UC_NhanVien uC_NhanVien1;
        private UC_PhuTung uC_PhuTung1;
        private UC_Xe uC_Xe1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTaiChinh;
        private UC_TaiChinh uC_TaiChinh1;
    }
}

