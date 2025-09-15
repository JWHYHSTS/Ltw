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

        private void groupBoxHCN_Enter(object sender, EventArgs e)
        {

        }

        private void radHCN_CheckedChanged(object sender, EventArgs e)
        {
            if (radHCN.Checked)
            {
                groupBoxHCN.Enabled = true;
                groupBoxHT.Enabled = false;
            }
            else if (radHT.Checked)
            {
                groupBoxHCN.Enabled = false;
                groupBoxHT.Enabled = true;
            }
        }

        private void btnxuatJson_Click(object sender, EventArgs e)
        {
            if (danhSachHinhHoc.Count == 0)
            {
                MessageBox.Show("Danh sách hình học rỗng. Vui lòng thêm hình học trước khi xuất.");
                return;
            }
            var jsonstring = System.Text.Json.JsonSerializer.Serialize(danhSachHinhHoc, new System.Text.Json.JsonSerializerOptions { WriteIndented = true });
            File.WriteAllBytes("dshinhhoc.json", System.Text.Encoding.UTF8.GetBytes(jsonstring));
        }

        private void btnxuattext_Click(object sender, EventArgs e)
        {
            if(danhSachHinhHoc.Count == 0)
            {
                MessageBox.Show("Danh sách hình học rỗng. Vui lòng thêm hình học trước khi xuất.");
                return;
            }
            var mang = new List<string>();
            mang.Add("#1. Hình chữ nhật, 2. Hình tròn; các thông số các nhau bởi tab");
            foreach(var item in danhSachHinhHoc)
            {
                if (item.Type == 1) 
                {
                    var hcn = item as HinhChuNhat;
                    if (hcn != null)
                        mang.Add($"1\t{hcn.Dai}\t{hcn.Rong}\t{hcn.DienTich}\t{hcn.ChuVi}");
                }
                else if (item.Type == 2)
                {
                    var ht = item as HinhTron;
                    if (ht != null)
                        mang.Add($"2\t{ht.BanKinh}\t{ht.DienTich}\t{ht.ChuVi}");
                }
            }
            File.WriteAllLines("dshinhhoc.txt", mang.ToArray());
        }
    }
}