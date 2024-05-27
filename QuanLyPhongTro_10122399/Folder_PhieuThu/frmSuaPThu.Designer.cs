namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    partial class frmSuaPThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSuaPThu));
            this.maDV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbMaPT = new System.Windows.Forms.ComboBox();
            this.dtpNgayThu = new System.Windows.Forms.DateTimePicker();
            this.lblChiTiet = new System.Windows.Forms.Label();
            this.lblGiaPhong = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoaHangToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblCMND = new System.Windows.Forms.Label();
            this.cmbMaDV = new System.Windows.Forms.ComboBox();
            this.pnlCTPhieuThu = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnThemCTPT = new QuanLyPhongTro_10122399.RJButton();
            this.dgvCTDV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSoLuong = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.rjTextBox2 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.lblThongTinPT = new System.Windows.Forms.Label();
            this.pnlPhieuThu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGiaNuoc = new System.Windows.Forms.Label();
            this.rjTextBox3 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGiaDien = new System.Windows.Forms.Label();
            this.rjTextBox1 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblMaPThu = new System.Windows.Forms.Label();
            this.txtGiaPhong = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtNgayThu = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnCapNhatPThu = new QuanLyPhongTro_10122399.RJButton();
            this.txtThanhToan = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnThoat = new QuanLyPhongTro_10122399.RJButton();
            this.txtMaPT = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.lblNoCu = new System.Windows.Forms.Label();
            this.txtNoCu = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.pnlCTPhieuThu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.pnlPhieuThu.SuspendLayout();
            this.SuspendLayout();
            // 
            // maDV
            // 
            this.maDV.DataPropertyName = "maDV";
            this.maDV.HeaderText = "Mã dịch vụ";
            this.maDV.MinimumWidth = 6;
            this.maDV.Name = "maDV";
            this.maDV.ReadOnly = true;
            this.maDV.Width = 210;
            // 
            // cmbMaPT
            // 
            this.cmbMaPT.BackColor = System.Drawing.Color.White;
            this.cmbMaPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaPT.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPT.FormattingEnabled = true;
            this.cmbMaPT.Location = new System.Drawing.Point(181, 134);
            this.cmbMaPT.Name = "cmbMaPT";
            this.cmbMaPT.Size = new System.Drawing.Size(161, 32);
            this.cmbMaPT.TabIndex = 137;
            this.cmbMaPT.SelectedIndexChanged += new System.EventHandler(this.cmbMaPT_SelectedIndexChanged);
            // 
            // dtpNgayThu
            // 
            this.dtpNgayThu.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpNgayThu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayThu.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgayThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayThu.Location = new System.Drawing.Point(305, 395);
            this.dtpNgayThu.Name = "dtpNgayThu";
            this.dtpNgayThu.Size = new System.Drawing.Size(182, 27);
            this.dtpNgayThu.TabIndex = 131;
            this.dtpNgayThu.ValueChanged += new System.EventHandler(this.dtpNgayThu_ValueChanged);
            // 
            // lblChiTiet
            // 
            this.lblChiTiet.AutoSize = true;
            this.lblChiTiet.BackColor = System.Drawing.Color.Transparent;
            this.lblChiTiet.Font = new System.Drawing.Font("iCiel Cadena", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChiTiet.ForeColor = System.Drawing.Color.White;
            this.lblChiTiet.Location = new System.Drawing.Point(3, 513);
            this.lblChiTiet.Name = "lblChiTiet";
            this.lblChiTiet.Size = new System.Drawing.Size(117, 40);
            this.lblChiTiet.TabIndex = 130;
            this.lblChiTiet.Text = "Chi tiết:";
            // 
            // lblGiaPhong
            // 
            this.lblGiaPhong.AutoSize = true;
            this.lblGiaPhong.BackColor = System.Drawing.Color.Transparent;
            this.lblGiaPhong.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaPhong.Location = new System.Drawing.Point(441, 105);
            this.lblGiaPhong.Name = "lblGiaPhong";
            this.lblGiaPhong.Size = new System.Drawing.Size(96, 24);
            this.lblGiaPhong.TabIndex = 127;
            this.lblGiaPhong.Text = "GIÁ PHÒNG";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(55, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 24);
            this.label3.TabIndex = 134;
            this.label3.Text = "SỐ LƯỢNG";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 24);
            this.label2.TabIndex = 132;
            this.label2.Text = "Mã Dịch vụ";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            this.soLuong.Width = 240;
            // 
            // xoaHangToolStripMenuItem
            // 
            this.xoaHangToolStripMenuItem.Name = "xoaHangToolStripMenuItem";
            this.xoaHangToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.xoaHangToolStripMenuItem.Text = "Xóa hàng";
            this.xoaHangToolStripMenuItem.Click += new System.EventHandler(this.xoaHangToolStripMenuItem_Click);
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.BackColor = System.Drawing.Color.Transparent;
            this.lblCMND.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCMND.Location = new System.Drawing.Point(176, 106);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(131, 24);
            this.lblCMND.TabIndex = 124;
            this.lblCMND.Text = "MÃ PHÒNG TRỌ";
            // 
            // cmbMaDV
            // 
            this.cmbMaDV.BackColor = System.Drawing.Color.White;
            this.cmbMaDV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaDV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaDV.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaDV.FormattingEnabled = true;
            this.cmbMaDV.Location = new System.Drawing.Point(62, 68);
            this.cmbMaDV.Name = "cmbMaDV";
            this.cmbMaDV.Size = new System.Drawing.Size(145, 31);
            this.cmbMaDV.TabIndex = 136;
            // 
            // pnlCTPhieuThu
            // 
            this.pnlCTPhieuThu.BackColor = System.Drawing.Color.White;
            this.pnlCTPhieuThu.Controls.Add(this.flowLayoutPanel2);
            this.pnlCTPhieuThu.Controls.Add(this.flowLayoutPanel1);
            this.pnlCTPhieuThu.Controls.Add(this.cmbMaDV);
            this.pnlCTPhieuThu.Controls.Add(this.btnThemCTPT);
            this.pnlCTPhieuThu.Controls.Add(this.dgvCTDV);
            this.pnlCTPhieuThu.Controls.Add(this.txtSoLuong);
            this.pnlCTPhieuThu.Controls.Add(this.label3);
            this.pnlCTPhieuThu.Controls.Add(this.rjTextBox2);
            this.pnlCTPhieuThu.Controls.Add(this.label2);
            this.pnlCTPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlCTPhieuThu.Location = new System.Drawing.Point(0, 548);
            this.pnlCTPhieuThu.Name = "pnlCTPhieuThu";
            this.pnlCTPhieuThu.Size = new System.Drawing.Size(796, 310);
            this.pnlCTPhieuThu.TabIndex = 3;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 305);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(812, 23);
            this.flowLayoutPanel2.TabIndex = 142;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(254, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(87, 310);
            this.flowLayoutPanel1.TabIndex = 141;
            // 
            // btnThemCTPT
            // 
            this.btnThemCTPT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnThemCTPT.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnThemCTPT.BorderColor = System.Drawing.Color.White;
            this.btnThemCTPT.BorderRadius = 20;
            this.btnThemCTPT.BorderSize = 1;
            this.btnThemCTPT.FlatAppearance.BorderSize = 0;
            this.btnThemCTPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCTPT.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCTPT.ForeColor = System.Drawing.Color.White;
            this.btnThemCTPT.Image = ((System.Drawing.Image)(resources.GetObject("btnThemCTPT.Image")));
            this.btnThemCTPT.Location = new System.Drawing.Point(57, 234);
            this.btnThemCTPT.Name = "btnThemCTPT";
            this.btnThemCTPT.Size = new System.Drawing.Size(160, 58);
            this.btnThemCTPT.TabIndex = 131;
            this.btnThemCTPT.Text = "THÊM";
            this.btnThemCTPT.TextColor = System.Drawing.Color.White;
            this.btnThemCTPT.UseVisualStyleBackColor = false;
            this.btnThemCTPT.Click += new System.EventHandler(this.btnThemCTPT_Click);
            // 
            // dgvCTDV
            // 
            this.dgvCTDV.AllowUserToAddRows = false;
            this.dgvCTDV.BackgroundColor = System.Drawing.Color.White;
            this.dgvCTDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDV,
            this.soLuong});
            this.dgvCTDV.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvCTDV.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgvCTDV.Location = new System.Drawing.Point(289, 0);
            this.dgvCTDV.Name = "dgvCTDV";
            this.dgvCTDV.ReadOnly = true;
            this.dgvCTDV.RowHeadersWidth = 51;
            this.dgvCTDV.RowTemplate.Height = 24;
            this.dgvCTDV.Size = new System.Drawing.Size(507, 310);
            this.dgvCTDV.TabIndex = 135;
            this.dgvCTDV.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvCTDV_CellMouseUp);
            this.dgvCTDV.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvCTDV_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xoaHangToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 26);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.BackColor = System.Drawing.Color.White;
            this.txtSoLuong.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtSoLuong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtSoLuong.BorderRadius = 20;
            this.txtSoLuong.BorderSize = 2;
            this.txtSoLuong.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(47, 162);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4);
            this.txtSoLuong.Multiline = false;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtSoLuong.PasswordChar = false;
            this.txtSoLuong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtSoLuong.PlaceholderText = "";
            this.txtSoLuong.Size = new System.Drawing.Size(179, 39);
            this.txtSoLuong.TabIndex = 133;
            this.txtSoLuong.Texts = "0";
            this.txtSoLuong.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderColor = System.Drawing.Color.SaddleBrown;
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 20;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.White;
            this.rjTextBox2.Location = new System.Drawing.Point(47, 63);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(179, 39);
            this.rjTextBox2.TabIndex = 131;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.lblThanhToan.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhToan.Location = new System.Drawing.Point(176, 296);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(114, 24);
            this.lblThanhToan.TabIndex = 122;
            this.lblThanhToan.Text = "THANH TOÁN";
            // 
            // lblThongTinPT
            // 
            this.lblThongTinPT.AutoSize = true;
            this.lblThongTinPT.BackColor = System.Drawing.Color.Transparent;
            this.lblThongTinPT.Font = new System.Drawing.Font("iCiel Cadena", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPT.Location = new System.Drawing.Point(128, 25);
            this.lblThongTinPT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblThongTinPT.Name = "lblThongTinPT";
            this.lblThongTinPT.Size = new System.Drawing.Size(417, 55);
            this.lblThongTinPT.TabIndex = 121;
            this.lblThongTinPT.Text = "THÔNG TIN PHIẾU THU";
            // 
            // pnlPhieuThu
            // 
            this.pnlPhieuThu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPhieuThu.BackgroundImage")));
            this.pnlPhieuThu.Controls.Add(this.lblNoCu);
            this.pnlPhieuThu.Controls.Add(this.txtNoCu);
            this.pnlPhieuThu.Controls.Add(this.label5);
            this.pnlPhieuThu.Controls.Add(this.lblGiaNuoc);
            this.pnlPhieuThu.Controls.Add(this.rjTextBox3);
            this.pnlPhieuThu.Controls.Add(this.label4);
            this.pnlPhieuThu.Controls.Add(this.lblGiaDien);
            this.pnlPhieuThu.Controls.Add(this.rjTextBox1);
            this.pnlPhieuThu.Controls.Add(this.lblMaPThu);
            this.pnlPhieuThu.Controls.Add(this.cmbMaPT);
            this.pnlPhieuThu.Controls.Add(this.dtpNgayThu);
            this.pnlPhieuThu.Controls.Add(this.lblChiTiet);
            this.pnlPhieuThu.Controls.Add(this.txtGiaPhong);
            this.pnlPhieuThu.Controls.Add(this.lblGiaPhong);
            this.pnlPhieuThu.Controls.Add(this.txtNgayThu);
            this.pnlPhieuThu.Controls.Add(this.btnCapNhatPThu);
            this.pnlPhieuThu.Controls.Add(this.txtThanhToan);
            this.pnlPhieuThu.Controls.Add(this.btnThoat);
            this.pnlPhieuThu.Controls.Add(this.txtMaPT);
            this.pnlPhieuThu.Controls.Add(this.lblCMND);
            this.pnlPhieuThu.Controls.Add(this.lblThanhToan);
            this.pnlPhieuThu.Controls.Add(this.lblThongTinPT);
            this.pnlPhieuThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.pnlPhieuThu.Name = "pnlPhieuThu";
            this.pnlPhieuThu.Size = new System.Drawing.Size(796, 548);
            this.pnlPhieuThu.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(445, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 145;
            this.label5.Text = "GIÁ NƯỚC";
            // 
            // lblGiaNuoc
            // 
            this.lblGiaNuoc.AutoSize = true;
            this.lblGiaNuoc.BackColor = System.Drawing.Color.White;
            this.lblGiaNuoc.Font = new System.Drawing.Font("Quicksand", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaNuoc.Location = new System.Drawing.Point(445, 230);
            this.lblGiaNuoc.Name = "lblGiaNuoc";
            this.lblGiaNuoc.Size = new System.Drawing.Size(82, 25);
            this.lblGiaNuoc.TabIndex = 144;
            this.lblGiaNuoc.Text = "Giá nước";
            // 
            // rjTextBox3
            // 
            this.rjTextBox3.BackColor = System.Drawing.Color.White;
            this.rjTextBox3.BorderColor = System.Drawing.Color.SaddleBrown;
            this.rjTextBox3.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox3.BorderRadius = 20;
            this.rjTextBox3.BorderSize = 2;
            this.rjTextBox3.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox3.ForeColor = System.Drawing.Color.White;
            this.rjTextBox3.Location = new System.Drawing.Point(431, 223);
            this.rjTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox3.Multiline = false;
            this.rjTextBox3.Name = "rjTextBox3";
            this.rjTextBox3.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox3.PasswordChar = false;
            this.rjTextBox3.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox3.PlaceholderText = "";
            this.rjTextBox3.Size = new System.Drawing.Size(210, 39);
            this.rjTextBox3.TabIndex = 143;
            this.rjTextBox3.Texts = "";
            this.rjTextBox3.UnderlinedStyle = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 24);
            this.label4.TabIndex = 142;
            this.label4.Text = "GIÁ ĐIỆN";
            // 
            // lblGiaDien
            // 
            this.lblGiaDien.AutoSize = true;
            this.lblGiaDien.BackColor = System.Drawing.Color.White;
            this.lblGiaDien.Font = new System.Drawing.Font("Quicksand", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaDien.Location = new System.Drawing.Point(176, 230);
            this.lblGiaDien.Name = "lblGiaDien";
            this.lblGiaDien.Size = new System.Drawing.Size(77, 25);
            this.lblGiaDien.TabIndex = 141;
            this.lblGiaDien.Text = "Giá điện";
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderColor = System.Drawing.Color.SaddleBrown;
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 20;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(162, 223);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(210, 39);
            this.rjTextBox1.TabIndex = 140;
            this.rjTextBox1.Texts = "";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // lblMaPThu
            // 
            this.lblMaPThu.AutoSize = true;
            this.lblMaPThu.BackColor = System.Drawing.Color.Transparent;
            this.lblMaPThu.Font = new System.Drawing.Font("iCiel Cadena", 30F, System.Drawing.FontStyle.Bold);
            this.lblMaPThu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblMaPThu.Location = new System.Drawing.Point(530, 25);
            this.lblMaPThu.Name = "lblMaPThu";
            this.lblMaPThu.Size = new System.Drawing.Size(126, 55);
            this.lblMaPThu.TabIndex = 139;
            this.lblMaPThu.Text = "MaPT";
            this.lblMaPThu.Click += new System.EventHandler(this.lblMaPTro_Click);
            // 
            // txtGiaPhong
            // 
            this.txtGiaPhong.BackColor = System.Drawing.Color.White;
            this.txtGiaPhong.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtGiaPhong.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGiaPhong.BorderRadius = 20;
            this.txtGiaPhong.BorderSize = 2;
            this.txtGiaPhong.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaPhong.ForeColor = System.Drawing.Color.Black;
            this.txtGiaPhong.Location = new System.Drawing.Point(431, 130);
            this.txtGiaPhong.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaPhong.Multiline = false;
            this.txtGiaPhong.Name = "txtGiaPhong";
            this.txtGiaPhong.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGiaPhong.PasswordChar = false;
            this.txtGiaPhong.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGiaPhong.PlaceholderText = "";
            this.txtGiaPhong.Size = new System.Drawing.Size(210, 39);
            this.txtGiaPhong.TabIndex = 126;
            this.txtGiaPhong.Texts = "0";
            this.txtGiaPhong.UnderlinedStyle = false;
            // 
            // txtNgayThu
            // 
            this.txtNgayThu.BackColor = System.Drawing.Color.White;
            this.txtNgayThu.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtNgayThu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNgayThu.BorderRadius = 20;
            this.txtNgayThu.BorderSize = 2;
            this.txtNgayThu.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayThu.ForeColor = System.Drawing.Color.White;
            this.txtNgayThu.Location = new System.Drawing.Point(292, 388);
            this.txtNgayThu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNgayThu.Multiline = false;
            this.txtNgayThu.Name = "txtNgayThu";
            this.txtNgayThu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNgayThu.PasswordChar = false;
            this.txtNgayThu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNgayThu.PlaceholderText = "";
            this.txtNgayThu.Size = new System.Drawing.Size(210, 39);
            this.txtNgayThu.TabIndex = 118;
            this.txtNgayThu.Texts = "";
            this.txtNgayThu.UnderlinedStyle = false;
            // 
            // btnCapNhatPThu
            // 
            this.btnCapNhatPThu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnCapNhatPThu.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnCapNhatPThu.BorderColor = System.Drawing.Color.White;
            this.btnCapNhatPThu.BorderRadius = 20;
            this.btnCapNhatPThu.BorderSize = 1;
            this.btnCapNhatPThu.FlatAppearance.BorderSize = 0;
            this.btnCapNhatPThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatPThu.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatPThu.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatPThu.Image = ((System.Drawing.Image)(resources.GetObject("btnCapNhatPThu.Image")));
            this.btnCapNhatPThu.Location = new System.Drawing.Point(190, 456);
            this.btnCapNhatPThu.Name = "btnCapNhatPThu";
            this.btnCapNhatPThu.Size = new System.Drawing.Size(178, 58);
            this.btnCapNhatPThu.TabIndex = 119;
            this.btnCapNhatPThu.Text = "CẬP NHẬT";
            this.btnCapNhatPThu.TextColor = System.Drawing.Color.White;
            this.btnCapNhatPThu.UseVisualStyleBackColor = false;
            this.btnCapNhatPThu.Click += new System.EventHandler(this.btnCapNhatPThu_Click);
            // 
            // txtThanhToan
            // 
            this.txtThanhToan.BackColor = System.Drawing.Color.White;
            this.txtThanhToan.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtThanhToan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtThanhToan.BorderRadius = 20;
            this.txtThanhToan.BorderSize = 2;
            this.txtThanhToan.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhToan.ForeColor = System.Drawing.Color.Black;
            this.txtThanhToan.Location = new System.Drawing.Point(162, 322);
            this.txtThanhToan.Margin = new System.Windows.Forms.Padding(4);
            this.txtThanhToan.Multiline = false;
            this.txtThanhToan.Name = "txtThanhToan";
            this.txtThanhToan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtThanhToan.PasswordChar = false;
            this.txtThanhToan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtThanhToan.PlaceholderText = "";
            this.txtThanhToan.Size = new System.Drawing.Size(210, 39);
            this.txtThanhToan.TabIndex = 115;
            this.txtThanhToan.Texts = "0";
            this.txtThanhToan.UnderlinedStyle = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(193)))), ((int)(((byte)(195)))));
            this.btnThoat.BorderColor = System.Drawing.Color.White;
            this.btnThoat.BorderRadius = 20;
            this.btnThoat.BorderSize = 1;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(423, 456);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(178, 58);
            this.btnThoat.TabIndex = 120;
            this.btnThoat.Text = "THOÁT";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMaPT
            // 
            this.txtMaPT.BackColor = System.Drawing.Color.White;
            this.txtMaPT.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtMaPT.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaPT.BorderRadius = 20;
            this.txtMaPT.BorderSize = 2;
            this.txtMaPT.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaPT.ForeColor = System.Drawing.Color.White;
            this.txtMaPT.Location = new System.Drawing.Point(162, 130);
            this.txtMaPT.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaPT.Multiline = false;
            this.txtMaPT.Name = "txtMaPT";
            this.txtMaPT.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMaPT.PasswordChar = false;
            this.txtMaPT.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaPT.PlaceholderText = "";
            this.txtMaPT.Size = new System.Drawing.Size(210, 39);
            this.txtMaPT.TabIndex = 117;
            this.txtMaPT.Texts = "";
            this.txtMaPT.UnderlinedStyle = false;
            // 
            // lblNoCu
            // 
            this.lblNoCu.AutoSize = true;
            this.lblNoCu.BackColor = System.Drawing.Color.Transparent;
            this.lblNoCu.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoCu.Location = new System.Drawing.Point(447, 296);
            this.lblNoCu.Name = "lblNoCu";
            this.lblNoCu.Size = new System.Drawing.Size(53, 24);
            this.lblNoCu.TabIndex = 158;
            this.lblNoCu.Text = "Nợ cũ";
            // 
            // txtNoCu
            // 
            this.txtNoCu.BackColor = System.Drawing.Color.White;
            this.txtNoCu.BorderColor = System.Drawing.Color.SaddleBrown;
            this.txtNoCu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtNoCu.BorderRadius = 20;
            this.txtNoCu.BorderSize = 2;
            this.txtNoCu.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoCu.ForeColor = System.Drawing.Color.Black;
            this.txtNoCu.Location = new System.Drawing.Point(431, 322);
            this.txtNoCu.Margin = new System.Windows.Forms.Padding(4);
            this.txtNoCu.Multiline = false;
            this.txtNoCu.Name = "txtNoCu";
            this.txtNoCu.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtNoCu.PasswordChar = false;
            this.txtNoCu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtNoCu.PlaceholderText = "";
            this.txtNoCu.Size = new System.Drawing.Size(210, 39);
            this.txtNoCu.TabIndex = 157;
            this.txtNoCu.Texts = "";
            this.txtNoCu.UnderlinedStyle = false;
            // 
            // frmSuaPThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(796, 883);
            this.Controls.Add(this.pnlCTPhieuThu);
            this.Controls.Add(this.pnlPhieuThu);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuaPThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaPThu";
            this.pnlCTPhieuThu.ResumeLayout(false);
            this.pnlCTPhieuThu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTDV)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.pnlPhieuThu.ResumeLayout(false);
            this.pnlPhieuThu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn maDV;
        private System.Windows.Forms.ComboBox cmbMaPT;
        private System.Windows.Forms.DateTimePicker dtpNgayThu;
        private System.Windows.Forms.Label lblChiTiet;
        private RJControls.RJTextBox txtGiaPhong;
        private System.Windows.Forms.Label lblGiaPhong;
        private RJControls.RJTextBox txtNgayThu;
        private RJButton btnCapNhatPThu;
        private RJControls.RJTextBox txtSoLuong;
        private System.Windows.Forms.Label label3;
        private RJControls.RJTextBox rjTextBox2;
        private System.Windows.Forms.Label label2;
        private RJControls.RJTextBox txtThanhToan;
        private RJButton btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private RJControls.RJTextBox txtMaPT;
        private System.Windows.Forms.ToolStripMenuItem xoaHangToolStripMenuItem;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.ComboBox cmbMaDV;
        private RJButton btnThemCTPT;
        private System.Windows.Forms.Panel pnlCTPhieuThu;
        private System.Windows.Forms.DataGridView dgvCTDV;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label lblThongTinPT;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel pnlPhieuThu;
        private System.Windows.Forms.Label lblMaPThu;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGiaNuoc;
        private RJControls.RJTextBox rjTextBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGiaDien;
        private RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label lblNoCu;
        private RJControls.RJTextBox txtNoCu;
    }
}