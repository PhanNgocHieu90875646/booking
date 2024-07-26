using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace booking
{
    public partial class NhanVien : Form
    {
        public NhanVien()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NhanVienCon1 dd = new NhanVienCon1();
            if (textBox2.Text != "" && textBox3.Text != "")
            {
                if (textBox2.Text == "a" && textBox3.Text == "12")
                {
                    dd.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Tai khoan ma ban nhap khong ton tai", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Moi ban nhap thong tin", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
