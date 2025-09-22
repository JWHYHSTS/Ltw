namespace Baitap2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkhoitaoform_Click(object sender, EventArgs e)
        {
            if(int.TryParse(txtcot.Text, out int soCot) && int.TryParse(txtdong.Text, out int SoDong) && soCot > 0 && SoDong > 0)
            {
                var form = new FrmXuat(SoDong, soCot);
                form.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa hợp lệ!!! ");
            }
        }
    }
}
