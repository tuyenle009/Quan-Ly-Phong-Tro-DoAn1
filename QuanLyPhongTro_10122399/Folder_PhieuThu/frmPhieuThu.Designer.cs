namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    partial class frmPhieuThu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPhieuThu));
            this.grbDanhSachPT = new System.Windows.Forms.GroupBox();
            this.dgvDSPT = new System.Windows.Forms.DataGridView();
            this.maThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.giaPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noCu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conLai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.cmbTimKiem = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xuấtPhiếuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.btnXuatPT = new QuanLyPhongTro_10122399.RJButton();
            this.btnXoaPT = new QuanLyPhongTro_10122399.RJButton();
            this.rjButton2 = new QuanLyPhongTro_10122399.RJButton();
            this.txtTimKiem = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnThemPT = new QuanLyPhongTro_10122399.RJButton();
            this.grbDanhSachPT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhSachPT
            // 
            this.grbDanhSachPT.Controls.Add(this.dgvDSPT);
            this.grbDanhSachPT.Location = new System.Drawing.Point(42, 235);
            this.grbDanhSachPT.Name = "grbDanhSachPT";
            this.grbDanhSachPT.Size = new System.Drawing.Size(1156, 493);
            this.grbDanhSachPT.TabIndex = 20;
            this.grbDanhSachPT.TabStop = false;
            // 
            // dgvDSPT
            // 
            this.dgvDSPT.AllowUserToAddRows = false;
            this.dgvDSPT.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSPT.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSPT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThu,
            this.maPT,
            this.giaPhong,
            this.ngayThu,
            this.noCu,
            this.tongTien,
            this.daTra,
            this.conLai});
            this.dgvDSPT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSPT.Location = new System.Drawing.Point(3, 23);
            this.dgvDSPT.Name = "dgvDSPT";
            this.dgvDSPT.ReadOnly = true;
            this.dgvDSPT.RowHeadersWidth = 51;
            this.dgvDSPT.RowTemplate.Height = 40;
            this.dgvDSPT.Size = new System.Drawing.Size(1150, 467);
            this.dgvDSPT.TabIndex = 0;
            this.dgvDSPT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSPT_CellDoubleClick);
            this.dgvDSPT.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSPT_CellMouseUp);
            this.dgvDSPT.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDSPT_RowPrePaint);
            this.dgvDSPT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDSPT_MouseClick);
            // 
            // maThu
            // 
            this.maThu.DataPropertyName = "maThu";
            this.maThu.HeaderText = "Mã phiếu thu";
            this.maThu.MinimumWidth = 6;
            this.maThu.Name = "maThu";
            this.maThu.ReadOnly = true;
            this.maThu.Width = 130;
            // 
            // maPT
            // 
            this.maPT.DataPropertyName = "maPT";
            this.maPT.HeaderText = "Mã phòng trọ";
            this.maPT.MinimumWidth = 6;
            this.maPT.Name = "maPT";
            this.maPT.ReadOnly = true;
            this.maPT.Width = 140;
            // 
            // giaPhong
            // 
            this.giaPhong.DataPropertyName = "giaPhong";
            this.giaPhong.HeaderText = "Giá phòng";
            this.giaPhong.Name = "giaPhong";
            this.giaPhong.ReadOnly = true;
            this.giaPhong.Width = 150;
            // 
            // ngayThu
            // 
            this.ngayThu.DataPropertyName = "ngayThu";
            this.ngayThu.HeaderText = "Ngày thu";
            this.ngayThu.MinimumWidth = 6;
            this.ngayThu.Name = "ngayThu";
            this.ngayThu.ReadOnly = true;
            this.ngayThu.Width = 140;
            // 
            // noCu
            // 
            this.noCu.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.noCu.DataPropertyName = "noCu";
            this.noCu.HeaderText = "Nợ cũ";
            this.noCu.Name = "noCu";
            this.noCu.ReadOnly = true;
            this.noCu.Width = 130;
            // 
            // tongTien
            // 
            this.tongTien.DataPropertyName = "tongTien";
            this.tongTien.HeaderText = "Tổng tiền";
            this.tongTien.MinimumWidth = 6;
            this.tongTien.Name = "tongTien";
            this.tongTien.ReadOnly = true;
            this.tongTien.Width = 150;
            // 
            // daTra
            // 
            this.daTra.DataPropertyName = "daTra";
            this.daTra.HeaderText = "Đã trả";
            this.daTra.Name = "daTra";
            this.daTra.ReadOnly = true;
            this.daTra.Width = 150;
            // 
            // conLai
            // 
            this.conLai.DataPropertyName = "conLai";
            this.conLai.HeaderText = "Còn lại";
            this.conLai.Name = "conLai";
            this.conLai.ReadOnly = true;
            this.conLai.Width = 150;
            // 
            // picTimKiem
            // 
            this.picTimKiem.BackColor = System.Drawing.Color.White;
            this.picTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("picTimKiem.Image")));
            this.picTimKiem.Location = new System.Drawing.Point(645, 153);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(35, 42);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 25;
            this.picTimKiem.TabStop = false;
            this.picTimKiem.Click += new System.EventHandler(this.picTimKiem_Click);
            // 
            // cmbTimKiem
            // 
            this.cmbTimKiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTimKiem.Font = new System.Drawing.Font("Quicksand", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTimKiem.FormattingEnabled = true;
            this.cmbTimKiem.Items.AddRange(new object[] {
            "Mã PT",
            "Tháng/Năm",
            "Đã thanh toán",
            "Chưa thanh toán"});
            this.cmbTimKiem.Location = new System.Drawing.Point(58, 150);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Size = new System.Drawing.Size(158, 34);
            this.cmbTimKiem.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("iCiel Cadena", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 55);
            this.label1.TabIndex = 18;
            this.label1.Text = "PHIẾU THU";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xuấtPhiếuToolStripMenuItem,
            this.thanhToánToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 48);
            // 
            // xuấtPhiếuToolStripMenuItem
            // 
            this.xuấtPhiếuToolStripMenuItem.Name = "xuấtPhiếuToolStripMenuItem";
            this.xuấtPhiếuToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.xuấtPhiếuToolStripMenuItem.Text = "Xuất phiếu";
            this.xuấtPhiếuToolStripMenuItem.Click += new System.EventHandler(this.xuấtPhiếuToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(57, 187);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 36);
            this.panel3.TabIndex = 104;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(210, 187);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 36);
            this.panel2.TabIndex = 103;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(63, 189);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 10);
            this.panel1.TabIndex = 108;
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold);
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(63, 193);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(153, 31);
            this.dtpThangNam.TabIndex = 107;
            // 
            // btnXuatPT
            // 
            this.btnXuatPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(176)))));
            this.btnXuatPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(176)))));
            this.btnXuatPT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatPT.BackgroundImage")));
            this.btnXuatPT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.btnXuatPT.BorderRadius = 30;
            this.btnXuatPT.BorderSize = 1;
            this.btnXuatPT.FlatAppearance.BorderSize = 0;
            this.btnXuatPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatPT.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatPT.ForeColor = System.Drawing.Color.White;
            this.btnXuatPT.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatPT.Image")));
            this.btnXuatPT.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatPT.Location = new System.Drawing.Point(746, 137);
            this.btnXuatPT.Name = "btnXuatPT";
            this.btnXuatPT.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnXuatPT.Size = new System.Drawing.Size(144, 63);
            this.btnXuatPT.TabIndex = 26;
            this.btnXuatPT.Text = "Xuất";
            this.btnXuatPT.TextColor = System.Drawing.Color.White;
            this.btnXuatPT.UseVisualStyleBackColor = false;
            this.btnXuatPT.Click += new System.EventHandler(this.btnXuatPT_Click);
            // 
            // btnXoaPT
            // 
            this.btnXoaPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaPT.BorderRadius = 30;
            this.btnXoaPT.BorderSize = 1;
            this.btnXoaPT.FlatAppearance.BorderSize = 0;
            this.btnXoaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaPT.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold);
            this.btnXoaPT.ForeColor = System.Drawing.Color.White;
            this.btnXoaPT.Location = new System.Drawing.Point(1046, 137);
            this.btnXoaPT.Name = "btnXoaPT";
            this.btnXoaPT.Size = new System.Drawing.Size(144, 63);
            this.btnXoaPT.TabIndex = 23;
            this.btnXoaPT.Text = "Xóa";
            this.btnXoaPT.TextColor = System.Drawing.Color.White;
            this.btnXoaPT.UseVisualStyleBackColor = false;
            this.btnXoaPT.Click += new System.EventHandler(this.btnXoaPT_Click);
            // 
            // rjButton2
            // 
            this.rjButton2.BackColor = System.Drawing.Color.White;
            this.rjButton2.BackgroundColor = System.Drawing.Color.White;
            this.rjButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjButton2.BorderRadius = 20;
            this.rjButton2.BorderSize = 0;
            this.rjButton2.FlatAppearance.BorderSize = 0;
            this.rjButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.rjButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.rjButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rjButton2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjButton2.ForeColor = System.Drawing.Color.Silver;
            this.rjButton2.Location = new System.Drawing.Point(42, 116);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(199, 108);
            this.rjButton2.TabIndex = 24;
            this.rjButton2.Text = "Tìm kiếm";
            this.rjButton2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rjButton2.TextColor = System.Drawing.Color.Silver;
            this.rjButton2.UseVisualStyleBackColor = false;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderColor = System.Drawing.Color.White;
            this.txtTimKiem.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTimKiem.BorderRadius = 20;
            this.txtTimKiem.BorderSize = 3;
            this.txtTimKiem.Font = new System.Drawing.Font("Quicksand", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.txtTimKiem.Location = new System.Drawing.Point(293, 149);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(405, 48);
            this.txtTimKiem.TabIndex = 21;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // btnThemPT
            // 
            this.btnThemPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemPT.BorderRadius = 30;
            this.btnThemPT.BorderSize = 1;
            this.btnThemPT.FlatAppearance.BorderSize = 0;
            this.btnThemPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemPT.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold);
            this.btnThemPT.ForeColor = System.Drawing.Color.White;
            this.btnThemPT.Location = new System.Drawing.Point(896, 137);
            this.btnThemPT.Name = "btnThemPT";
            this.btnThemPT.Size = new System.Drawing.Size(144, 63);
            this.btnThemPT.TabIndex = 22;
            this.btnThemPT.Text = "Thêm";
            this.btnThemPT.TextColor = System.Drawing.Color.White;
            this.btnThemPT.UseVisualStyleBackColor = false;
            this.btnThemPT.Click += new System.EventHandler(this.btnThemPT_Click);
            // 
            // frmPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1229, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.btnXuatPT);
            this.Controls.Add(this.grbDanhSachPT);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.btnXoaPT);
            this.Controls.Add(this.cmbTimKiem);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThemPT);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmPhieuThu";
            this.Load += new System.EventHandler(this.frmPhieuThu_Load);
            this.grbDanhSachPT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachPT;
        private System.Windows.Forms.DataGridView dgvDSPT;
        private System.Windows.Forms.PictureBox picTimKiem;
        private RJButton btnXoaPT;
        private System.Windows.Forms.ComboBox cmbTimKiem;
        private RJButton rjButton2;
        private RJControls.RJTextBox txtTimKiem;
        private RJButton btnThemPT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private RJButton btnXuatPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn giaPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThu;
        private System.Windows.Forms.DataGridViewTextBoxColumn noCu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn daTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn conLai;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.ToolStripMenuItem xuấtPhiếuToolStripMenuItem;
    }
}