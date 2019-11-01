namespace QuanLyXeMay
{
    partial class UC_PhuTung
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
            this.lsvPhuTung = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nmSoLuongTonKho = new System.Windows.Forms.NumericUpDown();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txbTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.nmDonGia = new System.Windows.Forms.NumericUpDown();
            this.txbSearchPhuTung = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongTonKho)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lsvPhuTung
            // 
            this.lsvPhuTung.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lsvPhuTung.FullRowSelect = true;
            this.lsvPhuTung.GridLines = true;
            this.lsvPhuTung.HideSelection = false;
            this.lsvPhuTung.Location = new System.Drawing.Point(4, 106);
            this.lsvPhuTung.Margin = new System.Windows.Forms.Padding(4);
            this.lsvPhuTung.Name = "lsvPhuTung";
            this.lsvPhuTung.Size = new System.Drawing.Size(785, 427);
            this.lsvPhuTung.TabIndex = 2;
            this.lsvPhuTung.UseCompatibleStateImageBehavior = false;
            this.lsvPhuTung.View = System.Windows.Forms.View.Details;
            this.lsvPhuTung.SelectedIndexChanged += new System.EventHandler(this.LsvPhuTung_SelectedIndexChanged);
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
            this.columnHeader3.Text = "Đơn Giá";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Số Lượng Tồn Kho";
            // 
            // nmSoLuongTonKho
            // 
            this.nmSoLuongTonKho.Location = new System.Drawing.Point(792, 639);
            this.nmSoLuongTonKho.Margin = new System.Windows.Forms.Padding(4);
            this.nmSoLuongTonKho.Name = "nmSoLuongTonKho";
            this.nmSoLuongTonKho.Size = new System.Drawing.Size(264, 22);
            this.nmSoLuongTonKho.TabIndex = 41;
            this.nmSoLuongTonKho.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(979, 289);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(132, 60);
            this.btnEdit.TabIndex = 39;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(819, 393);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 60);
            this.btnDelete.TabIndex = 38;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(819, 289);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(132, 60);
            this.btnAdd.TabIndex = 37;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(635, 641);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Số Lượng Tồn Kho:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(635, 577);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "Đơn Giá:";
            // 
            // txbTen
            // 
            this.txbTen.Location = new System.Drawing.Point(140, 638);
            this.txbTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbTen.Name = "txbTen";
            this.txbTen.Size = new System.Drawing.Size(392, 22);
            this.txbTen.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 641);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 25;
            this.label2.Text = "Tên:";
            // 
            // txbMa
            // 
            this.txbMa.Location = new System.Drawing.Point(140, 574);
            this.txbMa.Margin = new System.Windows.Forms.Padding(4);
            this.txbMa.Name = "txbMa";
            this.txbMa.Size = new System.Drawing.Size(285, 22);
            this.txbMa.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 577);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Schoolbook", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(480, 30);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(218, 47);
            this.label9.TabIndex = 42;
            this.label9.Text = "Phụ Tùng";
            // 
            // nmDonGia
            // 
            this.nmDonGia.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nmDonGia.Location = new System.Drawing.Point(792, 574);
            this.nmDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.nmDonGia.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.nmDonGia.Name = "nmDonGia";
            this.nmDonGia.Size = new System.Drawing.Size(264, 22);
            this.nmDonGia.TabIndex = 43;
            this.nmDonGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbSearchPhuTung
            // 
            this.txbSearchPhuTung.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txbSearchPhuTung.Location = new System.Drawing.Point(823, 179);
            this.txbSearchPhuTung.Margin = new System.Windows.Forms.Padding(4);
            this.txbSearchPhuTung.Name = "txbSearchPhuTung";
            this.txbSearchPhuTung.Size = new System.Drawing.Size(288, 22);
            this.txbSearchPhuTung.TabIndex = 44;
            this.txbSearchPhuTung.Text = "Tìm kiếm";
            this.txbSearchPhuTung.Click += new System.EventHandler(this.TxbSearchPhuTung_Click);
            this.txbSearchPhuTung.TextChanged += new System.EventHandler(this.TxbSearchPhuTung_TextChanged);
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(43)))), ((int)(((byte)(55)))));
            this.btnShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShow.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(979, 393);
            this.btnShow.Margin = new System.Windows.Forms.Padding(4);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(132, 60);
            this.btnShow.TabIndex = 49;
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
            this.btnExport.Location = new System.Drawing.Point(901, 17);
            this.btnExport.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(133, 60);
            this.btnExport.TabIndex = 50;
            this.btnExport.Text = "Xuất";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.BtnExport_Click);
            // 
            // UC_PhuTung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txbSearchPhuTung);
            this.Controls.Add(this.nmDonGia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.nmSoLuongTonKho);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbMa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lsvPhuTung);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_PhuTung";
            this.Size = new System.Drawing.Size(1144, 738);
            this.Load += new System.EventHandler(this.UC_PhuTung_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmSoLuongTonKho)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmDonGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lsvPhuTung;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.NumericUpDown nmSoLuongTonKho;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown nmDonGia;
        private System.Windows.Forms.TextBox txbSearchPhuTung;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnExport;
    }
}
