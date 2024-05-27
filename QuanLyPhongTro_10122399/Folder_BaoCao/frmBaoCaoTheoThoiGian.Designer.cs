namespace QuanLyPhongTro_10122399.Folder_BaoCao
{
    partial class frmBaoCaoTheoThoiGian
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
            this.rptBaoCaoTong = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptBaoCaoTong
            // 
            this.rptBaoCaoTong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptBaoCaoTong.Location = new System.Drawing.Point(0, 0);
            this.rptBaoCaoTong.Name = "rptBaoCaoTong";
            this.rptBaoCaoTong.ServerReport.BearerToken = null;
            this.rptBaoCaoTong.Size = new System.Drawing.Size(1189, 585);
            this.rptBaoCaoTong.TabIndex = 0;
            // 
            // frmBaoCaoTheoThoiGian
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1189, 585);
            this.Controls.Add(this.rptBaoCaoTong);
            this.Font = new System.Drawing.Font("Inter", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "frmBaoCaoTheoThoiGian";
            this.Text = "frmBaoCaoTheoThoiGian";
            this.Load += new System.EventHandler(this.frmBaoCaoTheoThoiGian_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptBaoCaoTong;
    }
}