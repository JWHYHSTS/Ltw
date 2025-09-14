/*
Xây dựng lớp sản phẩm bao gồm các trường mã, tên, giá.
o Hàm tạo 3 đối số và hàm tạo mặc định.
o Phương thức tính thuế VAT
o Phương thức nhập mã, tên, giá từ bàn phím
o Phương thức xuất thông tin sản phẩm: mã, tên, giá và thuế VAT
o Viết chương trình nhập 2 sản phẩm từ bàn phím
o Viết chương trình thực hiện các công việc sau
 Tạo đối tượng sản phẩm
 Gọi phương thức nhập
 Gọi phương thức xuất
*/

using System;
using System.Collections.Generic;
using System.Text;

class SanPham
{
    public string Ma { get; set; }
    public string Ten { get; set; }
    public double Gia { get; set; }

    // Hàm tạo mặc định
    public SanPham()
    {
        Ma = "";
        Ten = "";
        Gia = 0;
    }

    // Hàm tạo 3 đối số
    public SanPham(string ma, string ten, double gia)
    {
        Ma = ma;
        Ten = ten;
        Gia = gia;
    }

    // Phương thức tính thuế VAT (giả sử 10%)
    public double TinhVAT()
    {
        return Gia * 0.1;
    }

    // Phương thức nhập thông tin sản phẩm từ bàn phím
    public void Nhap()
    {
        Console.Write("Nhập mã sản phẩm: ");
        Ma = Console.ReadLine();
        Console.Write("Nhập tên sản phẩm: ");
        Ten = Console.ReadLine();
        Console.Write("Nhập giá sản phẩm: ");
        double giaInput;
        while (!double.TryParse(Console.ReadLine(), out giaInput) || giaInput < 0)
        {
            Console.Write("Giá không hợp lệ. Nhập lại giá sản phẩm: ");
        }
    }

    // Phương thức xuất thông tin sản phẩm
    public void Xuat()
    {
        Console.WriteLine($"Mã: {Ma}, Tên: {Ten}, Giá: {Gia:N0} VND, Thuế VAT: {TinhVAT():N0} VND");
    }
}

class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        List<SanPham> danhSachSanPham = new List<SanPham>();

        Console.Write("Nhập số lượng sản phẩm: ");
        int n;
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Số lượng không hợp lệ. Nhập lại: ");
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"\nNhập thông tin sản phẩm thứ {i + 1}:");
            SanPham sp = new SanPham();
            sp.Nhap();
            danhSachSanPham.Add(sp);
        }

        Console.WriteLine("\nThông tin các sản phẩm:");
        foreach (var sp in danhSachSanPham)
        {
            sp.Xuat();
        }
    }
}

