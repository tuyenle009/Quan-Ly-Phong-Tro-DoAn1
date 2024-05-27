using BLL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    public partial class frmSuaDN : Form
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
        public frmSuaDN()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //cap nhat gia tr textbox
            cmbMaPT.Items.Clear();
            foreach (string item in dvBLL.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }
            phanQuyen();
        }
        //phan quyen
        private void phanQuyen()
        {
            if (TaiKhoan.quyenTK == "Khách trọ")
            {
                btnSuaDN.Enabled = false;
            }

        }
        DichVuBLL dvBLL = new DichVuBLL();

        //cập nhật giá trị textbox 
        public void capNhatGiaTriTextBox(string maDN, string maPT, string tuNgay, string toiNgay, string chiSoMoi, string chiSoCu) //, string donGia
        {
            lblMaDN.Text = maDN;
            cmbMaPT.SelectedItem = maPT;
            //dtpTuNgay.Value = DateTime.ParseExact(tuNgay, "dd/MM/yyyy", CultureInfo.InvariantCulture); // Giả sử DateTimePicker của bạn có tên là dateTimePicker1
            dtpToiNgay.Value = DateTime.ParseExact(toiNgay, "dd/MM/yyyy", CultureInfo.InvariantCulture); // Giả sử DateTimePicker của bạn có tên là dateTimePicker1
            txtChiSoCu.Texts = chiSoCu;
            txtChiSoMoi.Texts = chiSoMoi;
            //txtDonGia.Texts = donGia;

        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //cap nhat
        //kiểm tra dịch vụ điện nước trước khi thêm
        private bool kiemTraDVDN()
        {
            int check = 0;
            string thongBao = "";
            if (txtChiSoMoi.Texts.Length > 6 || txtChiSoCu.Texts.Length > 6 || cmbMaPT.SelectedIndex == -1 //|| !double.TryParse(txtDonGia.Texts.Trim(), out _)
                || !int.TryParse(txtChiSoMoi.Texts.Trim(), out _) || !int.TryParse(txtChiSoCu.Texts.Trim(), out _))
            {
                thongBao = "Vui lòng nhập đủ và đúng thông tin!";
                check = 1;
            }
            else if (int.Parse(txtChiSoCu.Texts) > int.Parse(txtChiSoMoi.Texts))
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
            if (check == 1)
            {
                MessageBox.Show(thongBao, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnSuaDN_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn chắc chắn muốn cập nhật?", "Cập nhật điện nước", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                if (kiemTraDVDN())
                {
                    byte ktDN = 0;
                    if (lblMaDN.Text[0] == 'D') //neu co ma la D thi sẽ tính tiền điện
                        ktDN = 1;
                    DichVuDienNuoc dichVu = new DichVuDienNuoc
                    {
                        MaDN = lblMaDN.Text,
                        MaPT = cmbMaPT.SelectedItem.ToString(),
                        Loai = "",
                        ThoiGian = dtpToiNgay.Value.ToString("MM/dd/yyyy").Trim(),
                        ChiSoCu = txtChiSoCu.Texts.Trim(),
                        ChiSoMoi = txtChiSoMoi.Texts.Trim(),
                        //DonGia = txtDonGia.Texts.Trim()
                    };
                   
                    dvBLL.capNhatDienNuoc(dichVu, ktDN); // Thêm dịch vụ điện nước
                }
            }
        }
    }
}
