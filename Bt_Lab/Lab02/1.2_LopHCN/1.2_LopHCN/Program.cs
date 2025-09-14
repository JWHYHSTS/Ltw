/*
Tạo ứng dụng Console, thêm vào 1 class tên HinhChuNhat gồm các thành phần dữ liệu: mChieuCao,
mChieuRong. Thực hiện các yêu cầu sau:
 Viết các constructor không tham số và có tham số để khởi tạo các giá trị cho mChieuCao và
mChieuRong.
 Viết các properties để truy cập đến 2 thành phần trên
 Viết 2 phương thức trả về chu vi (mChieuDai+mChieuRong) x 2 và diện tích hình chữ nhật
(mChieuDai x mChieuRong).
 Phương thức xuất thông tin hình chữ nhật: rộng, dài, diện tích và chu vi.
 Viết phương thức kiểm tra xem hình chữ nhật có phải là hình vuông hay không?
 Viết hàm Main để kiểm tra lớp HinhChuNhat: khởi tạo đối tượng, các giá trị cho đối tượng, gọi các
phương thức, …

*/
using System;
using System.Text;
using System.Collections.Generic;

class HinhChuNhat
{

    private double mChieuCao;
    private double mChieuRong;

    public HinhChuNhat()
    {
        mChieuCao = 0;
        mChieuRong = 0;
    }

    public HinhChuNhat(double chieuCao, double chieuRong)
    {
        mChieuCao = chieuCao;
        mChieuRong = chieuRong;
    }

    public double ChieuCao
    {
        get { return mChieuCao; }
        set { mChieuCao = value; }
    }

    public double ChieuRong
    {
        get { return mChieuRong; }
        set { mChieuRong = value; }
    }

    public double TinhChuVi()
    {
        return (mChieuCao + mChieuRong) * 2;
    }

    public double TinhDienTich()
    {
        return mChieuCao * mChieuRong;
    }

    public void XuatThongTin()
    {
        Console.WriteLine("Chiều cao: {0}", mChieuCao);
        Console.WriteLine("Chiều rộng: {0}", mChieuRong);
        Console.WriteLine("Diện tích: {0}", TinhDienTich());
        Console.WriteLine("Chu vi: {0}", TinhChuVi());
    }

    public bool LaHinhVuong()
    {
        return mChieuCao == mChieuRong;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<HinhChuNhat> danhSachHCN = new List<HinhChuNhat>();

        Console.Write("Nhập số lượng hình chữ nhật: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nHình chữ nhật thứ {i + 1}:");
            Console.Write("Nhập chiều cao: ");
            double chieuCao = double.Parse(Console.ReadLine());
            Console.Write("Nhập chiều rộng: ");
            double chieuRong = double.Parse(Console.ReadLine());

            HinhChuNhat hcn = new HinhChuNhat(chieuCao, chieuRong);
            danhSachHCN.Add(hcn);
        }

        Console.WriteLine("\n--- Thông tin các hình chữ nhật ---");
        for (int i = 0; i < danhSachHCN.Count; i++)
        {
            Console.WriteLine($"\nHình chữ nhật thứ {i + 1}:");
            danhSachHCN[i].XuatThongTin();
            Console.WriteLine("Có phải hình vuông? " + (danhSachHCN[i].LaHinhVuong() ? "Có" : "Không"));
        }

        Console.ReadKey();
    }
}