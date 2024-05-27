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

namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    public partial class frmXuatPhieuThu : Form
    {
        PhieuThuBLL ptbll = new PhieuThuBLL();
        public int width = 588;
        public int high = 798;
        public frmXuatPhieuThu(string maPThu,string tenPT, string ngayThu, string tienPhong, string dSoCu, string dSoMoi, string dTieuThu, string dThanhTien, 
            string nSoCu, string nSoMoi, string nTieuThu, string nThanhTien, string noCu, string TongTien, string daTra)
        {
            
            //588, 798
            InitializeComponent();
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pTenPhong",tenPT),
                new Microsoft.Reporting.WinForms.ReportParameter("pNgayThu",ngayThu),
                new Microsoft.Reporting.WinForms.ReportParameter("pTienPhong",tienPhong),
                new Microsoft.Reporting.WinForms.ReportParameter("pSoMoi",dSoMoi),
                new Microsoft.Reporting.WinForms.ReportParameter("pSoCu",dSoCu),
                new Microsoft.Reporting.WinForms.ReportParameter("pTieuThu",dTieuThu),
                new Microsoft.Reporting.WinForms.ReportParameter("pThanhTien",dThanhTien),
                new Microsoft.Reporting.WinForms.ReportParameter("pNSoMoi",nSoMoi),
                new Microsoft.Reporting.WinForms.ReportParameter("pNSoCu",nSoCu),
                new Microsoft.Reporting.WinForms.ReportParameter("pNTieuThu",nTieuThu),
                new Microsoft.Reporting.WinForms.ReportParameter("pNThanhTien",nThanhTien),
                new Microsoft.Reporting.WinForms.ReportParameter("pNoCu",noCu),
                new Microsoft.Reporting.WinForms.ReportParameter("pTongTien",TongTien),
                new Microsoft.Reporting.WinForms.ReportParameter("pThoiGianLapPhieu",DateTime.Now.ToString())

            };
            //this.rptVPhieuThu.LocalReport.ReportPath = "rptPThu.rdlc";
            this.rptVPhieuThu.LocalReport.ReportEmbeddedResource = "QuanLyPhongTro_10122399.Folder_PhieuThu.rptPThu.rdlc";
            this.rptVPhieuThu.LocalReport.SetParameters(para);
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsDichVu";
            //lấy giá trị của bảng
            reportDataSource.Value = ptbll.layBangDV(maPThu);
            //thêm bảng vừa lấy vào báo cáo
            rptVPhieuThu.LocalReport.DataSources.Add(reportDataSource);
        }
        public frmXuatPhieuThu(string thangNam)
        {
            //832, 798
            width = 850;
            high = 798;
            InitializeComponent();
            this.rptVPhieuThu.LocalReport.ReportEmbeddedResource = "QuanLyPhongTro_10122399.Folder_PhieuThu.rptTongPThu.rdlc";
            ReportDataSource reportDataSource = new ReportDataSource();
            reportDataSource.Name = "dsTongPhieuThu";
            //lấy giá trị của bảng
            reportDataSource.Value = ptbll.layToanBoPThu(thangNam);
            //thêm bảng vừa lấy vào báo cáo
            rptVPhieuThu.LocalReport.DataSources.Add(reportDataSource);
        }
        private void frmXuatPhieuThu_Load(object sender, EventArgs e)
        {
            //thay doi kich thuoc 
            this.Size = new System.Drawing.Size(width, high);
            this.rptVPhieuThu.RefreshReport();
        }
    }
}
