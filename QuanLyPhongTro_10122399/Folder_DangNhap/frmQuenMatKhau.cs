using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;
using System.Xml.Linq;

namespace QuanLyPhongTro_10122399
{
    public partial class frmQuenMatKhau : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
           int nLeftRect,     // x-coordinate of upper-left corner
           int nTopRect,      // y-coordinate of upper-left corner
           int nRightRect,    // x-coordinate of lower-right corner
           int nBottomRect,   // y-coordinate of lower-right corner
           int nWidthEllipse, // width of ellipse
           int nHeightEllipse // height of ellipse
       );
        public frmQuenMatKhau()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 40, 40));
            label2.Text = "";
        }



        Modify modify = new Modify();
        //gửi mail
        private void guiGmail(string noidung, string taiKhoan)
        {
            string nguoiGui = "leductuyen099@gmail.com";
            string nguoiNhan = txtEmailDK.Text.Trim();

            var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(nguoiGui, "drji zvof kntk ptlx"),
                Timeout = 20000
            };
            using (var message = new MailMessage(nguoiGui, nguoiNhan)
            {
                Subject = "Phòng trọ TYN - Thông tin mật khẩu của bạn",
                Body = $"Gmail: {nguoiNhan} \nAccount: {taiKhoan}\nPassWord: {noidung}"
               
            })
            {
                smtp.Send(message);
            }
        }
        private void btnLayLaiMK_Click(object sender, EventArgs e)
        {
            string gmail = txtEmailDK.Text;
            if(gmail.Trim()=="")
            { MessageBox.Show("Vui lòng nhập gmail đăng ký!"); }
            else
            {
                string query = "Select * from Nguoidung where Gmail = '" + gmail + "'";
                if (modify.lstTaiKhoan(query).Count != 0)
                {
                    label2.ForeColor = Color.Blue;
                    label2.Text ="Vui lòng vào Gmail để kiểm tra mật khẩu!";
                    guiGmail(modify.lstTaiKhoan(query)[0].MatKhau, modify.lstTaiKhoan(query)[0].TenTaiKhoan);
                }
                else
                {
                    label2.ForeColor = Color.Red;
                    label2.Text = "Gmail này chưa được đăng kí!";
                }

            }
        }

        private void picThuNho_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void picThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
