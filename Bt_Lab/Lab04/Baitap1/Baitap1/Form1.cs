namespace Baitap1
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

        private void btnadd_Click(object sender, EventArgs e)
        {
            if (cobtitle.Text.Length > 0 && txtfirstname.Text.Length > 0 && txtlastname.Text.Length > 0)
            {
                var chuoi = $"{cobtitle.Text} {txtfirstname.Text} {txtlastname.Text}";
                // Kiểm tra trùng tên (bao gồm cả title)
                bool isDuplicate = false;
                foreach (var item in lstdanhsach.Items)
                {
                    if (string.Equals(item.ToString(), chuoi, StringComparison.OrdinalIgnoreCase))
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                // Kiểm tra các title đặc biệt
                var titles = new[] { "Mr", "Mrs", "Miss", "Dr" };
                bool isSpecialTitle = titles.Any(t => string.Equals(cobtitle.Text, t, StringComparison.OrdinalIgnoreCase));

                if (isDuplicate && isSpecialTitle)
                {
                    MessageBox.Show("Tên đã tồn tại với chức danh đặc biệt (Mr, Mrs, Miss, Dr). Vui lòng nhập lại!");
                }
                else if (isDuplicate)
                {
                    MessageBox.Show("Tên đã tồn tại. Vui lòng nhập lại!");
                }
                else
                {
                    lstdanhsach.Items.Add(chuoi);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!!!");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cobtitle.Text = "";
            txtfirstname.Text = "";
            txtlastname.Clear();

            // Xóa hết các mục đã chọn trong ListBox
            lstdanhsach.Items.Clear();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            var traloi = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnsavefile_Click(object sender, EventArgs e)
        {
            if(lstdanhsach.Items.Count == 0)
            {
                MessageBox.Show("Danh sách rỗng, không có gì để lưu!!!");
                return;
            }
            var danhsach = new List<string>();
            foreach(var item in lstdanhsach.Items)
            {
                if (item is string str && !string.IsNullOrEmpty(str))
                {
                    danhsach.Add(str);
                }
            }
            File.WriteAllLines("danhsach.txt", danhsach);
        }
    }
}
