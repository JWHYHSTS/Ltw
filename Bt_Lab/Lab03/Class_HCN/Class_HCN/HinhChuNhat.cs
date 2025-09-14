using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_HCN
{
    public class HinhChuNhat
    {
        // Properties: biểu diễn đặc điểm của lớp
        public double ChieuDai { get; set; }
        public double ChieuRong { get; set; }
        public double DienTich { get; set; }
        public double ChuVi { get; set; }

        // Hàm tạo
        public HinhChuNhat(double chieudai = 1, double chieurong = 1)
        {
            ChieuDai = chieudai;
            ChieuRong = chieurong;
            DienTich = ChieuDai * ChieuRong;
            ChuVi = (ChieuDai + ChieuRong) * 2;
        }
        // Hàm override ToString()
        public override string ToString()
        {
            return $"HinhChuNhat: ChieuDai = {ChieuDai}, ChieuRong = {ChieuRong}, DienTich = {DienTich}, ChuVi = {ChuVi}";
        }
    }
}
