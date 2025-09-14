namespace WFGIAIPTBAC2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double A, B, C;
            try
            {
                A = double.Parse(txtA.Text);
                B = double.Parse(txtB.Text);
                C = double.Parse(txtC.Text);
            }
            catch
            {
                MessageBox.Show("Please enter valid numbers for A, B, and C.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            double delta = B * B - 4 * A * C;
            if (delta > 0)
            {
                double x1 = Math.Round((-B + Math.Sqrt(delta)) / (2 * A), 2);
                double x2 = Math.Round((-B - Math.Sqrt(delta)) / (2 * A), 2);
                txtKetQua.Text = $"Phương trình có 2 nghiệm phân biệt: x1 = {x1}, x2 = {x2}";

            }
            else if (delta == 0)
            {
                txtKetQua.Text = $"Phương trình có nghiệm kép: x = {-B / (2 * A)}";
            }
            else
            {
                txtKetQua.Text = "Phương trình vô nghiệm";
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Text = "";
            txtC.Clear();
            txtKetQua.Clear();
            // đưa dấu nháy về txtA để nhập lại
            txtA.Focus();
        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add logic as needed
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add logic as needed
        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {
            // You can leave this empty or add logic as needed
        }
    }
}
