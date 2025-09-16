namespace QuanLyTonKho
{
    public partial class Form1 : Form
    {
        static List<HangHoa> hangHoas = new List<HangHoa>()
        {
            new HangHoa{ MaHh=Guid.NewGuid(),TenHh="Laptop Lenovo",DonGia="20000000",SoLuong=10},
            new HangHoa{ MaHh=Guid.NewGuid(),TenHh="Laptop Asus",DonGia="25000000",SoLuong=15},
            new HangHoa{ MaHh=Guid.NewGuid(),TenHh="Laptop Acer",DonGia="30000000",SoLuong=20},
            new HangHoa{ MaHh=Guid.NewGuid(),TenHh="Laptop Dell",DonGia="35000000",SoLuong=25},
            new HangHoa{ MaHh=Guid.NewGuid(),TenHh="Laptop HP",DonGia="40000000",SoLuong=30},

        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = hangHoas;
            cbohanghoa.DisplayMember = "TenHh";
            cbohanghoa.ValueMember = "MaHh";
            cbohanghoa.DataSource = hangHoas;
        }

        private void cbohanghoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mahhdangchon = Guid.Parse(cbohanghoa.SelectedValue.ToString());
            var hhchon = hangHoas.SingleOrDefault(hh => hh.MaHh == mahhdangchon);
            if (hhchon != null)
            {
                // Convert DonGia from string to int before formatting
                if (int.TryParse(hhchon.DonGia, out int donGiaInt))
                {
                    lbldongia.Text = donGiaInt.ToString("#,##0");
                }
                else
                {
                    lbldongia.Text = "Invalid";
                }
            }
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(nudsoluong.Value);
            var mahhdangchon = Guid.Parse(cbohanghoa.SelectedValue.ToString());
            var hhchon = hangHoas.SingleOrDefault(hh => hh.MaHh == mahhdangchon);
            if (hhchon != null)
            {
                // Convert DonGia from string to int before formatting
                if (int.TryParse(hhchon.DonGia, out int donGiaInt))
                {
                    hhchon.SoLuong += soluong;
                }
                else
                {
                    lbldongia.Text = "Invalid";
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = hangHoas;
            }
        }

        private void btngiam_Click(object sender, EventArgs e)
        {
            int soluong = Convert.ToInt32(nudsoluong.Value);
            var mahhdangchon = Guid.Parse(cbohanghoa.SelectedValue.ToString());
            var hhchon = hangHoas.SingleOrDefault(hh => hh.MaHh == mahhdangchon);
            if (hhchon != null)
            {
                // Convert DonGia from string to int before formatting
                if (int.TryParse(hhchon.DonGia, out int donGiaInt))
                {
                    if (hhchon.SoLuong - soluong < 0)
                    {
                        MessageBox.Show("Số lượng không đủ để giảm", "Thông báo");
                        return;
                    }
                    hhchon.SoLuong -= soluong;
                }
                else
                {
                    lbldongia.Text = "Invalid";
                }
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = hangHoas;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                // Do nothing, user canceled the exit
                return;
            }
        }
    }
}
