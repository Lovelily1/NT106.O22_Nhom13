using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NT106
{
    public class PlanItem
    {
        private System.DateTime date;
        public System.DateTime Date
        {
            get { return date; }
            set { date = value; }
        }


        //Công việc là gì
        private string job;
        public string Job
        {
            get { return job; }
            set { job = value; }
        }


        //Thời gian bắt đầu chỉ lưu giờ và phút
        private Point fromTime;
        public Point FromTime
        {
            get { return fromTime; }
            set { fromTime = value; }
        }


        //Thời gian kết thúc
        private Point toTime;
        public Point ToTime
        {
            get { return toTime; }
            set { toTime = value; }
        }



        private string status;
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
        public static List<string> ListStatus = new List<string> { "DONE", "DOING", "COMING", "MISSED" };
        public enum EPlanItem
        {
            DONE,
            DOING,
            COMING,
            MISSED
        }
    }
}
