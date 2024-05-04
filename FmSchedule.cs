using Google.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NT106
{
    public partial class FmSchedule : Form
    {
        /*Danh sách button*/
        #region Peoperties


        private int appTime;
        public int AppTime
        {
            get { return appTime; }
            set { appTime = value; }
        }

        private List<List<Button>> matrix;

        public List<List<Button>> buttonList
        {
            get { return matrix; }
            set { matrix = value; }
        }

        /*Dùng để lưu Item - các tác vụ*/
        private PlanData planData;

        public PlanData PlanData
        {
            get { return planData; }
            set { planData = value; }
        }

        private string filePath = "data.xml";


        private List<string> dateOfWeek = new List<string>() { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        #endregion

        public FmSchedule()

        {
            InitializeComponent();
            tmNotify.Start();
            AppTime = 0;

            LoadMatrix();
            try
            {
                PlanData = (PlanData)DeserializeFromXML(filePath);
            }
            catch
            {
                SetDefaultJob();
            }
        }

        /*Dữ liệu mẫu*/
        void SetDefaultJob()
        {
            PlanData = new PlanData();
            PlanData.PlanItems =
            [
                new PlanItem()
                {
                    Date = System.DateTime.Now,
                    FromTime = new Point(4, 0),
                    ToTime = new Point(5, 0),
                    Job = "Demo",
                    Status = PlanItem.ListStatus[(int)PlanItem.EPlanItem.COMING]
                 },
                new PlanItem()
                {
                    Date = System.DateTime.Now.AddDays(2),
                    FromTime = new Point(4, 0),
                    ToTime = new Point(5, 0),
                    Job = "Demo",
                    Status = PlanItem.ListStatus[(int)PlanItem.EPlanItem.COMING]
                },
                new PlanItem()
                {
                    Date = System.DateTime.Now.AddDays(-1),
                    FromTime = new Point(4, 0),
                    ToTime = new Point(5, 0),
                    Job = "Demo",
                    Status = PlanItem.ListStatus[(int)PlanItem.EPlanItem.DONE]
                },
                new PlanItem()
                {
                    Date = System.DateTime.Now,
                    FromTime = new Point(4, 0),
                    ToTime = new Point(5, 0),
                    Job = "Demo",
                    Status = PlanItem.ListStatus[(int)PlanItem.EPlanItem.MISSED]
                },
            ];
        }

        void LoadMatrix()
        {
            buttonList = new List<List<Button>>();

            Button oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, 0) };
            for (int i = 0; i < Cons.Week_Of_Year; i++)
            {
                buttonList.Add(new List<Button>());
                for (int j = 0; j < Cons.Day_of_Week; j++)
                {
                    Button button = new Button() { Width = Cons.Date_btn_Width, Height = Cons.Date_btn_Height };
                    button.Location = new Point(oldBtn.Location.X + oldBtn.Width + Cons.margin, oldBtn.Location.Y);
                    button.Click += Button_Click;

                    /*Có được danh sách button*/
                    pnMatrix.Controls.Add(button);

                    buttonList[i].Add(button);
                    oldBtn = button;
                }
                oldBtn = new Button() { Width = 0, Height = 0, Location = new Point(-Cons.margin, oldBtn.Location.Y + Cons.Date_btn_Height) };
            }
            SetDefaultDate();
        }

        private void Button_Click(object? sender, EventArgs e)
        {
            if (string.IsNullOrEmpty((sender as Button).Text))
            {
                return;
            }


            FmDailyPlan daily = new FmDailyPlan(new System.DateTime(dateTimePicker1.Value.Year, dateTimePicker1.Value.Month, Convert.ToInt32((sender as Button).Text)), planData);

            daily.ShowDialog();
        }

        int DayOfMonth(System.DateTime date)
        {
            switch (date.Month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    return 31;

                case 2:
                    if ((date.Year % 4 == 0 && date.Year % 100 != 0) || date.Year % 400 == 0)
                    {
                        return 29;
                    }
                    else
                    {
                        return 28;
                    }
                default:
                    return 30;
            }
        }

        /*Hàm dùng để tạo ma trận lịch*/
        void AddNumberIntoMatrixByDate(System.DateTime date)
        {
            //Trước khi tạo mới thì phải xóa
            ClearMatrix();
            //Từ 1 ngày trong tháng xđ đc thứ mấy trong tuần
            System.DateTime useDate = new System.DateTime(date.Year, date.Month, 1);

            int line = 0;

            for (int i = 1; i <= DayOfMonth(date); i++)
            {
                int column = dateOfWeek.IndexOf(useDate.DayOfWeek.ToString());

                Button btn = new Button();
                btn = buttonList[line][column];
                btn.Text = i.ToString();
                btn.ForeColor = System.Drawing.Color.Black;
                if (isEqualDate(useDate, System.DateTime.Now))
                {
                    btn.BackColor = System.Drawing.Color.DarkSeaGreen;
                }

                if (isEqualDate(useDate, date))
                {
                    btn.BackColor = System.Drawing.Color.LightGreen;
                }

                //Cuối tuần thì xuống dòng
                if (column >= 6)
                {
                    line++;
                }
                useDate = useDate.AddDays(1);
            }
        }

        bool isEqualDate(System.DateTime date1, System.DateTime date2)
        {
            return date1.Year == date2.Year && date1.Month == date2.Month && date1.Day == date2.Day;
        }

        /*Dùng để mỗi khi vào thì giá trị của dateTimePicker1 luôn đúng vs thời điểm vào*/
        void SetDefaultDate()
        {
            dateTimePicker1.Value = System.DateTime.Now;
        }

        /*Hàm dùng để xóa các giá trị cũ trước khi load lại lịch*/
        void ClearMatrix()
        {
            for (int i = 0; i < buttonList.Count; i++)
            {
                for (int j = 0; j < buttonList[i].Count; j++)
                {
                    buttonList[i][j].Text = "";
                    buttonList[i][j].BackColor = System.Drawing.Color.White;
                }
            }
        }

        /*Sự kiện khi đồi giá trị của dateTimePicker1 thì sẽ gọi hàm load lại ma trận ngày tháng*/
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            AddNumberIntoMatrixByDate((sender as DateTimePicker).Value);
        }

        private void picLeft_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(-1);
        }

        private void picRight_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = dateTimePicker1.Value.AddMonths(1);
        }

        private void picToday_Click(object sender, EventArgs e)
        {
            SetDefaultDate();
        }


        /*:Lưu  xuống file XML và load lên*/
        //Hàm sẽ chạy khi chương trình đóng lại
        private void SerializeToXML(object data, string filePath)
        {
            //Dùng Create vì khi dùng OpenorCreate sẽ bị chồng kết quả nếu gt trước nhiều hơn giá trị sau. Khá loạn ==> chỉ tạo mới
            FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);
            XmlSerializer sr = new XmlSerializer(typeof(PlanData));

            sr.Serialize(fs, data);

            fs.Close();
        }
        //Hàm chạy khi chương trình vừa mở lên
        private object DeserializeFromXML(string filePath)
        {
            FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read);
            try
            {

                XmlSerializer sr = new XmlSerializer(typeof(PlanData));

                object result = sr.Deserialize(fs);
                fs.Close();

                return result;
            }
            catch (Exception ex)
            {
                fs.Close();
                throw new NotImplementedException();
            }

        }

        private void FmSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            SerializeToXML(PlanData, filePath);
        }

        private void tmNotify_Tick(object sender, EventArgs e)
        {
           // if (!cBNotify.Checked) { return; }

            AppTime++;

            if (AppTime < Cons.time) { return; }
            if (PlanData == null || PlanData.PlanItems == null) { return; }

            List<PlanItem> todayJob = PlanData.PlanItems.Where(p => p.Date.Year == System.DateTime.Now.Year && p.Date.Month == System.DateTime.Now.Date.Month && p.Date.Day == System.DateTime.Now.Date.Day).ToList();
            Notify.ShowBalloonTip(Cons.timeout, "Lịch công việc", string.Format("Bạn có {0} việc cần làm hôm nay. Mau vào học thôi nào!", todayJob.Count), ToolTipIcon.Info);

            //Phải set icon cho nó
            AppTime = 0;
        }

       /* private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nmNotify.Enabled = cBNotify.Checked;
        }

        private void nmNotify_ValueChanged(object sender, EventArgs e)
        {
            Cons.time = (int)nmNotify.Value;
        }*/
    }
}
