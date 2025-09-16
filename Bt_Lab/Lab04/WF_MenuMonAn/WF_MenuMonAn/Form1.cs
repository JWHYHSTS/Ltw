namespace WF_MenuMonAn
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

        private void txttenmon_KeyUp(object sender, KeyEventArgs e)
        {
            btnthem.Enabled = txttenmon.Text.Trim().Length > 0 ? true : false;

        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            var tenmon = txttenmon.Text.Trim();
            if (string.IsNullOrEmpty(tenmon))
            {
                MessageBox.Show("Tên món ăn không được để trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmon.SelectAll();
                txttenmon.Focus();
                return;
            }
            if (!lstthucdon.Items.Contains(tenmon))
            {
                lstthucdon.Items.Add(tenmon);
                txttenmon.Clear();
                txttenmon.Focus();
            }
            else
            {
                MessageBox.Show("Món ăn đã có trong thực đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttenmon.SelectAll();
                txttenmon.Focus();
            }
        }

        private void btnchon_Click(object sender, EventArgs e)
        {
            foreach (var item in lstthucdon.SelectedItems)
            {
                var itemStr = item?.ToString();
                if (!string.IsNullOrEmpty(itemStr) && !lstchon.Items.Contains(itemStr))
                {
                    lstchon.Items.Add(itemStr);
                }
            }
        }

        private void btnchontatca_Click(object sender, EventArgs e)
        {
            lstchon.Items.Clear();
            foreach (var item in lstthucdon.Items)
            {
                var itemStr = item?.ToString();
                if (!string.IsNullOrEmpty(itemStr))
                {
                    lstchon.Items.Add(itemStr);
                }
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            while (lstchon.SelectedItems.Count > 0)
            {
                var selectedItem = lstchon.SelectedItem;
                if (selectedItem != null)
                {
                    lstchon.Items.Remove(selectedItem);
                }
            }
        }

        private void btnxoatatca_Click(object sender, EventArgs e)
        {
            lstchon.Items.Clear();

        }

        private void txttenmon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r') // Enter
            {
                btnthem_Click(sender, e);
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                txttenmon.Focus();
            }
        }
    }
}
