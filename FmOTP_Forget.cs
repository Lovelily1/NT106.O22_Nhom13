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
    public partial class FmOTP_Forget : Form
    {
        public FmOTP_Forget()
        {
            InitializeComponent();
        }
        private int otp;
        private string mail;
        public FmOTP_Forget(int otp, string email)
        {
            InitializeComponent();
            this.otp = otp;
            this.mail = email;
        }

      
        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                if (otp.ToString().Equals(txtOTP.Text))
                {
                    Hide();
                    FmDoiMK fmDoiMK = new FmDoiMK();
                    fmDoiMK.ShowDialog();
                    Close();
                }
                else
                {
                    lbError.Text = "Mã xác thực không chính xác. Vui lòng nhập lại!";
                    lbError.ForeColor = Color.Red;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Hide();
            FmForget fmForget = new FmForget();
            fmForget.ShowDialog();
            Close();
        }
        Random random = new Random();
        int otp_new;
        private void lLabAgain_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            otp_new = random.Next(100000, 1000000);
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("22520769@gm.uit.edu.vn");
                mail.To.Add(this.mail);
                mail.Subject = "Mã xác thực Emai";
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
