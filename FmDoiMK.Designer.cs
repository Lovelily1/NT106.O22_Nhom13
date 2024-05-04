namespace NT106.O22
{
    partial class FmDoiMK
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNewPass = new TextBox();
            txtAgainPwd = new TextBox();
            btnChange = new Button();
            picBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(241, 20);
            label1.Name = "label1";
            label1.Size = new Size(274, 46);
            label1.TabIndex = 19;
            label1.Text = "ĐỔI MẬT KHẨU";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(26, 85);
            label2.Name = "label2";
            label2.Size = new Size(179, 35);
            label2.TabIndex = 20;
            label2.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(26, 187);
            label3.Name = "label3";
            label3.Size = new Size(230, 35);
            label3.TabIndex = 21;
            label3.Text = "Nhập lại mật khẩu";
            // 
            // txtNewPass
            // 
            txtNewPass.Anchor = AnchorStyles.None;
            txtNewPass.Font = new Font("Segoe UI", 12F);
            txtNewPass.Location = new Point(26, 123);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.Size = new Size(717, 34);
            txtNewPass.TabIndex = 22;
            // 
            // txtAgainPwd
            // 
            txtAgainPwd.Anchor = AnchorStyles.None;
            txtAgainPwd.Font = new Font("Segoe UI", 12F);
            txtAgainPwd.Location = new Point(26, 225);
            txtAgainPwd.Name = "txtAgainPwd";
            txtAgainPwd.Size = new Size(717, 34);
            txtAgainPwd.TabIndex = 23;
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.None;
            btnChange.BackColor = Color.FromArgb(0, 192, 0);
            btnChange.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(241, 310);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(241, 52);
            btnChange.TabIndex = 28;
            btnChange.Text = "Đổi mật khẩu";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
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
            // FmDoiMK
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(778, 411);
            Controls.Add(picBack);
            Controls.Add(btnChange);
            Controls.Add(txtAgainPwd);
            Controls.Add(txtNewPass);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmDoiMK";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmDoiMK";
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNewPass;
        private TextBox txtAgainPwd;
        private Button btnChange;
        private PictureBox picBack;
    }
}