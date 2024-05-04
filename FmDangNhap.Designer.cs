namespace NT106.O22
{
    partial class FmDangNhap
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
            btnSignIn = new Button();
            txtPaswd = new TextBox();
            label3 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lLabForget = new LinkLabel();
            lLabSignUp = new LinkLabel();
            lbError = new Label();
            SuspendLayout();
            // 
            // btnSignIn
            // 
            btnSignIn.Anchor = AnchorStyles.None;
            btnSignIn.BackColor = Color.FromArgb(0, 192, 0);
            btnSignIn.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(286, 371);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(219, 49);
            btnSignIn.TabIndex = 23;
            btnSignIn.Text = "Đăng nhập";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // txtPaswd
            // 
            txtPaswd.Anchor = AnchorStyles.None;
            txtPaswd.Font = new Font("Segoe UI", 12F);
            txtPaswd.Location = new Point(42, 206);
            txtPaswd.Name = "txtPaswd";
            txtPaswd.PasswordChar = '●';
            txtPaswd.Size = new Size(717, 34);
            txtPaswd.TabIndex = 22;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(42, 168);
            label3.Name = "label3";
            label3.Size = new Size(126, 35);
            label3.TabIndex = 21;
            label3.Text = "Mật khẩu";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(42, 113);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(717, 34);
            txtEmail.TabIndex = 20;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(42, 75);
            label2.Name = "label2";
            label2.Size = new Size(78, 35);
            label2.TabIndex = 19;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 25F, FontStyle.Bold);
            label1.ForeColor = Color.LawnGreen;
            label1.Location = new Point(237, 9);
            label1.Name = "label1";
            label1.Size = new Size(282, 57);
            label1.TabIndex = 18;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // lLabForget
            // 
            lLabForget.ActiveLinkColor = Color.Green;
            lLabForget.Anchor = AnchorStyles.None;
            lLabForget.AutoSize = true;
            lLabForget.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lLabForget.LinkColor = Color.Green;
            lLabForget.Location = new Point(42, 307);
            lLabForget.Name = "lLabForget";
            lLabForget.Size = new Size(166, 28);
            lLabForget.TabIndex = 24;
            lLabForget.TabStop = true;
            lLabForget.Text = "Quên mật khẩu?";
            lLabForget.VisitedLinkColor = Color.Green;
            lLabForget.LinkClicked += lLabForget_LinkClicked;
            // 
            // lLabSignUp
            // 
            lLabSignUp.ActiveLinkColor = Color.Green;
            lLabSignUp.Anchor = AnchorStyles.None;
            lLabSignUp.AutoSize = true;
            lLabSignUp.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lLabSignUp.LinkColor = Color.Green;
            lLabSignUp.Location = new Point(669, 307);
            lLabSignUp.Name = "lLabSignUp";
            lLabSignUp.Size = new Size(90, 28);
            lLabSignUp.TabIndex = 25;
            lLabSignUp.TabStop = true;
            lLabSignUp.Text = "Đăng ký";
            lLabSignUp.VisitedLinkColor = Color.Green;
            lLabSignUp.LinkClicked += lLabSignUp_LinkClicked;
            // 
            // lbError
            // 
            lbError.AutoSize = true;
            lbError.Location = new Point(42, 266);
            lbError.Name = "lbError";
            lbError.Size = new Size(0, 20);
            lbError.TabIndex = 27;
            // 
            // FmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbError);
            Controls.Add(lLabSignUp);
            Controls.Add(lLabForget);
            Controls.Add(btnSignIn);
            Controls.Add(txtPaswd);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmDangNhap";
            FormClosed += FmDangNhap_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSignIn;
        private TextBox txtPaswd;
        private Label label3;
        private TextBox txtEmail;
        private Label label2;
        private Label label1;
        private LinkLabel lLabForget;
        private LinkLabel lLabSignUp;
        private Label lbError;
    }
}