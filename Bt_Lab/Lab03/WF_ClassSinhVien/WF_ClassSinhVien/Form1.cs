namespace WF_ClassSinhVien
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
        List<SinhVien> listSV = new List<SinhVien>();
        private void btnthem_Click(object sender, EventArgs e)
        {
            // Tự check hợp lệ dữ liệu
            SinhVien sinhVien = new SinhVien(txtmasv.Text, txthoten.Text, txtsdt.Text, double.Parse(txtgpa.Text));
            // Sử dụng LINQ để kiểm tra mã sinh viên có bị trùng hay không
            SinhVien? sinhvien = listSV.SingleOrDefault(sv => sv.MaSV == txtmasv.Text);
            if (sinhvien == null) // Không tìm thấy mã sinh viên trùng
            {
                listSV.Add(sinhVien);
            }
            else
            {
                MessageBox.Show("Mã sinh viên đã tồn tại, vui lòng nhập mã khác", "Thông báo");
            }
            HienThiDanhSach();
        }
        void HienThiDanhSach()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listSV;
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            var traloi = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên có mã " + txtmasv.Text + " không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            // Dựa vào mã sinh viên để xóa
            SinhVien? sinhvien = listSV.SingleOrDefault(sv => sv.MaSV == txtmasv.Text);
            if (sinhvien == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã " + txtmasv.Text, "Thông báo");
            }
            else
            {
                listSV.Remove(sinhvien);
                HienThiDanhSach();
                MessageBox.Equals("Xóa sinh viên thành công", "Thông báo");
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            // Dựa vào mã sinh viên để sửa
            SinhVien? sinhvien = listSV.SingleOrDefault(sv => sv.MaSV == txtmasv.Text);
            if (sinhvien == null)
            {
                MessageBox.Show("Không tìm thấy sinh viên có mã " + txtmasv.Text, "Thông báo");
            }
            else
            {
                sinhvien.HoTen = txthoten.Text;
                sinhvien.DienThoai = txtsdt.Text;
                sinhvien.GPA = double.Parse(txtgpa.Text);
                HienThiDanhSach();
                MessageBox.Equals("Cập nhật thông tin sinh viên thành công", "Thông báo");
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            // Xóa trắng các textbox
            txtmasv.Clear();
            txthoten.Clear();
            txtsdt.Clear();
            txtgpa.Clear();
            txtmasv.Focus();
            // Xóa chọn trên datagridview
            dataGridView1.ClearSelection();
            // Xóa dữ liệu trong list
            listSV.Clear();
            HienThiDanhSach();
        }
    }
}
