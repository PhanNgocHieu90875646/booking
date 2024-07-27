namespace booking
{
    partial class TrangChu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TrangChu));
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            button6 = new Button();
            button5 = new Button();
            pictureBox5 = new PictureBox();
            btntrangChu = new Button();
            grpmenu = new GroupBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(pictureBox5);
            groupBox1.Controls.Add(btntrangChu);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(21, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(252, 919);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ActiveCaption;
            button2.Location = new Point(0, 485);
            button2.Name = "button2";
            button2.Size = new Size(217, 88);
            button2.TabIndex = 13;
            button2.Text = "77";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(0, 203);
            button1.Name = "button1";
            button1.Size = new Size(217, 88);
            button1.TabIndex = 12;
            button1.Text = "Đặt Bàn";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click_1;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ActiveCaption;
            button6.Location = new Point(0, 391);
            button6.Name = "button6";
            button6.Size = new Size(217, 88);
            button6.TabIndex = 11;
            button6.Text = "Nhân Viên";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ActiveCaption;
            button5.Location = new Point(-1, 297);
            button5.Name = "button5";
            button5.Size = new Size(217, 88);
            button5.TabIndex = 10;
            button5.Text = "Đánh Giá";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.White;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(216, 92);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // btntrangChu
            // 
            btntrangChu.BackColor = SystemColors.ActiveCaption;
            btntrangChu.Location = new Point(-1, 109);
            btntrangChu.Name = "btntrangChu";
            btntrangChu.Size = new Size(217, 88);
            btntrangChu.TabIndex = 0;
            btntrangChu.Text = "Trang chủ";
            btntrangChu.UseVisualStyleBackColor = false;
            btntrangChu.Click += btntrangChu_Click;
            // 
            // grpmenu
            // 
            grpmenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpmenu.Location = new Point(279, 56);
            grpmenu.Name = "grpmenu";
            grpmenu.Size = new Size(1312, 875);
            grpmenu.TabIndex = 24;
            grpmenu.TabStop = false;
            grpmenu.Text = "77";
            // 
            // TrangChu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1661, 973);
            Controls.Add(grpmenu);
            Controls.Add(groupBox1);
            Name = "TrangChu";
            Text = "Menu";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button6;
        private Button button5;
        private PictureBox pictureBox5;
        private Button btntrangChu;
        private GroupBox grpmenu;
        private Button button1;
        private Button button2;
    }
}