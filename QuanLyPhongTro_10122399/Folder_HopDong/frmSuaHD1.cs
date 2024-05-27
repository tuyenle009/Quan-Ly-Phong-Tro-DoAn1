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
using Aspose.Words;
using Aspose.Words.Tables;


namespace QuanLyPhongTro_10122399.Folder_HopDong
{
    public partial class frmSuaHD1 : Form
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
        public frmSuaHD1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            HienThiDSKT();
            phanQuyen();
        }
        //phan quyen
        private void phanQuyen()
        {
            if (TaiKhoan.quyenTK == "Khách trọ")
            {
                btnSua.Enabled = false;
            }

        }
        HopDongBLL hdbll = new HopDongBLL();
        KhachTroBLL ktbll = new KhachTroBLL();
        //load len se duoc cap nhat vao textbox
        public string maHD = "";
        public void capNhatGiaTriTextBox(string maHD, string maKT, string maPT, string ngayThue, string ngayTra, string tienCoc, string tinhTrang)
        {
            HienThiDSMaKT(maHD);
            lblMaHD.Text = maHD;
            dtpNgayThue.Value = DateTime.ParseExact(ngayThue, "dd/MM/yyyy", CultureInfo.InvariantCulture); // Giả sử DateTimePicker của bạn có tên là dateTimePicker1
            dtpNgayTra.Value = DateTime.ParseExact(ngayTra, "dd/MM/yyyy", CultureInfo.InvariantCulture); ; // Giả sử DateTimePicker của bạn có tên là dateTimePicker1
            txtTienCoc.Texts = tienCoc;
            //thêm giá trị vào cmb khách trọ 
            cmbMaKT.Items.Clear();
            foreach (string item in hdbll.dsKhachTro())
            {
                cmbMaKT.Items.Add(item.Trim());
            }
            cmbMaKT.SelectedItem = maKT.Trim(); //lựa chọn item ban đầu

            //thêm giá trị vào cmb phòng trọ 
            cmbMaPT.Items.Clear();
            foreach (string item in hdbll.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }
            cmbMaPT.SelectedItem = maPT.Trim();
            cmbTinhTrang.SelectedItem = tinhTrang.Trim().ToUpper(); //lựa chọn tình trạn cũ

        }

        //hien thi danh sách khách trọ trong dgv
        public void HienThiDSKT()
        {
            string query = "select makt, hoten from khachtro where makt not in (\r\nselect ctkt.makt from chitietkt as ctkt join hopdong as hd on ctkt.mahd = hd.mahd where hd.TinhTrang=1)\r\n";
            dgvCTKT.DataSource = ktbll.HienThiDSKT_TB(query);
        }
        public void HienThiDSMaKT(string maHD)
        {

            foreach (string item in hdbll.dsMaKT(maHD))
            {
                dgvMaKT.Rows.Add(item);
                ds_maKTBanDau.Add(item);

            }

        }
        public void capNhatGiaTriTextBox()
        {
            //thêm giá trị vào cmb khách trọ 
            cmbMaKT.Items.Clear();
            foreach (string item in hdbll.dsKhachTro())
            {
                cmbMaKT.Items.Add(item.Trim());
            }
            //thêm giá trị vào cmb phòng trọ 
            cmbMaPT.Items.Clear();
            foreach (string item in hdbll.dsPhongTro())
            {
                cmbMaPT.Items.Add(item.Trim());
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //lấy ra danh sách phiếu chi có mã giống với mã phiếu thu
        private void themChiTietKT(string maHD)
        {
            foreach (DataGridViewRow row in dgvMaKT.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không duyệt qua hàng mới
                    // Lấy giá trị từ cột đầu tiên của mỗi hàng
                    hdbll.themCTKT(maHD, row.Cells["maKT1"].Value.ToString());
            }
        }

        private void dgvCTKT_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dgvCTKT.Rows[e.RowIndex];
                // Lấy dữ liệu từ các cột tương ứng trong hàng được chọn
                string makt = selectedRow.Cells["maKT"].Value.ToString(); // Thay "ColumnAge" bằng tên cột thông tin tuổi

                bool ktTonTai = false; //true la đã tồn tại
                foreach (DataGridViewRow row in dgvMaKT.Rows)
                {
                    if (row.Cells["maKT1"].Value != null && row.Cells["maKT1"].Value.ToString() == makt)
                    {
                        ktTonTai = true;
                        break;
                    }
                }
                if (!ktTonTai)
                    dgvMaKT.Rows.Add(makt);
            }
        }

        private void dgvMaKT_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hitTest = dgvMaKT.HitTest(e.X, e.Y);
                if (hitTest.Type == DataGridViewHitTestType.Cell)
                {
                    dgvMaKT.CurrentCell = dgvMaKT[hitTest.ColumnIndex, hitTest.RowIndex];
                    contextMenuStrip1.Show(dgvMaKT, e.Location);
                }
            }
        }

        private void xoaHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dgvMaKT.Rows[this.rowIndex].IsNewRow)
            {
                this.dgvMaKT.Rows.RemoveAt(this.rowIndex); //xoa tai bang dgv
            }
        }
        //lấy ra vị trí cột được chọn
        private int rowIndex = 0;

        private void dgvMaKT_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dgvMaKT.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dgvMaKT.CurrentCell = this.dgvMaKT.Rows[e.RowIndex].Cells[0];
                this.contextMenuStrip1.Show(this.dgvMaKT, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }
        //dem phan tu co trong dgv makt
        private int demMaKT()
        {
            List<string> lst = new List<string>();
            //duyệt lẩy ds mã mới được thêm
            foreach (DataGridViewRow row in dgvMaKT.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không duyệt qua hàng trống cuối
                {
                    lst.Add(row.Cells[0].Value.ToString());
                }
            }
            if (lst.Contains(cmbMaKT.Text.ToString().Trim())) //neu chua ca ma chủ phòng rồi thì thôi
                return lst.Count;
            else
                return lst.Count + 1;
        }
       //Sua hop dong
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult re = MessageBox.Show("Bạn chắc chắn muốn cập nhật?", "Cập nhật khách trọ", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (re == DialogResult.Yes)
            {
                HopDong hd = new HopDong();
                hd.MaHD = lblMaHD.Text;
                hd.MaKT = cmbMaKT.Text;
                hd.MaPT = cmbMaPT.Text;

                hd.NgayThue = dtpNgayThue.Value.ToString("yyyy/MM/dd");
                hd.NgayTra = dtpNgayTra.Value.ToString("yyyy/MM/dd");
                hd.TienCoc = txtTienCoc.Texts;
                hd.TinhTrang = cmbTinhTrang.Text.Trim();

                string str = "";
                bool kiemTra = hdbll.kiemTraHD(hd, out str,1,soluongKT: demMaKT(), maPT:hd.MaPT);
                if (kiemTra)
                {
                    CapNhatChiTietHopDong();
                    hdbll.capNhatHD(hd);
                    str = "Sửa hợp đồng thành công!";
                }
                MessageBox.Show(str, "Sửa hợp đồng", MessageBoxButtons.OK);
            }
        }
        // kiểm tra xem 
        List<string> ds_maKTMoi = new List<string>();
        List<string> ds_maKTBanDau = new List<string>();
     

        private void CapNhatChiTietHopDong()
        {
            //duyệt lẩy ds mã mới được thêm
            foreach (DataGridViewRow row in dgvMaKT.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không duyệt qua hàng trống cuối
                {
                    ds_maKTMoi.Add(row.Cells[0].Value.ToString());
                }
            }
            //TH1: cũ ko nằm trong mới -> xóa cũ
            foreach (string item in ds_maKTBanDau)
            {
                if (!ds_maKTMoi.Contains(item))
                    ktbll.xoaCTKT(item,lblMaHD.Text );
            }
            foreach (DataGridViewRow row in dgvMaKT.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không duyệt qua hàng mới
                {
                    // Lấy giá trị từ cột đầu tiên của mỗi hàng
                    string makt = row.Cells[0].Value.ToString();

                    //nếu nằm trong list thì bỏ qua, nếu không nằm trong list thì thêm vào 

                    if (ds_maKTBanDau.Contains(row.Cells[0].Value.ToString()))
                    {
                        continue;
                    }
                    
                    else
                    {
                        ktbll.themCTKT(makt, lblMaHD.Text);
                    }
                    

                }
            }
            //nếu mã người đại diện không có thì thêm vào cmbMaKT.Text
            if (!ds_maKTMoi.Contains(cmbMaKT.Text))
            {
                ktbll.themCTKT(cmbMaKT.Text, lblMaHD.Text);

            }
            
        }
    }
}
