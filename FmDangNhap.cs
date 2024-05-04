using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Authentication.Classes;
using Google.Cloud.Firestore;
namespace NT106.O22
{
    public partial class FmDangNhap : Form
    {



        public FmDangNhap()
        {
            InitializeComponent();
        }

        private void lLabSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FmDangKy fmDangKy = new FmDangKy();
            fmDangKy.ShowDialog();
            Close();
        }

        private void lLabForget_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            FmForget fmForget = new FmForget();
            fmForget.ShowDialog();
            Close();
        }

        private void FmDangNhap_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string passwd = txtPaswd.Text;

            var database = FirestoreHelper.database;
            DocumentReference doc = database.Collection("UserData").Document(email);
            UserData data = doc.GetSnapshotAsync().Result.ConvertTo<UserData>();

            if (data != null)
            {
                if (passwd == Security.Decrypt(data.Password))
                {
                    
                    Hide();
                    FmTrangChu fmTrangChu = new FmTrangChu();
                    fmTrangChu.ShowDialog();
                    Close();
                }
                else
                {
                    lbError.Text = "Email/Mật khẩu sai. Vui lòng nhập lại!";
                    lbError.ForeColor = Color.Red;
                }
            }
            else
            {
                lbError.Text = "Email/Mật khẩu sai. Vui lòng nhập lại!";
                lbError.ForeColor = Color.Red;
            }


        }

    }
}
