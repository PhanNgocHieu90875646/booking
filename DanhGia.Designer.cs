namespace booking
{
    partial class DanhGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DanhGia));
            grpmenu = new GroupBox();
            groupBox3 = new GroupBox();
            pictureBox2 = new PictureBox();
            label2 = new Label();
            textBox3 = new TextBox();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            textBox2 = new TextBox();
            grpmenu.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // grpmenu
            // 
            grpmenu.Controls.Add(groupBox3);
            grpmenu.Controls.Add(groupBox2);
            grpmenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpmenu.Location = new Point(110, 104);
            grpmenu.Name = "grpmenu";
            grpmenu.Size = new Size(1271, 689);
            grpmenu.TabIndex = 20;
            grpmenu.TabStop = false;
            grpmenu.Text = "Đánh Giá";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox2);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(textBox3);
            groupBox3.Location = new Point(572, 48);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(409, 388);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chất lượng phục vụ";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(376, 180);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 219);
            label2.Name = "label2";
            label2.Size = new Size(131, 20);
            label2.TabIndex = 2;
            label2.Text = "Nhận xét của bạn";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(6, 252);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(382, 130);
            textBox3.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(textBox2);
            groupBox2.Location = new Point(81, 48);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(418, 388);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chất lượng bữa ăn";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(376, 180);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 219);
            label1.Name = "label1";
            label1.Size = new Size(131, 20);
            label1.TabIndex = 1;
            label1.Text = "Nhận xét của bạn";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(6, 252);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(382, 130);
            textBox2.TabIndex = 0;
            // 
            // DanhGia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1661, 973);
            Controls.Add(grpmenu);
            Name = "DanhGia";
            Text = "DanhGia";
            grpmenu.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpmenu;
        private GroupBox groupBox3;
        private PictureBox pictureBox2;
        private Label label2;
        private TextBox textBox3;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
        private Label label1;
        private TextBox textBox2;
    }
}