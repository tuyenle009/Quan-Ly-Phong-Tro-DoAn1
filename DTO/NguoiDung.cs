using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDung
    {
        public string TenTK { get; set; }
        public string MatKhau { get; set; }
        public string Gmail { get; set; }
        public string Quyen { get; set; }
        public string QuyenPhongTro { get; set; }
        public string QuyenPhieuChi { get; set; }
        public string QuyenDichVu { get; set; }
        public string QuyenPhieuThu { get; set; }
        public string QuyenKhachTro { get; set; }
        public string QuyenHopDong { get; set; }
        public string QuyenThongKe { get; set; }
        public string QuyenCaiDat { get; set; }

        public NguoiDung(DataRow row)
        {
            this.TenTK = row["TenTK"].ToString();
            this.MatKhau = row["MatKhau"].ToString();
            this.Gmail = row["Email"].ToString();
            this.Quyen = row["Quyen"].ToString();
        }
        public NguoiDung(string TenTK, string MatKhau, string Gmail, string Quyen)
        {
            this.TenTK = TenTK;
            this.MatKhau = MatKhau;
            this.Gmail = Gmail;
            this.Quyen = Quyen;
        }
        // Hàm tạo thông thường
        public NguoiDung(string Quyen,
                         string QuyenPhongTro, string QuyenPhieuChi, string QuyenDichVu,
                         string QuyenPhieuThu, string QuyenKhachTro, string QuyenHopDong,
                         string QuyenThongKe, string QuyenCaiDat)
        {
            this.Quyen = Quyen;
            this.QuyenPhongTro = QuyenPhongTro;
            this.QuyenPhieuChi = QuyenPhieuChi;
            this.QuyenDichVu = QuyenDichVu;
            this.QuyenPhieuThu = QuyenPhieuThu;
            this.QuyenKhachTro = QuyenKhachTro;
            this.QuyenHopDong = QuyenHopDong;
            this.QuyenThongKe = QuyenThongKe;
            this.QuyenCaiDat = QuyenCaiDat;
        }
        public NguoiDung() { }
    }
}
