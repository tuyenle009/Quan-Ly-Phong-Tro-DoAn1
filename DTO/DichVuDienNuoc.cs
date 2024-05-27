using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DichVuDienNuoc
    {
        public string MaDN { get; set; }
        public string MaPT { get; set; }
        public string Loai { get; set; }
        public string ThoiGian { get; set; }
        public string ChiSoCu { get; set; }
        public string ChiSoMoi { get; set; }
        //public string DonGia { get; set; }
        public string ThanhTien { get; set; }
        public DichVuDienNuoc(string MaDN, string MaPT,string Loai, string ThoiGian, string ChiSoCu, string ChiSoMoi, string ThanhTien)// string DonGia,
        {
            this.MaDN = MaDN;
            this.MaPT = MaPT;
            this.Loai = Loai;
            this.ThoiGian = ThoiGian;
            this.ChiSoCu = ChiSoCu;
            this.ChiSoMoi = ChiSoMoi;
            //this.DonGia = DonGia;
            this.ThanhTien = ThanhTien;
        }
        public DichVuDienNuoc() { }
    }
}
