namespace QuanLyPhongTro_10122399.Folder_HopDong
{
    partial class frmHopDong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHopDong));
            this.grbDanhSachKT = new System.Windows.Forms.GroupBox();
            this.dgvDSHD = new System.Windows.Forms.DataGridView();
            this.maHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maPT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayThue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tienCoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tinhTrang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.picTimKiem = new System.Windows.Forms.PictureBox();
            this.cmbTimKiem = new System.Windows.Forms.ComboBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.HDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpThangNam = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnXuatHD = new QuanLyPhongTro_10122399.RJButton();
            this.btnXoaHD = new QuanLyPhongTro_10122399.RJButton();
            this.rjButton2 = new QuanLyPhongTro_10122399.RJButton();
            this.txtTimKiem = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnThemHD = new QuanLyPhongTro_10122399.RJButton();
            this.grbDanhSachKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhSachKT
            // 
            this.grbDanhSachKT.Controls.Add(this.dgvDSHD);
            this.grbDanhSachKT.Location = new System.Drawing.Point(39, 234);
            this.grbDanhSachKT.Name = "grbDanhSachKT";
            this.grbDanhSachKT.Size = new System.Drawing.Size(1156, 493);
            this.grbDanhSachKT.TabIndex = 12;
            this.grbDanhSachKT.TabStop = false;
            // 
            // dgvDSHD
            // 
            this.dgvDSHD.AllowUserToAddRows = false;
            this.dgvDSHD.BackgroundColor = System.Drawing.Color.White;
            this.dgvDSHD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDSHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHD,
            this.maKT,
            this.maPT,
            this.ngayThue,
            this.ngayTra,
            this.tienCoc,
            this.tinhTrang});
            this.dgvDSHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDSHD.Location = new System.Drawing.Point(3, 23);
            this.dgvDSHD.Name = "dgvDSHD";
            this.dgvDSHD.ReadOnly = true;
            this.dgvDSHD.RowHeadersWidth = 51;
            this.dgvDSHD.RowTemplate.Height = 40;
            this.dgvDSHD.Size = new System.Drawing.Size(1150, 467);
            this.dgvDSHD.TabIndex = 1;
            this.dgvDSHD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSHD_CellDoubleClick);
            this.dgvDSHD.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSHD_CellMouseClick);
            this.dgvDSHD.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDSHD_CellMouseUp);
            this.dgvDSHD.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvDSHD_RowPrePaint);
            // 
            // maHD
            // 
            this.maHD.DataPropertyName = "maHD";
            this.maHD.HeaderText = "Mã hợp đồng";
            this.maHD.MinimumWidth = 6;
            this.maHD.Name = "maHD";
            this.maHD.ReadOnly = true;
            this.maHD.Width = 140;
            // 
            // maKT
            // 
            this.maKT.DataPropertyName = "maKT";
            this.maKT.HeaderText = "Mã khách trọ";
            this.maKT.MinimumWidth = 6;
            this.maKT.Name = "maKT";
            this.maKT.ReadOnly = true;
            this.maKT.Width = 160;
            // 
            // maPT
            // 
            this.maPT.DataPropertyName = "maPT";
            this.maPT.HeaderText = "Mã phòng trọ";
            this.maPT.MinimumWidth = 6;
            this.maPT.Name = "maPT";
            this.maPT.ReadOnly = true;
            this.maPT.Width = 160;
            // 
            // ngayThue
            // 
            this.ngayThue.DataPropertyName = "ngayThue";
            this.ngayThue.HeaderText = "Ngày thuê";
            this.ngayThue.MinimumWidth = 6;
            this.ngayThue.Name = "ngayThue";
            this.ngayThue.ReadOnly = true;
            this.ngayThue.Width = 150;
            // 
            // ngayTra
            // 
            this.ngayTra.DataPropertyName = "ngayTra";
            this.ngayTra.HeaderText = "Ngày kết thúc";
            this.ngayTra.MinimumWidth = 6;
            this.ngayTra.Name = "ngayTra";
            this.ngayTra.ReadOnly = true;
            this.ngayTra.Width = 170;
            // 
            // tienCoc
            // 
            this.tienCoc.DataPropertyName = "tienCoc";
            this.tienCoc.HeaderText = "Tiền cọc";
            this.tienCoc.MinimumWidth = 6;
            this.tienCoc.Name = "tienCoc";
            this.tienCoc.ReadOnly = true;
            this.tienCoc.Width = 180;
            // 
            // tinhTrang
            // 
            this.tinhTrang.DataPropertyName = "tinhTrang";
            this.tinhTrang.HeaderText = "Tình trạng";
            this.tinhTrang.MinimumWidth = 6;
            this.tinhTrang.Name = "tinhTrang";
            this.tinhTrang.ReadOnly = true;
            this.tinhTrang.Width = 80;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("iCiel Cadena", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 55);
            this.label1.TabIndex = 10;
            this.label1.Text = "HỢP ĐỒNG";
            // 
            // picTimKiem
            // 
            this.picTimKiem.BackColor = System.Drawing.Color.White;
            this.picTimKiem.Image = ((System.Drawing.Image)(resources.GetObject("picTimKiem.Image")));
            this.picTimKiem.Location = new System.Drawing.Point(642, 152);
            this.picTimKiem.Name = "picTimKiem";
            this.picTimKiem.Size = new System.Drawing.Size(35, 42);
            this.picTimKiem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picTimKiem.TabIndex = 17;
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
            "Mã HD",
            "Gần đúng",
            "Tháng/Năm",
            "HD hết hạn",
            "HD chưa hết hạn"});
            this.cmbTimKiem.Location = new System.Drawing.Point(56, 149);
            this.cmbTimKiem.Name = "cmbTimKiem";
            this.cmbTimKiem.Size = new System.Drawing.Size(144, 34);
            this.cmbTimKiem.TabIndex = 11;
            this.cmbTimKiem.SelectedIndexChanged += new System.EventHandler(this.cmbTimKiem_SelectedIndexChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HDToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(129, 26);
            // 
            // HDToolStripMenuItem
            // 
            this.HDToolStripMenuItem.Name = "HDToolStripMenuItem";
            this.HDToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.HDToolStripMenuItem.Text = "Hợp đồng";
            this.HDToolStripMenuItem.Click += new System.EventHandler(this.HDToolStripMenuItem_Click);
            // 
            // dtpThangNam
            // 
            this.dtpThangNam.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpThangNam.CustomFormat = "MM/yyyy";
            this.dtpThangNam.Font = new System.Drawing.Font("Quicksand", 14F, System.Drawing.FontStyle.Bold);
            this.dtpThangNam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpThangNam.Location = new System.Drawing.Point(56, 192);
            this.dtpThangNam.Name = "dtpThangNam";
            this.dtpThangNam.Size = new System.Drawing.Size(153, 31);
            this.dtpThangNam.TabIndex = 101;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(56, 188);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 10);
            this.panel1.TabIndex = 102;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(203, 186);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 36);
            this.panel2.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(50, 186);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 36);
            this.panel3.TabIndex = 3;
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(176)))));
            this.btnXuatHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(129)))), ((int)(((byte)(176)))));
            this.btnXuatHD.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnXuatHD.BackgroundImage")));
            this.btnXuatHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(76)))), ((int)(((byte)(121)))));
            this.btnXuatHD.BorderRadius = 30;
            this.btnXuatHD.BorderSize = 1;
            this.btnXuatHD.FlatAppearance.BorderSize = 0;
            this.btnXuatHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatHD.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatHD.ForeColor = System.Drawing.Color.White;
            this.btnXuatHD.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatHD.Image")));
            this.btnXuatHD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXuatHD.Location = new System.Drawing.Point(748, 141);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Padding = new System.Windows.Forms.Padding(18, 0, 0, 0);
            this.btnXuatHD.Size = new System.Drawing.Size(144, 63);
            this.btnXuatHD.TabIndex = 18;
            this.btnXuatHD.Text = "Xuất";
            this.btnXuatHD.TextColor = System.Drawing.Color.White;
            this.btnXuatHD.UseVisualStyleBackColor = false;
            this.btnXuatHD.Click += new System.EventHandler(this.btnXuatHD_Click);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaHD.BorderRadius = 30;
            this.btnXoaHD.BorderSize = 1;
            this.btnXoaHD.FlatAppearance.BorderSize = 0;
            this.btnXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHD.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaHD.ForeColor = System.Drawing.Color.White;
            this.btnXoaHD.Location = new System.Drawing.Point(1048, 141);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(144, 63);
            this.btnXoaHD.TabIndex = 15;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.TextColor = System.Drawing.Color.White;
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
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
            this.rjButton2.Location = new System.Drawing.Point(32, 115);
            this.rjButton2.Name = "rjButton2";
            this.rjButton2.Size = new System.Drawing.Size(199, 108);
            this.rjButton2.TabIndex = 16;
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
            this.txtTimKiem.Location = new System.Drawing.Point(290, 148);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimKiem.Multiline = false;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTimKiem.PasswordChar = false;
            this.txtTimKiem.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTimKiem.PlaceholderText = "";
            this.txtTimKiem.Size = new System.Drawing.Size(405, 48);
            this.txtTimKiem.TabIndex = 13;
            this.txtTimKiem.Texts = "";
            this.txtTimKiem.UnderlinedStyle = false;
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemHD.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemHD.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemHD.BorderRadius = 30;
            this.btnThemHD.BorderSize = 1;
            this.btnThemHD.FlatAppearance.BorderSize = 0;
            this.btnThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHD.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.ForeColor = System.Drawing.Color.White;
            this.btnThemHD.Location = new System.Drawing.Point(898, 141);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(144, 63);
            this.btnThemHD.TabIndex = 14;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.TextColor = System.Drawing.Color.White;
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // frmHopDong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1229, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dtpThangNam);
            this.Controls.Add(this.btnXuatHD);
            this.Controls.Add(this.grbDanhSachKT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picTimKiem);
            this.Controls.Add(this.btnXoaHD);
            this.Controls.Add(this.cmbTimKiem);
            this.Controls.Add(this.rjButton2);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThemHD);
            this.Font = new System.Drawing.Font("Inter", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHopDong";
            this.Text = "frmHopDong";
            this.Load += new System.EventHandler(this.frmHopDong_Load);
            this.grbDanhSachKT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTimKiem)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachKT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTimKiem;
        private RJButton btnXoaHD;
        private System.Windows.Forms.ComboBox cmbTimKiem;
        private RJButton rjButton2;
        private RJControls.RJTextBox txtTimKiem;
        private RJButton btnThemHD;
        private System.Windows.Forms.DataGridView dgvDSHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayThue;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn tienCoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tinhTrang;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem HDToolStripMenuItem;
        private RJButton btnXuatHD;
        private System.Windows.Forms.DateTimePicker dtpThangNam;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}