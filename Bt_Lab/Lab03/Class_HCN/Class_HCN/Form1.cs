namespace Class_HCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        List<HinhChuNhat> dsHinh = new List<HinhChuNhat>();
        private void btnthem_Click(object sender, EventArgs e)
        {
            double dai, rong;
            if (!double.TryParse(txtcd.Text, out dai) || (dai <= 0))
            {
                MessageBox.Show("Chiều dài hợp lệ");
                return;
            }
            if (!double.TryParse(txtcr.Text, out rong) || (rong <= 0))
            {
                MessageBox.Show("Chiều rộng hợp lệ");
                return;
            }
            HinhChuNhat hcn = new HinhChuNhat(dai, rong);
            dsHinh.Add(hcn);
            ResetHCNTextBox();
            XuatDs();
        }
        void XuatDs()
        {
            txtkq.Clear();
            foreach (HinhChuNhat hcn in dsHinh)
            {
                txtkq.AppendText(hcn.ToString() + Environment.NewLine);
            }
        }
        void ResetHCNTextBox()
        {
            txtcd.Clear();
            txtcr.Clear();
            txtcd.Focus();
        }

        private void btnxuat_Click(object sender, EventArgs e)
        {
            txtcd.Clear();
            txtcr.Clear();
            txtkq.Clear();
            dsHinh.Clear();
            txtcd.Focus();
        }
    }
}
