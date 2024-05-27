using BLL;
using DTO;
using QuanLyPhongTro_10122399.Folder_KhachTro;
using QuanLyPhongTro_10122399.Folder_PhongTro;
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
using Aspose.Words;
using Aspose.Words.Tables;
using System.IO;

namespace QuanLyPhongTro_10122399.Folder_HopDong
{
    public partial class frmHopDong : Form
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
        public frmHopDong()
        {
             InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            //hien thi
            HienThiDSHD();
            dgvDSHD.ReadOnly = true;
            cmbTimKiem.SelectedIndex = 0;
            //phanquyen
            phanQuyen();
        }
        //Phan quyen
        public void phanQuyen()
        {
            if (TaiKhoan.quyenTK == "Khách trọ")
            {
                btnThemHD.Enabled = false;
                btnXoaHD.Enabled = false;
            }
        }



        HopDongBLL hdbll = new HopDongBLL();
        KhachTroBLL ktbll = new KhachTroBLL();
        PhongTroBLL ptbll = new PhongTroBLL();
        public void HienThiDSHD()
        {
            //HopDongBLL hdbll = new HopDongBLL();
            dgvDSHD.Rows.Clear();
            List<HopDong> ds = hdbll.hienThiDSHD();
            foreach (HopDong item in ds)
            {
                dgvDSHD.Rows.Add(item.MaHD, item.MaKT, item.MaPT, item.NgayThue, item.NgayTra, item.TienCoc, item.TinhTrang);
            }
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDSHD.SelectedRows;
            //HopDongBLL hdbll = new HopDongBLL();

            if(MessageBox.Show("Bạn có chắc chắn muốn xóa hợp đồng này không!","Xóa hợp đồng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in hangChon)
                {
                    // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                    string maHD = row.Cells["maHD"].Value.ToString();
                    // Thực hiện xử lý với giá trị trong hàng đã chọn
                    if (!hdbll.xoaHopDong(maHD)) //xóa không thành công
                    {
                        MessageBox.Show($"xóa hợp đồng {maHD.Trim()} không thành công!", "Xóa hợp đồng", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                HienThiDSHD();
            }
            
        }

        private void frmHopDong_Load(object sender, EventArgs e)
        {

        }

        private void dgvDSHD_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
            {
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDSHD.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDSHD.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(249, 173, 192);
                //255 182 193
            }
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            int luaChon = 1;
            //nếu mà mã hd hoặc gần đúng thì sẽ vô đó
            if((cmbTimKiem.Text.Trim() == "Mã HD" || cmbTimKiem.Text.Trim() == "Gần đúng" || (cmbTimKiem.Text.Trim() == "Tháng/Năm" && txtTimKiem.Texts.Length != 0)) )
            {
                if (txtTimKiem.Texts.Length != 0)
                {
                    dgvDSHD.Rows.Clear();//xóa các hàng trong grid view

                    if (cmbTimKiem.Text == "Gần đúng")
                        luaChon = 2;
                    else if (cmbTimKiem.Text == "Tháng/Năm")
                        luaChon = 3;
                    List<HopDong> ds = hdbll.timKiemHD(luaChon.ToString(), txtTimKiem.Texts.Trim(), dtpThangNam.Value.ToString("yyyy/MM/dd").Trim()); //dtpThangNam.ToString("yyyy/MM/dd").Trim() khởi tạo ds để duyệt vào grid
                    foreach (HopDong item in ds)
                    {
                        dgvDSHD.Rows.Add(item.MaHD, item.MaKT, item.MaPT, item.NgayThue, item.NgayTra, item.TienCoc, item.TinhTrang);
                    }
                }
                else HienThiDSHD();
            }
            else
            {
                dgvDSHD.Rows.Clear();//xóa các hàng trong grid view
                if (cmbTimKiem.Text.Trim() == "Tháng/Năm")
                    luaChon = 6;
                else if (cmbTimKiem.Text.Trim() == "HD hết hạn")
                    luaChon = 4;
                else if (cmbTimKiem.Text.Trim() == "HD chưa hết hạn")
                    luaChon = 5;
                List<HopDong> ds = hdbll.timKiemHD(luaChon.ToString(), txtTimKiem.Texts.Trim(), dtpThangNam.Value.ToString("yyyy/MM/dd").Trim()); //dtpThangNam.ToString("yyyy/MM/dd").Trim() khởi tạo ds để duyệt vào grid
                foreach (HopDong item in ds)
                {
                    dgvDSHD.Rows.Add(item.MaHD, item.MaKT, item.MaPT, item.NgayThue, item.NgayTra, item.TienCoc, item.TinhTrang);
                }
            }
            


        }

        private void dgvDSHD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDSHD.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string maHD = selectedRow.Cells["maHD"].Value.ToString().Trim(); 
                string maKT = selectedRow.Cells["maKT"].Value.ToString().Trim(); 
                string maPT = selectedRow.Cells["maPT"].Value.ToString().Trim(); 
                string ngayThue = selectedRow.Cells["ngayThue"].Value.ToString().Trim(); 
                string ngayTra = selectedRow.Cells["ngayTra"].Value.ToString().Trim(); 
                string tienCoc = selectedRow.Cells["tienCoc"].Value.ToString().Trim(); 
                string tinhTrang = selectedRow.Cells["tinhTrang"].Value.ToString().Trim();


                // Đặt giá trị của TextBox trên OtherForm là giá trị của ô được chọn
                frmSuaHD1 suaHT = new frmSuaHD1();
                suaHT.capNhatGiaTriTextBox(maHD, maKT, maPT, ngayThue, ngayTra, tienCoc, tinhTrang);
                suaHT.ShowDialog();
                HienThiDSHD();

                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            frmThemHD1 themHD = new frmThemHD1();
            themHD.capNhatGiaTriTextBox();
            themHD.ShowDialog();
            dgvDSHD.Rows.Clear();
            HienThiDSHD();
        }
        //dien thong tin vao word
        private void dienTTVaoWord(string maHD, string ngayHienTai, string tenKhachTro, string cccd, string sdt, string email, string ngheNghiep, string diaChi, string maPhong, string ngayThue, string ngayKetThuc, string giaPhong, string soLuong, string tienCoc)
        {
            // In hop dong
            // Bước 1: Nạp file mẫu
            Document hopDongWord = new Document(@"HopDong.docx");
            // Bước 2: Điền các thông tin cố định
            hopDongWord.MailMerge.Execute(new[] { "maHD" }, new[] { maHD });
            hopDongWord.MailMerge.Execute(new[] { "ngayHienTai" }, new[] { ngayHienTai });
            hopDongWord.MailMerge.Execute(new[] { "tenKhachTro" }, new[] { tenKhachTro });
            hopDongWord.MailMerge.Execute(new[] { "cccd" }, new[] { cccd });
            hopDongWord.MailMerge.Execute(new[] { "sdt" }, new[] { sdt });
            hopDongWord.MailMerge.Execute(new[] { "Email" }, new[] { email });
            hopDongWord.MailMerge.Execute(new[] { "ngheNghiep" }, new[] { ngheNghiep });
            hopDongWord.MailMerge.Execute(new[] { "diaChi" }, new[] { diaChi });
            hopDongWord.MailMerge.Execute(new[] { "maPhong" }, new[] { maPhong });
            hopDongWord.MailMerge.Execute(new[] { "ngayThue" }, new[] { ngayThue });
            hopDongWord.MailMerge.Execute(new[] { "ngayKetThuc" }, new[] { ngayKetThuc });
            hopDongWord.MailMerge.Execute(new[] { "giaPhong" }, new[] { giaPhong });
            hopDongWord.MailMerge.Execute(new[] { "soLuong" }, new[] { soLuong });
            hopDongWord.MailMerge.Execute(new[] { "tienCoc" }, new[] { tienCoc });

            // Bước 3: Lưu và mở file
            //hopDongWord.SaveAndOpenFile(@"HopDong.docx");

            // Bước 3: Lưu file vào Desktop
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, $"HopDong{maHD}.docx");
            hopDongWord.Save(filePath);

        }


        //in ra hop dong dang word
        private void HDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvDSHD.Rows[this.rowIndex].IsNewRow)
            {
                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string maHD = this.dgvDSHD.Rows[this.rowIndex].Cells[0].Value.ToString();
                string maKT = this.dgvDSHD.Rows[this.rowIndex].Cells[1].Value.ToString();
                string maPT =  this.dgvDSHD.Rows[this.rowIndex].Cells[2].Value.ToString();
                string ngayThue =  this.dgvDSHD.Rows[this.rowIndex].Cells[3].Value.ToString();
                string ngayKetThuc =  this.dgvDSHD.Rows[this.rowIndex].Cells[4].Value.ToString();
                string tienCoc =  this.dgvDSHD.Rows[this.rowIndex].Cells[5].Value.ToString();
                List<KhachTro> lstkt = ktbll.timKiemKT("1", maKT);
                KhachTro kt = lstkt[0];
                string tenKT = kt.HoTen;
                string cccd = kt.CMND;
                string sdt = kt.SDT;
                string ngheNghiep = kt.NgheNghiep;
                string email = kt.Email;
                string diachi = kt.DiaChi;
                List<PhongTro> lstpt = ptbll.timKiemPT2("1", maPT);
                PhongTro pt = lstpt[0];
                string tenPhong = pt.TenPT;
                string giaPhong = pt.GiaPhong;
                string soLuong = pt.SLToiDa;
                // Gọi hàm dienTTVaoWord với các tham số tương ứng
                dienTTVaoWord(maHD, DateTime.Now.ToString("dd/MM/yyyy"), tenKT, cccd, sdt, email, ngheNghiep, diachi, tenPhong, ngayThue, ngayKetThuc, giaPhong, soLuong, tienCoc);
            }

        }
        //lấy ra vị trí cột được chọn

        private void dgvDSHD_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvDSHD.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {
                    dgvDSHD.CurrentCell = dgvDSHD[hitTest.ColumnIndex, hitTest.RowIndex];
                    contextMenuStrip1.Show(dgvDSHD, e.Location);
                }
            }
        }
        private int rowIndex = 0;
        private void dgvDSHD_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button == MouseButtons.Right)
            {
                this.dgvDSHD.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvDSHD.CurrentCell = this.dgvDSHD.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvDSHD, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
                
            }
        }


        private void cmbTimKiem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnXuatHD_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDSHD.SelectedRows;

            if (MessageBox.Show("Bạn có chắc chắn muốn xuất các hợp đồng này?", "Xuất hợp đồng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in hangChon)
                {
                    // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                    string maHD = row.Cells[0].Value.ToString();
                    string maKT = row.Cells[1].Value.ToString();
                    string maPT = row.Cells[2].Value.ToString();
                    string ngayThue = row.Cells[3].Value.ToString();
                    string ngayKetThuc = row.Cells[4].Value.ToString();
                    string tienCoc = row.Cells[5].Value.ToString();

                    List<KhachTro> lstkt = ktbll.timKiemKT("1", maKT);
                    KhachTro kt = lstkt[0];
                    string tenKT = kt.HoTen;
                    string cccd = kt.CMND;
                    string sdt = kt.SDT;
                    string ngheNghiep = kt.NgheNghiep;
                    string email = kt.Email;
                    string diachi = kt.DiaChi;

                    List<PhongTro> lstpt = ptbll.timKiemPT2("1", maPT);
                    PhongTro pt = lstpt[0];
                    string tenPhong = pt.TenPT;
                    string giaPhong = pt.GiaPhong;
                    string soLuong = pt.SLToiDa;

                    // Gọi hàm dienTTVaoWord với các tham số tương ứng
                    dienTTVaoWord(maHD, DateTime.Now.ToString("dd/MM/yyyy"), tenKT, cccd, sdt, email, ngheNghiep, diachi, tenPhong, ngayThue, ngayKetThuc, giaPhong, soLuong, tienCoc);
                }
            }
        }
    }
}
