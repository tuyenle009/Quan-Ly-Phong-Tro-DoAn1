using BLL;
using DTO;
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

namespace QuanLyPhongTro_10122399.Folder_PhanQuyen
{
    public partial class frmCapQuyen : Form
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
        public frmCapQuyen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            hienThiQuyen();
            phanQuyen();
        }
        //phan quyen
        private void phanQuyen()
        {
            if (TaiKhoan.quyenTK == "Khách trọ")
            {
                btnLuu.Enabled = false;
            }

        }
        PhanQuyenBLL pqbll = new PhanQuyenBLL();
        //hien thi quyen
        private void hienThiQuyen()
        {
            NguoiDung ct = pqbll.layDsQuyen("Chủ trọ")[0];

            btnCTPhongTro.Checked = bool.Parse(ct.QuyenPhongTro);
            btnCTPC.Checked = bool.Parse(ct.QuyenPhieuChi);
            btnCTDV.Checked = bool.Parse(ct.QuyenDichVu);
            btnCTPhieuThu.Checked = bool.Parse(ct.QuyenPhieuThu);
            btnCTKT.Checked = bool.Parse(ct.QuyenKhachTro);
            btnCTHD.Checked = bool.Parse(ct.QuyenHopDong);
            btnCTTK.Checked = bool.Parse(ct.QuyenThongKe);
            btnCTCD.Checked = bool.Parse(ct.QuyenCaiDat);
            NguoiDung kt = pqbll.layDsQuyen("Khách trọ")[0];

            btnKTPT.Checked = bool.Parse(kt.QuyenPhongTro);
            btnKTPC.Checked = bool.Parse(kt.QuyenPhieuChi);
            btnKTDV.Checked = bool.Parse(kt.QuyenDichVu);
            btnKTPhieuThu.Checked = bool.Parse(kt.QuyenPhieuThu);
            btnKTKT.Checked = bool.Parse(kt.QuyenKhachTro);
            btnKTHD.Checked = bool.Parse(kt.QuyenHopDong);
            btnKTTK.Checked = bool.Parse(kt.QuyenThongKe);
            btnKTCD.Checked = bool.Parse(kt.QuyenCaiDat);
        }
        //update quyen
        private void btnLuu_Click(object sender, EventArgs e)
        {
            //quyen chu tro
            NguoiDung chuTro = new NguoiDung("Chủ trọ", btnCTPhongTro.Checked.ToString(), btnCTPC.Checked.ToString(), btnCTDV.Checked.ToString(),btnCTPhieuThu.Checked.ToString(), btnCTKT.Checked.ToString(), btnCTHD.Checked.ToString(), btnCTTK.Checked.ToString(), btnCTCD.Checked.ToString());
            NguoiDung nguoiDung = new NguoiDung("Khách trọ", btnKTPT.Checked.ToString(), btnKTPC.Checked.ToString(), btnKTDV.Checked.ToString(),btnKTPhieuThu.Checked.ToString(), btnKTKT.Checked.ToString(), btnKTHD.Checked.ToString(), btnKTTK.Checked.ToString(), btnKTCD.Checked.ToString());
            
            
            if (pqbll.capNhatQuyen(chuTro) && pqbll.capNhatQuyen(nguoiDung))
                MessageBox.Show("Cập nhật quyền thành công!", "Cập nhật quyền", MessageBoxButtons.OK);
            else
                MessageBox.Show("Cập nhật quyền thất bại!", "Cập nhật quyền", MessageBoxButtons.OK);

        }
    }
}
