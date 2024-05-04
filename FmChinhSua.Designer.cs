namespace NT106.O22
{
    partial class FmChinhSua
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
            txtName = new TextBox();
            txtBirth = new TextBox();
            btnSave = new Button();
            picbBack = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picbBack).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 192, 0);
            label1.Location = new Point(110, 9);
            label1.Name = "label1";
            label1.Size = new Size(488, 50);
            label1.TabIndex = 0;
            label1.Text = "Thay đổi thông tin cá nhân";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Green;
            label2.Location = new Point(33, 96);
            label2.Name = "label2";
            label2.Size = new Size(40, 32);
            label2.TabIndex = 1;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label3.ForeColor = Color.Green;
            label3.Location = new Point(29, 194);
            label3.Name = "label3";
            label3.Size = new Size(128, 32);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh";
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI", 12F);
            txtName.Location = new Point(33, 131);
            txtName.Name = "txtName";
            txtName.Size = new Size(657, 34);
            txtName.TabIndex = 4;
            // 
            // txtBirth
            // 
            txtBirth.Font = new Font("Segoe UI", 12F);
            txtBirth.Location = new Point(33, 229);
            txtBirth.Name = "txtBirth";
            txtBirth.Size = new Size(657, 34);
            txtBirth.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.None;
            btnSave.BackColor = Color.FromArgb(0, 192, 0);
            btnSave.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(236, 309);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(219, 49);
            btnSave.TabIndex = 16;
            btnSave.Text = "Lưu thay đổi";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // picbBack
            // 
            picbBack.BackColor = Color.Transparent;
            picbBack.Image = Properties.Resources.arrow_13552693;
            picbBack.Location = new Point(12, 12);
            picbBack.Name = "picbBack";
            picbBack.Size = new Size(49, 39);
            picbBack.SizeMode = PictureBoxSizeMode.Zoom;
            picbBack.TabIndex = 17;
            picbBack.TabStop = false;
            picbBack.Click += pictureBox1_Click;
            // 
            // FmChinhSua
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background_Homepage_App_NT106__2_2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(721, 388);
            Controls.Add(picbBack);
            Controls.Add(btnSave);
            Controls.Add(txtBirth);
            Controls.Add(txtName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "FmChinhSua";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmChinhSua";
            ((System.ComponentModel.ISupportInitialize)picbBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtBirth;
        private Button btnSave;
        private PictureBox picbBack;
    }
}