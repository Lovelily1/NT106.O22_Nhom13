namespace NT106
{
    partial class FmDailyPlan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            pnTask = new Panel();
            panel2 = new Panel();
            picRight = new PictureBox();
            picLeft = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            menu = new MenuStrip();
            ToolAddJob = new ToolStripMenuItem();
            ToolToday = new ToolStripMenuItem();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLeft).BeginInit();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(pnTask);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(897, 657);
            panel1.TabIndex = 0;
            // 
            // pnTask
            // 
            pnTask.Anchor = AnchorStyles.None;
            pnTask.Location = new Point(-6, 115);
            pnTask.Name = "pnTask";
            pnTask.Size = new Size(900, 542);
            pnTask.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.White;
            panel2.Controls.Add(picRight);
            panel2.Controls.Add(picLeft);
            panel2.Controls.Add(dateTimePicker1);
            panel2.Location = new Point(4, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(893, 96);
            panel2.TabIndex = 0;
            // 
            // picRight
            // 
            picRight.Image = Properties.Resources.Remove_bg_ai_1714467924660;
            picRight.Location = new Point(830, 19);
            picRight.Name = "picRight";
            picRight.Size = new Size(63, 62);
            picRight.SizeMode = PictureBoxSizeMode.Zoom;
            picRight.TabIndex = 2;
            picRight.TabStop = false;
            picRight.Click += picRight_Click;
            // 
            // picLeft
            // 
            picLeft.BackColor = Color.Transparent;
            picLeft.Image = Properties.Resources.Remove_bg_ai_1714467837409;
            picLeft.Location = new Point(0, 19);
            picLeft.Name = "picLeft";
            picLeft.Size = new Size(63, 62);
            picLeft.SizeMode = PictureBoxSizeMode.Zoom;
            picLeft.TabIndex = 1;
            picLeft.TabStop = false;
            picLeft.Click += picLeft_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            dateTimePicker1.Location = new Point(268, 33);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(342, 34);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // menu
            // 
            menu.BackColor = Color.Transparent;
            menu.Font = new Font("Segoe UI", 12F);
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { ToolAddJob, ToolToday });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(932, 36);
            menu.TabIndex = 1;
            menu.Text = "menuStrip1";
            // 
            // ToolAddJob
            // 
            ToolAddJob.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ToolAddJob.ForeColor = Color.Green;
            ToolAddJob.Name = "ToolAddJob";
            ToolAddJob.Size = new Size(143, 32);
            ToolAddJob.Text = "Thêm tác vụ";
            ToolAddJob.Click += ToolAddJob_Click;
            // 
            // ToolToday
            // 
            ToolToday.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            ToolToday.ForeColor = Color.Green;
            ToolToday.Name = "ToolToday";
            ToolToday.Size = new Size(111, 32);
            ToolToday.Text = "Hôm nay";
            ToolToday.Click += ToolToday_Click;
            // 
            // FmDailyPlan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.DailyPlan;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(932, 745);
            Controls.Add(panel1);
            Controls.Add(menu);
            DoubleBuffered = true;
            MainMenuStrip = menu;
            Name = "FmDailyPlan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmDailyPlan";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLeft).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel pnTask;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private PictureBox picRight;
        private PictureBox picLeft;
        private MenuStrip menu;
        private ToolStripMenuItem ToolAddJob;
        private ToolStripMenuItem ToolToday;
    }
}