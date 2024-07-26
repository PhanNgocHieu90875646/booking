namespace booking
{
    partial class NhanVien
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
            grpmenu = new GroupBox();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            grpmenu.SuspendLayout();
            SuspendLayout();
            // 
            // grpmenu
            // 
            grpmenu.Controls.Add(button2);
            grpmenu.Controls.Add(button1);
            grpmenu.Controls.Add(label2);
            grpmenu.Controls.Add(label1);
            grpmenu.Controls.Add(textBox3);
            grpmenu.Controls.Add(textBox2);
            grpmenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpmenu.Location = new Point(276, 46);
            grpmenu.Name = "grpmenu";
            grpmenu.Size = new Size(566, 400);
            grpmenu.TabIndex = 20;
            grpmenu.TabStop = false;
            grpmenu.Text = "Nhân Viên";
            // 
            // button1
            // 
            button1.Location = new Point(133, 227);
            button1.Name = "button1";
            button1.Size = new Size(113, 31);
            button1.TabIndex = 4;
            button1.Text = "Đăng nhập";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 163);
            label2.Name = "label2";
            label2.Size = new Size(77, 20);
            label2.TabIndex = 3;
            label2.Text = "Mật Khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 98);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 2;
            label1.Text = "Tài Khoản";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(170, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(322, 27);
            textBox3.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(170, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(322, 27);
            textBox2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(340, 227);
            button2.Name = "button2";
            button2.Size = new Size(113, 31);
            button2.TabIndex = 5;
            button2.Text = "Hủy";
            button2.UseVisualStyleBackColor = true;
            // 
            // NhanVien
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1661, 973);
            Controls.Add(grpmenu);
            Name = "NhanVien";
            Text = "NhanVien";
            grpmenu.ResumeLayout(false);
            grpmenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpmenu;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Button button2;
    }
}