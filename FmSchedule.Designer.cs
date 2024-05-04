namespace NT106
{
    partial class FmSchedule
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmSchedule));
            panel1 = new Panel();
            panel3 = new Panel();
            picToday = new PictureBox();
            dateTimePicker1 = new DateTimePicker();
            panel2 = new Panel();
            picRight = new PictureBox();
            picLeft = new PictureBox();
            pnMatrix = new Panel();
            panel4 = new Panel();
            btnSUN = new Button();
            btnSAT = new Button();
            btnFRI = new Button();
            btnTHU = new Button();
            btnWED = new Button();
            btnTUE = new Button();
            btnMON = new Button();
            Notify = new NotifyIcon(components);
            tmNotify = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picToday).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLeft).BeginInit();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(12, 33);
            panel1.Name = "panel1";
            panel1.Size = new Size(855, 529);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(206, 233, 190);
            panel3.Controls.Add(picToday);
            panel3.Controls.Add(dateTimePicker1);
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(854, 77);
            panel3.TabIndex = 1;
            // 
            // picToday
            // 
            picToday.Image = Properties.Resources.scheduled_date_and_time_icon_2048x2048_f2z3nhy3;
            picToday.Location = new Point(600, 15);
            picToday.Name = "picToday";
            picToday.Size = new Size(49, 42);
            picToday.SizeMode = PictureBoxSizeMode.Zoom;
            picToday.TabIndex = 1;
            picToday.TabStop = false;
            picToday.Click += picToday_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F);
            dateTimePicker1.Location = new Point(265, 23);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(320, 34);
            dateTimePicker1.TabIndex = 0;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(picRight);
            panel2.Controls.Add(picLeft);
            panel2.Controls.Add(pnMatrix);
            panel2.Location = new Point(0, 77);
            panel2.Name = "panel2";
            panel2.Size = new Size(855, 452);
            panel2.TabIndex = 0;
            // 
            // picRight
            // 
            picRight.Image = Properties.Resources.Remove_bg_ai_1714467924660;
            picRight.Location = new Point(799, 171);
            picRight.Name = "picRight";
            picRight.Size = new Size(56, 62);
            picRight.SizeMode = PictureBoxSizeMode.Zoom;
            picRight.TabIndex = 2;
            picRight.TabStop = false;
            picRight.Click += picRight_Click;
            // 
            // picLeft
            // 
            picLeft.Image = Properties.Resources.Remove_bg_ai_1714467837409;
            picLeft.Location = new Point(0, 171);
            picLeft.Name = "picLeft";
            picLeft.Size = new Size(56, 62);
            picLeft.SizeMode = PictureBoxSizeMode.Zoom;
            picLeft.TabIndex = 1;
            picLeft.TabStop = false;
            picLeft.Click += picLeft_Click;
            // 
            // pnMatrix
            // 
            pnMatrix.Font = new Font("Segoe UI", 12F);
            pnMatrix.Location = new Point(60, 55);
            pnMatrix.Name = "pnMatrix";
            pnMatrix.Size = new Size(737, 395);
            pnMatrix.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Controls.Add(btnSUN);
            panel4.Controls.Add(btnSAT);
            panel4.Controls.Add(btnFRI);
            panel4.Controls.Add(btnTHU);
            panel4.Controls.Add(btnWED);
            panel4.Controls.Add(btnTUE);
            panel4.Controls.Add(btnMON);
            panel4.Location = new Point(12, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(854, 49);
            panel4.TabIndex = 0;
            // 
            // btnSUN
            // 
            btnSUN.BackColor = Color.Silver;
            btnSUN.FlatAppearance.BorderSize = 0;
            btnSUN.FlatStyle = FlatStyle.Flat;
            btnSUN.Location = new Point(697, 0);
            btnSUN.Name = "btnSUN";
            btnSUN.Size = new Size(100, 49);
            btnSUN.TabIndex = 5;
            btnSUN.Text = "CHỦ NHẬT";
            btnSUN.UseVisualStyleBackColor = false;
            // 
            // btnSAT
            // 
            btnSAT.BackColor = Color.Silver;
            btnSAT.FlatAppearance.BorderSize = 0;
            btnSAT.FlatStyle = FlatStyle.Flat;
            btnSAT.Location = new Point(591, 0);
            btnSAT.Name = "btnSAT";
            btnSAT.Size = new Size(100, 49);
            btnSAT.TabIndex = 4;
            btnSAT.Text = "THỨ BẢY";
            btnSAT.UseVisualStyleBackColor = false;
            // 
            // btnFRI
            // 
            btnFRI.BackColor = Color.Silver;
            btnFRI.FlatAppearance.BorderSize = 0;
            btnFRI.FlatStyle = FlatStyle.Flat;
            btnFRI.Location = new Point(485, 0);
            btnFRI.Name = "btnFRI";
            btnFRI.Size = new Size(100, 49);
            btnFRI.TabIndex = 4;
            btnFRI.Text = "THỨ SÁU";
            btnFRI.UseVisualStyleBackColor = false;
            // 
            // btnTHU
            // 
            btnTHU.BackColor = Color.Silver;
            btnTHU.FlatAppearance.BorderSize = 0;
            btnTHU.FlatStyle = FlatStyle.Flat;
            btnTHU.Location = new Point(379, 0);
            btnTHU.Name = "btnTHU";
            btnTHU.Size = new Size(100, 49);
            btnTHU.TabIndex = 3;
            btnTHU.Text = "THỨ NĂM";
            btnTHU.UseVisualStyleBackColor = false;
            // 
            // btnWED
            // 
            btnWED.BackColor = Color.Silver;
            btnWED.FlatAppearance.BorderSize = 0;
            btnWED.FlatStyle = FlatStyle.Flat;
            btnWED.Location = new Point(273, 0);
            btnWED.Name = "btnWED";
            btnWED.Size = new Size(100, 49);
            btnWED.TabIndex = 2;
            btnWED.Text = "THỨ TƯ";
            btnWED.UseVisualStyleBackColor = false;
            // 
            // btnTUE
            // 
            btnTUE.BackColor = Color.Silver;
            btnTUE.FlatAppearance.BorderSize = 0;
            btnTUE.FlatStyle = FlatStyle.Flat;
            btnTUE.Location = new Point(167, 0);
            btnTUE.Name = "btnTUE";
            btnTUE.Size = new Size(100, 49);
            btnTUE.TabIndex = 1;
            btnTUE.Text = "THỨ BA";
            btnTUE.UseVisualStyleBackColor = false;
            // 
            // btnMON
            // 
            btnMON.BackColor = Color.Silver;
            btnMON.FlatAppearance.BorderColor = Color.Silver;
            btnMON.FlatAppearance.BorderSize = 0;
            btnMON.FlatStyle = FlatStyle.Flat;
            btnMON.Location = new Point(60, 0);
            btnMON.Name = "btnMON";
            btnMON.Size = new Size(101, 49);
            btnMON.TabIndex = 0;
            btnMON.Text = "THỨ HAI";
            btnMON.UseVisualStyleBackColor = false;
            // 
            // Notify
            // 
            Notify.BalloonTipIcon = ToolTipIcon.Info;
            Notify.Icon = (Icon)resources.GetObject("Notify.Icon");
            Notify.Text = "Lập lịch";
            Notify.Visible = true;
            // 
            // tmNotify
            // 
            tmNotify.Enabled = true;
            tmNotify.Interval = 60000;
            tmNotify.Tick += tmNotify_Tick;
            // 
            // FmSchedule
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_Homepage_App_NT106__3_1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(879, 587);
            Controls.Add(panel4);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "FmSchedule";
            Text = "FmSchedule";
            FormClosing += FmSchedule_FormClosing;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picToday).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picRight).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLeft).EndInit();
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private DateTimePicker dateTimePicker1;
        private Panel panel2;
        private Panel pnMatrix;
        private Panel panel4;
        private Button btnMON;
        private Button btnTHU;
        private Button btnWED;
        private Button btnTUE;
        private Button btnSAT;
        private Button btnFRI;
        private Button btnSUN;
        private PictureBox picLeft;
        private PictureBox picRight;
        private PictureBox picToday;
        private NotifyIcon Notify;
        private System.Windows.Forms.Timer tmNotify;
    }
}