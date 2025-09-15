using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_QuanlyHCN
{
    public abstract class HinhHoc
    {
        public double DienTich { get; set; }
        public double ChuVi { get; set; }
        public int Type { get; set; }
        public abstract void TinhDienTichChuVi();

    }
    public class  HinhChuNhat: HinhHoc
    {
        public double Dai { get; set; }
        public double Rong { get; set; }
        public HinhChuNhat(double d = 1, double r = 1)
        {
            Type = 1;
            Dai = d;
            Rong = r;
        }

        public override void TinhDienTichChuVi()
        {
            DienTich = Math.Round((Dai * Rong),3);
            ChuVi = Math.Round(((Dai + Rong) * 2),3);
        }
        public override string ToString()
        {
            return $"Hình chữ nhật: Dài = {Dai}, Rộng = {Rong}, Diện tích = {DienTich}, Chu vi = {ChuVi}";
        }
    }
    public class HinhTron: HinhHoc
    {
        public double BanKinh { get; set; }
        public HinhTron(double r = 1)
        {
            Type = 2;
            BanKinh = r;
        }
        public override void TinhDienTichChuVi()
        {
            DienTich = Math.Round((Math.PI * BanKinh * BanKinh),3);
            ChuVi = Math.Round((2 * Math.PI * BanKinh),2);
        }
        public override string ToString()
        {
            return $"Hình tròn: Bán kính = {BanKinh}, Diện tích = {DienTich}, Chu vi = {ChuVi}";
        }
    }
}
