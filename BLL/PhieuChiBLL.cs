using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuChiBLL
    {
        PhieuChiDAL pcDAL = new PhieuChiDAL();
        public DataTable hienThiDSPC() //lấy ds dv 
        {
            string query = "SELECT * FROM PhieuChi";
            return pcDAL.HienThi(query);
        }
        public DataTable timKiemPC(string maPC) //lấy dv theo mã
        {
            string query = $"SELECT * FROM PhieuChi WHERE MAPC = '{maPC}'";
            return pcDAL.HienThi(query);
        }
        public bool themPC(PhieuChi phieuChi)
        {
            return pcDAL.themPC(phieuChi);
        }
        //kiem tra mã PC
        public bool kiemTraPC(PhieuChi phieuChi, out string str)
        {
            str = "";
            //if (phieuChi.MaPC.Length == 0 || phieuChi.LyDo.Length == 0 || phieuChi.MaPC.Length == 0)
            //    str = "Mã hoặc tên phiếu chi không được trống!";
            if (float.Parse(phieuChi.SoTien) < 0)
                str = "Tiền chi phải lớn hơn 0!";
            else if(phieuChi.SoTien.Length>9)
            {
                str = "Số tiền quá lớn vui lòng kiểm tra lại!";
            }
            else
            {
                str = "Thêm phiếu chi thành công!";
                return true;
            }
            return false;
        }
        // Cập nhật phiếu chi 
        public bool capNhatPC(PhieuChi phieuChi)
        {
            return pcDAL.capNhatPC(phieuChi);
        }

        // Xóa phiếu chi 
        public bool xoaPC(string maPC)
        {
            return pcDAL.xoaPC(maPC);
        }
        // ds pt
        public List<string> dsPhongTro()
        {
            return pcDAL.dsPhongTro();
        }
        //kiem tra max phieu chi xem da ton tai chua
        public bool kiemTraMaPC(string txtMaPC)
        {
            List<PhieuChi> ds = pcDAL.hienThiDSPC();
            foreach (PhieuChi item in ds)
            {
                if (txtMaPC.ToUpper() == item.MaPC.Trim().ToUpper())
                    return true;
            }
            return false;
        }
    }
}
