namespace QuanLyPhongTro_10122399.Folder_PhanQuyen
{
    partial class frmTaiKhoan
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
            this.cmbQuyen = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grbDanhSachKT = new System.Windows.Forms.GroupBox();
            this.dgvND = new System.Windows.Forms.DataGridView();
            this.taiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGmail = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.btnCapNhatND = new QuanLyPhongTro_10122399.RJButton();
            this.btnXoaND = new QuanLyPhongTro_10122399.RJButton();
            this.btnThemND = new QuanLyPhongTro_10122399.RJButton();
            this.txtMatKhau = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtDonViTinh = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtTaiKhoan = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.grbDanhSachKT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbQuyen
            // 
            this.cmbQuyen.BackColor = System.Drawing.Color.White;
            this.cmbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbQuyen.Font = new System.Drawing.Font("Quicksand", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbQuyen.FormattingEnabled = true;
            this.cmbQuyen.Items.AddRange(new object[] {
            "Chủ trọ",
            "Khách trọ"});
            this.cmbQuyen.Location = new System.Drawing.Point(715, 594);
            this.cmbQuyen.Name = "cmbQuyen";
            this.cmbQuyen.Size = new System.Drawing.Size(128, 31);
            this.cmbQuyen.TabIndex = 129;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(252, 596);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 24);
            this.label7.TabIndex = 123;
            this.label7.Text = "Mật Khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(631, 596);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 24);
            this.label6.TabIndex = 122;
            this.label6.Text = "Quyền:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(252, 529);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 24);
            this.label5.TabIndex = 121;
            this.label5.Text = "Tài Khoản:";
            // 
            // grbDanhSachKT
            // 
            this.grbDanhSachKT.Controls.Add(this.dgvND);
            this.grbDanhSachKT.Font = new System.Drawing.Font("Inter", 12F);
            this.grbDanhSachKT.Location = new System.Drawing.Point(27, 124);
            this.grbDanhSachKT.Name = "grbDanhSachKT";
            this.grbDanhSachKT.Size = new System.Drawing.Size(1156, 358);
            this.grbDanhSachKT.TabIndex = 120;
            this.grbDanhSachKT.TabStop = false;
            // 
            // dgvND
            // 
            this.dgvND.AllowUserToAddRows = false;
            this.dgvND.BackgroundColor = System.Drawing.Color.White;
            this.dgvND.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvND.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvND.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.taiKhoan,
            this.matKhau,
            this.gmail,
            this.quyen});
            this.dgvND.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvND.Location = new System.Drawing.Point(3, 23);
            this.dgvND.Name = "dgvND";
            this.dgvND.ReadOnly = true;
            this.dgvND.RowHeadersWidth = 51;
            this.dgvND.RowTemplate.Height = 40;
            this.dgvND.Size = new System.Drawing.Size(1150, 332);
            this.dgvND.TabIndex = 1;
            this.dgvND.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvND_CellClick);
            this.dgvND.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvND_CellDoubleClick);
            this.dgvND.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvND_RowPrePaint);
            // 
            // taiKhoan
            // 
            this.taiKhoan.DataPropertyName = "taiKhoan";
            this.taiKhoan.HeaderText = "Tài khoản";
            this.taiKhoan.Name = "taiKhoan";
            this.taiKhoan.ReadOnly = true;
            this.taiKhoan.Width = 200;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "Mật khẩu";
            this.matKhau.MinimumWidth = 6;
            this.matKhau.Name = "matKhau";
            this.matKhau.ReadOnly = true;
            this.matKhau.Width = 300;
            // 
            // gmail
            // 
            this.gmail.DataPropertyName = "gmail";
            this.gmail.HeaderText = "Gmail";
            this.gmail.MinimumWidth = 6;
            this.gmail.Name = "gmail";
            this.gmail.ReadOnly = true;
            this.gmail.Width = 250;
            // 
            // quyen
            // 
            this.quyen.DataPropertyName = "quyen";
            this.quyen.HeaderText = "Quyền";
            this.quyen.MinimumWidth = 6;
            this.quyen.Name = "quyen";
            this.quyen.ReadOnly = true;
            this.quyen.Width = 300;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(631, 529);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 131;
            this.label1.Text = "Gmail:";
            // 
            // txtGmail
            // 
            this.txtGmail.BackColor = System.Drawing.Color.White;
            this.txtGmail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtGmail.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtGmail.BorderRadius = 15;
            this.txtGmail.BorderSize = 2;
            this.txtGmail.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGmail.Location = new System.Drawing.Point(699, 520);
            this.txtGmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtGmail.Multiline = false;
            this.txtGmail.Name = "txtGmail";
            this.txtGmail.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtGmail.PasswordChar = false;
            this.txtGmail.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtGmail.PlaceholderText = "";
            this.txtGmail.Size = new System.Drawing.Size(245, 39);
            this.txtGmail.TabIndex = 132;
            this.txtGmail.Texts = "";
            this.txtGmail.UnderlinedStyle = false;
            // 
            // btnCapNhatND
            // 
            this.btnCapNhatND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnCapNhatND.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnCapNhatND.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnCapNhatND.BorderRadius = 30;
            this.btnCapNhatND.BorderSize = 1;
            this.btnCapNhatND.FlatAppearance.BorderSize = 0;
            this.btnCapNhatND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhatND.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhatND.ForeColor = System.Drawing.Color.White;
            this.btnCapNhatND.Location = new System.Drawing.Point(717, 49);
            this.btnCapNhatND.Name = "btnCapNhatND";
            this.btnCapNhatND.Size = new System.Drawing.Size(192, 63);
            this.btnCapNhatND.TabIndex = 130;
            this.btnCapNhatND.Text = "Cập nhật";
            this.btnCapNhatND.TextColor = System.Drawing.Color.White;
            this.btnCapNhatND.UseVisualStyleBackColor = false;
            this.btnCapNhatND.Click += new System.EventHandler(this.btnCapNhatND_Click);
            // 
            // btnXoaND
            // 
            this.btnXoaND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaND.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaND.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnXoaND.BorderRadius = 30;
            this.btnXoaND.BorderSize = 1;
            this.btnXoaND.FlatAppearance.BorderSize = 0;
            this.btnXoaND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaND.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaND.ForeColor = System.Drawing.Color.White;
            this.btnXoaND.Location = new System.Drawing.Point(1046, 49);
            this.btnXoaND.Name = "btnXoaND";
            this.btnXoaND.Size = new System.Drawing.Size(125, 63);
            this.btnXoaND.TabIndex = 128;
            this.btnXoaND.Text = "Xóa ";
            this.btnXoaND.TextColor = System.Drawing.Color.White;
            this.btnXoaND.UseVisualStyleBackColor = false;
            this.btnXoaND.Click += new System.EventHandler(this.btnXoaND_Click);
            // 
            // btnThemND
            // 
            this.btnThemND.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemND.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemND.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThemND.BorderRadius = 30;
            this.btnThemND.BorderSize = 1;
            this.btnThemND.FlatAppearance.BorderSize = 0;
            this.btnThemND.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemND.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemND.ForeColor = System.Drawing.Color.White;
            this.btnThemND.Location = new System.Drawing.Point(915, 49);
            this.btnThemND.Name = "btnThemND";
            this.btnThemND.Size = new System.Drawing.Size(125, 63);
            this.btnThemND.TabIndex = 127;
            this.btnThemND.Text = "Thêm";
            this.btnThemND.TextColor = System.Drawing.Color.White;
            this.btnThemND.UseVisualStyleBackColor = false;
            this.btnThemND.Click += new System.EventHandler(this.btnThemND_Click);
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.BackColor = System.Drawing.Color.White;
            this.txtMatKhau.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtMatKhau.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMatKhau.BorderRadius = 15;
            this.txtMatKhau.BorderSize = 2;
            this.txtMatKhau.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(348, 587);
            this.txtMatKhau.Margin = new System.Windows.Forms.Padding(4);
            this.txtMatKhau.Multiline = false;
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtMatKhau.PasswordChar = false;
            this.txtMatKhau.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMatKhau.PlaceholderText = "";
            this.txtMatKhau.Size = new System.Drawing.Size(223, 39);
            this.txtMatKhau.TabIndex = 126;
            this.txtMatKhau.Texts = "";
            this.txtMatKhau.UnderlinedStyle = false;
            // 
            // txtDonViTinh
            // 
            this.txtDonViTinh.BackColor = System.Drawing.Color.White;
            this.txtDonViTinh.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtDonViTinh.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtDonViTinh.BorderRadius = 15;
            this.txtDonViTinh.BorderSize = 2;
            this.txtDonViTinh.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViTinh.ForeColor = System.Drawing.Color.White;
            this.txtDonViTinh.Location = new System.Drawing.Point(701, 589);
            this.txtDonViTinh.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonViTinh.Multiline = false;
            this.txtDonViTinh.Name = "txtDonViTinh";
            this.txtDonViTinh.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtDonViTinh.PasswordChar = false;
            this.txtDonViTinh.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtDonViTinh.PlaceholderText = "";
            this.txtDonViTinh.Size = new System.Drawing.Size(153, 39);
            this.txtDonViTinh.TabIndex = 125;
            this.txtDonViTinh.Texts = "";
            this.txtDonViTinh.UnderlinedStyle = false;
            // 
            // txtTaiKhoan
            // 
            this.txtTaiKhoan.BackColor = System.Drawing.Color.White;
            this.txtTaiKhoan.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtTaiKhoan.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtTaiKhoan.BorderRadius = 15;
            this.txtTaiKhoan.BorderSize = 2;
            this.txtTaiKhoan.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaiKhoan.Location = new System.Drawing.Point(348, 520);
            this.txtTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txtTaiKhoan.Multiline = false;
            this.txtTaiKhoan.Name = "txtTaiKhoan";
            this.txtTaiKhoan.Padding = new System.Windows.Forms.Padding(10, 7, 10, 7);
            this.txtTaiKhoan.PasswordChar = false;
            this.txtTaiKhoan.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtTaiKhoan.PlaceholderText = "";
            this.txtTaiKhoan.Size = new System.Drawing.Size(223, 39);
            this.txtTaiKhoan.TabIndex = 124;
            this.txtTaiKhoan.Texts = "";
            this.txtTaiKhoan.UnderlinedStyle = false;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(34)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(1205, 660);
            this.Controls.Add(this.txtGmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCapNhatND);
            this.Controls.Add(this.cmbQuyen);
            this.Controls.Add(this.btnXoaND);
            this.Controls.Add(this.btnThemND);
            this.Controls.Add(this.txtMatKhau);
            this.Controls.Add(this.txtDonViTinh);
            this.Controls.Add(this.txtTaiKhoan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbDanhSachKT);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmTaiKhoan";
            this.Text = "frmTaiKhoan";
            this.grbDanhSachKT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvND)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnCapNhatND;
        private System.Windows.Forms.ComboBox cmbQuyen;
        private RJButton btnXoaND;
        private RJButton btnThemND;
        private RJControls.RJTextBox txtMatKhau;
        private RJControls.RJTextBox txtDonViTinh;
        private RJControls.RJTextBox txtTaiKhoan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grbDanhSachKT;
        private System.Windows.Forms.DataGridView dgvND;
        private RJControls.RJTextBox txtGmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn taiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn gmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyen;
    }
}