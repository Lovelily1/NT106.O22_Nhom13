namespace NT106.O22
{
    partial class FmDangKy
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
            btnSignUp = new Button();
            txtPasswd = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtAgain = new TextBox();
            label4 = new Label();
            picbBack = new PictureBox();
            lbMailErr = new Label();
            lbPassErr = new Label();
            txtOTP = new TextBox();
            btnOTP = new Button();
            label5 = new Label();
            Again = new LinkLabel();
            lbError = new Label();
            lbPasswd = new Label();
            ((System.ComponentModel.ISupportInitialize)picbBack).BeginInit();
            SuspendLayout();
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = Color.FromArgb(0, 192, 0);
            btnSignUp.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSignUp.ForeColor = Color.White;
            btnSignUp.Location = new Point(262, 568);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(219, 49);
            btnSignUp.TabIndex = 15;
            btnSignUp.Text = "Đăng ký";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignIn_Click;
            // 
            // txtPasswd
            // 
            txtPasswd.Font = new Font("Segoe UI", 12F);
            txtPasswd.Location = new Point(44, 229);
            txtPasswd.Name = "txtPasswd";
            txtPasswd.PasswordChar = '●';
            txtPasswd.Size = new Size(717, 34);
            txtPasswd.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(44, 191);
            label3.Name = "label3";
            label3.Size = new Size(126, 35);
            label3.TabIndex = 11;
            label3.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(44, 121);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(717, 34);
            txtEmail.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(44, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 35);
            label2.TabIndex = 9;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(277, 9);
            label1.Name = "label1";
            label1.Size = new Size(213, 57);
            label1.TabIndex = 8;
            label1.Text = "ĐĂNG KÝ";
            // 
            // txtAgain
            // 
            txtAgain.Font = new Font("Segoe UI", 12F);
            txtAgain.Location = new Point(44, 342);
            txtAgain.Name = "txtAgain";
            txtAgain.PasswordChar = '●';
            txtAgain.Size = new Size(717, 34);
            txtAgain.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(44, 304);
            label4.Name = "label4";
            label4.Size = new Size(230, 35);
            label4.TabIndex = 16;
            label4.Text = "Nhập lại mật khẩu";
            // 
            // picbBack
            // 
            picbBack.Image = Properties.Resources.arrow_13552693;
            picbBack.Location = new Point(12, 15);
            picbBack.Name = "picbBack";
            picbBack.Size = new Size(49, 39);
            picbBack.SizeMode = PictureBoxSizeMode.Zoom;
            picbBack.TabIndex = 18;
            picbBack.TabStop = false;
            picbBack.Click += picbBack_Click;
            // 
            // lbMailErr
            // 
            lbMailErr.AutoSize = true;
            lbMailErr.Location = new Point(51, 158);
            lbMailErr.Name = "lbMailErr";
            lbMailErr.Size = new Size(0, 20);
            lbMailErr.TabIndex = 19;
            // 
            // lbPassErr
            // 
            lbPassErr.AutoSize = true;
            lbPassErr.Location = new Point(51, 383);
            lbPassErr.Name = "lbPassErr";
            lbPassErr.Size = new Size(0, 20);
            lbPassErr.TabIndex = 20;
            // 
            // txtOTP
            // 
            txtOTP.Font = new Font("Segoe UI", 12F);
            txtOTP.Location = new Point(44, 441);
            txtOTP.Name = "txtOTP";
            txtOTP.PasswordChar = '●';
            txtOTP.Size = new Size(514, 34);
            txtOTP.TabIndex = 21;
            // 
            // btnOTP
            // 
            btnOTP.BackColor = Color.FromArgb(0, 192, 0);
            btnOTP.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOTP.ForeColor = Color.White;
            btnOTP.Location = new Point(581, 436);
            btnOTP.Name = "btnOTP";
            btnOTP.Size = new Size(180, 45);
            btnOTP.TabIndex = 22;
            btnOTP.Text = "Xác nhận Email";
            btnOTP.UseVisualStyleBackColor = false;
            btnOTP.Click += button1_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.Green;
            label5.Location = new Point(44, 403);
            label5.Name = "label5";
            label5.Size = new Size(63, 35);
            label5.TabIndex = 23;
            label5.Text = "OTP";
            // 
            // Again
            // 
            Again.ActiveLinkColor = Color.FromArgb(0, 192, 0);
            Again.AutoSize = true;
            Again.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            Again.LinkColor = Color.Green;
            Again.Location = new Point(475, 490);
            Again.Name = "Again";
            Again.Size = new Size(69, 25);
            Again.TabIndex = 24;
            Again.TabStop = true;
            Again.Text = "Gửi lại";
            Again.VisitedLinkColor = Color.FromArgb(128, 255, 128);
            Again.LinkClicked += linkLabel1_LinkClicked;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Font = new Font("Segoe UI", 12F);
            lbError.Location = new Point(51, 478);
            lbError.Name = "lbError";
            lbError.Size = new Size(0, 28);
            lbError.TabIndex = 25;
            // 
            // lbPasswd
            // 
            lbPasswd.AutoSize = true;
            lbPasswd.Location = new Point(51, 266);
            lbPasswd.Name = "lbPasswd";
            lbPasswd.Size = new Size(0, 20);
            lbPasswd.TabIndex = 26;
            // 
            // FmDangKy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 670);
            Controls.Add(lbPasswd);
            Controls.Add(lbError);
            Controls.Add(Again);
            Controls.Add(label5);
            Controls.Add(btnOTP);
            Controls.Add(txtOTP);
            Controls.Add(lbPassErr);
            Controls.Add(lbMailErr);
            Controls.Add(picbBack);
            Controls.Add(txtAgain);
            Controls.Add(label4);
            Controls.Add(btnSignUp);
            Controls.Add(txtPasswd);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmDangKy";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmDangKy";
            ((System.ComponentModel.ISupportInitialize)picbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignUp;
        private TextBox txtPasswd;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private TextBox txtAgain;
        private Label label4;
        private PictureBox picbBack;
        private Label lbMailErr;
        private Label lbPassErr;
        private TextBox txtOTP;
        private Button btnOTP;
        private Label label5;
        private LinkLabel Again;
        private Label lbError;
        private Label lbPasswd;
    }
}