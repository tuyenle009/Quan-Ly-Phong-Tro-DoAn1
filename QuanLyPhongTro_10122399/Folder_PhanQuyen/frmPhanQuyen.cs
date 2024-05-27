using QuanLyPhongTro_10122399.Folder_DichVu;
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
    public partial class frmPhanQuyen : Form
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

        public frmPhanQuyen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            show_TK();
        }
        private void show_TK()
        {
            pnlDSQL.Controls.Clear();//xoa panel hien co
            frmTaiKhoan frmTK = new frmTaiKhoan();
            frmTK.TopLevel = false;
            frmTK.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmTK.FormBorderStyle = FormBorderStyle.None;
            pnlDSQL.Controls.Add(frmTK);

            frmTK.Show();
        }
        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            show_TK();
        }

        private void btnCapQuyen_Click(object sender, EventArgs e)
        {
            pnlDSQL.Controls.Clear();//xoa panel hien co
            frmCapQuyen frmPQ = new frmCapQuyen();
            frmPQ.TopLevel = false;
            frmPQ.Dock = DockStyle.Fill;//fill up panel hien tai vao
            frmPQ.FormBorderStyle = FormBorderStyle.None;
            pnlDSQL.Controls.Add(frmPQ);

            frmPQ.Show();
        }
    }
}
