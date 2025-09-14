namespace GPA_MONHOC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnsolve_Click(object sender, EventArgs e)
        {
            double cc, th, da;
            if (!double.TryParse(txtchuyencan.Text, out cc) || cc < 0 || cc > 10)
            {
                MessageBox.Show("Điểm chuyên cần không hợp lệ. Vui lòng nhập lại!!!");
                txtchuyencan.Focus();
                return;
            }
            if (!double.TryParse(txtthuchanh.Text, out th) || th < 0 || th > 10)
            {
                MessageBox.Show("Điểm thực hành không hợp lệ. Vui lòng nhập lại!!!");
                txtthuchanh.Focus();
                return;
            }
            if (!double.TryParse(txtdoan.Text, out da) || da < 0 || da > 10)
            {
                MessageBox.Show("Điểm đồ án không hợp lệ. Vui lòng nhập lại!!!");
                txtdoan.Focus();
                return;
            }
            double dtb = 0;
            if (da < 4)
            {
                dtb = da;
            }
            else
            {
                dtb = Math.Round(cc * 0.2 + th * 0.2 + da * 0.6, 1);
            }
            char GPA;
            string xeploai;
            if (dtb < 4)
            {
                GPA = 'F';
                xeploai = "Rớt";
            }
            else if (dtb < 5.5)
            {
                GPA = 'D';
                xeploai = "Yếu";
            }
            else if (dtb < 7)
            {
                GPA = 'C';
                xeploai = "Trung bình";
            }
            else if (dtb < 8.5)
            {
                GPA = 'B';
                xeploai = "Khá";
            }
            else
            {
                GPA = 'A';
                xeploai = "Giỏi";
            }
            txtkq.Text = $"Điểm trung bình: {dtb} \r\n GPA: {GPA} \r\n Xếp loại: {xeploai}";

        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtchuyencan.Clear();
            txtthuchanh.Clear();    
            txtdoan.Clear();
            txtkq.Clear();
            txtchuyencan.Focus();
        }
    }
}
