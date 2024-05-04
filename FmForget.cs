using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O22
{
    public partial class FmForget : Form
    {
        public FmForget()
        {
            InitializeComponent();
        }
        Random random = new Random();
        int otp;
        private void btnSend_Click(object sender, EventArgs e)
        {
            otp = random.Next(100000, 1000000);
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("22520769@gm.uit.edu.vn");
                mail.To.Add(txtEmail.Text);
                mail.Subject = "Mã xác thực Email";
                mail.Body = "Xin chào,\nĐây là mã xác thực của bạn:" + otp;

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                System.Net.NetworkCredential network = new NetworkCredential();
                network.UserName = "22520769@gm.uit.edu.vn";
                network.Password = "1680179975";
                smtpClient.Credentials = network;
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.Send(mail);

                MessageBox.Show("Mã xác thực đã được gửi đến mail của bạn!");
                Hide();
                FmOTP_Forget fmOTP = new FmOTP_Forget(otp, txtEmail.Text);
                fmOTP.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Hide();
            FmDangNhap fmDangNhap = new FmDangNhap();
            fmDangNhap.ShowDialog();
            Close();
        }
    }
}
