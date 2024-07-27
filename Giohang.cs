using System;
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
    public partial class Giohang : Form
    {
        public Giohang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ThanhToan thanh= new ThanhToan();
            thanh.Show();
        }
    }
}
