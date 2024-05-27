using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class PhanQuyenDAL : Database
    {
        //Dịch vụ khác
        public List<NguoiDung> hienThiDSND(string quyen="") //lấy ds dv 
        {
            MoKetNoi();
            List<NguoiDung> dsNguoiDung = new List<NguoiDung>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM NguoiDung", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                //neu la quan tri vien thi bo qua
                if (reader.GetString(3) == "Quản trị" && quyen !="Quản trị")
                    continue;
                NguoiDung NguoiDung = new NguoiDung(reader.GetString(0), reader.GetString(1), reader.GetString(2).ToString(), reader.GetString(3));
                dsNguoiDung.Add(NguoiDung);
            }
            reader.Close();
            DongKetNoi();
            return dsNguoiDung;
        }
        public bool themND(NguoiDung NguoiDung)
        {
            string query = $"INSERT INTO NguoiDung VALUES ('{NguoiDung.TenTK}','{NguoiDung.MatKhau}','{NguoiDung.Gmail}',N'{NguoiDung.Quyen}')";

            return thucThiSQL(query);
        }
        //kiem tra mã NguoiDung
        public bool kiemTraSoLuong(string query)
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);//query
            int k = (int)sqlCmd.ExecuteScalar();
            DongKetNoi();
            return (k > 0); //k>0 có nghĩa là mã tồn tại

        }
        // Cập nhật NguoiDung
        public bool capNhatND(NguoiDung NguoiDung)
        {
            string query = "";
            query = $"UPDATE NguoiDung SET  matkhau ='{NguoiDung.MatKhau}' , gmail = '{NguoiDung.Gmail}', quyen= N'{NguoiDung.Quyen}' WHERE taikhoan = '" + NguoiDung.TenTK + "'";
            //nếu là admin thì không được cập nhật quyền
            //if (NguoiDung.TenTK.Trim() == "admin1")
            //{
            //    query = $"UPDATE NguoiDung SET  matkhau ='{NguoiDung.MatKhau}' , gmail = '{NguoiDung.Gmail}' WHERE taikhoan = '" + NguoiDung.TenTK + "'";
            //}
            return thucThiSQL(query);
        }

        // Xóa NguoiDung
        public bool xoaND(string taikhoan)
        {
            string query = "DELETE FROM NguoiDung WHERE taikhoan = '" + taikhoan + "'";
            return thucThiSQL(query);
        }
        //lay quyen 
        public List<NguoiDung> layDsQuyen(string quyen) //lấy ds quyen
        {
            MoKetNoi();
            List<NguoiDung> dsQuyen = new List<NguoiDung>();
            SqlCommand sqlCmd = new SqlCommand($"SELECT * FROM PhanQuyen where quyen = N'{quyen}'", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                NguoiDung NguoiDung = new NguoiDung(reader.GetString(0), reader.GetBoolean(1).ToString(), 
                    reader.GetBoolean(2).ToString(), reader.GetBoolean(3).ToString(), reader.GetBoolean(4).ToString(), reader.GetBoolean(5).ToString(), 
                    reader.GetBoolean(6).ToString(), reader.GetBoolean(7).ToString(), reader.GetBoolean(8).ToString());
                dsQuyen.Add(NguoiDung);
            }
            reader.Close();
            DongKetNoi();
            return dsQuyen;
        }
        //cap nhat quyen
        public bool capNhatQuyen(NguoiDung NguoiDung)
        {
            string query = $"UPDATE PhanQuyen SET QuyenPhongTro = '{NguoiDung.QuyenPhongTro}', QuyenPhieuChi = '{NguoiDung.QuyenPhieuChi}', QuyenDichVu = '{NguoiDung.QuyenDichVu}', " +
                $"QuyenPhieuThu = '{NguoiDung.QuyenPhieuThu}', QuyenKhachTro = '{NguoiDung.QuyenKhachTro}', QuyenHopDong = '{NguoiDung.QuyenHopDong}', QuyenThongKe = '{NguoiDung.QuyenThongKe}', QuyenCaiDat = '{NguoiDung.QuyenCaiDat}'" +
                $"WHERE Quyen = N'{NguoiDung.Quyen}';";
            return thucThiSQL(query);
        }
        //kiem tra quyen đang đăng nhập
        public string ktQuyen(string tk)
        {
            string query = $"Select quyen from nguoiDung where taikhoan = N'{tk}'";
            return thucThiSQL_MaTD(query);
        }

    }
}
