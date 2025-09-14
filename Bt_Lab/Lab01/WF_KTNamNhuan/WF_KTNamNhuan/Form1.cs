namespace WF_KTNamNhuan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            int Nam, Thang;
            if (!int.TryParse(txtNam.Text, out Nam) || (Nam < 0))
            {
                MessageBox.Show("Năm không hợp lệ");
                txtNam.Focus();
                return;
            }
            if (!int.TryParse(txtThang.Text, out Thang) || (Thang < 1) || (Thang > 12))
            {
                MessageBox.Show("Tháng không hợp lệ");
                txtThang.Focus();
                return;
            }
            bool NamNhuan = (Nam % 4 == 0 && Nam % 100 != 0) || (Nam % 400 == 0);
            int SoNgay = 0;
            switch (Thang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    SoNgay = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    SoNgay = 30;
                    break;
                case 2:
                    SoNgay = NamNhuan ? 29 : 28;
                    break;
            }
            txtKQ.Text = $"Năm: {Nam} là năm {(NamNhuan ? "nhuận" : "không nhuận")}, \r\nTháng {Thang} có {SoNgay} ngày.";
        }
    }
}
