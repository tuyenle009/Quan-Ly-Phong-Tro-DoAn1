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
    public class ThongKeBLL
    {
        ThongKeDAL tkDAL = new ThongKeDAL();
        //lấy ra bảng thống kê dịch vụ
        public DataTable ThongKeTieuThuDien(string ngayBD, string ngayKT)
        {
            return tkDAL.ThongKeTieuThuDien(ngayBD, ngayKT);
        }

        public DataTable TKChiTietDV(string ngayBD, string ngayKT)
        {
           
            return tkDAL.TKChiTietDV(ngayBD, ngayKT);

        }
        public DataTable TKDV(string ngayBD, string ngayKT)
        {
           
            return tkDAL.TKDV(ngayBD, ngayKT);

        }
        public DataTable TKPhongThue(string ngayBD, string ngayKT)
        {

            return tkDAL.TKPhongThue(ngayBD, ngayKT);


        }
        public DataTable TKThuTien(string ngayBD, string ngayKT)
        {
            return tkDAL.TKThuTien(ngayBD, ngayKT);

        }
        public DataTable TKTongHop(string ngayBD, string ngayKT)
        {
            return tkDAL.TKTongHop(ngayBD, ngayKT);


        }
        /*
        //lấy ra bảng thống kê dịch vụ
        public DataTable layBangTKDV(string thang, string nam)
        {
            if (thang.Length == 0 || nam.Length == 0)
            {
                thang = "1";
                nam = "2024";
            }
            return tkDAL.layBangTKDV(thang,nam);
        }
        public List<ThongKe> hienThiDSTKDV(string thang, string nam)
        {
            if (thang.Length == 0 || nam.Length == 0)
            {
                thang = "1";
                nam = "2024";
            }
            return tkDAL.hienThiDSTKDV(thang, nam);
        }
        public ThongKe thongKeDSPT() // Lấy danh sách pt
        {
            return tkDAL.thongKeDSPT();
        }
        public ThongKe thongKeDienNuoc(string thang, string nam) // Lấy danh sách so dien da su dung
        {
            if (thang.Length == 0 || nam.Length == 0)
            {
                thang = "1";
                nam = "2024";
            }
            return tkDAL.thongKeDienNuoc(thang,nam);
        }
        //tổng tiền chi trong 1 tháng
        public float tienChiTrongThang(string thang, string nam)
        {
            if (thang.Length == 0 || nam.Length == 0)
            {
                thang = "1";
                nam = "2024";
            }
            return tkDAL.tienChiTrongThang(thang, nam);
        }*/

    }
}
