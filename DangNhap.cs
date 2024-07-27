namespace booking
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TrangChu dd = new TrangChu();
            if (textBox2.Text != "" && textBox1.Text != "")
            {
                if (textBox2.Text == "a" && textBox1.Text == "12")
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
