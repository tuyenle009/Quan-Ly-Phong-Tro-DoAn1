namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    partial class frmSuaDN
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
            this.lblThongTinPT = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpToiNgay = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbMaPT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMaDN = new System.Windows.Forms.Label();
            this.btnThoat = new QuanLyPhongTro_10122399.RJButton();
            this.btnSuaDN = new QuanLyPhongTro_10122399.RJButton();
            this.txtChiSoMoi = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtChiSoCu = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.rjTextBox1 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.rjTextBox2 = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.txtMaDV = new QuanLyPhongTro_10122399.RJControls.RJTextBox();
            this.SuspendLayout();
            // 
            // lblThongTinPT
            // 
            this.lblThongTinPT.AutoSize = true;
            this.lblThongTinPT.BackColor = System.Drawing.Color.Transparent;
            this.lblThongTinPT.Font = new System.Drawing.Font("iCiel Cadena", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.lblThongTinPT.Location = new System.Drawing.Point(127, 49);
            this.lblThongTinPT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblThongTinPT.Name = "lblThongTinPT";
            this.lblThongTinPT.Size = new System.Drawing.Size(418, 55);
            this.lblThongTinPT.TabIndex = 143;
            this.lblThongTinPT.Text = "THÔNG TIN ĐIỆN NƯỚC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.label6.Location = new System.Drawing.Point(122, 304);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 24);
            this.label6.TabIndex = 138;
            this.label6.Text = "Chỉ số mới";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(402, 304);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 24);
            this.label5.TabIndex = 137;
            this.label5.Text = "Chỉ số cũ";
            // 
            // dtpToiNgay
            // 
            this.dtpToiNgay.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpToiNgay.CustomFormat = "MM/yyyy";
            this.dtpToiNgay.Font = new System.Drawing.Font("Quicksand", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToiNgay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpToiNgay.Location = new System.Drawing.Point(238, 483);
            this.dtpToiNgay.Margin = new System.Windows.Forms.Padding(4);
            this.dtpToiNgay.Name = "dtpToiNgay";
            this.dtpToiNgay.Size = new System.Drawing.Size(154, 31);
            this.dtpToiNgay.TabIndex = 135;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(271, 445);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 132;
            this.label4.Text = "Thời gian:";
            // 
            // cmbMaPT
            // 
            this.cmbMaPT.BackColor = System.Drawing.Color.White;
            this.cmbMaPT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMaPT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbMaPT.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMaPT.FormattingEnabled = true;
            this.cmbMaPT.Location = new System.Drawing.Point(382, 184);
            this.cmbMaPT.Margin = new System.Windows.Forms.Padding(4);
            this.cmbMaPT.Name = "cmbMaPT";
            this.cmbMaPT.Size = new System.Drawing.Size(153, 32);
            this.cmbMaPT.TabIndex = 130;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(418, 152);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 24);
            this.label2.TabIndex = 127;
            this.label2.Text = "Mã PT";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(134, 152);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 24);
            this.label1.TabIndex = 126;
            this.label1.Text = "Mã DV";
            // 
            // lblMaDN
            // 
            this.lblMaDN.AutoSize = true;
            this.lblMaDN.BackColor = System.Drawing.Color.White;
            this.lblMaDN.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaDN.Location = new System.Drawing.Point(108, 188);
            this.lblMaDN.Name = "lblMaDN";
            this.lblMaDN.Size = new System.Drawing.Size(57, 24);
            this.lblMaDN.TabIndex = 147;
            this.lblMaDN.Text = "MaHD";
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThoat.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThoat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnThoat.BorderRadius = 30;
            this.btnThoat.BorderSize = 1;
            this.btnThoat.FlatAppearance.BorderSize = 0;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(365, 642);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(170, 63);
            this.btnThoat.TabIndex = 146;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextColor = System.Drawing.Color.White;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSuaDN
            // 
            this.btnSuaDN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnSuaDN.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnSuaDN.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.btnSuaDN.BorderRadius = 30;
            this.btnSuaDN.BorderSize = 1;
            this.btnSuaDN.FlatAppearance.BorderSize = 0;
            this.btnSuaDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDN.Font = new System.Drawing.Font("Quicksand", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDN.ForeColor = System.Drawing.Color.White;
            this.btnSuaDN.Location = new System.Drawing.Point(148, 642);
            this.btnSuaDN.Name = "btnSuaDN";
            this.btnSuaDN.Size = new System.Drawing.Size(170, 63);
            this.btnSuaDN.TabIndex = 0;
            this.btnSuaDN.Text = "Cập nhật";
            this.btnSuaDN.TextColor = System.Drawing.Color.White;
            this.btnSuaDN.UseVisualStyleBackColor = false;
            this.btnSuaDN.Click += new System.EventHandler(this.btnSuaDN_Click);
            // 
            // txtChiSoMoi
            // 
            this.txtChiSoMoi.BackColor = System.Drawing.Color.White;
            this.txtChiSoMoi.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtChiSoMoi.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtChiSoMoi.BorderRadius = 15;
            this.txtChiSoMoi.BorderSize = 2;
            this.txtChiSoMoi.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoMoi.Location = new System.Drawing.Point(366, 329);
            this.txtChiSoMoi.Margin = new System.Windows.Forms.Padding(6);
            this.txtChiSoMoi.Multiline = false;
            this.txtChiSoMoi.Name = "txtChiSoMoi";
            this.txtChiSoMoi.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.txtChiSoMoi.PasswordChar = false;
            this.txtChiSoMoi.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChiSoMoi.PlaceholderText = "";
            this.txtChiSoMoi.Size = new System.Drawing.Size(189, 45);
            this.txtChiSoMoi.TabIndex = 140;
            this.txtChiSoMoi.Texts = "";
            this.txtChiSoMoi.UnderlinedStyle = false;
            // 
            // txtChiSoCu
            // 
            this.txtChiSoCu.BackColor = System.Drawing.Color.White;
            this.txtChiSoCu.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtChiSoCu.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtChiSoCu.BorderRadius = 15;
            this.txtChiSoCu.BorderSize = 2;
            this.txtChiSoCu.Font = new System.Drawing.Font("Quicksand", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChiSoCu.Location = new System.Drawing.Point(87, 329);
            this.txtChiSoCu.Margin = new System.Windows.Forms.Padding(6);
            this.txtChiSoCu.Multiline = false;
            this.txtChiSoCu.Name = "txtChiSoCu";
            this.txtChiSoCu.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.txtChiSoCu.PasswordChar = false;
            this.txtChiSoCu.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtChiSoCu.PlaceholderText = "";
            this.txtChiSoCu.Size = new System.Drawing.Size(189, 45);
            this.txtChiSoCu.TabIndex = 139;
            this.txtChiSoCu.Texts = "";
            this.txtChiSoCu.UnderlinedStyle = false;
            // 
            // rjTextBox1
            // 
            this.rjTextBox1.BackColor = System.Drawing.Color.White;
            this.rjTextBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjTextBox1.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox1.BorderRadius = 15;
            this.rjTextBox1.BorderSize = 2;
            this.rjTextBox1.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox1.ForeColor = System.Drawing.Color.White;
            this.rjTextBox1.Location = new System.Drawing.Point(220, 475);
            this.rjTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox1.Multiline = false;
            this.rjTextBox1.Name = "rjTextBox1";
            this.rjTextBox1.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.rjTextBox1.PasswordChar = false;
            this.rjTextBox1.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox1.PlaceholderText = "";
            this.rjTextBox1.Size = new System.Drawing.Size(198, 45);
            this.rjTextBox1.TabIndex = 136;
            this.rjTextBox1.Texts = "01/01/2222";
            this.rjTextBox1.UnderlinedStyle = false;
            // 
            // rjTextBox2
            // 
            this.rjTextBox2.BackColor = System.Drawing.Color.White;
            this.rjTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.rjTextBox2.BorderFocusColor = System.Drawing.Color.HotPink;
            this.rjTextBox2.BorderRadius = 15;
            this.rjTextBox2.BorderSize = 2;
            this.rjTextBox2.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rjTextBox2.ForeColor = System.Drawing.Color.White;
            this.rjTextBox2.Location = new System.Drawing.Point(366, 177);
            this.rjTextBox2.Margin = new System.Windows.Forms.Padding(6);
            this.rjTextBox2.Multiline = false;
            this.rjTextBox2.Name = "rjTextBox2";
            this.rjTextBox2.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.rjTextBox2.PasswordChar = false;
            this.rjTextBox2.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.rjTextBox2.PlaceholderText = "";
            this.rjTextBox2.Size = new System.Drawing.Size(189, 45);
            this.rjTextBox2.TabIndex = 129;
            this.rjTextBox2.Texts = "";
            this.rjTextBox2.UnderlinedStyle = false;
            // 
            // txtMaDV
            // 
            this.txtMaDV.BackColor = System.Drawing.Color.White;
            this.txtMaDV.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(173)))), ((int)(((byte)(192)))));
            this.txtMaDV.BorderFocusColor = System.Drawing.Color.HotPink;
            this.txtMaDV.BorderRadius = 15;
            this.txtMaDV.BorderSize = 2;
            this.txtMaDV.Font = new System.Drawing.Font("Quicksand Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDV.Location = new System.Drawing.Point(87, 177);
            this.txtMaDV.Margin = new System.Windows.Forms.Padding(6);
            this.txtMaDV.Multiline = false;
            this.txtMaDV.Name = "txtMaDV";
            this.txtMaDV.Padding = new System.Windows.Forms.Padding(15, 10, 15, 10);
            this.txtMaDV.PasswordChar = false;
            this.txtMaDV.PlaceholderColor = System.Drawing.Color.DarkGray;
            this.txtMaDV.PlaceholderText = "";
            this.txtMaDV.Size = new System.Drawing.Size(189, 45);
            this.txtMaDV.TabIndex = 128;
            this.txtMaDV.Texts = "";
            this.txtMaDV.UnderlinedStyle = false;
            // 
            // frmSuaDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 755);
            this.Controls.Add(this.lblMaDN);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnSuaDN);
            this.Controls.Add(this.lblThongTinPT);
            this.Controls.Add(this.txtChiSoMoi);
            this.Controls.Add(this.txtChiSoCu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpToiNgay);
            this.Controls.Add(this.rjTextBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbMaPT);
            this.Controls.Add(this.rjTextBox2);
            this.Controls.Add(this.txtMaDV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSuaDN";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSuaDN";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RJButton btnThoat;
        private RJButton btnSuaDN;
        private System.Windows.Forms.Label lblThongTinPT;
        private RJControls.RJTextBox txtChiSoMoi;
        private RJControls.RJTextBox txtChiSoCu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpToiNgay;
        private RJControls.RJTextBox rjTextBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbMaPT;
        private RJControls.RJTextBox rjTextBox2;
        private RJControls.RJTextBox txtMaDV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMaDN;
    }
}