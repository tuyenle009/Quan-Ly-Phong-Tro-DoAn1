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

namespace QuanLyPhongTro_10122399.Folder_HopDong
{
    public partial class frmThemHD1 : Form
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
        public frmThemHD1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            cmbTinhTrang.SelectedIndex = 0; //chọn mặc định item đầu tiên
            HienThiDSKT();
        }
        HopDongBLL hdbll = new HopDongBLL();
        KhachTroBLL ktbll = new KhachTroBLL();
        //hien thi danh sách khách trọ trong dgv
        public void HienThiDSKT()
        {
            string query = "select makt, hoten from khachtro where makt not in (\r\nselect ctkt.makt from chitietkt as ctkt join hopdong as hd on ctkt.mahd = hd.mahd where hd.TinhTrang=1)\r\n";
            dgvCTKT.DataSource = ktbll.HienThiDSKT_TB(query);
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
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        //lấy ra danh sách phiếu chi có mã giống với mã phiếu thu
        private void themChiTietKT(string maHD)
        {
            foreach (DataGridViewRow row in dgvMaKT.Rows)
            {
                if (!row.IsNewRow) // Đảm bảo không duyệt qua hàng mới
                {
                    //Nếu là mã khách đại diện thì không thêm để cuối mới thêm
                    if (row.Cells["maKT1"].Value.ToString().Trim() == cmbMaKT.Text.Trim())
                        continue;
                    // Lấy giá trị từ cột đầu tiên của mỗi hàng
                    hdbll.themCTKT(maHD, row.Cells["maKT1"].Value.ToString());
                }
            }
            hdbll.themCTKT(maHD, cmbMaKT.Text.Trim());

        }

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
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            HopDong hd = new HopDong();
            if (cmbMaKT.SelectedIndex == -1 || cmbMaPT.SelectedIndex == -1
                            || !float.TryParse(txtTienCoc.Texts, out _)
                            || cmbTinhTrang.SelectedIndex == -1)
                MessageBox.Show("Vui lòng nhập đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                hd.MaKT = cmbMaKT.SelectedItem.ToString().Trim();
                hd.MaPT = cmbMaPT.SelectedItem.ToString().Trim();
                hd.NgayThue = dtpNgayThue.Value.ToString("yyyy/MM/dd").Trim();
                hd.NgayTra = dtpNgayTra.Value.ToString("yyyy/MM/dd").Trim();
                hd.TienCoc = txtTienCoc.Texts.Trim();
                hd.TinhTrang = cmbTinhTrang.SelectedItem.ToString().Trim();
                //nếu ngày trả < ngày hiện tại ==> false
                if (dtpNgayTra.Value < DateTime.Now)
                    hd.TinhTrang = "FALSE";
                string str = "";
                bool kiemTra = hdbll.kiemTraHD(hd, out str, 0, demMaKT(), hd.MaPT);
                if (kiemTra)
                {
                    string maHD = hdbll.maTD("select dbo.maTuDongHD()");
                    hdbll.themHopDong(hd);
                    themChiTietKT(maHD);
                    str = "Thêm hợp đồng thành công!";
                }
                MessageBox.Show(str, "Thêm hợp đồng", MessageBoxButtons.OK);
            }
        }
        //chọn khách trọ để chuyển sang bảng phòng trọ
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
                        ktTonTai= true;
                        break;
                    }
                }
                if(!ktTonTai)
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
    }
}
