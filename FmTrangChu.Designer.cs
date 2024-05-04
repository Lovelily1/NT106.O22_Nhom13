namespace NT106.O22
{
    partial class FmTrangChu
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
            panel_Top = new Panel();
            txtSearch = new TextBox();
            btnForum = new Button();
            picInfo = new PictureBox();
            panel_Left = new Panel();
            btnSchedule = new Button();
            btnReview = new Button();
            btnGroup = new Button();
            btnLibrary = new Button();
            btnHome = new Button();
            panel_Body = new Panel();
            pictureBox2 = new PictureBox();
            panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picInfo).BeginInit();
            panel_Left.SuspendLayout();
            panel_Body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel_Top
            // 
            panel_Top.Anchor = AnchorStyles.None;
            panel_Top.BackColor = Color.FromArgb(110, 191, 73);
            panel_Top.Controls.Add(txtSearch);
            panel_Top.Controls.Add(btnForum);
            panel_Top.Controls.Add(picInfo);
            panel_Top.Location = new Point(0, 1);
            panel_Top.Name = "panel_Top";
            panel_Top.Size = new Size(1114, 73);
            panel_Top.TabIndex = 0;
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 12F);
            txtSearch.Location = new Point(401, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(407, 34);
            txtSearch.TabIndex = 2;
            // 
            // btnForum
            // 
            btnForum.BackColor = Color.FromArgb(110, 191, 73);
            btnForum.FlatAppearance.BorderSize = 0;
            btnForum.FlatStyle = FlatStyle.Flat;
            btnForum.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnForum.ForeColor = Color.FromArgb(197, 241, 178);
            btnForum.Location = new Point(0, 12);
            btnForum.Name = "btnForum";
            btnForum.Size = new Size(241, 43);
            btnForum.TabIndex = 1;
            btnForum.Text = "FORUM";
            btnForum.UseVisualStyleBackColor = false;
            btnForum.Click += button1_Click;
            // 
            // picInfo
            // 
            picInfo.Dock = DockStyle.Right;
            picInfo.Image = Properties.Resources.预览图_千图网_编号286065751;
            picInfo.Location = new Point(1033, 0);
            picInfo.Name = "picInfo";
            picInfo.Size = new Size(81, 73);
            picInfo.SizeMode = PictureBoxSizeMode.Zoom;
            picInfo.TabIndex = 0;
            picInfo.TabStop = false;
            picInfo.Click += pictureBox1_Click_1;
            // 
            // panel_Left
            // 
            panel_Left.Anchor = AnchorStyles.None;
            panel_Left.BackColor = Color.FromArgb(197, 241, 178);
            panel_Left.Controls.Add(btnSchedule);
            panel_Left.Controls.Add(btnReview);
            panel_Left.Controls.Add(btnGroup);
            panel_Left.Controls.Add(btnLibrary);
            panel_Left.Controls.Add(btnHome);
            panel_Left.Location = new Point(0, 74);
            panel_Left.Name = "panel_Left";
            panel_Left.Size = new Size(241, 582);
            panel_Left.TabIndex = 1;
            // 
            // btnSchedule
            // 
            btnSchedule.Anchor = AnchorStyles.None;
            btnSchedule.BackColor = Color.FromArgb(197, 241, 178);
            btnSchedule.FlatAppearance.BorderSize = 0;
            btnSchedule.FlatStyle = FlatStyle.Flat;
            btnSchedule.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnSchedule.ForeColor = Color.FromArgb(32, 115, 53);
            btnSchedule.Location = new Point(0, 208);
            btnSchedule.Name = "btnSchedule";
            btnSchedule.Size = new Size(241, 52);
            btnSchedule.TabIndex = 4;
            btnSchedule.Text = "THỜI KHÓA BIỂU";
            btnSchedule.UseVisualStyleBackColor = false;
            btnSchedule.Click += btnSchedule_Click;
            // 
            // btnReview
            // 
            btnReview.Anchor = AnchorStyles.None;
            btnReview.BackColor = Color.FromArgb(197, 241, 178);
            btnReview.FlatAppearance.BorderSize = 0;
            btnReview.FlatStyle = FlatStyle.Flat;
            btnReview.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnReview.ForeColor = Color.FromArgb(32, 115, 53);
            btnReview.Location = new Point(0, 156);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(241, 52);
            btnReview.TabIndex = 3;
            btnReview.Text = "ÔN TẬP";
            btnReview.UseVisualStyleBackColor = false;
            btnReview.Click += btnReview_Click;
            // 
            // btnGroup
            // 
            btnGroup.Anchor = AnchorStyles.None;
            btnGroup.BackColor = Color.FromArgb(197, 241, 178);
            btnGroup.FlatAppearance.BorderSize = 0;
            btnGroup.FlatStyle = FlatStyle.Flat;
            btnGroup.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnGroup.ForeColor = Color.FromArgb(32, 115, 53);
            btnGroup.Location = new Point(0, 104);
            btnGroup.Name = "btnGroup";
            btnGroup.Size = new Size(241, 52);
            btnGroup.TabIndex = 2;
            btnGroup.Text = "NHÓM ";
            btnGroup.UseVisualStyleBackColor = false;
            btnGroup.Click += btnGroup_Click;
            // 
            // btnLibrary
            // 
            btnLibrary.Anchor = AnchorStyles.None;
            btnLibrary.BackColor = Color.FromArgb(197, 241, 178);
            btnLibrary.FlatAppearance.BorderSize = 0;
            btnLibrary.FlatStyle = FlatStyle.Flat;
            btnLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnLibrary.ForeColor = Color.FromArgb(32, 115, 53);
            btnLibrary.Location = new Point(0, 52);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(241, 52);
            btnLibrary.TabIndex = 1;
            btnLibrary.Text = "THƯ VIỆN";
            btnLibrary.UseVisualStyleBackColor = false;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // btnHome
            // 
            btnHome.Anchor = AnchorStyles.None;
            btnHome.BackColor = Color.FromArgb(197, 241, 178);
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnHome.ForeColor = Color.FromArgb(32, 115, 53);
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(241, 52);
            btnHome.TabIndex = 0;
            btnHome.Text = "TRANG CHỦ";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel_Body
            // 
            panel_Body.Anchor = AnchorStyles.None;
            panel_Body.BackColor = Color.White;
            panel_Body.Controls.Add(pictureBox2);
            panel_Body.Location = new Point(236, 74);
            panel_Body.Name = "panel_Body";
            panel_Body.Size = new Size(878, 582);
            panel_Body.TabIndex = 2;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.Background_Homepage_App_NT106__1_2;
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(878, 582);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FmTrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1114, 656);
            Controls.Add(panel_Body);
            Controls.Add(panel_Left);
            Controls.Add(panel_Top);
            ForeColor = Color.White;
            Name = "FmTrangChu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FmTrangChu";
            FormClosed += FmTrangChu_FormClosed;
            panel_Top.ResumeLayout(false);
            panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picInfo).EndInit();
            panel_Left.ResumeLayout(false);
            panel_Body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel_Top;
        private Panel panel_Left;
        private Button btnSchedule;
        private Button btnReview;
        private Button btnGroup;
        private Button btnLibrary;
        private Button btnHome;
        private Panel panel_Body;
        private PictureBox picInfo;
        private Button btnForum;
        private PictureBox pictureBox2;
        private TextBox txtSearch;
    }
}