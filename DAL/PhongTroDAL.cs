using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using DTO;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlTypes;
using System.Collections;

namespace DAL
{
    public class PhongTroDAL : Database
    {

        //Ham hien thi danh sach phongtro
        public List<DTO.PhongTro> HienThiDSPT()
        {
            MoKetNoi();
            List<DTO.PhongTro> dsPT = new List<DTO.PhongTro>();
            SqlCommand sqlCmd = new SqlCommand("select * from PhongTro", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                PhongTro pt = new PhongTro
                {
                    MaPT = reader.GetString(0).Trim(),
                    TenPT = reader.GetString(1).Trim(),
                    GiaPhong = reader.GetDouble(2).ToString().Trim(),
                    SLToiDa = reader.GetInt32(3).ToString().Trim(),
                    TinhTrang = reader.GetBoolean(4).ToString().Trim(),
                    HinhAnh = reader.GetSqlBytes(5).Value
                };

                dsPT.Add(pt);
            }
            reader.Close();
            DongKetNoi();
            return dsPT;
        }

        public DataTable HienThiDSPT_TB(string query)
        {
            return dsDuLieu(query);
        }

        //Ham them phongtro
        public bool themPhongTro(PhongTro pt )
        {
            //chuyen doi hinh anh
            string tenPT = pt.TenPT;
            string giaPhong = pt.GiaPhong;
            string slToiDa = pt.SLToiDa;
            string query = "INSERT INTO PhongTro VALUES (dbo.maTuDongPT(),N'" + tenPT + "'," + giaPhong + "," + slToiDa +",'0',@hinhanh)";

            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.Add("@hinhanh", pt.HinhAnh);

            int k = (int)sqlCmd.ExecuteNonQuery();
            DongKetNoi();
            return (k > 0);
        }
        //Cập nhật khách trọ
        public bool capNhatPT(PhongTro pt)
        {
            string maPT = pt.MaPT;
            string tenPT = pt.TenPT;
            string giaPhong = pt.GiaPhong;
            string slToiDa = pt.SLToiDa;
            //string tinhTrang = pt.TinhTrang;
            byte[] hinhAnh = pt.HinhAnh;

            string query = "UPDATE dbo.PhongTro SET TenPhong=N'" + tenPT + "',GiaPhong=" + giaPhong + ",SLToiDa=" + slToiDa + ",anhPhong = @hinhanh WHERE MaPT = '" + maPT + "'";
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
            sqlCmd.Parameters.Add("@hinhanh", hinhAnh);
            int k = (int)sqlCmd.ExecuteNonQuery();
            DongKetNoi();
            return (k > 0);
        }
        //Tìm kiếm phong tro
        public List<DTO.PhongTro> timKiemPT(string luaChon, string chuoiTimKiem)
        {
            MoKetNoi();
            List<DTO.PhongTro> dsPT = new List<DTO.PhongTro>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            if(luaChon=="1" || luaChon == "2")
                sqlCmd.CommandText = "SELECT * FROM dbo.TimKiemPhongTro(" + luaChon + ",N'" + chuoiTimKiem + "')";
            else if(luaChon=="3") //phòng đã được thuê
                sqlCmd.CommandText = $"select * from PhongTro where mapt in (select pt.mapt from PhongTro as pt join HopDong as hd on pt.MaPT = hd.MaPT where hd.TinhTrang='{chuoiTimKiem}')";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string maPT = reader.GetString(0);
                string tenPT = reader.GetString(1);
                string giaPhong = reader.GetDouble(2).ToString();
                string slToiDa = reader.GetInt32(3).ToString();
                //string tinhTrang = reader.GetInt32(4).ToString();

                PhongTro pt = new PhongTro();
                pt.MaPT = maPT;
                pt.TenPT = tenPT;
                pt.GiaPhong = giaPhong;
                pt.SLToiDa = slToiDa;
                //pt.TinhTrang = tinhTrang;

                dsPT.Add(pt);
            }
            reader.Close();
            DongKetNoi();
            return dsPT;

        }
        //Xóa khách trọ
        public bool xoaPhongTro(string mapt)
        {
            //kiem tra pt da ky ket hd chua
            string check = "SELECT COUNT(*) FROM dbo.PhongTro AS pt JOIN dbo.HopDong AS hd ON hd.MaPT = pt.MaPT AND pt.MaPT = '" + mapt + "'";
            if (!thucThiSQL_Count(check)) //pt chưa ký hợp đồng nào 
            {
                string query_PC = ("DELETE FROM dbo.PhieuChi WHERE MaPT = '" + mapt + "'");
                thucThiSQL(query_PC);
                //xoa pt khachtro
                string query_PT = ("DELETE FROM dbo.PhongTro WHERE MaPT = '" + mapt + "'");
                return thucThiSQL(query_PT);
            }
           
            return false;
        }
        //Lấy hình ảnh ra


    }
}
