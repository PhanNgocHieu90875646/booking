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
    public partial class Ban : Form
    {
        public Ban()
        {
            InitializeComponent();
        }

        private void btntrangChu_Click(object sender, EventArgs e)
        {
            Menuu menuu = new Menuu();
            menuu.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
