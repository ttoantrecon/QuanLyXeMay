namespace QuanLyXeMay
{
    partial class UC_Xe
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
            this.lsvXe = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbMau = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxLoai = new System.Windows.Forms.ComboBox();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.nmSoLuongTonKho = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.nmDonGia = new System.Windows.Forms.NumericUpDown();
            this.nmDungTich = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.txbSearchXe = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDungTich)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvXe
            // 
            this.lsvXe.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lsvXe.FullRowSelect = true;
            this.lsvXe.GridLines = true;
            this.lsvXe.HideSelection = false;
            this.lsvXe.Location = new System.Drawing.Point(5, 86);
            this.lsvXe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lsvXe.Name = "lsvXe";
            this.lsvXe.Size = new System.Drawing.Size(785, 366);
            this.lsvXe.TabIndex = 0;
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
            // columnHeader3
            // 
            this.columnHeader3.Text = "Loại";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Đơn Giá";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Màu";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Hãng";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Dung Tích";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Số Lượng Tồn Kho";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 491);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã:";
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(128, 487);
            this.txbMa.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbMa.Name = "txbMa";
            this.txbMa.Size = new System.Drawing.Size(285, 22);
            this.txbMa.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 545);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 598);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Loại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 654);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đơn Giá:";
            // 
            // txbMau
            // 
            this.txbMau.Location = new System.Drawing.Point(717, 487);
            this.txbMau.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbMau.Name = "txbMau";
            this.txbMau.Size = new System.Drawing.Size(325, 22);
            this.txbMau.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(623, 491);
            this.label5.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Màu:";
            // 
            // txbHang
            // 
            this.txbHang.Location = new System.Drawing.Point(717, 542);
            this.txbHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbHang.Name = "txbHang";
            this.txbHang.Size = new System.Drawing.Size(325, 22);
            this.txbHang.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(623, 545);
            this.label6.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "Hãng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(623, 654);
            this.label7.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Số Lượng Tồn Kho:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(623, 598);
            this.label8.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 17);
            this.label8.TabIndex = 13;
            this.label8.Text = "Dung Tích:";
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(979, 233);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(133, 60);
            this.btnEdit.TabIndex = 19;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(821, 338);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(133, 60);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click_1);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(821, 233);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(133, 60);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click_1);
            // 
            // cbxLoai
            // 
            this.cbxLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLoai.FormattingEnabled = true;
            this.cbxLoai.Items.AddRange(new object[] {
            "Xe Tay Ga",
            "Xe Tay Côn",
            "Xe Cub",
            "Xe Số"});
            this.cbxLoai.Location = new System.Drawing.Point(128, 594);
            this.cbxLoai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.cbxLoai.Name = "cbxLoai";
            this.cbxLoai.Size = new System.Drawing.Size(285, 24);
            this.cbxLoai.TabIndex = 20;
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(128, 542);
            this.txbTen.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(393, 22);
            this.txbTen.TabIndex = 4;
            // 
            // nmSoLuongTonKho
            // 
            this.nmSoLuongTonKho.Location = new System.Drawing.Point(779, 651);
            this.nmSoLuongTonKho.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nmSoLuongTonKho.Name = "nmSoLuongTonKho";
            this.nmSoLuongTonKho.Size = new System.Drawing.Size(139, 22);
            this.nmSoLuongTonKho.TabIndex = 21;
            this.nmSoLuongTonKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(507, 12);
            this.label9.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 47);
            this.label9.TabIndex = 22;
            this.label9.Text = "Xe";
            // 
            // nmDonGia
            // 
            this.nmDonGia.Increment = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.nmDonGia.Location = new System.Drawing.Point(128, 654);
            this.nmDonGia.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nmDonGia.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmDonGia.Name = "nmDonGia";
            this.nmDonGia.Size = new System.Drawing.Size(287, 22);
            this.nmDonGia.TabIndex = 23;
            this.nmDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nmDungTich
            // 
            this.nmDungTich.Increment = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nmDungTich.Location = new System.Drawing.Point(779, 596);
            this.nmDungTich.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nmDungTich.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.nmDungTich.Name = "nmDungTich";
            this.nmDungTich.Size = new System.Drawing.Size(139, 22);
            this.nmDungTich.TabIndex = 24;
            this.nmDungTich.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(928, 598);
            this.label10.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "CC";
            // 
            // txbSearchXe
            // 
            this.txbSearchXe.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSearchXe.Location = new System.Drawing.Point(821, 125);
            this.txbSearchXe.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txbSearchXe.Name = "txbSearchXe";
            this.txbSearchXe.Size = new System.Drawing.Size(291, 22);
            this.txbSearchXe.TabIndex = 27;
            this.txbSearchXe.Text = "Tìm kiếm";
            this.txbSearchXe.Click += new System.EventHandler(this.TxbSearchXe_Click);
            this.txbSearchXe.TextChanged += new System.EventHandler(this.TxbSearchXe_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(980, 338);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 60);
            this.btnShow.TabIndex = 48;
            this.btnShow.Text = "Xem";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExport.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.ForeColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(909, 15);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 60);
            this.btnExport.TabIndex = 49;
            this.btnExport.Text = "Xuất";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // UC_Xe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txbSearchXe);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nmDungTich);
            this.Controls.Add(this.nmDonGia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nmSoLuongTonKho);
            this.Controls.Add(this.cbxLoai);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txbHang);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbMau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvXe);
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "UC_Xe";
            this.Size = new System.Drawing.Size(1144, 738);
            this.Load += new System.EventHandler(this.UC_Xe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDungTich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvXe;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxLoai;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.NumericUpDown nmSoLuongTonKho;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmDonGia;
        private System.Windows.Forms.NumericUpDown nmDungTich;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txbSearchXe;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExport;
    }
}
