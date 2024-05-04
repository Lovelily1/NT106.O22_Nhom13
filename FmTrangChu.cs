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
    public partial class FmTrangChu : Form
    {
        public FmTrangChu()
        {
            InitializeComponent();
        }

        private Form currentFormChild;
        private void OpenChildForm(Form child)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = child;
            child.TopLevel = false;
            child.FormBorderStyle = FormBorderStyle.None;
            child.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(child);
            panel_Body.Tag = child;
            child.BringToFront();
            child.Show();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Hide();
            FmInfo fmInfo = new FmInfo();
            fmInfo.ShowDialog();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }



        private void btnLibrary_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FmLibrary());
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FmGroup());
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FmReview());
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FmSchedule());
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FmTrangChu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
