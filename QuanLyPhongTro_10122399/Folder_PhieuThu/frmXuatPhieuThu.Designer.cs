namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    partial class frmXuatPhieuThu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXuatPhieuThu));
            this.rptVPhieuThu = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptVPhieuThu
            // 
            this.rptVPhieuThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptVPhieuThu.LocalReport.ReportEmbeddedResource = "QuanLyPhongTro_10122399.Folder_PhieuThu.rptTongPThu.rdlc";
            this.rptVPhieuThu.Location = new System.Drawing.Point(0, 0);
            this.rptVPhieuThu.Name = "rptVPhieuThu";
            this.rptVPhieuThu.ServerReport.BearerToken = null;
            this.rptVPhieuThu.Size = new System.Drawing.Size(858, 759);
            this.rptVPhieuThu.TabIndex = 0;
            // 
            // frmXuatPhieuThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 759);
            this.Controls.Add(this.rptVPhieuThu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmXuatPhieuThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmXuatPhieuThu";
            this.Load += new System.EventHandler(this.frmXuatPhieuThu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptVPhieuThu;
    }
}