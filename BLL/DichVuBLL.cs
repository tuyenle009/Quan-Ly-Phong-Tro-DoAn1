using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BLL
{
    public class DichVuBLL
    {
        //DienNuoc
        DichVuDAL dvDAL = new DichVuDAL();
        public List<DichVuDienNuoc> hienThiDSDienNuoc()
        {
            return dvDAL.hienThiDSDienNuoc();

        }
        //Ham them 
        public bool themDienNuoc(DichVuDienNuoc dv, byte kiemTraDN)
        {
            return dvDAL.themDienNuoc(dv, kiemTraDN);
        }
        //kiem tra ma hd
        //public bool kiemTraDVDN(DichVuDienNuoc dv, out string str)
        //{
        //    return dvDAL.kiemTraDVDN(dv, out str);
        //}
        //Cập nhật Hợp đồng
        public bool capNhatDienNuoc(DichVuDienNuoc dv, byte kiemTraDN)
        {
            return dvDAL.capNhatDienNuoc(dv, kiemTraDN);
        }
       
        public bool xoaDienNuoc(string maDV)
        {
            return dvDAL.xoaDienNuoc(maDV);
        }
        //DS PhongTro
        public List<string> dsPhongTro()
        {
            return dvDAL.dsPhongTro();
        }


        //DS Phong tro theo thang
        public List<DichVuDienNuoc> DSDienNuocThang(int thang, int nam)
        {
            List < DichVuDienNuoc > lstDN = new List<DichVuDienNuoc>();
            foreach(DichVuDienNuoc dv in dvDAL.hienThiDSDienNuoc())
            {
                //kiểm tra xem có đúng tháng năm hay không
                if (int.Parse(dv.ThoiGian.Split('/')[1]) == thang && int.Parse(dv.ThoiGian.Split('/')[2]) == nam)
                {
                    lstDN.Add(dv);
                }
            }

            return lstDN;
        }
        public bool layDLThangTruoc(int thang, int nam)
        {
            return dvDAL.layDLThangTruoc(thang, nam);
        }
        public List<DichVuDienNuoc> timKiemDN(string mapt, string ngayThu)
        {
            return dvDAL.timKiemDN(mapt, ngayThu);
        }

        //______________________________________________________________
        //DichVuKhac

        public List<DichVu> hienThiDSDV() //lấy ds dv 
        {
            return dvDAL.hienThiDSDV();
        }
        public bool themDV(DichVu dichVu)
        {
           return dvDAL.themDV(dichVu);
        }
        //kiem tra mã dich vu
        public bool kiemTraDV(DichVu dichVu, out string str)
        {
            str = "";
            if (dichVu.TenDV.Length == 0 )
                str = "Mã hoặc tên dịch vụ không được trống!";
            else if (float.Parse(dichVu.DonGia) < 0 || dichVu.DonGia.Length>8)
                str = "Giá dịch vụ không được âm và không quá lớn!";
            else
            {
                str = "Thêm dịch vụ thành công!";
                return true;
            }
            return false;
        }
        // Cập nhật dịch vụ 
        public bool capNhatDV(DichVu dichVu)
        {
            return dvDAL.capNhatDV(dichVu);
        }

        // Xóa dịch vụ
        public bool xoaDV(string maDV)
        {
            return dvDAL.xoaDV(maDV);
        }
        //kiểm tra xem dịch vụ còn tồn tài ở phàn nào không trước khi xóa
        public bool ktTonTai(string maDV)
        {
            return dvDAL.thucThiSQL_Count($"Select count(*) from chitietphieuthu where madv = '{maDV}'");
        }

    }
}
