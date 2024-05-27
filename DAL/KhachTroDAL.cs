using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;



namespace DAL
{
    public class KhachTroDAL:Database
    {

        //Ham hien thi danh sach khachtro
        public List<DTO.KhachTro> HienThiDSKT()
        {
            MoKetNoi();
            List<DTO.KhachTro> dsVT = new List<DTO.KhachTro>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "select * from KhachTro";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string makt = reader.GetString(0).Trim();
                string tenkt = reader.GetString(1).Trim();
                string gioiTinh = reader.GetString(2).Trim();
                string sdt = reader.GetString(3).Trim();
                string cmnd = reader.GetString(4).Trim();
                string email = reader.GetString(5).Trim();
                string ngheNghiep = reader.GetString(6).Trim();
                string diaChi = reader.GetString(7).Trim();

                KhachTro kt = new KhachTro(makt, tenkt, gioiTinh, sdt, cmnd, email, ngheNghiep, diaChi);
                dsVT.Add(kt);
            }

            reader.Close();
            DongKetNoi();
            return dsVT;
        }
        //danh sách khách trọ trong bảng
        public DataTable HienThiDSPT_TB(string query)
        {
            return dsDuLieu(query);
        }
        //Ham them khachtro
        public bool themKhachTro(KhachTro kt)
        {
            string query = "INSERT INTO khachtro VALUES (dbo.maTuDongKT(),N'" + kt.HoTen + "',N'" + kt.GioiTinh + "','" + kt.SDT + "','" + kt.CMND + "',N'_',N'"+kt.NgheNghiep+"',N'"+kt.DiaChi+"')";
            return thucThiSQL(query);
        }
       
        //Cập nhật khách trọ
        public bool capNhatKT(KhachTro kt)
        {
            string query = "UPDATE dbo.KhachTro SET " +
                           "HoTen = N'" + kt.HoTen + "', " +
                           "CMND = '" + kt.CMND + "', " +
                           "GioiTinh = N'" + kt.GioiTinh + "', " +
                           "DiaChi = N'" + kt.DiaChi + "', " +
                           "SDT = '" + kt.SDT + "', " +
                           "NgheNghiep = N'" + kt.NgheNghiep + "', " +
                           "Email = N'' " +
                           "WHERE MaKT = '" + kt.MaKT + "'";
            return thucThiSQL(query);
        }

        //Tìm kiếm khách trọ
        public List<DTO.KhachTro> timKiemKT(string luaChon, string chuoiTimKiem)
        {
            MoKetNoi();
            List<DTO.KhachTro> dsVT = new List<DTO.KhachTro>();
            SqlCommand sqlCmd = new SqlCommand();
            sqlCmd.CommandType = CommandType.Text;
            sqlCmd.CommandText = "SELECT * FROM dbo.TimKiemKhachTro("+luaChon+",N'"+chuoiTimKiem+"')";
            sqlCmd.Connection = sqlCon;
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                KhachTro kt = new KhachTro();
                kt.MaKT = reader.GetString(0);
                kt.HoTen = reader.GetString(1);
                kt.GioiTinh = reader.GetString(2);
                kt.SDT = reader.GetString(3);
                kt.CMND = reader.GetString(4);
                kt.Email = reader.GetString(5);
                kt.NgheNghiep = reader.GetString(6);
                kt.DiaChi = reader.GetString(7);

                dsVT.Add(kt);
            }
            reader.Close();
            DongKetNoi();
            return dsVT;
           
        }
        //Xóa khách trọ
        public bool xoaKhachTro(string makt)
        {
            //kiem tra pt da ky ket hd chua
            string check = "SELECT COUNT(*) FROM dbo.KhachTro AS kt JOIN dbo.HopDong AS hd ON hd.MaKT = kt.MaKT AND kt.MaKT = '" + makt + "'";
            if (!thucThiSQL_Count(check)) //pt chưa ký hợp đồng nào 
            {
                //xoa cac bang co lien quan
                string query_PC = ("DELETE FROM dbo.ChiTietKT WHERE maKT = '" + makt + "'");
                thucThiSQL(query_PC);
                //xoa pt khachtro
                string query_PT = ("DELETE FROM dbo.KhachTro WHERE maKT = '" + makt + "'");
                return thucThiSQL(query_PT);
            }

            return false;

        }
        //Xoa CT KT
        public bool xoaCTKT(string makt, string maHD)
        {
            //xoa ctkhachtro
            string query_PT = ($"DELETE FROM dbo.ChiTietKT WHERE maKT ='{makt}' and mahd = '{maHD}' ");
            return thucThiSQL(query_PT);

        }
        //them CT KT
        public bool themCTKT(string makt, string maHD)
        {
            //xoa ctkhachtro
            string query_PT = ($"INSERT INTO ChiTietKT VALUES ('{makt}','{maHD}') ");
            return thucThiSQL(query_PT);

        }

    }
}
