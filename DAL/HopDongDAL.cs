using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class HopDongDAL : Database
    {
        //Ham hien thi danh sach vat tu
        public List<DTO.HopDong> HienThiDSHD()
        {
            MoKetNoi();
            List<DTO.HopDong> dsHD = new List<DTO.HopDong>();
            SqlCommand sqlCmd = new SqlCommand("select * from HopDong",sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                HopDong hd = new HopDong();
                hd.MaHD = reader.GetString(0).Trim();
                hd.MaKT = reader.GetString(1).Trim();
                hd.MaPT = reader.GetString(2).Trim();
                hd.NgayThue = reader.GetDateTime(3).ToString("dd/MM/yyyy").Trim();
                hd.NgayTra = reader.GetDateTime(4).ToString("dd/MM/yyyy").Trim();
                hd.TienCoc = reader.GetDouble(5).ToString().Trim();
                hd.TinhTrang = reader.GetBoolean(6).ToString().Trim();

                dsHD.Add(hd);
            }
            reader.Close();
            DongKetNoi();
            return dsHD;
        }
        //lấy mã tự động 
        public string maTD(string loai)
        {
            return thucThiSQL_MaTD(loai);
        }
        //Ham them ctkt
        public void themCTKT(string mahd,string makt)
        {
                string query = $"INSERT INTO ChiTietKT VALUES ('{makt}' , '{mahd}')";
                thucThiSQL(query);
        }
        //Ham them hop dong
        public bool themHopDong(HopDong hd)
        {
            string tinhTrang = hd.TinhTrang.Trim();
            if (tinhTrang == "TRUE") tinhTrang = "1";
            else if (tinhTrang == "FALSE") tinhTrang = "0";

            string query= ("INSERT INTO HopDong VALUES (dbo.maTuDongHD() , '" + hd.MaKT + "', '" + hd.MaPT + "', '" + hd.NgayThue 
                + "', '" + hd.NgayTra + "', " + hd.TienCoc + ", " + tinhTrang + ")");
            return thucThiSQL(query);

        }
        //kiem tra điều kiện khách thuê trọ, chỉ có 1 khách đại diện thuê cho 1 phòng trọ
        public bool kiemTraLuongKT(HopDong hd, out string str)
        {
            MoKetNoi();
            //"select count(*) from hopdong as hd join phongtro as pt on pt.MaPT = hd.MaPT and pt.MaPT = 'PT1' where hd.TinhTrang =1"
            str = "";
            //kiem tra ma hop dong
            SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.HopDong as hd join phongtro as pt on pt.MaPT = hd.MaPT and pt.MaPT = '"+hd.MaPT+"' Where hd.TinhTrang =1 ", sqlCon);
            int k = (int)sqlCmd.ExecuteScalar();
            DongKetNoi();
            if (k > 0)
            {
                str = "Phòng này đã được thuê, vui lòng kiểm tra lại!";
                return true;
            }
            return false;
        }
        //kiem tra ma hd
        public bool kiemTraMaHD(HopDong hd, out string str) //kiem tra ma hd co bi trung hay khong
        {
            MoKetNoi();
            str = "";
            //kiem tra ma hop dong
            SqlCommand sqlCmd = new SqlCommand("SELECT COUNT(*) FROM dbo.HopDong WHERE MaHD = '" + hd.MaHD + "'", sqlCon);
            int k = (int)sqlCmd.ExecuteScalar();
            DongKetNoi();
            if (k > 0)
            {
                str = "Mã hợp đồng không được trùng";
                return false;
            }
            return true;
        }
        //Cập nhật khách trọ
        public bool capNhatHD(HopDong hd)
        {
            string mahd = hd.MaHD;
            string makt = hd.MaKT;
            string maPT = hd.MaPT;
            string ngayThue = hd.NgayThue;
            string ngayTra = hd.NgayTra;
            string tienCoc = hd.TienCoc;
            string tinhTrang = hd.TinhTrang.Trim();
            if (tinhTrang == "TRUE") tinhTrang = "1";
            else if (tinhTrang == "FALSE") tinhTrang = "0";

            string query = ("UPDATE dbo.HopDong SET maKT ='" + makt + "',MaPT ='" + maPT + "',NgayThue ='" + ngayThue + "',NgayKetThuc='" + ngayTra + "',TienCoc=" + tienCoc + ",TinhTrang ='" + tinhTrang + "' WHERE MaHD='" + mahd + "'");
            return thucThiSQL(query);
        }
        //Tìm kiếm khách trọ
        public List<DTO.HopDong> timKiemHD(string luaChon, string chuoiTimKiem, string thangNam)
        {
            MoKetNoi();
            List<DTO.HopDong> dsHD = new List<DTO.HopDong>();
            SqlCommand sqlCmd = new SqlCommand("SELECT * FROM dbo.TimKiemHopDong(" + luaChon + ",N'" + chuoiTimKiem + "','"+ thangNam + "')",sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                //gán vào class hop dong
                HopDong hd = new HopDong();
                hd.MaHD = reader.GetString(0);
                hd.MaKT = reader.GetString(1);
                hd.MaPT = reader.GetString(2);
                hd.NgayThue = reader.GetDateTime(3).ToString("dd/MM/yyyy");
                hd.NgayTra = reader.GetDateTime(4).ToString("dd/MM/yyyy");
                hd.TienCoc = reader.GetDouble(5).ToString();
                hd.TinhTrang = reader.GetBoolean(6).ToString();

                dsHD.Add(hd);
            }
            reader.Close();
            DongKetNoi();
            return dsHD;

        }
        //Xóa HD
        public bool xoaHopDong(string mahd)
        {
            //xoa ct khachtro
            string queryKT = ("DELETE FROM dbo.ChiTietKT WHERE MaHD = '" + mahd + "'");
            thucThiSQL(queryKT);
            string query = ("DELETE FROM dbo.HopDong WHERE MaHD = '" + mahd + "'");
            return thucThiSQL(query);
        }
      
        //nhận vào mã khách trọ và trả về thông tin khách trọ
        public List<string> dsTTKT(string maKT)
        {
            MoKetNoi();
            List<string> dsTTKT = new List<string>(); //khoi tao ds chua makt
            SqlCommand sqlCmd = new SqlCommand("select HoTen, CMND, SDT, DiaChi from KhachTro where MaKT ='" + maKT + "'",sqlCon);
           
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                string tenkt = reader.GetString(0);
                string cmnd = reader.GetString(1);
                string diaChi = reader.GetString(3);
                string sdt = reader.GetString(2);
                dsTTKT.Add(tenkt);
                dsTTKT.Add(cmnd);
                dsTTKT.Add(diaChi);
                dsTTKT.Add(sdt);
            }
            reader.Close();
            DongKetNoi();
            return dsTTKT;
        }
        //lst danh sach ma khach tro trong bảng chi tiết khách trọ theo mã hợp đồng cho trước
        public List<string> DSMaKT(string maHD)
        {
            List<string> dsKT = new List<string>();
            MoKetNoi();
            SqlCommand sqlCmd = new SqlCommand($"select * from chiTietKT where mahd='{maHD}'", sqlCon);
            SqlDataReader reader = sqlCmd.ExecuteReader();
            while (reader.Read())
            {
                dsKT.Add(reader.GetString(0).Trim());
            }
            reader.Close();
            DongKetNoi();
            return dsKT;
        }
    }
}
