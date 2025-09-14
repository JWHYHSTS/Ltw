namespace WF_Mangdonglist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Khai báo ngoài sự kiện
        List<int> myList = new List<int>();
        int sophantu = 0;
        private void btntaomang_Click(object sender, EventArgs e)
        {
            myList.Clear();
            sophantu = int.TryParse(txtsophantu.Text, out int n) ? n : 0;
            var random = new Random();
            // khởi tạo mảng số nguyên ko trùng gồm sophantu phần tử
            while (myList.Count < sophantu)
            {
                int songaunhien = random.Next(1, 1000);
                if (!myList.Contains(songaunhien))
                {
                    myList.Add(songaunhien);
                }
            }
            txtkq.Text = $"Mảng: {string.Join(", ", myList)}";
        }

        private void btnxoamang_Click(object sender, EventArgs e)
        {
            myList.Clear();
            txtkq.Clear();
        }

        private void btntim_Click(object sender, EventArgs e)
        {
            int giatritim = int.TryParse(txtgiatri.Text, out int n) ? n : 0;
            int vitritimthay = myList.IndexOf(giatritim);
            if (vitritimthay < 0)
            {
                txtkq.Text = $"Không tìm thấy {giatritim} trong mảng: {string.Join(", ", myList)}";
            }
            else
            {
                txtkq.Text = $"Tìm thấy {giatritim} tại vị trí {vitritimthay} trong mảng: {string.Join(", ", myList)}";
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            int giatritim = int.TryParse(txtgiatri.Text, out int n) ? n : 0;
            int vitritimthay = myList.IndexOf(giatritim);
            if (vitritimthay < 0)
            {
                txtkq.Text = $"Không tìm thấy {giatritim} trong mảng: {string.Join(", ", myList)}";
            }
            else
            {
                myList.RemoveAt(vitritimthay);
                txtkq.Text = $"Tìm thấy {giatritim} tại vị trí {vitritimthay} trong mảng: {string.Join(", ", myList)}";
                txtkq.Text += $"\r\nSau khi xóa: {string.Join(", ", myList)}";
            }
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtsophantu.Clear();
            txtgiatri.Clear();
            txtkq.Clear();
            myList.Clear();
            txtsophantu.Focus();
        }
    }
}
