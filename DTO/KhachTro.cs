using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachTro
    {
        public string MaKT { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string SDT { get; set; }

        public string CMND { get; set; }
        public string Email { get; set; }
        public string NgheNghiep { get; set; }
        public string DiaChi { get; set; }
        // Hàm khởi tạo
        public KhachTro(string maKT, string hoTen, string gioiTinh, string sdt, string cmnd, string email, string ngheNghiep, string diaChi)
        {
            this.MaKT = maKT;
            this.HoTen = hoTen;
            this.GioiTinh = gioiTinh;
            this.SDT = sdt;
            this.CMND = cmnd;
            this.Email = email;
            this.NgheNghiep = ngheNghiep;
            this.DiaChi = diaChi;
        }
        public KhachTro() { }

    }
   
}
