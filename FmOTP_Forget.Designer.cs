namespace NT106.O22
{
    partial class FmOTP_Forget
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
            btnAccept = new Button();
            txtOTP = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lLabAgain = new LinkLabel();
            picBack = new PictureBox();
            lbError = new Label();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            SuspendLayout();
            // 
            // btnAccept
            // 
            btnAccept.Anchor = AnchorStyles.None;
            btnAccept.BackColor = Color.FromArgb(0, 192, 0);
            btnAccept.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnAccept.ForeColor = Color.White;
            btnAccept.Location = new Point(259, 213);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(241, 52);
            btnAccept.TabIndex = 27;
            btnAccept.Text = "Xác nhận";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // txtOTP
            // 
            txtOTP.Anchor = AnchorStyles.None;
            txtOTP.Font = new Font("Segoe UI", 12F);
            txtOTP.Location = new Point(42, 118);
            txtOTP.Name = "txtOTP";
            txtOTP.Size = new Size(717, 34);
            txtOTP.TabIndex = 26;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(42, 67);
            label2.Name = "label2";
            label2.Size = new Size(134, 35);
            label2.TabIndex = 25;
            label2.Text = "Nhập OTP";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(233, 9);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 24;
            label1.Text = "QUÊN MẬT KHẨU";
            // 
            // lLabAgain
            // 
            lLabAgain.ActiveLinkColor = Color.Green;
            lLabAgain.Anchor = AnchorStyles.None;
            lLabAgain.AutoSize = true;
            lLabAgain.Font = new Font("Segoe UI", 12F);
            lLabAgain.LinkColor = Color.Green;
            lLabAgain.Location = new Point(673, 166);
            lLabAgain.Name = "lLabAgain";
            lLabAgain.Size = new Size(68, 28);
            lLabAgain.TabIndex = 28;
            lLabAgain.TabStop = true;
            lLabAgain.Text = "Gửi lại";
            lLabAgain.VisitedLinkColor = Color.Green;
            lLabAgain.LinkClicked += lLabAgain_LinkClicked;
            // 
            // picBack
            // 
            picBack.Image = Properties.Resources.arrow_13552693;
            picBack.Location = new Point(12, 12);
            picBack.Name = "picBack";
            picBack.Size = new Size(49, 39);
            picBack.SizeMode = PictureBoxSizeMode.Zoom;
            picBack.TabIndex = 34;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Font = new Font("Segoe UI", 11F);
            lbError.Location = new Point(42, 169);
            lbError.Name = "lbError";
            lbError.Size = new Size(0, 25);
            lbError.TabIndex = 35;
            // 
            // FmOTP_Forget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 295);
            Controls.Add(lbError);
            Controls.Add(picBack);
            Controls.Add(lLabAgain);
            Controls.Add(btnAccept);
            Controls.Add(txtOTP);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmOTP_Forget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmOTP";
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAccept;
        private TextBox txtOTP;
        private Label label2;
        private Label label1;
        private LinkLabel lLabAgain;
        private PictureBox picBack;
        private Label lbError;
    }
}