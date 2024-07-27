using booking.Models;
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
    public partial class NhanVienCon1 : Form
    {
        SqlDuAn1Context _context = new SqlDuAn1Context();
        public NhanVienCon1()
        {
           
            InitializeComponent();
        }

        private void NhanVienCon1_Load(object sender, EventArgs e)
        {

        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            
        }
    }
}
