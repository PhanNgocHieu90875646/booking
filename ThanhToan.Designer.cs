namespace booking
{
    partial class ThanhToan
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
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            btntrangChu = new Button();
            button1 = new Button();
            grpmenu.SuspendLayout();
            SuspendLayout();
            // 
            // grpmenu
            // 
            grpmenu.Controls.Add(dateTimePicker1);
            grpmenu.Controls.Add(label2);
            grpmenu.Controls.Add(label1);
            grpmenu.Controls.Add(textBox2);
            grpmenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpmenu.Location = new Point(102, 119);
            grpmenu.Name = "grpmenu";
            grpmenu.Size = new Size(1171, 380);
            grpmenu.TabIndex = 22;
            grpmenu.TabStop = false;
            grpmenu.Text = "Khách Hàng";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(197, 210);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 217);
            label2.Name = "label2";
            label2.Size = new Size(127, 20);
            label2.TabIndex = 3;
            label2.Text = "Ngày thanh toán";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 58);
            label1.Name = "label1";
            label1.Size = new Size(140, 20);
            label1.TabIndex = 2;
            label1.Text = "Họ tên khách hàng";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 0;
            // 
            // btntrangChu
            // 
            btntrangChu.BackColor = Color.IndianRed;
            btntrangChu.Location = new Point(1110, 539);
            btntrangChu.Name = "btntrangChu";
            btntrangChu.Size = new Size(163, 60);
            btntrangChu.TabIndex = 21;
            btntrangChu.Text = "Thanh Toán";
            btntrangChu.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.IndianRed;
            button1.Location = new Point(919, 539);
            button1.Name = "button1";
            button1.Size = new Size(163, 60);
            button1.TabIndex = 23;
            button1.Text = "Khuyến mãi";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ThanhToan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1661, 973);
            Controls.Add(button1);
            Controls.Add(grpmenu);
            Controls.Add(btntrangChu);
            Name = "ThanhToan";
            Text = "ThanhToan";
            grpmenu.ResumeLayout(false);
            grpmenu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpmenu;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private Button btntrangChu;
        private Button button1;
    }
}