using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL pqDAL = new PhanQuyenDAL();
        public List<NguoiDung> hienThiDSND(string quyen ="")
        {
            return pqDAL.hienThiDSND(quyen);

        }
        public List<NguoiDung> layDsQuyen(string quyen)
        {
            return pqDAL.layDsQuyen(quyen);

        }
        public bool themND(NguoiDung NguoiDung)
        {
            return pqDAL.themND(NguoiDung);
        }
        public bool capNhatND(NguoiDung NguoiDung)
        {
            return pqDAL.capNhatND(NguoiDung);
        }
        // Xóa nguoidung
        public bool xoaND(string taikhoan)
        {
            return pqDAL.xoaND(taikhoan);
        }
        //
        //kiem tra mã NguoiDung
        public bool kiemTraSoLuong(string key, string str)
        {
            string query = $"SELECT COUNT(*) FROM NguoiDung WHERE {str} ='{key}'";
            return pqDAL.kiemTraSoLuong(query);
        }
        //cap nhat quyen
        public bool capNhatQuyen(NguoiDung NguoiDung)
        {
           
            return pqDAL.capNhatQuyen(NguoiDung);
        }
        //kiem tra quyen đang đăng nhập
        public string ktQuyen(string tk)
        {
            return pqDAL.ktQuyen(tk);
        }
    }
}
