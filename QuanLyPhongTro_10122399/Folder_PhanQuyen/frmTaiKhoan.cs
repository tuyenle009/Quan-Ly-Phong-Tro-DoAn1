using Aspose.Words.Tables;
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
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace QuanLyPhongTro_10122399.Folder_PhanQuyen
{
    public partial class frmTaiKhoan : Form
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
        public frmTaiKhoan()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //hien thi
            HienThiND();
            phanQuyen();
            //neu la quan tri thi có thể sửa được thông tin người quản trị
            if (TaiKhoan.quyenTK == "Quản trị")
                cmbQuyen.Items.Add("Quản trị");
        }
        //phan quyen
        private void phanQuyen()
        {
            if (TaiKhoan.quyenTK == "Khách trọ")
            {
                btnThemND.Enabled = false;
                btnCapNhatND.Enabled = false;
                btnXoaND.Enabled = false;
            }

        }
        PhanQuyenBLL pqBLL = new PhanQuyenBLL();
        public void HienThiND()
        {
            dgvND.Rows.Clear();
            List<NguoiDung> ds = pqBLL.hienThiDSND(TaiKhoan.quyenTK);
            foreach (NguoiDung item in ds)
            {
                dgvND.Rows.Add(item.TenTK, item.MatKhau, item.Gmail, item.Quyen);
            }
            //mac dinh la thang
            cmbQuyen.SelectedIndex = 0;
        }


        private void dgvND_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvND.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            else
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvND.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(249, 173, 192);
            //255 182 193
        }

        private void btnXoaND_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvND.SelectedRows;
            //HopDongBLL hdbll = new HopDongBLL();

            
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa người dùng này không!", "Xóa người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in hangChon)
                {
                    //if(txtTaiKhoan.Texts.Trim() == "admin1")
                    //{
                    //    MessageBox.Show($"Không thể xóa quản trị viên!", "Xóa người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    break;
                    //}
                    // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                    string maND = row.Cells["taiKhoan"].Value.ToString();
                    // Thực hiện xử lý với giá trị trong hàng đã chọn
                    if(row.Cells["quyen"].Value.ToString()=="Quản trị")
                    {
                        MessageBox.Show($"không thể xóa quản trị viên!", "Xóa người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                    if (!pqBLL.xoaND(maND)) //xóa không thành công
                    {
                        MessageBox.Show($"xóa người dùng {maND.Trim()} không thành công!", "Xóa người dùng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                HienThiND();
            }
        }

        private void dgvND_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex >= 0)
            //{
            //    DataGridViewRow selectedRow = dgvND.Rows[e.RowIndex];

            //    // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
            //    //txtMaDV.Texts = selectedRow.Cells["MaDV"].Value.ToString().Trim();
            //    txtTaiKhoan.Texts = selectedRow.Cells["taiKhoan"].Value.ToString().Trim();
            //    txtMatKhau.Texts = selectedRow.Cells["matKhau"].Value.ToString().Trim();
            //    txtGmail.Texts = selectedRow.Cells["gmail"].Value.ToString().Trim();
            //    cmbQuyen.SelectedItem = selectedRow.Cells["quyen"].Value.ToString().Trim();
            //}
        }
        //kiểm tra dịch vụ đã chuẩn định dạng có thể thêm chưa
        public bool checkAccount(string ac) //check mk va ten tk
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(string em)//check email
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com$");
        }
        private bool kiemTraND(out string str, string chucnang = "Them")
        {
            if (txtTaiKhoan.Texts.Trim().Length == 0 || txtMatKhau.Texts.Trim().Length == 0 )
            {
                str = "Vui lòng nhập đủ và đúng thông tin!";
                return false;
            }
            else if( txtGmail.Texts.Length!=0 && !checkEmail(txtGmail.Texts.Trim()))
            {
                str = "Vui lòng nhập đúng định dạng email!";
                return false;
            }
            else if(!checkAccount(txtTaiKhoan.Texts.Trim()))
            {
                str = "Vui lòng nhập tên tài khoản 6-24 ký tự, với các ký tự chữ và số!";
                return false; 
            }
            else if (pqBLL.kiemTraSoLuong(txtTaiKhoan.Texts.Trim(), "TaiKhoan") && chucnang== "Them")
            {
                str = "Tài khoản đã tồn tại!";
                return false;
            }
            else if(pqBLL.kiemTraSoLuong(txtGmail.Texts.Trim(), "Gmail") && chucnang == "Them")//
            {
                str = "Gmail đã tồn tại!";
                return false;
            }
            
            str = "Thao tác thành công!";
            return true;
        }

        private void btnThemND_Click(object sender, EventArgs e)
        {
            string str = "";
            if (kiemTraND(out str))
            {
                NguoiDung nd = new NguoiDung(txtTaiKhoan.Texts.Trim(), txtMatKhau.Texts.Trim(),txtGmail.Texts.Trim(),cmbQuyen.SelectedItem.ToString());//txtMaDV.Texts
                pqBLL.themND(nd); // Thêm 
                HienThiND();
            }
            MessageBox.Show(str, "Thêm dịch vụ", MessageBoxButtons.OK);

        }

        private void btnCapNhatND_Click(object sender, EventArgs e)
        {
            bool ktMaPC = pqBLL.kiemTraSoLuong(txtTaiKhoan.Texts.Trim(),"TaiKhoan");
            string str = "";
            if (kiemTraND(out str, "CapNhat"))
            {
                NguoiDung nd = new NguoiDung(txtTaiKhoan.Texts.Trim(), txtMatKhau.Texts.Trim(), txtGmail.Texts.Trim(), cmbQuyen.SelectedItem.ToString());//txtMaDV.Texts
                pqBLL.capNhatND(nd); // Kiểm tra xem mã dịch vụ đã tồn tại hay chưa
                MessageBox.Show("Cập nhật thành công!", "Cập nhật", MessageBoxButtons.OK);
                HienThiND();
            }
            else
            {
                MessageBox.Show(str, "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvND_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvND.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                //txtMaDV.Texts = selectedRow.Cells["MaDV"].Value.ToString().Trim();
                txtTaiKhoan.Texts = selectedRow.Cells["taiKhoan"].Value.ToString().Trim();
                txtMatKhau.Texts = selectedRow.Cells["matKhau"].Value.ToString().Trim();
                txtGmail.Texts = selectedRow.Cells["gmail"].Value.ToString().Trim();
                cmbQuyen.SelectedItem = selectedRow.Cells["quyen"].Value.ToString().Trim();
            }
        }
    }
}
