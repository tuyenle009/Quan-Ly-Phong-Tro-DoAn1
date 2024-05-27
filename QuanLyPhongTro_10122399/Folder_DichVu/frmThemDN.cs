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

namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    public partial class frmThemDN : Form
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
        public frmThemDN()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //thêm giá trị vào cmb phòng trọ 
            cmbMaPT.Items.Clear();
            foreach (string item in dvBLL.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }
        }
        DichVuBLL dvBLL = new DichVuBLL();
      

        //kiểm tra dịch vụ điện nước trước khi thêm
        private bool kiemTraDVDN()
        {
            int check = 0;
            string thongBao = "";
            if (txtChiSoMoi.Texts.Length >6|| txtChiSoCu.Texts.Length>6 || cmbMaDN.SelectedIndex == -1 || cmbMaPT.SelectedIndex == -1 // || !double.TryParse(txtDonGia.Texts.Trim(), out _
                || !int.TryParse(txtChiSoMoi.Texts.Trim(), out _) || !int.TryParse(txtChiSoCu.Texts.Trim(), out _))
            {
                thongBao = "Vui lòng nhập đủ và đúng thông tin!";
                check = 1;
            }
            else if ((int.Parse(txtChiSoCu.Texts) > int.Parse(txtChiSoMoi.Texts)) )
            {
                thongBao = "Chỉ số cũ không được lớn hơn chỉ số mới";
                check = 1;
            }
            //else if (dtpTuNgay.Value > dtpToiNgay.Value)
            //{
            //    thongBao = "Ngày bắt đầu không được nhỏ hơn ngày kết thúc!";
            //    check = 1;
            //}
            //else if (double.Parse(txtDonGia.Texts.Trim()) < 0)
            //{
            //    thongBao = "Đơn giá không được nhỏ hơn 0!";
            //    check = 1;
            //}
            if(check==1)
            {
                MessageBox.Show(thongBao, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnThemDN_Click(object sender, EventArgs e)
        {
            if (kiemTraDVDN())
            {
                string maDN= "N";
                string loai = "Nước";
                byte ktDN = 0;
                if (cmbMaDN.SelectedIndex==0)
                {
                    maDN = "D";
                    loai = "Điện";
                    ktDN = 1;
                }
                DichVuDienNuoc dichVu = new DichVuDienNuoc
                {
                    MaDN = maDN,
                    MaPT = cmbMaPT.SelectedItem.ToString(),
                    Loai = loai,
                    ThoiGian = dtpToiNgay.Value.ToString("MM/dd/yyyy").Trim(),
                    ChiSoCu = txtChiSoCu.Texts.Trim(),
                    ChiSoMoi = txtChiSoMoi.Texts.Trim(),
                    //DonGia = txtDonGia.Texts.Trim()
                };

                dvBLL.themDienNuoc(dichVu, ktDN); // Thêm dịch vụ điện nước
                MessageBox.Show("Thêm dịch vụ điện nước thành công!", "Thêm dịch vụ điện nước", MessageBoxButtons.OK);
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
