using BLL;
using DTO;
using QuanLyPhongTro_10122399.Folder_BaoCao;
using QuanLyPhongTro_10122399.Folder_DichVu;
using QuanLyPhongTro_10122399.Folder_HopDong;
using QuanLyPhongTro_10122399.Folder_PhanQuyen;
using QuanLyPhongTro_10122399.Folder_PhieuChi;
using QuanLyPhongTro_10122399.Folder_PhieuThu;
using QuanLyPhongTro_10122399.Folder_PhongTro;
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

namespace QuanLyPhongTro_10122399
{
    public partial class frmGiaoDien2 : Form
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
        public frmGiaoDien2()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //show form trang chu
            //hien thi frm trang chu
            frmTrangChu2 frmTrangChu = new frmTrangChu2();
            frmTrangChu.TopLevel = false;
            frmTrangChu.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmTrangChu.FormBorderStyle = FormBorderStyle.None;
            pnlSubMain.Controls.Add(frmTrangChu);
            frmTrangChu.Show();
            //____________________
            customizeDesign();
            //phan quyen
            phanQuyen();
        }
        PhanQuyenBLL pqBLL = new PhanQuyenBLL();
        //Phan quyen nguoi dung
        public string Phongtro ="True";
        public string KhachTro = "True";

        //lay quyen ra
        public void phanQuyen()
        {
            btnThongKe.Visible = false;
            NguoiDung nd = pqBLL.layDsQuyen(TaiKhoan.quyenTK)[0];
            //QuyenPhongTro
            Phongtro = nd.QuyenPhongTro;
            string PhieuChi = nd.QuyenPhieuChi;
            string DichVu = nd.QuyenDichVu;
            string PhieuThu = nd.QuyenPhieuThu;
            KhachTro = nd.QuyenKhachTro;
            string HopDong = nd.QuyenHopDong;
            string ThongKe = nd.QuyenThongKe;
            string CaiDat = nd.QuyenCaiDat;
            //phan quyen
           
            if (bool.Parse(PhieuChi))
                btnPhieuChi.Visible = true;
            else
                btnPhieuChi.Visible = false;
            if (bool.Parse(DichVu))
                btnDichVu.Visible = true;
            else
                btnDichVu.Visible = false;
            if (bool.Parse(PhieuThu))
                btnPhieuThu.Visible = true;
            else
                btnPhieuThu.Visible = false;
            
            if (bool.Parse(HopDong))
                btnHopDong.Visible = true;
            else
                btnHopDong.Visible = false;
            if (bool.Parse(ThongKe))
                btnThongKe.Visible = true;
            else
                btnThongKe.Visible = false;
            if (bool.Parse(CaiDat))
                btnCaiDat.Visible = true;
            else
                btnCaiDat.Visible = false;

        }
        private void customizeDesign()
        {
            pnlSubPT.Visible = false;
            pnlSubKT.Visible = false;
        }
        private void hideSubmenu(int cat)
        { //category 1-pt 2-kt
            if (cat == 1)
                if (pnlSubPT.Visible == true)
                {
                    pnlSubPT.Visible = false;
                }
            else
                if (pnlSubKT.Visible == true)
                {
                    pnlSubKT.Visible = false;
                }
        }
        private void showSubmenu(Panel submenu, int cat)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu(cat);
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }
        //trang chu

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            //btnTrangChu.BackColor = Color.FromArgb(255, 181, 197);
            btnTrangChu.BackColor = Color.FromArgb(249, 173, 192);
            pnlSubMain.Controls.Clear();

            //249, 173, 192
            //hien thi frm trang chu
            frmTrangChu2 frmTrangChu = new frmTrangChu2();
            frmTrangChu.TopLevel = false;
            frmTrangChu.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmTrangChu.FormBorderStyle = FormBorderStyle.None;
            pnlSubMain.Controls.Add(frmTrangChu);
            frmTrangChu.Show();
        }
        //btn phong tro
        private void btnPhongTro_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubPT,1);
            //btnTrangChu.BackColor = Color.FromArgb(255, 181, 197);
            btnPhongTro.BackColor = Color.FromArgb(249, 173, 192);

            pnlSubMain.Controls.Clear();//xoa panel hien co
            if (bool.Parse(Phongtro)) //neu duoc phan quyen thi se hien thi
            {
                frmPhongTro frmPT = new frmPhongTro();
                frmPT.TopLevel = false;
                frmPT.Dock = DockStyle.Fill;//fill up panel hien tai vao
                frmPT.FormBorderStyle = FormBorderStyle.None;
                pnlSubMain.Controls.Add(frmPT);
                frmPT.Show();
            }
        }
        //btn phieu chi
        private void btnPhieuChi_Click(object sender, EventArgs e)
        {
            pnlSubMain.Controls.Clear();//xoa panel hien co
            frmPhieuChi frmPC = new frmPhieuChi();
            frmPC.TopLevel = false;
            frmPC.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmPC.FormBorderStyle = FormBorderStyle.None;
            pnlSubMain.Controls.Add(frmPC);
            frmPC.Show();
        }
        //Dich vu

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            pnlSubMain.Controls.Clear();//xoa panel hien co
            frmDichVu frmDV = new frmDichVu();
            frmDV.TopLevel = false;
            frmDV.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmDV.FormBorderStyle = FormBorderStyle.None;
            pnlSubMain.Controls.Add(frmDV);
            frmDV.Show();
        }
        //btn phieu thu
        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            pnlSubMain.Controls.Clear();//xoa panel hien co
            frmPhieuThu frmPT = new frmPhieuThu();
            frmPT.TopLevel = false;
            frmPT.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmPT.FormBorderStyle = FormBorderStyle.None;
            pnlSubMain.Controls.Add(frmPT);
            frmPT.Show();
        }
        //btn khach tro

        private void btnKhachTro_Click(object sender, EventArgs e)
        {
            showSubmenu(pnlSubKT, 2);

            btnKhachTro.BackColor = Color.FromArgb(249, 173, 192);//doi mau cho lable
            pnlSubMain.Controls.Clear();//xoa panel hien co
            if (bool.Parse(KhachTro)) //neu duoc phan quyen thi se hien thi
            {
                frmKhachTro1 frmKT = new frmKhachTro1();
                frmKT.TopLevel = false;
                frmKT.Dock = DockStyle.Fill;//fill up panel hien tai vao
                frmKT.FormBorderStyle = FormBorderStyle.None;
                pnlSubMain.Controls.Add(frmKT);
                frmKT.Show();
            }
        }
        //btn hop dong
        private void btnHopDong_Click(object sender, EventArgs e)
        {

            pnlSubMain.Controls.Clear();//xoa panel hien co
            frmHopDong frmHD = new frmHopDong();
            frmHD.TopLevel = false;
            frmHD.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmHD.FormBorderStyle = FormBorderStyle.None;
            pnlSubMain.Controls.Add(frmHD);
            frmHD.Show();
        }

        private void btnChiTietKhachTro_Click(object sender, EventArgs e)
        {

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.FromArgb(249, 173, 192);//doi mau cho lable

            pnlSubMain.Controls.Clear();//xoa panel hien co
            frmBaoCaoThongKe frmTK = new frmBaoCaoThongKe();
            frmTK.TopLevel = false;
            frmTK.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmTK.FormBorderStyle = FormBorderStyle.None;
            pnlSubMain.Controls.Add(frmTK);
            frmTK.Show();
        }

        private void btnDX_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Đăng Xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                this.Hide();
                frmDangNhap dangNhap = new frmDangNhap();
                dangNhap.ShowDialog();
                //btnTrangChu.BackColor = Color.FromArgb(255, 181, 197);
                //34, 34, 34
                this.Close();
            }
        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void picThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }
        private void btnCaiDat_Click(object sender, EventArgs e)
        {
            btnCaiDat.BackColor = Color.FromArgb(249, 173, 192);//doi mau cho lable
            pnlSubMain.Controls.Clear();//xoa panel hien co
            frmPhanQuyen frmPQ = new frmPhanQuyen();
            frmPQ.TopLevel = false;
            frmPQ.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmPQ.FormBorderStyle = FormBorderStyle.None;
            pnlSubMain.Controls.Add(frmPQ);
            frmPQ.Show();
        }
        //LEAVE
        private void btnTrangChu_Leave(object sender, EventArgs e)
        {
            btnTrangChu.BackColor = Color.FromArgb(23, 24, 29);

        }

        private void btnPhongTro_Leave(object sender, EventArgs e)
        {
            btnPhongTro.BackColor = Color.FromArgb(23, 24, 29);

        }

        private void btnKhachTro_Leave(object sender, EventArgs e)
        {
            btnKhachTro.BackColor = Color.FromArgb(23, 24, 29);

        }

        private void btnThongKe_Leave(object sender, EventArgs e)
        {
            btnThongKe.BackColor = Color.FromArgb(23, 24, 29);

        }

        private void btnCaiDat_Leave(object sender, EventArgs e)
        {
            btnCaiDat.BackColor = Color.FromArgb(23, 24, 29);

        }

        
    }
}
