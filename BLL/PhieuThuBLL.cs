using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuThuBLL
    {
        PhieuThuDAL ptDAL = new PhieuThuDAL();
        public List<PhieuThu> hienThiDSPT(string thangNam = "") //lấy ds dv 
        {
            return ptDAL.hienThiDSPT(thangNam);
        }
        public List<PhieuThu> hienThiDSCTPT(string MaThu) // Lấy danh sách ct phiếu chi{
        {
            return ptDAL.hienThiDSCTPT(MaThu);
        }
        //Tìm kiếm Phiêu thu
        public List<PhieuThu> timKiemPThu(string luaChon, string chuoiTimKiem, string thangNam)
        {
            return ptDAL.timKiemPThu(luaChon, chuoiTimKiem, thangNam);
        }
        public bool themPT(PhieuThu phieuThu)
        {
            return ptDAL.themPT(phieuThu);
        }
        public void tinhTienPT(string mathu, string MaPT, string NgayThu, string GiaPhong, string NoCu)
        {
            ptDAL.tinhTienPT(mathu, MaPT, NgayThu, GiaPhong, NoCu);
        }
        //thanh toan 
        public bool thanhToan(string MaThu, string tongTien)
        {
            return ptDAL.thanhToan(MaThu, tongTien);
        }
        //lấy ra mã PT
        public string maPT()
        {
            return ptDAL.maPT();
        }
        //kiem tra mã PT
        public bool kiemTraPT(PhieuThu phieuThu, out string str)
        {
            str = "";
            if (phieuThu.MaPT.Length == 0)
                str = "Mã không được trống!";
            else if (phieuThu.GiaPhong.Length > 9 || phieuThu.NoCu.Length>9 || phieuThu.DaTra.Length>9)
            {
                str = "Giá trị nhập quá lớn vui lòng kiểm tra lại!";
            }
            else
            {
                str = "Thêm phiếu thu thành công!";
                return true;
            }
            return false;
        }
        // Cập nhật phiếu thu 
        public bool capNhatPT(PhieuThu phieuThu)
        {
            return ptDAL.capNhatPT(phieuThu);
        }

        // Xóa phiếu thu 
        public bool xoaPT(string maPT)
        {
            return ptDAL.xoaPT(maPT);
        }
        // ds pt
        public List<string> dsPhongTro()
        {
            return ptDAL.dsPhongTro();
        }
        // ds kt
        public List<string> dsKhachTro()
        {
            return ptDAL.dsKhachTro();
        }
        // ds dv
        public List<string> dsDichVu()
        {
            return ptDAL.dsDichVu();
        }
        // them ct phieu thu
        public bool themCTPT(PhieuThu phieuThu)
        {
            return ptDAL.themCTPT( phieuThu);
        }
        //xoa ct phieu thu
        public bool xoaCTPT(string maPT , string maDV)
        {
            return ptDAL.xoaCTPT(maPT, maDV);
        }
        public bool capNhatCTPT(PhieuThu ctpt)
        {
            return ptDAL.capNhatCTPT(ctpt);
        }


        //kiem tra phiếu thu - mã pt và kt phải được kí kết rồi
        public bool kiemTraHopDong(string MaPT)
        {
            return ptDAL.kiemTraHopDong(MaPT);
        }
        //lấy ra giá phòng, lấy ra giá điện, giá nước trong tháng
        public List<float> PhongDienNuoc(string MaPT, string ThoiGian)
        {
            //thucThiSQL_Float
            return ptDAL.PhongDienNuoc(MaPT, ThoiGian);

        }
        //lay ra dịch vụ để xuất dịch vụ 
        public DataTable layBangDV(string mapt)
        {
            return ptDAL.layBangDV( mapt);

        }
        //lay ra toan bo phieu thu theo thang nam
        public DataTable layToanBoPThu(string thangNam)
        {
            return ptDAL.layToanBoPThu(thangNam.Split('/')[0], thangNam.Split('/')[1]);

        }
    }
}
