using Authentication.Classes;
using Google.Cloud.Firestore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
namespace NT106.O22
{
    public partial class FmDangKy : Form
    {
        public FmDangKy()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {

            var database = FirestoreHelper.database;
            if (CheckIfUserAlreadyExist())
            {
                lbPassErr.Text = "";
                lbMailErr.Text = "Email đã tồn tại. Vui lòng nhập email khác!";
                lbMailErr.ForeColor = Color.Red;
                return;
            }
            if (txtPasswd.Text != null || txtAgain.Text != null)
            {
                if (txtPasswd.Text != txtAgain.Text)
                {
                    lbMailErr.Text = "";
                    lbPassErr.Text = "Nhập sai mật khẩu. Vui lòng nhập lại!";
                    lbPassErr.ForeColor = Color.Red;
                    return;
                }
                lbError.Text = "";
                lbMailErr.Text = "";
                lbPassErr.Text = "";
                lbPasswd.Text = "Vui lòng nhập mật khẩu!";
                lbError.ForeColor = Color.Red;
            }
            if (otp.ToString().Equals(txtOTP.Text))
            {
                var data = GetWriteData();
                DocumentReference doc = database.Collection("UserData").Document(data.Email);
                doc.SetAsync(data);
                Hide();
                FmDangNhap fmDangNhap = new FmDangNhap();
                fmDangNhap.ShowDialog();
                Close();
            }
            else
            {
                lbPassErr.Text = "";
                lbMailErr.Text = "";
                lbPasswd.Text = "";
                lbError.Text = "Vui lòng nhập đúng OTP!";
                lbError.ForeColor = Color.Red;
            }
        }

        private UserData GetWriteData()
        {
            string email = txtEmail.Text.Trim();
            string passwd = Security.Encrypt(txtPasswd.Text.Trim());

            return new UserData() { Email = email, Password = passwd };
        }

        private bool CheckIfUserAlreadyExist()
        {
            string email = txtEmail.Text.Trim();
            string passwd = txtPasswd.Text;

            var database = FirestoreHelper.database;
            DocumentReference doc = database.Collection("UserData").Document(email);
            UserData data = doc.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                return true;
            }
            return false;
        }

        private void picbBack_Click(object sender, EventArgs e)
        {
            Hide();
            FmDangNhap fmDangNhap = new FmDangNhap();
            fmDangNhap.ShowDialog();
            Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            otp = random.Next(100000, 1000000);
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("22520769@gm.uit.edu.vn");
                mail.To.Add(txtEmail.Text);
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
        Random random = new Random();
        int otp;
        private void button1_Click(object sender, EventArgs e)
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
