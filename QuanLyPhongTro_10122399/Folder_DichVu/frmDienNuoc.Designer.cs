namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    partial class frmDienNuoc
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
            this.grbDanhSachKT = new System.Windows.Forms.GroupBox();
            this.dgvDVDN = new System.Windows.Forms.DataGridView();
            this.maDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chiSoMoi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.btnThemDV = new QuanLyPhongTro_10122399.RJButton();
            this.btnMoi = new QuanLyPhongTro_10122399.RJButton();
            this.rjButton3 = new QuanLyPhongTro_10122399.RJButton();
            this.btnLayDL = new QuanLyPhongTro_10122399.RJButton();
            this.btnXoaDV = new QuanLyPhongTro_10122399.RJButton();
            this.grbDanhSachKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVDN)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDanhSachKT
            // 
            this.grbDanhSachKT.Controls.Add(this.dgvDVDN);
            this.grbDanhSachKT.Font = new System.Drawing.Font("Inter", 12F);
            this.grbDanhSachKT.Location = new System.Drawing.Point(29, 185);
            this.grbDanhSachKT.Name = "grbDanhSachKT";
            this.grbDanhSachKT.Size = new System.Drawing.Size(1156, 420);
            this.grbDanhSachKT.TabIndex = 24;
            this.grbDanhSachKT.TabStop = false;
            // 
            // dgvDVDN
            // 
            this.dgvDVDN.AllowUserToAddRows = false;
            this.dgvDVDN.BackgroundColor = System.Drawing.Color.White;
            this.dgvDVDN.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDVDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDVDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDN,
            this.maPT,
            this.loai,
            this.thoiGian,
            this.chiSoCu,
            this.chiSoMoi,
            this.thanhTien});
            this.dgvDVDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDVDN.Location = new System.Drawing.Point(3, 23);
            this.dgvDVDN.Name = "dgvDVDN";
            this.dgvDVDN.ReadOnly = true;
            this.dgvDVDN.RowHeadersWidth = 51;
            this.dgvDVDN.RowTemplate.Height = 40;
            this.dgvDVDN.Size = new System.Drawing.Size(1150, 394);
            this.dgvDVDN.TabIndex = 1;
            this.dgvDVDN.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDVDN_CellDoubleClick);
            this.dgvDVDN.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDVDN_RowPrePaint);
            // 
            // maDN
            // 
            this.maDN.DataPropertyName = "maDN";
            this.maDN.HeaderText = "Mã dịch vụ";
            this.maDN.MinimumWidth = 6;
            this.maDN.Name = "maDN";
            this.maDN.ReadOnly = true;
            this.maDN.Width = 150;
            // 
            // maPT
            // 
            this.maPT.DataPropertyName = "maPT";
            this.maPT.HeaderText = "Mã phòng trọ";
            this.maPT.MinimumWidth = 6;
            this.maPT.Name = "maPT";
            this.maPT.ReadOnly = true;
            this.maPT.Width = 170;
            // 
            // loai
            // 
            this.loai.DataPropertyName = "loai";
            this.loai.HeaderText = "Loại";
            this.loai.MinimumWidth = 6;
            this.loai.Name = "loai";
            this.loai.ReadOnly = true;
            this.loai.Width = 130;
            // 
            // thoiGian
            // 
            this.thoiGian.DataPropertyName = "thoiGian";
            this.thoiGian.HeaderText = "Thời gian";
            this.thoiGian.MinimumWidth = 6;
            this.thoiGian.Name = "thoiGian";
            this.thoiGian.ReadOnly = true;
            this.thoiGian.Width = 150;
            // 
            // chiSoCu
            // 
            this.chiSoCu.DataPropertyName = "chiSoCu";
            this.chiSoCu.HeaderText = "Chỉ số cũ";
            this.chiSoCu.MinimumWidth = 6;
            this.chiSoCu.Name = "chiSoCu";
            this.chiSoCu.ReadOnly = true;
            this.chiSoCu.Width = 150;
            // 
            // chiSoMoi
            // 
            this.chiSoMoi.DataPropertyName = "chiSoMoi";
            this.chiSoMoi.HeaderText = "Chỉ số mới";
            this.chiSoMoi.MinimumWidth = 6;
            this.chiSoMoi.Name = "chiSoMoi";
            this.chiSoMoi.ReadOnly = true;
            this.chiSoMoi.Width = 150;
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.MinimumWidth = 6;
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            this.thanhTien.Width = 140;
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Font = new System.Drawing.Font("Quicksand", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(71, 89);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(132, 34);
            this.dtpThangNam.TabIndex = 100;
            this.dtpThangNam.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnThemDV
            // 
            this.btnThemDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemDV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemDV.BorderRadius = 30;
            this.btnThemDV.BorderSize = 1;
            this.btnThemDV.FlatAppearance.BorderSize = 0;
            this.btnThemDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDV.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDV.ForeColor = System.Drawing.Color.White;
            this.btnThemDV.Location = new System.Drawing.Point(948, 70);
            this.btnThemDV.Name = "btnThemDV";
            this.btnThemDV.Size = new System.Drawing.Size(114, 63);
            this.btnThemDV.TabIndex = 102;
            this.btnThemDV.Text = "Thêm";
            this.btnThemDV.TextColor = System.Drawing.Color.White;
            this.btnThemDV.UseVisualStyleBackColor = false;
            this.btnThemDV.Click += new System.EventHandler(this.btnThemDV_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnMoi.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnMoi.BorderRadius = 30;
            this.btnMoi.BorderSize = 1;
            this.btnMoi.FlatAppearance.BorderSize = 0;
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoi.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoi.ForeColor = System.Drawing.Color.White;
            this.btnMoi.Location = new System.Drawing.Point(828, 70);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(114, 63);
            this.btnMoi.TabIndex = 101;
            this.btnMoi.Text = "Mới";
            this.btnMoi.TextColor = System.Drawing.Color.White;
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // rjButton3
            // 
            this.rjButton3.BackColor = System.Drawing.Color.White;
            this.rjButton3.BackgroundColor = System.Drawing.Color.White;
            this.rjButton3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjButton3.BorderRadius = 20;
            this.rjButton3.BorderSize = 0;
            this.rjButton3.FlatAppearance.BorderSize = 0;
            this.rjButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rjButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rjButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton3.ForeColor = System.Drawing.Color.Silver;
            this.rjButton3.Location = new System.Drawing.Point(32, 49);
            this.rjButton3.Name = "rjButton3";
            this.rjButton3.Size = new System.Drawing.Size(203, 81);
            this.rjButton3.TabIndex = 99;
            this.rjButton3.Text = "THÁNG/NĂM";
            this.rjButton3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton3.TextColor = System.Drawing.Color.Silver;
            this.rjButton3.UseVisualStyleBackColor = false;
            // 
            // btnLayDL
            // 
            this.btnLayDL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnLayDL.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnLayDL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnLayDL.BorderRadius = 20;
            this.btnLayDL.BorderSize = 1;
            this.btnLayDL.FlatAppearance.BorderSize = 0;
            this.btnLayDL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLayDL.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLayDL.ForeColor = System.Drawing.Color.White;
            this.btnLayDL.Location = new System.Drawing.Point(577, 67);
            this.btnLayDL.Name = "btnLayDL";
            this.btnLayDL.Size = new System.Drawing.Size(245, 63);
            this.btnLayDL.TabIndex = 95;
            this.btnLayDL.Text = "Lấy dữ liệu trước";
            this.btnLayDL.TextColor = System.Drawing.Color.White;
            this.btnLayDL.UseVisualStyleBackColor = false;
            this.btnLayDL.Click += new System.EventHandler(this.btnLayDL_Click);
            // 
            // btnXoaDV
            // 
            this.btnXoaDV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaDV.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaDV.BorderRadius = 30;
            this.btnXoaDV.BorderSize = 1;
            this.btnXoaDV.FlatAppearance.BorderSize = 0;
            this.btnXoaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDV.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDV.ForeColor = System.Drawing.Color.White;
            this.btnXoaDV.Location = new System.Drawing.Point(1068, 70);
            this.btnXoaDV.Name = "btnXoaDV";
            this.btnXoaDV.Size = new System.Drawing.Size(114, 63);
            this.btnXoaDV.TabIndex = 93;
            this.btnXoaDV.Text = "Xóa";
            this.btnXoaDV.TextColor = System.Drawing.Color.White;
            this.btnXoaDV.UseVisualStyleBackColor = false;
            this.btnXoaDV.Click += new System.EventHandler(this.btnXoaDV_Click);
            // 
            // frmDienNuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1205, 660);
            this.Controls.Add(this.btnThemDV);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.rjButton3);
            this.Controls.Add(this.btnLayDL);
            this.Controls.Add(this.btnXoaDV);
            this.Controls.Add(this.grbDanhSachKT);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmDienNuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmDienNuoc";
            this.grbDanhSachKT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDVDN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachKT;
        private System.Windows.Forms.DataGridView dgvDVDN;
        private RJButton btnXoaDV;
        private RJButton btnLayDL;
        private RJButton rjButton3;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private RJButton btnMoi;
        private RJButton btnThemDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn thoiGian;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn chiSoMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
    }
}