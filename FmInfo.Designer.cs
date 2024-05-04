namespace NT106.O22
{
    partial class FmInfo
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnChange = new Button();
            picBack = new PictureBox();
            txtName = new TextBox();
            txtBirth = new TextBox();
            txtEmail = new TextBox();
            btnOut = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picBack).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.None;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.预览图_千图网_编号286065751;
            pictureBox1.Location = new Point(281, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(95, 93);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(27, 136);
            label1.Name = "label1";
            label1.Size = new Size(41, 35);
            label1.TabIndex = 1;
            label1.Text = "ID";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(27, 223);
            label2.Name = "label2";
            label2.Size = new Size(131, 35);
            label2.TabIndex = 2;
            label2.Text = "Ngày sinh";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(27, 309);
            label3.Name = "label3";
            label3.Size = new Size(78, 35);
            label3.TabIndex = 3;
            label3.Text = "Email";
            // 
            // btnChange
            // 
            btnChange.Anchor = AnchorStyles.None;
            btnChange.BackColor = Color.FromArgb(0, 192, 0);
            btnChange.FlatAppearance.BorderSize = 0;
            btnChange.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnChange.ForeColor = Color.White;
            btnChange.Location = new Point(117, 429);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(148, 44);
            btnChange.TabIndex = 4;
            btnChange.Text = "Thay đổi";
            btnChange.UseVisualStyleBackColor = false;
            btnChange.Click += btnChange_Click;
            // 
            // picBack
            // 
            picBack.BackColor = Color.Transparent;
            picBack.Image = Properties.Resources.arrow_13552693;
            picBack.Location = new Point(12, 22);
            picBack.Name = "picBack";
            picBack.Size = new Size(49, 39);
            picBack.SizeMode = PictureBoxSizeMode.Zoom;
            picBack.TabIndex = 34;
            picBack.TabStop = false;
            picBack.Click += picBack_Click;
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(27, 174);
            txtName.Name = "txtName";
            txtName.ReadOnly = true;
            txtName.Size = new Size(641, 34);
            txtName.TabIndex = 35;
            // 
            // txtBirth
            // 
            txtBirth.Font = new Font("Segoe UI", 12F);
            txtBirth.Location = new Point(27, 261);
            txtBirth.Name = "txtBirth";
            txtBirth.ReadOnly = true;
            txtBirth.Size = new Size(641, 34);
            txtBirth.TabIndex = 36;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 12F);
            txtEmail.Location = new Point(27, 347);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(641, 34);
            txtEmail.TabIndex = 37;
            // 
            // btnOut
            // 
            btnOut.Anchor = AnchorStyles.None;
            btnOut.BackColor = Color.FromArgb(0, 192, 0);
            btnOut.FlatAppearance.BorderSize = 0;
            btnOut.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnOut.ForeColor = Color.White;
            btnOut.Location = new Point(386, 429);
            btnOut.Name = "btnOut";
            btnOut.Size = new Size(148, 44);
            btnOut.TabIndex = 38;
            btnOut.Text = "Đăng xuất";
            btnOut.UseVisualStyleBackColor = false;
            btnOut.Click += btnOut_Click;
            // 
            // FmInfo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BackgroundImage = Properties.Resources.Background_Homepage_App_NT106__2_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 526);
            Controls.Add(btnOut);
            Controls.Add(txtEmail);
            Controls.Add(txtBirth);
            Controls.Add(txtName);
            Controls.Add(picBack);
            Controls.Add(btnChange);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            Name = "FmInfo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thông tin cá nhân";
            Load += FmInfo_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)picBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnChange;
        private PictureBox picBack;
        private TextBox txtName;
        private TextBox txtBirth;
        private TextBox txtEmail;
        private Button btnOut;
    }
}