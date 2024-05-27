using BLL;
using DTO;
using QuanLyPhongTro_10122399.Folder_PhongTro;
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

namespace QuanLyPhongTro_10122399.Folder_PhieuThu
{
    public partial class frmPhieuThu : Form
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
        public frmPhieuThu()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));

            //hien thi tren gridview
            cmbTimKiem.SelectedIndex = 0;
            phanQuyen();
        }
        //phan quyen
        private void phanQuyen()
        {
            if (TaiKhoan.quyenTK == "Khách trọ")
            {
                btnThemPT.Enabled = false;
                btnXoaPT.Enabled = false;
                thanhToánToolStripMenuItem.Visible = false;
            }
        }
        private void frmPhieuThu_Load(object sender, EventArgs e)
        {
            HienThiDSPThu();
        }
        PhieuThuBLL ptbll = new PhieuThuBLL();
        PhongTroBLL phongbll = new PhongTroBLL();
        DichVuBLL dvbll = new DichVuBLL();
        //hien thi ds phieu thu
        public void HienThiDSPThu()
       {

            dgvDSPT.Rows.Clear();
            List<PhieuThu> ds = ptbll.hienThiDSPT();
            foreach (PhieuThu item in ds)
            {
                dgvDSPT.Rows.Add(item.MaThu, item.MaPT,item.GiaPhong, item.NgayThu,item.NoCu,item.TongTien, item.DaTra, (float.Parse(item.TongTien) - float.Parse(item.DaTra)).ToString());
            }
        }
        public void HienThiDSPThuThoiGian()
        {
            string thangNam = dtpThangNam.Value.ToString("yyyy/MM/dd");
            dgvDSPT.Rows.Clear();
            List<PhieuThu> ds = ptbll.hienThiDSPT(thangNam);
            foreach (PhieuThu item in ds)
            {
                dgvDSPT.Rows.Add(item.MaThu, item.MaPT, item.GiaPhong, item.NgayThu, item.NoCu, item.TongTien, item.DaTra, (float.Parse(item.TongTien) - float.Parse(item.DaTra)).ToString());
            }
        }

        private void dgvDSPT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvDSPT.Rows[e.RowIndex];

                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string maThu = selectedRow.Cells["maThu"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string MaPT = selectedRow.Cells["MaPT"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string giaPhong = selectedRow.Cells["giaPhong"].Value.ToString().Trim();
                string NgayThu = selectedRow.Cells["NgayThu"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string DaTra = selectedRow.Cells["daTra"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string NoCu = selectedRow.Cells["noCu"].Value.ToString().Trim(); // Thay "ColumnAge" bằng tên cột thông tin tuổi

                // Đặt giá trị của TextBox trên OtherForm là giá trị của ô được chọn
                frmSuaPThu suaPT = new frmSuaPThu();
                suaPT.capNhatGiaTriTextBox(maThu, MaPT, giaPhong, NgayThu, DaTra, NoCu);
                suaPT.ShowDialog();
                HienThiDSPThuThoiGian();
                hienThiTong();


                // Hiển thị thông tin trong các TextBox đã chỉ định
            }
        }

        private void dgvDSPT_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex % 2 == 0) // Kiểm tra xem dòng có chỉ số chẵn hay không
            {
                // Đổi màu cho các dòng có chỉ số chẵn (index 0, 2, 4, ...)
                dgvDSPT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else
            {
                // Đổi màu cho các dòng có chỉ số lẻ (index 1, 3, 5, ...)
                dgvDSPT.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.FromArgb(249, 173, 192);
                //255 182 193
            }
        }

        private void btnThemPT_Click(object sender, EventArgs e)
        {
            frmThemPTu themPThu = new frmThemPTu();
            themPThu.ShowDialog();
            HienThiDSPThuThoiGian();
            hienThiTong();

        }

        private void btnXoaPT_Click(object sender, EventArgs e)
        {
            DataGridViewSelectedRowCollection hangChon = dgvDSPT.SelectedRows;
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa phiếu này.","Xóa phiếu thu", MessageBoxButtons.YesNo,MessageBoxIcon.Question); ;
            if(result== DialogResult.Yes)
            foreach (DataGridViewRow row in hangChon)
            {
                // Làm gì đó với từng hàng đã chọn ở đây, ví dụ:
                string maThu = row.Cells["maThu"].Value.ToString().Trim();
                // Thực hiện xử lý với giá trị trong hàng đã chọn
                ptbll.xoaPT(maThu);

            }
            HienThiDSPThuThoiGian();
            hienThiTong();
        }

        private void picTimKiem_Click(object sender, EventArgs e)
        {
            dgvDSPT.Rows.Clear();//xóa các hàng trong grid view
            DateTime dateTime;
            int luaChon = 1;
            if (cmbTimKiem.Text == "Gần đúng")
                luaChon = 2;
            else if(cmbTimKiem.Text == "Chưa thanh toán")
                luaChon = 3;
            else if(cmbTimKiem.Text == "Đã thanh toán")
                luaChon = 4;
            else if (cmbTimKiem.Text == "Tháng/Năm" && txtTimKiem.Texts.Trim().Length!=0)
                luaChon = 5;
            else if (cmbTimKiem.Text == "Tháng/Năm" && txtTimKiem.Texts.Trim().Length == 0)
                luaChon = 6;
            List<PhieuThu> ds = ptbll.timKiemPThu(luaChon.ToString(), txtTimKiem.Texts.Trim(), dtpThangNam.Value.ToString("yyyy/MM/dd").Trim()); //khởi tạo ds để duyệt vào grid

            foreach (PhieuThu item in ds)
            {
                dgvDSPT.Rows.Add(item.MaThu, item.MaPT, item.GiaPhong, item.NgayThu, item.NoCu, item.TongTien, item.DaTra, (float.Parse(item.TongTien) - float.Parse(item.DaTra)));
            }
            //nếu không nhập gì thì không thay đổi
            if (((txtTimKiem.Texts.Trim()).Length == 0) && (luaChon==1 || luaChon ==2))
            {
                HienThiDSPThu();
            }
            //else if((txtTimKiem.Texts.Trim()).Length == 0)
            //{
            //    HienThiDSPThuThoiGian();
            //}
        }
        private void hienThiTong()
        {
            if (((txtTimKiem.Texts.Trim()).Length == 0) && (cmbTimKiem.Text == "Mã PT"))
            {
                HienThiDSPThu();
            }
        }
        //thanh toán toàn bộ tiền ở phiếu thu
        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thanh toán phiếu này.", "Thanh toán phiếu thu", MessageBoxButtons.YesNo, MessageBoxIcon.Question); ;
            if (result == DialogResult.Yes)
            {
                if (!this.dgvDSPT.Rows[this.rowIndex].IsNewRow)
                {
                
                    string maThu = this.dgvDSPT.Rows[this.rowIndex].Cells[0].Value.ToString(); //
                    string tongTien = this.dgvDSPT.Rows[this.rowIndex].Cells[5].Value.ToString(); //
                    ptbll.thanhToan(maThu, tongTien);
                    //Console.WriteLine($"DA VAO DAY DE THANH TOAN {maThu} {tongTien}");
                    HienThiDSPThuThoiGian();
                    hienThiTong();
                }
            }

        }

        private void dgvDSPT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvDSPT.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {
                    dgvDSPT.CurrentCell = dgvDSPT[hitTest.ColumnIndex, hitTest.RowIndex];
                    contextMenuStrip1.Show(dgvDSPT, e.Location);
                }
            }
        }
        //lấy ra vị trí cột được chọn
        private int rowIndex = 0;
        private void dgvDSPT_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvDSPT.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvDSPT.CurrentCell = this.dgvDSPT.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.dgvDSPT, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void btnXuatPT_Click(object sender, EventArgs e)
        {

            frmXuatPhieuThu xuatPhieuThu = new frmXuatPhieuThu(dtpThangNam.Text.Trim());
            xuatPhieuThu.ShowDialog();

        }
        //xuat phieu thu
        private void xuấtPhiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvDSPT.Rows[this.rowIndex].IsNewRow)
            {
                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string maThu = this.dgvDSPT.Rows[this.rowIndex].Cells[0].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string MaPT = this.dgvDSPT.Rows[this.rowIndex].Cells[1].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string giaPhong = this.dgvDSPT.Rows[this.rowIndex].Cells[2].Value.ToString();
                string NgayThu = this.dgvDSPT.Rows[this.rowIndex].Cells[3].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string TongTien = this.dgvDSPT.Rows[this.rowIndex].Cells[5].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string NoCu = this.dgvDSPT.Rows[this.rowIndex].Cells[4].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi
                string DaTra = this.dgvDSPT.Rows[this.rowIndex].Cells[6].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi

                List<PhongTro> lstpt = phongbll.timKiemPT2("1", MaPT);
                PhongTro pt = lstpt[0];
                string tenPhong = pt.TenPT;
                string soLuong = pt.SLToiDa;
                List<DichVuDienNuoc> dsDichVuDN = dvbll.timKiemDN(MaPT, NgayThu);
                //neu co ca dien ca nước
                if (dsDichVuDN.Count == 2)
                {
                    DichVuDienNuoc dien = dsDichVuDN[0];
                    string DchiSoCu = dien.ChiSoCu;
                    string DchiSoMoi = dien.ChiSoMoi;
                    string DtieuThu = (float.Parse(dien.ChiSoMoi) - float.Parse(dien.ChiSoCu)).ToString();
                    string DthanhTien = dien.ThanhTien;
                    DichVuDienNuoc nuoc = dsDichVuDN[1];
                    string NchiSoCu = nuoc.ChiSoCu;
                    string NchiSoMoi = nuoc.ChiSoMoi;
                    string NtieuThu = (float.Parse(nuoc.ChiSoMoi) - float.Parse(nuoc.ChiSoCu)).ToString();
                    string NthanhTien = nuoc.ThanhTien;
                    frmXuatPhieuThu xuatPhieuThu = new frmXuatPhieuThu(maThu, tenPhong, NgayThu, giaPhong, DchiSoCu, DchiSoMoi, DtieuThu, DthanhTien, NchiSoCu, NchiSoMoi, NtieuThu, NthanhTien, NoCu, TongTien, DaTra);
                    xuatPhieuThu.ShowDialog();
                }
                else if(dsDichVuDN.Count == 0) //neu khong co thong tin
                {
                    frmXuatPhieuThu xuatPhieuThu = new frmXuatPhieuThu(maThu, tenPhong, NgayThu, giaPhong, "0", "0", "0", "0", "0", "0", "0", "0", NoCu, TongTien, DaTra);
                    xuatPhieuThu.ShowDialog();
                }
                //neu chi co dien thoi
                else if (dsDichVuDN[0].Loai == "Điện")
                {
                    DichVuDienNuoc dien = dsDichVuDN[0];
                    string DchiSoCu = dien.ChiSoCu;
                    string DchiSoMoi = dien.ChiSoMoi;
                    string DtieuThu = (float.Parse(dien.ChiSoMoi) - float.Parse(dien.ChiSoCu)).ToString();
                    string DthanhTien = dien.ThanhTien;
                    frmXuatPhieuThu xuatPhieuThu = new frmXuatPhieuThu(maThu, tenPhong, NgayThu, giaPhong, DchiSoCu, DchiSoMoi, DtieuThu, DthanhTien, "0", "0", "0", "0", NoCu, TongTien, DaTra);
                    xuatPhieuThu.ShowDialog();
                }
                //neu chi co nuoc thoi
                else if (dsDichVuDN[0].Loai == "Nước")
                {
                    DichVuDienNuoc nuoc = dsDichVuDN[1];
                    string NchiSoCu = nuoc.ChiSoCu;
                    string NchiSoMoi = nuoc.ChiSoMoi;
                    string NtieuThu = (float.Parse(nuoc.ChiSoMoi) - float.Parse(nuoc.ChiSoCu)).ToString();
                    string NthanhTien = nuoc.ThanhTien;
                    frmXuatPhieuThu xuatPhieuThu = new frmXuatPhieuThu(maThu, tenPhong, NgayThu, giaPhong, "0", "0", "0", "0", NchiSoCu, NchiSoMoi, NtieuThu, NthanhTien, NoCu, TongTien, DaTra);
                    xuatPhieuThu.ShowDialog();
                }
                
            }
        }
    }
}
