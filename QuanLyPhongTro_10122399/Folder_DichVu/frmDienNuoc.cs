using BLL;
using DTO;
using QuanLyPhongTro_10122399.Folder_HopDong;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyPhongTro_10122399.Folder_DichVu
{
    public partial class frmDienNuoc : Form
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
        DichVuBLL dvBLL = new DichVuBLL();

        public frmDienNuoc()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //hien thi
            HienThiDVDN();
            phanQuyen();
        }
        //phan quyen
        private void phanQuyen()
        {
            if (TaiKhoan.quyenTK == "Khách trọ")
            {
                btnThemDV.Enabled = false;
                btnLayDL.Enabled = false;
                btnXoaDV.Enabled = false;
            }

        }
        public void HienThiDVDN()
        {
            dgvDVDN.Rows.Clear();
            List<DichVuDienNuoc> ds = dvBLL.hienThiDSDienNuoc();
            foreach (DichVuDienNuoc item in ds)
            {
                dgvDVDN.Rows.Add(item.MaDN, item.MaPT, item.Loai, item.ThoiGian, item.ChiSoCu, item.ChiSoMoi, item.ThanhTien); //item.DonGia,
            }
        }

        private void btnXoaDV_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDVDN.SelectedRows;
            //HopDongBLL hdbll = new HopDongBLL();

            if (MessageBox.Show("Bạn có chắc chắn muốn xóa dịch vụ này không!", "Xóa dịch vụ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in hangChon)
                {
                    // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                    string maDV = row.Cells["maDN"].Value.ToString();
                    // Thực hiện xử lý với giá trị trong hàng đã chọn
                    if (!dvBLL.xoaDienNuoc(maDV)) //xóa không thành công
                    {
                        MessageBox.Show($"xóa dịch vụ {maDV.Trim()} không thành công!", "Xóa dịch vụ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                hienThiDLTgian();
            }
        }

        private void dgvDVDN_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDVDN.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDVDN.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(249, 173, 192);//249, 173, 192
                                                                                                    //229, 193, 195
        }


        public void hienThiDLTgian()
        {
            dgvDVDN.Rows.Clear();
            List<DichVuDienNuoc> ds = dvBLL.DSDienNuocThang(int.Parse(dtpThangNam.Text.Split('/')[0]), int.Parse(dtpThangNam.Text.Split('/')[1]));
            foreach (DichVuDienNuoc item in ds)
            {
                dgvDVDN.Rows.Add(item.MaDN, item.MaPT, item.Loai, item.ThoiGian, item.ChiSoCu, item.ChiSoMoi,  item.ThanhTien); //item.DonGia,
            }
        }
      
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            hienThiDLTgian();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            dgvDVDN.Rows.Clear();
            HienThiDVDN();
        }

        private void btnLayDL_Click(object sender, EventArgs e)
        {
            Console.WriteLine(dtpThangNam.Text.Split('/')[0].ToString() + dtpThangNam.Text.Split('/')[01].ToString());
            dvBLL.layDLThangTruoc(int.Parse(dtpThangNam.Text.Split('/')[0]), int.Parse(dtpThangNam.Text.Split('/')[01]));
            hienThiDLTgian();
        }

        private void dgvDVDN_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDVDN.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string maDN = selectedRow.Cells["maDN"].Value.ToString().Trim();
                string maPT = selectedRow.Cells["maPT"].Value.ToString().Trim();
                string loai = selectedRow.Cells["loai"].Value.ToString().Trim();
                string thoiGian = selectedRow.Cells["thoiGian"].Value.ToString().Trim();
                string chiSoMoi = selectedRow.Cells["chiSoMoi"].Value.ToString().Trim();
                string chiSoCu = selectedRow.Cells["chiSoCu"].Value.ToString().Trim();
                //string donGia = selectedRow.Cells["donGia"].Value.ToString().Trim();

               
                frmSuaDN suaDN = new frmSuaDN();
                suaDN.capNhatGiaTriTextBox( maDN,  maPT, loai, thoiGian,  chiSoMoi,  chiSoCu );//donGia
                suaDN.ShowDialog();
                hienThiDLTgian();
                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }
        //thêm dịch vụ
        private void btnThemDV_Click(object sender, EventArgs e)
        {
            frmThemDN themDN = new frmThemDN();
            themDN.ShowDialog();
            hienThiDLTgian();
        }
    }
}
