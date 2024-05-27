using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace QuanLyPhongTro_10122399
{
    internal class Connection
    {
        static string strCon = "Data Source=AY22ZYAM0M3F0HS\\SQLEXPRESS;Initial Catalog=QuanLyPhongTroTYN;Integrated Security=True";
        public static SqlConnection GetSqlCon()
        {
            return new SqlConnection(strCon);
        }
    }
}
