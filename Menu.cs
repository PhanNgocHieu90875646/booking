﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace booking
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childform)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childform;
            childform.TopLevel = false;
            childform.FormBorderStyle = FormBorderStyle.None;
            childform.Dock = DockStyle.Fill;
            grpmenu.Controls.Add(childform);
            grpmenu.Tag = childform;
            childform.BringToFront();
            childform.Show();
        }
        private void btntrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Menu());//aa
        }

        private void btnkhuyenMai_Click(object sender, EventArgs e)
        {
            OpenChildForm(new KhuyenMai());
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OpenChildForm(new DanhGia());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenChildForm(new NhanVien());
        }

        private void btndatBan_Click(object sender, EventArgs e)
        {
            ThanhToan thanhtoan=new ThanhToan();
            thanhtoan.Show();
        }
    }
}
