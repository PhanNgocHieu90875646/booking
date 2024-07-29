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
            grpmenu = new GroupBox();
            groupBox4 = new GroupBox();
            txt_timkiem = new TextBox();
            btn_timkiem = new Button();
            groupBox3 = new GroupBox();
            btn_xoa = new Button();
            btn_capnhat = new Button();
            btn_Them = new Button();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1 = new GroupBox();
            textBox2 = new TextBox();
            label2 = new Label();
            txt_tensach = new TextBox();
            txt_masach = new TextBox();
            lb_tensach = new Label();
            lb_masach = new Label();
            grpmenu.SuspendLayout();
            groupBox4.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // grpmenu
            // 
            grpmenu.Controls.Add(groupBox4);
            grpmenu.Controls.Add(groupBox3);
            grpmenu.Controls.Add(groupBox2);
            grpmenu.Controls.Add(groupBox1);
            grpmenu.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grpmenu.Location = new Point(129, 149);
            grpmenu.Name = "grpmenu";
            grpmenu.Size = new Size(1403, 616);
            grpmenu.TabIndex = 26;
            grpmenu.TabStop = false;
            grpmenu.Text = "Thông tin đánh giá";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(txt_timkiem);
            groupBox4.Controls.Add(btn_timkiem);
            groupBox4.Location = new Point(556, 436);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(634, 77);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "Tìm kiếm";
            // 
            // txt_timkiem
            // 
            txt_timkiem.Location = new Point(13, 33);
            txt_timkiem.Name = "txt_timkiem";
            txt_timkiem.Size = new Size(498, 27);
            txt_timkiem.TabIndex = 12;
            // 
            // btn_timkiem
            // 
            btn_timkiem.BackColor = Color.White;
            btn_timkiem.Location = new Point(545, 32);
            btn_timkiem.Name = "btn_timkiem";
            btn_timkiem.Size = new Size(79, 29);
            btn_timkiem.TabIndex = 4;
            btn_timkiem.Text = "Tìm kiếm";
            btn_timkiem.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btn_xoa);
            groupBox3.Controls.Add(btn_capnhat);
            groupBox3.Controls.Add(btn_Them);
            groupBox3.Location = new Point(110, 436);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(340, 77);
            groupBox3.TabIndex = 21;
            groupBox3.TabStop = false;
            groupBox3.Text = "Cập nhập";
            // 
            // btn_xoa
            // 
            btn_xoa.Location = new Point(212, 32);
            btn_xoa.Name = "btn_xoa";
            btn_xoa.Size = new Size(94, 29);
            btn_xoa.TabIndex = 2;
            btn_xoa.Text = "Xóa";
            btn_xoa.UseVisualStyleBackColor = true;
            // 
            // btn_capnhat
            // 
            btn_capnhat.Location = new Point(112, 32);
            btn_capnhat.Name = "btn_capnhat";
            btn_capnhat.Size = new Size(94, 29);
            btn_capnhat.TabIndex = 1;
            btn_capnhat.Text = "Cập nhật";
            btn_capnhat.UseVisualStyleBackColor = true;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(12, 32);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(94, 29);
            btn_Them.TabIndex = 0;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Location = new Point(110, 214);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(1070, 215);
            groupBox2.TabIndex = 20;
            groupBox2.TabStop = false;
            groupBox2.Text = "Thông tin";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(35, 21);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(996, 188);
            dataGridView1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_tensach);
            groupBox1.Controls.Add(txt_masach);
            groupBox1.Controls.Add(lb_tensach);
            groupBox1.Controls.Add(lb_masach);
            groupBox1.Location = new Point(110, 34);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1070, 174);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông tin đánh giá";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(761, 59);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(270, 27);
            textBox2.TabIndex = 14;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(761, 36);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 12;
            label2.Text = "Bình luận";
            // 
            // txt_tensach
            // 
            txt_tensach.Location = new Point(410, 59);
            txt_tensach.Name = "txt_tensach";
            txt_tensach.Size = new Size(296, 27);
            txt_tensach.TabIndex = 8;
            // 
            // txt_masach
            // 
            txt_masach.Location = new Point(69, 59);
            txt_masach.Name = "txt_masach";
            txt_masach.Size = new Size(287, 27);
            txt_masach.TabIndex = 6;
            // 
            // lb_tensach
            // 
            lb_tensach.AutoSize = true;
            lb_tensach.Location = new Point(410, 36);
            lb_tensach.Name = "lb_tensach";
            lb_tensach.Size = new Size(71, 20);
            lb_tensach.TabIndex = 2;
            lb_tensach.Text = "Đánh giá";
            // 
            // lb_masach
            // 
            lb_masach.AutoSize = true;
            lb_masach.Location = new Point(69, 36);
            lb_masach.Name = "lb_masach";
            lb_masach.Size = new Size(118, 20);
            lb_masach.TabIndex = 0;
            lb_masach.Text = "Tên khách hàng";
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
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpmenu;
        private GroupBox groupBox4;
        private TextBox txt_timkiem;
        private Button btn_timkiem;
        private GroupBox groupBox3;
        private Button btn_xoa;
        private Button btn_capnhat;
        private Button btn_Them;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private GroupBox groupBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox txt_tensach;
        private TextBox txt_masach;
        private Label lb_tensach;
        private Label lb_masach;
    }
}