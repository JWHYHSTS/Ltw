using System.Windows.Forms;

namespace WF_QuanlyHCN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<HinhHoc> danhSachHinhHoc = new List<HinhHoc>();

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (radHCN.Checked)
            {
                double dai, rong;
                if (!double.TryParse(txtDai.Text, out dai) || !double.TryParse(txtRong.Text, out rong))
                {
                    MessageBox.Show("Vui lòng nhập đúng số cho Dài và Rộng.");
                    return;
                }
                // Kiểm tra trùng
                if (danhSachHinhHoc.OfType<HinhChuNhat>().Any(h => h.Dai == dai && h.Rong == rong))
                {
                    MessageBox.Show("Hình chữ nhật đã tồn tại. Vui lòng nhập lại.");
                    return;
                }
                danhSachHinhHoc.Add(new HinhChuNhat() { Dai = dai, Rong = rong });
            }
            else if (radHT.Checked)
            {
                double banKinh;
                if (!double.TryParse(txtBanKinh.Text, out banKinh))
                {
                    MessageBox.Show("Vui lòng nhập đúng số cho Bán kính.");
                    return;
                }
                // Kiểm tra trùng
                if (danhSachHinhHoc.OfType<HinhTron>().Any(h => h.BanKinh == banKinh))
                {
                    MessageBox.Show("Hình tròn đã tồn tại. Vui lòng nhập lại.");
                    return;
                }
                danhSachHinhHoc.Add(new HinhTron() { BanKinh = banKinh });
            }
            HienThiDanhSach();
        }

        private void HienThiDanhSach()
        {
            foreach (var hinh in danhSachHinhHoc)
            {
                hinh.TinhDienTichChuVi();
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = danhSachHinhHoc;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (radHCN.Checked)
            {
                double dai, rong;
                if (!double.TryParse(txtDai.Text, out dai) || !double.TryParse(txtRong.Text, out rong))
                {
                    MessageBox.Show("Vui lòng nhập đúng số cho Dài và Rộng.");
                    return;
                }
                var hcn = danhSachHinhHoc.OfType<HinhChuNhat>().FirstOrDefault(h => h.Dai == dai && h.Rong == rong);
                if (hcn != null)
                {
                    danhSachHinhHoc.Remove(hcn);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hình chữ nhật cần xóa.");
                }
            }
            else if (radHT.Checked)
            {
                double banKinh;
                if (!double.TryParse(txtBanKinh.Text, out banKinh))
                {
                    MessageBox.Show("Vui lòng nhập đúng số cho Bán kính.");
                    return;
                }
                var ht = danhSachHinhHoc.OfType<HinhTron>().FirstOrDefault(h => h.BanKinh == banKinh);
                if (ht != null)
                {
                    danhSachHinhHoc.Remove(ht);
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hình tròn cần xóa.");
                }
            }
            HienThiDanhSach();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (radHCN.Checked)
            {
                double dai, rong;
                if (!double.TryParse(txtDai.Text, out dai) || !double.TryParse(txtRong.Text, out rong))
                {
                    MessageBox.Show("Vui lòng nhập đúng số cho Dài và Rộng.");
                    return;
                }
                var hcn = danhSachHinhHoc.OfType<HinhChuNhat>().FirstOrDefault(h => h.Dai == dai && h.Rong == rong);
                if (hcn != null)
                {
                    string inputDai = Microsoft.VisualBasic.Interaction.InputBox("Nhập Dài mới:", "Sửa HCN", hcn.Dai.ToString());
                    string inputRong = Microsoft.VisualBasic.Interaction.InputBox("Nhập Rộng mới:", "Sửa HCN", hcn.Rong.ToString());
                    double daiMoi, rongMoi;
                    if (double.TryParse(inputDai, out daiMoi) && double.TryParse(inputRong, out rongMoi))
                    {
                        // Kiểm tra trùng
                        if (danhSachHinhHoc.OfType<HinhChuNhat>().Any(h => h.Dai == daiMoi && h.Rong == rongMoi))
                        {
                            MessageBox.Show("Hình chữ nhật đã tồn tại. Vui lòng nhập lại.");
                            return;
                        }
                        hcn.Dai = daiMoi;
                        hcn.Rong = rongMoi;
                    }
                    else
                    {
                        MessageBox.Show("Giá trị nhập không hợp lệ.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hình chữ nhật cần sửa.");
                }
            }
            else if (radHT.Checked)
            {
                double banKinh;
                if (!double.TryParse(txtBanKinh.Text, out banKinh))
                {
                    MessageBox.Show("Vui lòng nhập đúng số cho Bán kính.");
                    return;
                }
                var ht = danhSachHinhHoc.OfType<HinhTron>().FirstOrDefault(h => h.BanKinh == banKinh);
                if (ht != null)
                {
                    string inputBanKinh = Microsoft.VisualBasic.Interaction.InputBox("Nhập bán kính mới:", "Sửa Hình tròn", ht.BanKinh.ToString());
                    double banKinhMoi;
                    if (double.TryParse(inputBanKinh, out banKinhMoi))
                    {
                        // Kiểm tra trùng
                        if (danhSachHinhHoc.OfType<HinhTron>().Any(h => h.BanKinh == banKinhMoi))
                        {
                            MessageBox.Show("Hình tròn đã tồn tại. Vui lòng nhập lại.");
                            return;
                        }
                        ht.BanKinh = banKinhMoi;
                    }
                    else
                    {
                        MessageBox.Show("Giá trị nhập không hợp lệ.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy hình tròn cần sửa.");
                }
            }
            HienThiDanhSach();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            danhSachHinhHoc.Clear();
            HienThiDanhSach();
        }
    }
}