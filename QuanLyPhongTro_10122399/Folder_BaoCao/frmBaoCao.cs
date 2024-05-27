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
    public partial class frmBaoCao : Form
    {

        //khai báo biến
        string thang = "";
        string nam = "";
        private ThongKeBLL tkbll = new ThongKeBLL();

        public frmBaoCao()
        {
            
            InitializeComponent();
            Console.WriteLine(thang);
            try
            {
                Console.WriteLine("______________");
                //tham chiếu tới report
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhongTro_10122399.Folder_BaoCao.Report.rdlc";
                //
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                //lấy giá trị của bảng
                //reportDataSource.Value = tkbll.layBangTKDV("1", "2024");
                //thêm bảng vừa lấy vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public frmBaoCao(string thang, string nam)
        {
            this.thang = thang;
            this.nam = nam;
            InitializeComponent();
            Console.WriteLine(thang);
            try
            {
                Console.WriteLine("______________");
                //tham chiếu tới report
                reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyPhongTro_10122399.Folder_BaoCao.Report.rdlc";
                // QuanLyPhongTro_10122399.Report1.rdlc
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "DataSet1";
                //lấy giá trị của bảng
                //reportDataSource.Value = tkbll.layBangTKDV(thang, nam);
                //thêm bảng vừa lấy vào báo cáo
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmBaoCao_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }


    }
}
