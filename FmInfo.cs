using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106.O22
{
    public partial class FmInfo : Form
    {
        public FmInfo()
        {
            InitializeComponent();
        }

        private string username, birthday, email;
        public FmInfo(string name, string birth)
        {
            InitializeComponent();
            this.username = name;
            this.birthday = birth;
        }

        public FmInfo(string mail)
        {
            InitializeComponent();
            this.email = mail;
        }


        private void btnChange_Click(object sender, EventArgs e)
        {
            Hide();
            FmChinhSua fmChinhSua = new FmChinhSua();
            fmChinhSua.ShowDialog();
            Close();
            
        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Hide();
            FmTrangChu fmTrangChu = new FmTrangChu();
            fmTrangChu.ShowDialog();
            this.Close();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn chắc chắn muốn đăng xuất chương trình?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Hide();
                FmDangNhap fmDangNhap = new FmDangNhap();
                fmDangNhap.ShowDialog();
                this.Close();
            }
        }

        private void FmInfo_Load(object sender, EventArgs e)
        {
            txtName.Text = username;
            txtBirth.Text = birthday;
            txtEmail.Text = email;
        }
    }
}
