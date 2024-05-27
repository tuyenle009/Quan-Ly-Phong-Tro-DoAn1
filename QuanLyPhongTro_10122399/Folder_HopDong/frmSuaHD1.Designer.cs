namespace QuanLyPhongTro_10122399.Folder_HopDong
{
    partial class frmSuaHD1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaHD1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xoaHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnThoat = new QuanLyPhongTro_10122399.RJButton();
            this.btnSua = new QuanLyPhongTro_10122399.RJButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvMaKT = new System.Windows.Forms.DataGridView();
            this.maKT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpNgayTra = new System.Windows.Forms.DateTimePicker();
            this.lblSDT = new System.Windows.Forms.Label();
            this.txtNgayTra = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.cmbTinhTrang = new System.Windows.Forms.ComboBox();
            this.dtpNgayThue = new System.Windows.Forms.DateTimePicker();
            this.cmbMaKT = new System.Windows.Forms.ComboBox();
            this.cmbMaPT = new System.Windows.Forms.ComboBox();
            this.txtNgayThue = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblNgheNghiep = new System.Windows.Forms.Label();
            this.txtTinhTrang = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.txtTienCoc = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblGioiTinh = new System.Windows.Forms.Label();
            this.txtMaPT = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.txtMaKT = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.hoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCTKT = new System.Windows.Forms.DataGridView();
            this.lblThongTinHD = new System.Windows.Forms.Label();
            this.lblMaHD = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaKT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTKT)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaHangToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // xoaHangToolStripMenuItem
            // 
            this.xoaHangToolStripMenuItem.Name = "xoaHangToolStripMenuItem";
            this.xoaHangToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.xoaHangToolStripMenuItem.Text = "Xóa hàng";
            this.xoaHangToolStripMenuItem.Click += new System.EventHandler(this.xoaHangToolStripMenuItem_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.panel4.Controls.Add(this.btnThoat);
            this.panel4.Controls.Add(this.btnSua);
            this.panel4.Location = new System.Drawing.Point(-4, 675);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(810, 310);
            this.panel4.TabIndex = 185;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThoat.BorderColor = System.Drawing.Color.White;
            this.btnThoat.BorderRadius = 30;
            this.btnThoat.BorderSize = 3;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(416, 79);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(164, 76);
            this.btnThoat.TabIndex = 186;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnSua.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnSua.BorderColor = System.Drawing.Color.White;
            this.btnSua.BorderRadius = 30;
            this.btnSua.BorderSize = 3;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Quicksand", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(199, 79);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(164, 76);
            this.btnSua.TabIndex = 185;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextColor = System.Drawing.Color.White;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.panel1.Location = new System.Drawing.Point(464, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(44, 287);
            this.panel1.TabIndex = 207;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(-4, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(810, 40);
            this.panel2.TabIndex = 206;
            // 
            // dgvMaKT
            // 
            this.dgvMaKT.AllowUserToAddRows = false;
            this.dgvMaKT.BackgroundColor = System.Drawing.Color.White;
            this.dgvMaKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKT1});
            this.dgvMaKT.Location = new System.Drawing.Point(493, 435);
            this.dgvMaKT.Name = "dgvMaKT";
            this.dgvMaKT.ReadOnly = true;
            this.dgvMaKT.RowHeadersWidth = 51;
            this.dgvMaKT.RowTemplate.Height = 24;
            this.dgvMaKT.Size = new System.Drawing.Size(500, 260);
            this.dgvMaKT.TabIndex = 205;
            this.dgvMaKT.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaKT_CellMouseUp);
            this.dgvMaKT.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvMaKT_MouseClick);
            // 
            // maKT1
            // 
            this.maKT1.DataPropertyName = "maKT";
            this.maKT1.HeaderText = "Mã khách trọ";
            this.maKT1.MinimumWidth = 6;
            this.maKT1.Name = "maKT1";
            this.maKT1.ReadOnly = true;
            this.maKT1.Width = 210;
            // 
            // dtpNgayTra
            // 
            this.dtpNgayTra.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayTra.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayTra.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayTra.Location = new System.Drawing.Point(565, 226);
            this.dtpNgayTra.Name = "dtpNgayTra";
            this.dtpNgayTra.Size = new System.Drawing.Size(176, 27);
            this.dtpNgayTra.TabIndex = 202;
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.BackColor = System.Drawing.Color.Transparent;
            this.lblSDT.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSDT.Location = new System.Drawing.Point(407, 227);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(92, 24);
            this.lblSDT.TabIndex = 204;
            this.lblSDT.Text = "NGÀY TRẢ:";
            // 
            // txtNgayTra
            // 
            this.txtNgayTra.BackColor = System.Drawing.Color.White;
            this.txtNgayTra.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtNgayTra.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNgayTra.BorderRadius = 20;
            this.txtNgayTra.BorderSize = 2;
            this.txtNgayTra.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayTra.Location = new System.Drawing.Point(549, 219);
            this.txtNgayTra.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayTra.Multiline = false;
            this.txtNgayTra.Name = "txtNgayTra";
            this.txtNgayTra.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNgayTra.PasswordChar = false;
            this.txtNgayTra.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNgayTra.PlaceholderText = "";
            this.txtNgayTra.Size = new System.Drawing.Size(210, 39);
            this.txtNgayTra.TabIndex = 203;
            this.txtNgayTra.Texts = "";
            this.txtNgayTra.UnderlinedStyle = false;
            // 
            // cmbTinhTrang
            // 
            this.cmbTinhTrang.BackColor = System.Drawing.Color.White;
            this.cmbTinhTrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTinhTrang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTinhTrang.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTinhTrang.FormattingEnabled = true;
            this.cmbTinhTrang.Items.AddRange(new object[] {
            "TRUE",
            "FALSE"});
            this.cmbTinhTrang.Location = new System.Drawing.Point(176, 311);
            this.cmbTinhTrang.Name = "cmbTinhTrang";
            this.cmbTinhTrang.Size = new System.Drawing.Size(164, 31);
            this.cmbTinhTrang.TabIndex = 192;
            // 
            // dtpNgayThue
            // 
            this.dtpNgayThue.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayThue.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThue.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThue.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThue.Location = new System.Drawing.Point(175, 226);
            this.dtpNgayThue.Name = "dtpNgayThue";
            this.dtpNgayThue.Size = new System.Drawing.Size(175, 27);
            this.dtpNgayThue.TabIndex = 191;
            // 
            // cmbMaKT
            // 
            this.cmbMaKT.BackColor = System.Drawing.Color.White;
            this.cmbMaKT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaKT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaKT.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaKT.FormattingEnabled = true;
            this.cmbMaKT.Location = new System.Drawing.Point(565, 136);
            this.cmbMaKT.Name = "cmbMaKT";
            this.cmbMaKT.Size = new System.Drawing.Size(164, 31);
            this.cmbMaKT.TabIndex = 188;
            // 
            // cmbMaPT
            // 
            this.cmbMaPT.BackColor = System.Drawing.Color.White;
            this.cmbMaPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaPT.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPT.FormattingEnabled = true;
            this.cmbMaPT.Location = new System.Drawing.Point(176, 136);
            this.cmbMaPT.Name = "cmbMaPT";
            this.cmbMaPT.Size = new System.Drawing.Size(164, 31);
            this.cmbMaPT.TabIndex = 189;
            // 
            // txtNgayThue
            // 
            this.txtNgayThue.BackColor = System.Drawing.Color.White;
            this.txtNgayThue.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtNgayThue.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNgayThue.BorderRadius = 20;
            this.txtNgayThue.BorderSize = 2;
            this.txtNgayThue.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayThue.Location = new System.Drawing.Point(160, 219);
            this.txtNgayThue.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayThue.Multiline = false;
            this.txtNgayThue.Name = "txtNgayThue";
            this.txtNgayThue.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNgayThue.PasswordChar = false;
            this.txtNgayThue.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNgayThue.PlaceholderText = "";
            this.txtNgayThue.Size = new System.Drawing.Size(210, 39);
            this.txtNgayThue.TabIndex = 195;
            this.txtNgayThue.Texts = "01/01/2222";
            this.txtNgayThue.UnderlinedStyle = false;
            // 
            // lblNgheNghiep
            // 
            this.lblNgheNghiep.AutoSize = true;
            this.lblNgheNghiep.BackColor = System.Drawing.Color.Transparent;
            this.lblNgheNghiep.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgheNghiep.Location = new System.Drawing.Point(21, 229);
            this.lblNgheNghiep.Name = "lblNgheNghiep";
            this.lblNgheNghiep.Size = new System.Drawing.Size(103, 24);
            this.lblNgheNghiep.TabIndex = 201;
            this.lblNgheNghiep.Text = "NGÀY THUÊ:";
            // 
            // txtTinhTrang
            // 
            this.txtTinhTrang.BackColor = System.Drawing.Color.White;
            this.txtTinhTrang.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtTinhTrang.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTinhTrang.BorderRadius = 20;
            this.txtTinhTrang.BorderSize = 2;
            this.txtTinhTrang.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTinhTrang.Location = new System.Drawing.Point(157, 306);
            this.txtTinhTrang.Margin = new System.Windows.Forms.Padding(4);
            this.txtTinhTrang.Multiline = false;
            this.txtTinhTrang.Name = "txtTinhTrang";
            this.txtTinhTrang.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTinhTrang.PasswordChar = false;
            this.txtTinhTrang.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTinhTrang.PlaceholderText = "";
            this.txtTinhTrang.Size = new System.Drawing.Size(210, 39);
            this.txtTinhTrang.TabIndex = 196;
            this.txtTinhTrang.Texts = "";
            this.txtTinhTrang.UnderlinedStyle = false;
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.BackColor = System.Drawing.Color.Transparent;
            this.lblDiaChi.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaChi.Location = new System.Drawing.Point(21, 314);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(110, 24);
            this.lblDiaChi.TabIndex = 200;
            this.lblDiaChi.Text = "TÌNH TRẠNG:";
            // 
            // txtTienCoc
            // 
            this.txtTienCoc.BackColor = System.Drawing.Color.White;
            this.txtTienCoc.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtTienCoc.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTienCoc.BorderRadius = 20;
            this.txtTienCoc.BorderSize = 2;
            this.txtTienCoc.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienCoc.Location = new System.Drawing.Point(547, 306);
            this.txtTienCoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTienCoc.Multiline = false;
            this.txtTienCoc.Name = "txtTienCoc";
            this.txtTienCoc.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTienCoc.PasswordChar = false;
            this.txtTienCoc.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTienCoc.PlaceholderText = "";
            this.txtTienCoc.Size = new System.Drawing.Size(210, 39);
            this.txtTienCoc.TabIndex = 190;
            this.txtTienCoc.Texts = "0";
            this.txtTienCoc.UnderlinedStyle = false;
            // 
            // lblGioiTinh
            // 
            this.lblGioiTinh.AutoSize = true;
            this.lblGioiTinh.BackColor = System.Drawing.Color.Transparent;
            this.lblGioiTinh.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGioiTinh.Location = new System.Drawing.Point(405, 314);
            this.lblGioiTinh.Name = "lblGioiTinh";
            this.lblGioiTinh.Size = new System.Drawing.Size(85, 24);
            this.lblGioiTinh.TabIndex = 199;
            this.lblGioiTinh.Text = "TIỀN CỌC:";
            // 
            // txtMaPT
            // 
            this.txtMaPT.BackColor = System.Drawing.Color.White;
            this.txtMaPT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtMaPT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaPT.BorderRadius = 20;
            this.txtMaPT.BorderSize = 2;
            this.txtMaPT.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.Location = new System.Drawing.Point(159, 132);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPT.Multiline = false;
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaPT.PasswordChar = false;
            this.txtMaPT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaPT.PlaceholderText = "";
            this.txtMaPT.Size = new System.Drawing.Size(210, 39);
            this.txtMaPT.TabIndex = 194;
            this.txtMaPT.Texts = "";
            this.txtMaPT.UnderlinedStyle = false;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.BackColor = System.Drawing.Color.Transparent;
            this.lblCMND.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.ForeColor = System.Drawing.Color.Black;
            this.lblCMND.Location = new System.Drawing.Point(21, 138);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(135, 24);
            this.lblCMND.TabIndex = 198;
            this.lblCMND.Text = "MÃ PHÒNG TRỌ:";
            // 
            // txtMaKT
            // 
            this.txtMaKT.BackColor = System.Drawing.Color.White;
            this.txtMaKT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtMaKT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaKT.BorderRadius = 20;
            this.txtMaKT.BorderSize = 2;
            this.txtMaKT.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKT.Location = new System.Drawing.Point(547, 132);
            this.txtMaKT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaKT.Multiline = false;
            this.txtMaKT.Name = "txtMaKT";
            this.txtMaKT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaKT.PasswordChar = false;
            this.txtMaKT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaKT.PlaceholderText = "";
            this.txtMaKT.Size = new System.Drawing.Size(210, 39);
            this.txtMaKT.TabIndex = 193;
            this.txtMaKT.Texts = "";
            this.txtMaKT.UnderlinedStyle = false;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.BackColor = System.Drawing.Color.Transparent;
            this.lblHoTen.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHoTen.Location = new System.Drawing.Point(408, 141);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(132, 24);
            this.lblHoTen.TabIndex = 197;
            this.lblHoTen.Text = "MÃ KHÁCH TRỌ:";
            // 
            // hoTen
            // 
            this.hoTen.DataPropertyName = "hoTen";
            this.hoTen.HeaderText = "Họ tên";
            this.hoTen.MinimumWidth = 6;
            this.hoTen.Name = "hoTen";
            this.hoTen.ReadOnly = true;
            this.hoTen.Width = 240;
            // 
            // maKT
            // 
            this.maKT.DataPropertyName = "maKT";
            this.maKT.HeaderText = "Mã khách trọ";
            this.maKT.MinimumWidth = 6;
            this.maKT.Name = "maKT";
            this.maKT.ReadOnly = true;
            this.maKT.Width = 210;
            // 
            // dgvCTKT
            // 
            this.dgvCTKT.AllowUserToAddRows = false;
            this.dgvCTKT.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTKT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTKT.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKT,
            this.hoTen});
            this.dgvCTKT.Location = new System.Drawing.Point(-1, 435);
            this.dgvCTKT.Name = "dgvCTKT";
            this.dgvCTKT.ReadOnly = true;
            this.dgvCTKT.RowHeadersWidth = 51;
            this.dgvCTKT.RowTemplate.Height = 24;
            this.dgvCTKT.Size = new System.Drawing.Size(500, 260);
            this.dgvCTKT.TabIndex = 187;
            this.dgvCTKT.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTKT_CellDoubleClick);
            // 
            // lblThongTinHD
            // 
            this.lblThongTinHD.AutoSize = true;
            this.lblThongTinHD.BackColor = System.Drawing.Color.Transparent;
            this.lblThongTinHD.Font = new System.Drawing.Font("iCiel Cadena", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.lblThongTinHD.Location = new System.Drawing.Point(121, 20);
            this.lblThongTinHD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblThongTinHD.Name = "lblThongTinHD";
            this.lblThongTinHD.Size = new System.Drawing.Size(411, 55);
            this.lblThongTinHD.TabIndex = 186;
            this.lblThongTinHD.Text = "THÔNG TIN HỢP ĐỒNG";
            // 
            // lblMaHD
            // 
            this.lblMaHD.AutoSize = true;
            this.lblMaHD.BackColor = System.Drawing.Color.Transparent;
            this.lblMaHD.Font = new System.Drawing.Font("iCiel Cadena", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMaHD.Location = new System.Drawing.Point(522, 20);
            this.lblMaHD.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblMaHD.Name = "lblMaHD";
            this.lblMaHD.Size = new System.Drawing.Size(141, 55);
            this.lblMaHD.TabIndex = 208;
            this.lblMaHD.Text = "Mã HD";
            // 
            // frmSuaHD1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 900);
            this.Controls.Add(this.lblMaHD);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvMaKT);
            this.Controls.Add(this.dtpNgayTra);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.txtNgayTra);
            this.Controls.Add(this.cmbTinhTrang);
            this.Controls.Add(this.dtpNgayThue);
            this.Controls.Add(this.cmbMaKT);
            this.Controls.Add(this.cmbMaPT);
            this.Controls.Add(this.txtNgayThue);
            this.Controls.Add(this.lblNgheNghiep);
            this.Controls.Add(this.txtTinhTrang);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.txtTienCoc);
            this.Controls.Add(this.lblGioiTinh);
            this.Controls.Add(this.txtMaPT);
            this.Controls.Add(this.lblCMND);
            this.Controls.Add(this.txtMaKT);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.dgvCTKT);
            this.Controls.Add(this.lblThongTinHD);
            this.Font = new System.Drawing.Font("Quicksand", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "frmSuaHD1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaHD1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaKT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTKT)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xoaHangToolStripMenuItem;
        private System.Windows.Forms.Panel panel4;
        private RJButton btnThoat;
        private RJButton btnSua;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvMaKT;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKT1;
        private System.Windows.Forms.DateTimePicker dtpNgayTra;
        private System.Windows.Forms.Label lblSDT;
        private RJControls.RJTextBox txtNgayTra;
        private System.Windows.Forms.ComboBox cmbTinhTrang;
        private System.Windows.Forms.DateTimePicker dtpNgayThue;
        private System.Windows.Forms.ComboBox cmbMaKT;
        private System.Windows.Forms.ComboBox cmbMaPT;
        private RJControls.RJTextBox txtNgayThue;
        private System.Windows.Forms.Label lblNgheNghiep;
        private RJControls.RJTextBox txtTinhTrang;
        private System.Windows.Forms.Label lblDiaChi;
        private RJControls.RJTextBox txtTienCoc;
        private System.Windows.Forms.Label lblGioiTinh;
        private RJControls.RJTextBox txtMaPT;
        private System.Windows.Forms.Label lblCMND;
        private RJControls.RJTextBox txtMaKT;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn hoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKT;
        private System.Windows.Forms.DataGridView dgvCTKT;
        private System.Windows.Forms.Label lblThongTinHD;
        private System.Windows.Forms.Label lblMaHD;
    }
}