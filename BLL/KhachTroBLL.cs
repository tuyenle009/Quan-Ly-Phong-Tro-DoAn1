using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data;




namespace BLL
{
    public class KhachTroBLL
    {
        KhachTroDAL ktDAL = new KhachTroDAL();
        public List<KhachTro> hienThiDSVT()
        {
            return ktDAL.HienThiDSKT();

        }
        //danh sách khách trọ trong bảng
        public DataTable HienThiDSKT_TB(string query)
        {
            return ktDAL.HienThiDSPT_TB(query);
        }
        //Ham them 
        public bool themKhachTro(KhachTro kt)
        {
            return ktDAL.themKhachTro(kt);
        }
        //Cập nhật khách trọ
        public bool capNhatKT(KhachTro kt)
        {
            return ktDAL.capNhatKT(kt);
        }
        //Tìm kiếm khách trọ
        public List<KhachTro> timKiemKT(string luaChon, string chuoiTimKiem)
        {
            return ktDAL.timKiemKT(luaChon,chuoiTimKiem);
        }
        //Xóa khách trọ
        public bool xoaKhachTro(string maKT)
        {
            return ktDAL.xoaKhachTro(maKT);
        }
        //Chi tiet khach tro
        //xoa ct khach trọ
        public bool xoaCTKT(string maKT, string maHD)
        {
            return ktDAL.xoaCTKT(maKT, maHD);
        }
        //capNhatCTPT
        public bool themCTKT(string maKT, string maHD)
        {
            return ktDAL.themCTKT(maKT, maHD);
        }
    }
}
