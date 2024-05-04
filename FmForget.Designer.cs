namespace NT106.O22
{
    partial class FmForget
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
            btnSend = new Button();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            picBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            SuspendLayout();
            // 
            // btnSend
            // 
            btnSend.Anchor = AnchorStyles.None;
            btnSend.BackColor = Color.FromArgb(0, 192, 0);
            btnSend.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSend.ForeColor = Color.White;
            btnSend.Location = new Point(259, 213);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(241, 52);
            btnSend.TabIndex = 32;
            btnSend.Text = "Gửi OTP";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(39, 135);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(717, 34);
            txtEmail.TabIndex = 31;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(39, 84);
            label2.Name = "label2";
            label2.Size = new Size(78, 35);
            label2.TabIndex = 30;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(230, 26);
            label1.Name = "label1";
            label1.Size = new Size(308, 46);
            label1.TabIndex = 29;
            label1.Text = "QUÊN MẬT KHẨU";
            // 
            // picBack
            // 
            picBack.Image = Properties.Resources.arrow_13552693;
            picBack.Location = new Point(12, 12);
            picBack.Name = "picBack";
            picBack.Size = new Size(49, 39);
            picBack.SizeMode = PictureBoxSizeMode.Zoom;
            picBack.TabIndex = 33;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // FmForget
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 305);
            Controls.Add(picBack);
            Controls.Add(btnSend);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmForget";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmForget";
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSend;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private PictureBox picBack;
    }
}