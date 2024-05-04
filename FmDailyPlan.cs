#pragma warning disable IDE0005 // Using directive is unnecessary.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
#pragma warning restore IDE0005 // Using directive is unnecessary.

namespace NT106
{
    public partial class FmDailyPlan : Form
    {

        private DateTime date;
        public System.DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        private PlanData data;
        public PlanData Data
        {
            get { return data; }
            set { data = value; }
        }
        FlowLayoutPanel panel = new FlowLayoutPanel();
        public FmDailyPlan(System.DateTime date, PlanData job)
        {
            InitializeComponent();
            this.Date = date;
            this.Data = job;


            panel.Width = pnTask.Width;
            panel.Height = pnTask.Height;
            pnTask.Controls.Add(panel);

            dateTimePicker1.Value = Date;
        }


        void ShowJobByDate(System.DateTime date)
        {
            panel.Controls.Clear();
            if (Data != null && Data.PlanItems != null)
            {
                List<PlanItem> todayJob = getJobByDay(date);
                for (int i = 0; i < todayJob.Count; i++)
                {
                    AddJob(todayJob[i]);
                    
                }
            }
        }

        void AddJob(PlanItem job)
        {
            Job task = new Job(job);
            task.Edited += task_Edited;
            task.Deleted += task_Deleted;

            panel.Controls.Add(task);
        }

        void task_Deleted(object sender, EventArgs e)
        {
            Job uc = sender as Job;
            PlanItem job = uc.Plan;

            panel.Controls.Remove(uc);
            Data.PlanItems.Remove(job);
        }

        private void task_Edited(object? sender, EventArgs e)
        {
            //Không cần làm gì cả
        }

        List<PlanItem> getJobByDay(System.DateTime date)
        {
            return Data.PlanItems.Where(p => p.Date.Year == date.Date.Year && p.Date.Month == date.Date.Month && p.Date.Day == date.Date.Day).ToList();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            ShowJobByDate((sender as DateTimePicker).Value);
        }

        private void picRight_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(1);
        }

        private void picLeft_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddDays(-1);
        }

        private void ToolAddJob_Click(object sender, EventArgs e)
        {
            PlanItem item = new PlanItem() { Date = dateTimePicker1.Value};
            Data.PlanItems.Add(item);
            AddJob(item);
        }

        private void ToolToday_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
