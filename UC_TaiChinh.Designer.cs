namespace QuanLyXeMay
{
    partial class UC_TaiChinh
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblTongChi = new System.Windows.Forms.Label();
            this.lblTongThu = new System.Windows.Forms.Label();
            this.pieChartChi = new LiveCharts.WinForms.PieChart();
            this.pieChartThu = new LiveCharts.WinForms.PieChart();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnEditPT = new System.Windows.Forms.Button();
            this.nmDonGiaPT = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lsvPhuTung = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nmDonGia = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.lsvXe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nmLuong = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditNV = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lsvNhanVien = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGiaPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl1
            // 
            this.TabControl1.Controls.Add(this.tabPage3);
            this.TabControl1.Controls.Add(this.tabPage1);
            this.TabControl1.Controls.Add(this.tabPage2);
            this.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControl1.Location = new System.Drawing.Point(0, 0);
            this.TabControl1.Name = "TabControl1";
            this.TabControl1.SelectedIndex = 0;
            this.TabControl1.Size = new System.Drawing.Size(1144, 738);
            this.TabControl1.TabIndex = 0;
            this.TabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.TabControl1_Selected);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.lblTongChi);
            this.tabPage3.Controls.Add(this.lblTongThu);
            this.tabPage3.Controls.Add(this.pieChartChi);
            this.tabPage3.Controls.Add(this.pieChartThu);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1136, 709);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tài Chính";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblTongChi
            // 
            this.lblTongChi.AutoSize = true;
            this.lblTongChi.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongChi.Location = new System.Drawing.Point(675, 557);
            this.lblTongChi.Name = "lblTongChi";
            this.lblTongChi.Size = new System.Drawing.Size(147, 33);
            this.lblTongChi.TabIndex = 3;
            this.lblTongChi.Text = "Tổng Chi:";
            // 
            // lblTongThu
            // 
            this.lblTongThu.AutoSize = true;
            this.lblTongThu.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThu.Location = new System.Drawing.Point(49, 557);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(154, 33);
            this.lblTongThu.TabIndex = 2;
            this.lblTongThu.Text = "Tổng Thu:";
            // 
            // pieChartChi
            // 
            this.pieChartChi.Location = new System.Drawing.Point(576, 3);
            this.pieChartChi.Name = "pieChartChi";
            this.pieChartChi.Size = new System.Drawing.Size(557, 456);
            this.pieChartChi.TabIndex = 1;
            this.pieChartChi.Text = "pieChartChi";
            // 
            // pieChartThu
            // 
            this.pieChartThu.Location = new System.Drawing.Point(3, 3);
            this.pieChartThu.Name = "pieChartThu";
            this.pieChartThu.Size = new System.Drawing.Size(557, 456);
            this.pieChartThu.TabIndex = 0;
            this.pieChartThu.Text = "pieChartThu";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnEditPT);
            this.tabPage1.Controls.Add(this.nmDonGiaPT);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lsvPhuTung);
            this.tabPage1.Controls.Add(this.nmDonGia);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.lsvXe);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1136, 709);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Giá Sản Phẩm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnEditPT
            // 
            this.btnEditPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEditPT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditPT.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditPT.ForeColor = System.Drawing.Color.White;
            this.btnEditPT.Location = new System.Drawing.Point(805, 527);
            this.btnEditPT.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEditPT.Name = "btnEditPT";
            this.btnEditPT.Size = new System.Drawing.Size(133, 60);
            this.btnEditPT.TabIndex = 74;
            this.btnEditPT.Text = "Sửa";
            this.btnEditPT.UseVisualStyleBackColor = false;
            this.btnEditPT.Click += new System.EventHandler(this.BtnEditPT_Click);
            // 
            // nmDonGiaPT
            // 
            this.nmDonGiaPT.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmDonGiaPT.Location = new System.Drawing.Point(785, 476);
            this.nmDonGiaPT.Margin = new System.Windows.Forms.Padding(4);
            this.nmDonGiaPT.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmDonGiaPT.Name = "nmDonGiaPT";
            this.nmDonGiaPT.Size = new System.Drawing.Size(264, 22);
            this.nmDonGiaPT.TabIndex = 73;
            this.nmDonGiaPT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(777, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 47);
            this.label1.TabIndex = 72;
            this.label1.Text = "Phụ Tùng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(689, 478);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 71;
            this.label2.Text = "Đơn Giá:";
            // 
            // lsvPhuTung
            // 
            this.lsvPhuTung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader6});
            this.lsvPhuTung.FullRowSelect = true;
            this.lsvPhuTung.GridLines = true;
            this.lsvPhuTung.HideSelection = false;
            this.lsvPhuTung.Location = new System.Drawing.Point(623, 87);
            this.lsvPhuTung.Margin = new System.Windows.Forms.Padding(4);
            this.lsvPhuTung.Name = "lsvPhuTung";
            this.lsvPhuTung.Size = new System.Drawing.Size(487, 366);
            this.lsvPhuTung.TabIndex = 70;
            this.lsvPhuTung.UseCompatibleStateImageBehavior = false;
            this.lsvPhuTung.View = System.Windows.Forms.View.Details;
            this.lsvPhuTung.SelectedIndexChanged += new System.EventHandler(this.LsvPhuTung_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Mã";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tên";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Đơn Giá";
            // 
            // nmDonGia
            // 
            this.nmDonGia.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmDonGia.Location = new System.Drawing.Point(123, 476);
            this.nmDonGia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nmDonGia.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmDonGia.Name = "nmDonGia";
            this.nmDonGia.Size = new System.Drawing.Size(287, 22);
            this.nmDonGia.TabIndex = 69;
            this.nmDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(209, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 47);
            this.label9.TabIndex = 68;
            this.label9.Text = "Xe";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(171, 527);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 60);
            this.btnEdit.TabIndex = 65;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // lsvXe
            // 
            this.lsvXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader4});
            this.lsvXe.FullRowSelect = true;
            this.lsvXe.GridLines = true;
            this.lsvXe.HideSelection = false;
            this.lsvXe.Location = new System.Drawing.Point(8, 87);
            this.lsvXe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsvXe.Name = "lsvXe";
            this.lsvXe.Size = new System.Drawing.Size(487, 366);
            this.lsvXe.TabIndex = 50;
            this.lsvXe.UseCompatibleStateImageBehavior = false;
            this.lsvXe.View = System.Windows.Forms.View.Details;
            this.lsvXe.SelectedIndexChanged += new System.EventHandler(this.LsvXe_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 476);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 56;
            this.label4.Text = "Đơn Giá:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nmLuong);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnEditNV);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.lsvNhanVien);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1136, 709);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Lương Nhân Viên";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nmLuong
            // 
            this.nmLuong.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmLuong.Location = new System.Drawing.Point(453, 504);
            this.nmLuong.Margin = new System.Windows.Forms.Padding(4);
            this.nmLuong.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmLuong.Name = "nmLuong";
            this.nmLuong.Size = new System.Drawing.Size(309, 22);
            this.nmLuong.TabIndex = 70;
            this.nmLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(341, 508);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 69;
            this.label7.Text = "Lương:";
            // 
            // btnEditNV
            // 
            this.btnEditNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEditNV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditNV.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditNV.ForeColor = System.Drawing.Color.White;
            this.btnEditNV.Location = new System.Drawing.Point(495, 574);
            this.btnEditNV.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditNV.Name = "btnEditNV";
            this.btnEditNV.Size = new System.Drawing.Size(132, 60);
            this.btnEditNV.TabIndex = 68;
            this.btnEditNV.Text = "Sửa";
            this.btnEditNV.UseVisualStyleBackColor = false;
            this.btnEditNV.Click += new System.EventHandler(this.BtnEditNV_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(461, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 47);
            this.label3.TabIndex = 64;
            this.label3.Text = "Nhân Viên";
            // 
            // lsvNhanVien
            // 
            this.lsvNhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader14});
            this.lsvNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvNhanVien.FullRowSelect = true;
            this.lsvNhanVien.GridLines = true;
            this.lsvNhanVien.HideSelection = false;
            this.lsvNhanVien.Location = new System.Drawing.Point(169, 87);
            this.lsvNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.lsvNhanVien.Name = "lsvNhanVien";
            this.lsvNhanVien.Size = new System.Drawing.Size(798, 366);
            this.lsvNhanVien.TabIndex = 63;
            this.lsvNhanVien.UseCompatibleStateImageBehavior = false;
            this.lsvNhanVien.View = System.Windows.Forms.View.Details;
            this.lsvNhanVien.SelectedIndexChanged += new System.EventHandler(this.LsvNhanVien_SelectedIndexChanged);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Mã";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Tên";
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Lương";
            // 
            // UC_TaiChinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.TabControl1);
            this.Name = "UC_TaiChinh";
            this.Size = new System.Drawing.Size(1144, 738);
            this.Load += new System.EventHandler(this.UC_TaiChinh_Load);
            this.TabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGiaPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.NumericUpDown nmDonGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ListView lsvXe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditPT;
        private System.Windows.Forms.NumericUpDown nmDonGiaPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lsvPhuTung;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView lsvNhanVien;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.NumericUpDown nmLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditNV;
        private LiveCharts.WinForms.PieChart pieChartThu;
        private LiveCharts.WinForms.PieChart pieChartChi;
        private System.Windows.Forms.Label lblTongChi;
        private System.Windows.Forms.Label lblTongThu;
    }
}
