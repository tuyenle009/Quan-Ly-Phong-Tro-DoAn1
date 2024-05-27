using Aspose.Words.Tables;
using BLL;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399.Folder_BaoCao
{
    public partial class frmBaoCaoTheoThoiGian : Form
    {
        ThongKeBLL tkbll = new ThongKeBLL();
        public frmBaoCaoTheoThoiGian()
        {
            InitializeComponent();
        }
        public frmBaoCaoTheoThoiGian(string ngayBD, string ngayKT)
        {
            InitializeComponent();
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

        private void frmBaoCaoTheoThoiGian_Load(object sender, EventArgs e)
        {

            this.rptBaoCaoTong.RefreshReport();
        }
    }
}
