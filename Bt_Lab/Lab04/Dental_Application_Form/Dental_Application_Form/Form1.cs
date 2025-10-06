namespace Dental_Application_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        void EnableControl(bool enable = true)
        {
            Chkcaovoi.Enabled = enable;
            Chktaytrang.Enabled = enable;
            Nudnhorang.Enabled = enable;
            Nudtramrang.Enabled = enable;
            Nudtrongrang.Enabled = enable;
            btntinhtien.Enabled = enable;
            btnluufile.Enabled = enable;
            btnxoa.Enabled = enable;
            btnthoat.Enabled = enable;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnableControl(false);
        }

        private void txtkhachhang_TextChanged(object sender, EventArgs e)
        {
            if (txtkhachhang.Text.Trim().Length > 0)
            {
                EnableControl(true);
            }
            else
            {
                EnableControl(false);
            }
        }

        private void btntinhtien_Click(object sender, EventArgs e)
        {
            int tongtien = 0;
            if (Chkcaovoi.Checked)
            {
                tongtien += 1000000;
            }
            if (Chktaytrang.Checked)
            {
                tongtien += 1500000;
            }
            tongtien += Convert.ToInt32(Nudnhorang.Value) * 500000;
            tongtien += Convert.ToInt32(Nudtramrang.Value) * 200000;
            tongtien += Convert.ToInt32(Nudtrongrang.Value) * 20000000;

            txttongcong.Text = tongtien.ToString("#,##0") + " VND";

            MessageBox.Show($"Khách hàng: {txtkhachhang.Text.Trim()} cần trả số tiền {tongtien.ToString("#,##0")} VND");

        }

        private void btnluufile_Click(object sender, EventArgs e)
        {
            List<string> data = new List<string>()
            {
                "Họ tên:" + txtkhachhang.Text.Trim(),
                "Tổng tiền:" + txttongcong.Text.Trim()
            };
            File.WriteAllLines("data.txt", data);
            MessageBox.Show("Lưu file thành công");
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            txtkhachhang.Clear();
            txttongcong.Clear();
            Chkcaovoi.Checked = false;
            Chktaytrang.Checked = false;
            Nudnhorang.Value = 0;
            Nudtramrang.Value = 0;
            Nudtrongrang.Value = 0;
            txtkhachhang.Focus();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            var rs = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void Chktaytrang_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txttongcong_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            // You can add any logic here if you want something to happen when label9 is clicked.
            // For now, this can be left empty or display a message box, etc.
        }
    }
}
