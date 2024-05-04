namespace NT106
{
    partial class Job
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            ToMinute = new NumericUpDown();
            ToHour = new NumericUpDown();
            label1 = new Label();
            FrMinute = new NumericUpDown();
            FrHour = new NumericUpDown();
            txtTask = new TextBox();
            checkBox1 = new CheckBox();
            btnDel = new Button();
            btnEdit = new Button();
            cbbStatus = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ToMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ToHour).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)FrHour).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ToMinute);
            panel1.Controls.Add(ToHour);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(FrMinute);
            panel1.Controls.Add(FrHour);
            panel1.Location = new Point(376, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(266, 55);
            panel1.TabIndex = 8;
            // 
            // ToMinute
            // 
            ToMinute.Location = new Point(213, 19);
            ToMinute.Name = "ToMinute";
            ToMinute.Size = new Size(47, 27);
            ToMinute.TabIndex = 4;
            // 
            // ToHour
            // 
            ToHour.Location = new Point(160, 19);
            ToHour.Name = "ToHour";
            ToHour.Size = new Size(47, 27);
            ToHour.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(109, 16);
            label1.Name = "label1";
            label1.Size = new Size(45, 28);
            label1.TabIndex = 2;
            label1.Text = "đến";
            // 
            // FrMinute
            // 
            FrMinute.Location = new Point(56, 17);
            FrMinute.Name = "FrMinute";
            FrMinute.Size = new Size(47, 27);
            FrMinute.TabIndex = 1;
            // 
            // FrHour
            // 
            FrHour.Location = new Point(3, 17);
            FrHour.Name = "FrHour";
            FrHour.Size = new Size(47, 27);
            FrHour.TabIndex = 0;
            // 
            // txtTask
            // 
            txtTask.Location = new Point(49, 22);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(324, 27);
            txtTask.TabIndex = 7;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 12F);
            checkBox1.Location = new Point(22, 26);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnDel
            // 
            btnDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnDel.ForeColor = Color.Green;
            btnDel.Location = new Point(799, 33);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(75, 30);
            btnDel.TabIndex = 11;
            btnDel.Text = "XÓA";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 1, true);
            btnEdit.ForeColor = Color.Green;
            btnEdit.Location = new Point(800, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 30);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "LƯU";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Location = new Point(642, 22);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(151, 28);
            cbbStatus.TabIndex = 9;
            // 
            // Job
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(txtTask);
            Controls.Add(checkBox1);
            Controls.Add(btnDel);
            Controls.Add(btnEdit);
            Controls.Add(cbbStatus);
            Name = "Job";
            Size = new Size(880, 68);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ToMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)ToHour).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)FrHour).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private NumericUpDown ToMinute;
        private NumericUpDown ToHour;
        private Label label1;
        private NumericUpDown FrMinute;
        private NumericUpDown FrHour;
        private TextBox txtTask;
        private CheckBox checkBox1;
        private Button btnDel;
        private Button btnEdit;
        private ComboBox cbbStatus;
    }
}
