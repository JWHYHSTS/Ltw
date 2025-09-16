namespace WF_Baitap04_TongHonHop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txtn.Focus();
            }
        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int N;
            double X;
            if (!int.TryParse(txtn.Text, out N) || (N <= 0))
            {
                MessageBox.Show("Vui lòng nhập số nguyên cho N.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!double.TryParse(txtx.Text, out X))
            {
                MessageBox.Show("Vui lòng nhập số thực cho X.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double S4 = 0;
            string S1 = string.Empty;
            string S2 = string.Empty;
            string S3 = string.Empty;
            for (int i = 1; i <= N; i++)
            {
                S1 += $"X" + (i > 1 ? $"^{i}" : "") + "+";
                S2 += $"{X}{(i > 1 ? i.ToString() : "")}+";
                S3 += $"{Math.Pow(X, i)}+";
                S4 += Math.Pow(X, i);
            }
            txts1.Text = S1.Substring(0, S1.Length - 1);
            txts2.Text = S2.Substring(0, S2.Length - 1);
            txts3.Text = S3.Substring(0, S3.Length - 1);
            txts4.Text = S4.ToString();
        }

        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn nhập lại không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtn.Clear();
                txtx.Clear();
                txts1.Clear();
                txts2.Clear();
                txts3.Clear();
                txts4.Clear();
                txtn.Focus();
            }
        }
    }
}
