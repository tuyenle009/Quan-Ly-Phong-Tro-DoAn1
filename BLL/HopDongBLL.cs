using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class HopDongBLL
    {
        HopDongDAL hdDAL = new HopDongDAL();
        PhongTroDAL ptDAL = new PhongTroDAL();
        public List<HopDong> hienThiDSHD()
        {
            return hdDAL.HienThiDSHD();

        }
        //lấy mã tự động 
        public string maTD(string loai)
        {
            return hdDAL.thucThiSQL_MaTD(loai);
        }
        //Ham them ct kt
        public void themCTKT(string mahd,string makt)
        {
            hdDAL.themCTKT(mahd, makt);
        }
        //Ham them 
        public bool themHopDong(HopDong hd)
        {
            return hdDAL.themHopDong(hd);
        }
        //kiem tra ma hd
        public bool kiemTraHD(HopDong hd,out string str, int sua =0, int soluongKT =0, string maPT = "" )
        {
            
            str = "";
            string tienCoc = hd.TienCoc;
            string ngayThue = hd.NgayThue;
            string ngayTra = hd.NgayTra;
            

            if (float.Parse(tienCoc) < 0)
            {
                // Kiểm tra tienCoc >= 0 và ngayTra sau ngayThue
                str = "Tiền cọc không được nhỏ hơn 0.";
                return false;
            }
            else if (DateTime.Parse(ngayTra) < DateTime.Parse(ngayThue))
            {
                // Kiểm tra tiền cọc và ngày
                str = "Ngày trả phải sau ngày thuê.";
                return false;
            }
            else if(hd.TinhTrang.Trim()=="TRUE" && sua !=1)
            {
                if (hdDAL.kiemTraLuongKT(hd, out str)) //nếu phong đã được thuê thì return true
                    return false;
            }
            else if (hd.TienCoc.Length>9)
            {
                str = "Tiền cọc quá lớn vui lòng kiểm tra lại";
                return false;
            }
            //kiem tra xem so luong khach dki thue co lon hon so luong khach trong phong khong
            //Console.WriteLine($"_________________1SO LUONG TOI DA {ptDAL.timKiemPT("1", maPT).Count}  mapt{maPT}");
            if (maPT.Length != 0)
            {
                //lay ra so luong trong phong 
                List<PhongTro> lstpt = ptDAL.timKiemPT("1", maPT);
                PhongTro pt = lstpt[0];
                //Console.WriteLine($"_________________2SO LUONG TOI DA {int.Parse(pt.SLToiDa) } SO LUONG {soluongKT + 1}");
                if (int.Parse(pt.SLToiDa) < soluongKT)
                {
                    str = $"Số lượng khách trong phòng tối đa là {pt.SLToiDa}, vui lòng kiểm tra lại!!";
                    return false;
                }
            }
            return true;

        }
        //Cập nhật Hợp đồng
        public bool capNhatHD(HopDong hd)
        {
            return hdDAL.capNhatHD(hd);
        }
        //Tìm kiếm Hợp đồng
        public List<HopDong> timKiemHD(string luaChon, string chuoiTimKiem, string thangNam)
        {
            return hdDAL.timKiemHD(luaChon, chuoiTimKiem, thangNam);
        }
        //Xóa Hợp đồng
        public bool xoaHopDong(string maHD)
        {
            return hdDAL.xoaHopDong(maHD);
        }
        //DS khach tro
        public List<string> dsKhachTro()
        {
            return hdDAL.dsKhachTro();
        }
        //DS PhongTro
        public List<string> dsPhongTro()
        {
            return hdDAL.dsPhongTro();
        }
        //Thong tin khách trọ
        public List<string> dsTTKT(string maKT)
        {
            return hdDAL.dsTTKT(maKT);
        }
        // DSMaKT
        public List<string> dsMaKT(string maHD)
        {
            return hdDAL.DSMaKT(maHD);
        }
    }
}
