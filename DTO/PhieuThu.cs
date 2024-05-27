using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuThu
    {
        public string MaThu { get; set; }
        public string MaPT { get; set; }
        public string GiaPhong { get; set; }
        public string NgayThu { get; set; }
        public string NoCu { get; set; }
        public string TongTien { get; set; }
        public string MaDV { get; set; }
        public string SoLuong { get; set; }
        public string DaTra { get; set; }
        //XUAT PHIEU THU RA REPORT VIEWER
        public string tenPhong { get; set; }
        public string loai { get; set; }
        public string chiSoCu { get; set; }
        public string chiSoMoi { get; set; }
        public string thanhTien { get; set; }
        public string tenDV { get; set; }
        public string soluongDV { get; set; }


        public PhieuThu(string MaThu, string MaPT, string GiaPhong, string NgayThu, string TongTien, string DaTra,string NoCu)
        {
            this.MaThu = MaThu;
            this.MaPT = MaPT;
            this.GiaPhong = GiaPhong;
            this.NgayThu = NgayThu;
            this.TongTien = TongTien;
            this.DaTra = DaTra;
            this.NoCu = NoCu;


        }
        public PhieuThu(string MaThu, string MaDV, string SoLuong)
        {
            this.MaThu = MaThu;
            this.MaDV = MaDV;
            this.SoLuong = SoLuong;
        }
        //xuat phieu thu
        public PhieuThu(string MaThu, string tenPhong, string NgayThu, string GiaPhong, string loai, string chiSoCu, string chiSoMoi, string SoLuong, string tenDV, string soluongDV, string thanhTien, string NoCu, string TongTien, string DaTra)
        {
            this.MaThu = MaThu;
            this.tenPhong = tenPhong;
            this.NgayThu = NgayThu;
            this.GiaPhong = GiaPhong;
            this.loai = loai;
            this.chiSoCu = chiSoCu;
            this.chiSoMoi = chiSoMoi;
            this.thanhTien = thanhTien;
            this.NoCu = NoCu;
            this.TongTien = TongTien;
            this.DaTra = DaTra;
            this.MaDV = MaDV;
            this.SoLuong = SoLuong;
            this.tenDV = tenDV;
            this.soluongDV = soluongDV;
        }
        public PhieuThu() 
        {
            this.MaThu = "";
            this.MaPT = "";
            this.NgayThu = "";
            this.TongTien = "";
            this.MaDV = "";
            this.SoLuong = "";
        }
    }
}
