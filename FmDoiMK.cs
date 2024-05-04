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
    public partial class FmDoiMK : Form
    {
        public FmDoiMK()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            Hide();
            FmDangNhap fmDangNhap = new FmDangNhap();
            fmDangNhap.ShowDialog();
            Close();

        }

        private void picBack_Click(object sender, EventArgs e)
        {
            Hide();
            FmForget fmForget = new FmForget();
            fmForget.ShowDialog();
            Close();
        }
    }
}
