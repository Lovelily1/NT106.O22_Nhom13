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
    public partial class FmChinhSua : Form
    {
        public FmChinhSua()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FmInfo fmInfo = new FmInfo(txtName.Text, txtBirth.Text);
            this.Hide();
            fmInfo.ShowDialog();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FmInfo fmInfo = new FmInfo();
            fmInfo.ShowDialog();
            this.Close();
        }
    }
}
