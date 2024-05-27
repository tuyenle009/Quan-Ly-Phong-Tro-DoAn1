using BLL;
using Microsoft.Reporting.WinForms;
using QuanLyPhongTro_10122399.Folder_TrangChu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399.Folder_BaoCao
{
    public partial class frmBaoCaoThongKe : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
   (
       int nLeftRect,     // x-coordinate of upper-left corner
       int nTopRect,      // y-coordinate of upper-left corner
       int nRightRect,    // x-coordinate of lower-right corner
       int nBottomRect,   // y-coordinate of lower-right corner
       int nWidthEllipse, // width of ellipse
       int nHeightEllipse // height of ellipse
   );
         ThongKeBLL tkbll = new ThongKeBLL();

        public frmBaoCaoThongKe()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            capNhatBaoCao(dtpNgayBD.Value.ToString("yyyy/MM/dd"), dtpNgayKT.Value.ToString("yyyy/MM/dd"));
            // Thiết lập nguồn tài nguyên báo cáo
        }


        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {

            //this.rptBaoCaoTong.RefreshReport();
            this.rptBaoCaoTong.RefreshReport();
        }


        //khi thay đổi ngày các sự kiện bên trong cũng thay đổi
        private void capNhatBaoCao(string ngayBD, string ngayKT)
        {
            // Xóa các ReportDataSource cũ trước khi thêm mới
            rptBaoCaoTong.LocalReport.DataSources.Clear();
            // Thiết lập nguồn tài nguyên báo cáo
            this.rptBaoCaoTong.LocalReport.ReportEmbeddedResource = "QuanLyPhongTro_10122399.Folder_BaoCao.rptThongKe.rdlc";
            // Dien gia tri vao các bảng
            ReportDataSource reportDataSource1 = new ReportDataSource();
            reportDataSource1.Name = "dsTKTieuThuDien";
            reportDataSource1.Value = tkbll.ThongKeTieuThuDien(ngayBD, ngayKT);
            rptBaoCaoTong.LocalReport.DataSources.Add(reportDataSource1);

            ReportDataSource reportDataSource2 = new ReportDataSource();
            reportDataSource2.Name = "dsTKChiTietDV";
            reportDataSource2.Value = tkbll.TKChiTietDV(ngayBD, ngayKT);
            rptBaoCaoTong.LocalReport.DataSources.Add(reportDataSource2);

            ReportDataSource reportDataSource3 = new ReportDataSource();
            reportDataSource3.Name = "dsTKDichVu";
            reportDataSource3.Value = tkbll.TKDV(ngayBD, ngayKT);
            rptBaoCaoTong.LocalReport.DataSources.Add(reportDataSource3);

            ReportDataSource reportDataSource4 = new ReportDataSource();
            reportDataSource4.Name = "dsTKPhongThue";
            reportDataSource4.Value = tkbll.TKPhongThue(ngayBD, ngayKT);
            rptBaoCaoTong.LocalReport.DataSources.Add(reportDataSource4);

            ReportDataSource reportDataSource5 = new ReportDataSource();
            reportDataSource5.Name = "dsTKThuTIen";
            reportDataSource5.Value = tkbll.TKThuTien(ngayBD, ngayKT);
            rptBaoCaoTong.LocalReport.DataSources.Add(reportDataSource5);

            ReportDataSource reportDataSource6 = new ReportDataSource();
            reportDataSource6.Name = "dsTKTongHop";
            reportDataSource6.Value = tkbll.TKTongHop(ngayBD, ngayKT);
            rptBaoCaoTong.LocalReport.DataSources.Add(reportDataSource6);

        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Xóa các ReportDataSource cũ trước khi thêm mới
            //rptBaoCaoTong.LocalReport.DataSources.Clear();
            if(dtpNgayBD.Value.Date > dtpNgayKT.Value.Date)
            {
                MessageBox.Show("Ngày đắt đầu phải nhỏ hơn ngày kết thúc!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                pnlBCTK.Controls.Clear();
                frmBaoCaoTheoThoiGian frmBaoCao = new frmBaoCaoTheoThoiGian(dtpNgayBD.Value.ToString("yyyy/MM/dd"), dtpNgayKT.Value.ToString("yyyy/MM/dd"));
                frmBaoCao.TopLevel = false;
                frmBaoCao.Dock = DockStyle.Fill;//fill up panel hien tai vao
                frmBaoCao.FormBorderStyle = FormBorderStyle.None;
                pnlBCTK.Controls.Add(frmBaoCao);
                frmBaoCao.Show();
            }
        }
    }
}
