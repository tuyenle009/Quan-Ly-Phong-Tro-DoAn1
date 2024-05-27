using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhongTroBLL
    {
        PhongTroDAL ptDAL = new PhongTroDAL();
        public List<PhongTro> hienThiDSPT()
        {
            return ptDAL.HienThiDSPT();

        }
        public DataTable HienThiDSPT_TB(string query)
        {
            return ptDAL.HienThiDSPT_TB(query);
        }
        //Ham them 
        public bool themPhongTro(PhongTro pt)
        {
            return ptDAL.themPhongTro(pt);
        }
        //kiem tra ma pt
        public bool kiemTraPT(PhongTro pt,out string str)
        {
            //return ptDAL.kiemTraPT(pt, out str);
            str = "";
            string tenPT = pt.TenPT.Trim();
            string giaPhong = pt.GiaPhong;
            string slToiDa = pt.SLToiDa;

            if (float.Parse(giaPhong) < 0 || int.Parse(slToiDa) < 0)
            {
                // Kiểm tra tienCoc >= 0 và ngayTra sau ngayThue
                str = "Giá phòng hoặc số lượng khách không được nhỏ hơn 0.";
                return false;
            }
            else if (pt.GiaPhong.Length>9 || pt.SLToiDa.Length>3)
            {
                // Kiểm tra tienCoc >= 0 và ngayTra sau ngayThue
                str = "Giá trị nhập quá lớn vui lòng kiểm tra lại.";
                return false;
            }
            else if (tenPT.Length == 0)
            {
                str = "Tên phòng không được để rỗng.";
                return false;
            }
            else
                return true;
        }
        //Cập nhật khách trọ
        public bool capNhatPT(PhongTro pt)
        {
            return ptDAL.capNhatPT(pt);
        }
        //Tìm kiếm khách trọ
        public DataTable timKiemPT(string luaChon, string chuoiTimKiem)
        {
            if (luaChon == "1" || luaChon == "2")
                return ptDAL.HienThiDSPT_TB("SELECT * FROM dbo.TimKiemPhongTro(" + luaChon + ",N'" + chuoiTimKiem + "')");
            else if (luaChon=="3") //phòng đã được thuê
                return ptDAL.HienThiDSPT_TB($"select * from PhongTro where mapt in (select pt.mapt from PhongTro as pt join HopDong as hd on pt.MaPT = hd.MaPT where hd.TinhTrang='{1}')");
            else
                return ptDAL.HienThiDSPT_TB($"select * from PhongTro where mapt not in (select pt.mapt from PhongTro as pt join HopDong as hd on pt.MaPT = hd.MaPT where hd.TinhTrang='{1}')");

        }
        public List<DTO.PhongTro> timKiemPT2(string luaChon, string chuoiTimKiem)
        {
            return ptDAL.timKiemPT(luaChon, chuoiTimKiem);
        }
        //Xóa khách trọ
        public bool xoaPhongTro(string maPT)
        {
            return ptDAL.xoaPhongTro(maPT);
        }

    }
}
