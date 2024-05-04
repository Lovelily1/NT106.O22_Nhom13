using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NT106
{
    public partial class Job : UserControl
    {
        private PlanItem plan;
        public PlanItem Plan
        {
            get { return plan; }
            set { plan = value; }
        }


        private event EventHandler edited;
        public event EventHandler Edited
        {
            add { edited += value; }
            remove { edited -= value; }
        }

        private event EventHandler deleted;
        public event EventHandler Deleted
        {
            add { deleted += value; }
            remove { deleted -= value; }
        }

        public Job(PlanItem job)
        {
            InitializeComponent();

            cbbStatus.DataSource = PlanItem.ListStatus;

            this.Plan = job;
            ShowInfo();
        }


        //Hiển thị thông tin
        void ShowInfo()
        {
            txtTask.Text = Plan.Job;

            FrHour.Value = Plan.FromTime.X;
            FrMinute.Value = Plan.FromTime.Y;

            ToHour.Value = Plan.ToTime.X;
            ToMinute.Value = Plan.ToTime.Y;

            cbbStatus.SelectedIndex = PlanItem.ListStatus.IndexOf(Plan.Status);
            checkBox1.Checked = PlanItem.ListStatus.IndexOf(Plan.Status) == (int)PlanItem.EPlanItem.DONE ? true : false;
        }

        //Truyền dữ liệu với Event
        private void btnDel_Click(object sender, EventArgs e)
        {
            if (deleted != null)
            {
                deleted(this, new EventArgs());
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Plan.Job = txtTask.Text;
            Plan.FromTime = new Point((int)FrHour.Value, (int)FrMinute.Value);
            Plan.ToTime = new Point((int)ToHour.Value, (int)ToMinute.Value);
            Plan.Status = PlanItem.ListStatus[cbbStatus.SelectedIndex];
            if (edited != null)
            {
                edited(this, new EventArgs());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbbStatus.SelectedIndex = checkBox1.Checked? (int)PlanItem.EPlanItem.DONE: (int)PlanItem.EPlanItem.DOING;
        }
    }
}
