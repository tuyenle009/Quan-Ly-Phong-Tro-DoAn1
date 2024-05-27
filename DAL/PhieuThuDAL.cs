using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuThuDAL:Database
    {
        public List<PhieuThu> hienThiDSPT(string thoigian="") // Lấy danh sách phiếu chi
        {
            MoKetNoi();
            List<PhieuThu> dsPhieuThu = new List<PhieuThu>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM PhieuThu", sqlCon);
            if (thoigian.Length != 0)
            {
                sqlCmd = new SqlCommand($"SELECT * FROM PhieuThu where month(ngaythu) = month('{thoigian}') and year(ngaythu) = year('{thoigian}')", sqlCon);
            }
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuThu PhieuThu = new PhieuThu(
                    reader.GetString(0).Trim(), // MaThu NgayChi SoTien LyDo
                    reader.GetString(1).Trim(), // MaThu NgayChi SoTien LyDo
                    reader.GetDouble(2).ToString().Trim(),
                    reader.GetDateTime(3).ToString("dd/MM/yyyy").Trim(), // NgayChi (assumed as DateTime in the database)
                    reader.GetDouble(4).ToString().Trim(), // SoTien (assumed as Double/Float in the database)
                    reader.GetDouble(5).ToString().Trim(), // datra (assumed as Double/Float in the database)
                    reader.GetDouble(6).ToString().Trim() // no cu

                );
                dsPhieuThu.Add(PhieuThu);
            }
            reader.Close();
            DongKetNoi();
            return dsPhieuThu;
        }
        //lấy ds ct phiếu chi
        public List<PhieuThu> hienThiDSCTPT(string MaThu) // Lấy danh sách ct phiếu chi
        {
            MoKetNoi();
            List<PhieuThu> dsCTPhieuThu = new List<PhieuThu>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM ChiTietPhieuThu where MaThu ='" + MaThu+"'", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                PhieuThu PhieuThu = new PhieuThu(
                    reader.GetString(0).Trim(), // MaThu NgayChi SoTien LyDo
                    reader.GetString(1).Trim(), // MaDV NgayChi SoTien LyDo
                    reader.GetInt32(2).ToString()// SoLuong NgayChi SoTien LyDo
                );
                dsCTPhieuThu.Add(PhieuThu);
            }
            reader.Close();
            DongKetNoi();
            return dsCTPhieuThu;
        }
        //Tìm kiếm phieu thu
        public List<DTO.PhieuThu> timKiemPThu(string luaChon, string chuoiTimKiem, string thangNam)
        {
            MoKetNoi();
            List<DTO.PhieuThu> dsPT = new List<DTO.PhieuThu>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.TimKiemPhieuThu(" + luaChon + ",N'" + chuoiTimKiem + "','"+thangNam+"')", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                //gán vào class hop dong
                PhieuThu pt = new PhieuThu();
                pt.MaThu = reader.GetString(0);
                pt.MaPT = reader.GetString(1);
                pt.GiaPhong = reader.GetDouble(2).ToString();
                pt.NgayThu = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                pt.NoCu = reader.GetDouble(6).ToString();
                pt.TongTien = reader.GetDouble(4).ToString();
                pt.DaTra = reader.GetDouble(5).ToString();
                dsPT.Add(pt);
            }
            reader.Close();
            DongKetNoi();
            return dsPT;
        }
        //lấy ra mã phiếu thu
        public string maPT()
        {
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand("SELECT dbo.maTuDongPThu()",sqlCon); //lấy ra mã
            string maPT = sqlCmd.ExecuteScalar().ToString().Trim();
            DongKetNoi();
            return maPT;
         
        }
        //Thanh toán tiền cho phiếu thu
        public bool thanhToan(string MaThu, string TongTien)
        {
            string query = $"Update PhieuThu SET DaTra = {TongTien} where mathu = '{MaThu}'";
            return thucThiSQL(query);
        }
        //thêm phiếu thu
        public bool themPT(PhieuThu PhieuThu)
        {
            string query = $"INSERT INTO PhieuThu VALUES (dbo.maTuDongPThu(), '{ PhieuThu.MaPT }',{PhieuThu.GiaPhong}, '{ PhieuThu.NgayThu }',0, {PhieuThu.DaTra},{PhieuThu.NoCu})";
            return thucThiSQL(query);
        }
        public void tinhTienPT(string mathu, string MaPT, string NgayThu, string GiaPhong, string NoCu)
        {
            string query = $"Update PhieuThu SET Tongtien = dbo.Fn_UpTongTienPT('{mathu}','{MaPT}','{NgayThu}',{GiaPhong}, {NoCu}) where mathu = '{mathu}'";
            thucThiSQL(query);
        }
      
        public bool capNhatPT(PhieuThu phieuThu)
        {
            string query = $"UPDATE PhieuThu SET  MaPT = '{phieuThu.MaPT }',GiaPhong={phieuThu.GiaPhong}, NgayThu = '{phieuThu.NgayThu }',TongTien = {phieuThu.TongTien }, datra = {phieuThu.DaTra}, nocu={phieuThu.NoCu} WHERE MaThu = '" + phieuThu.MaThu + "'";
            return thucThiSQL(query);
        }
        // Xóa phiếu thu
        public bool xoaPT(string MaThu)
        {
            string query1 = "DELETE FROM ChiTietPhieuThu WHERE MaThu = '" + MaThu + "'";
            thucThiSQL(query1);
            string query = "DELETE FROM PhieuThu WHERE MaThu = '" + MaThu + "'";
            return thucThiSQL(query);
        }
        //them chi tiet pthu
        public bool themCTPT(PhieuThu PhieuThu)
        {
            string query = "INSERT INTO ChiTietPhieuThu VALUES ('" + PhieuThu.MaThu + "', '" + PhieuThu.MaDV + "', " + PhieuThu.SoLuong +")";
            return thucThiSQL(query);
        }
        // Xóa chi tiet phiếu thu
        public bool xoaCTPT(string MaThu, string MaDV)
        {
           
            string query = "DELETE FROM ChiTietPhieuThu WHERE MaThu = '" + MaThu + "' AND MaDV = '"+ MaDV+"'";
            return thucThiSQL(query);
        }
        //cập nhật chi tiết phiếu cthu
        public bool capNhatCTPT(PhieuThu ctpt)
        {

            string query = "Update ChiTietPhieuThu Set soLuong = " + ctpt.SoLuong + " WHERE MaThu = '" + ctpt.MaThu + "' AND MaDV = '" + ctpt.MaDV + "' ";
            return thucThiSQL(query);
        }
        //kiem tra phiếu thu - mã pt và kt phải được kí kết rồi
        public bool kiemTraHopDong(string MaPT ) 
        {
            //lấy ra hợp động đã được thuê
            string query = $"SELECT COUNT(*) FROM HopDong WHERE mapt = '{MaPT}' AND TinhTrang = 1";
            return thucThiSQL_Count(query);
        }
        //lấy ra giá phòng, lấy ra giá điện, giá nước trong tháng
        public List<float> PhongDienNuoc(string MaPT, string ThoiGian)
        {
            //thucThiSQL_Float        select dbo.maTuDongHD()
            //Console.WriteLine($"---------------{MaPT}-------------{ThoiGian}");
            string query = $"select dbo.GiaPhong('{MaPT}')";
            float giaPhong = thucThiSQL_Float(query);
            string query2 = $"select dbo.GiaDienNuoc('{MaPT}','{ThoiGian}','D')";
            float giaDien = thucThiSQL_Float(query2);
            string query3 = $"select dbo.GiaDienNuoc('{MaPT}','{ThoiGian}','N')";
            float giaNuoc = thucThiSQL_Float(query3);
            string query4 = $"select dbo.Fn_NoCu('{MaPT}','{ThoiGian}')";
            float nocu = thucThiSQL_Float(query4);

            //tra ve gia phong - dien - nuoc
            List<float> myList = new List<float>() { giaPhong, giaDien, giaNuoc, nocu };
            return myList;

        }
        //lay ra dịch vụ để xuất dịch vụ 
        public DataTable layBangDV(string mapt)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM dbo.Fn_XuatDichVu( '{mapt}')";
            MoKetNoi();
            adapter = new SqlDataAdapter(query, sqlCon);
            adapter.Fill(dataTable);
            DongKetNoi();
            return dataTable;

        }
        //lay ra toan bo phieu thu theo thang nam
        public DataTable layToanBoPThu(string thang, string nam)
        {
            DataTable dataTable = new DataTable();
            string query = $"SELECT * FROM dbo.Fn_XuatToanBoPThu( {thang},{nam})";
            MoKetNoi();
            adapter = new SqlDataAdapter(query, sqlCon);
            adapter.Fill(dataTable);
            DongKetNoi();
            return dataTable;

        }
    }
}
