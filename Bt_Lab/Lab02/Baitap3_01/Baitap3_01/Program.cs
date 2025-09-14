/*
 Tạo ứng dụng Console, thêm vào 1 class tên SinhVien bao gồm các thành phần dữ liệu: MaSV,
HoTen, NgaySinh, DiaChi, DienThoai.
 Khai báo và định nghĩa các Constructor tham số và không tham số.
 Khai báo và định nghĩa các properties để truy cập đến giá trị của các thành phần dữ liệu (get, set)
và viết thêm 1 properties chỉ đọc (get) dùng để lấy LayTuoi của SinhVien.
 Viết hàm Main() để kiểm tra lớp trên.

 */
using System;
using System.Text;
using System.Collections.Generic;

class SinhVien
{
    // Thành phần dữ liệu
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public DateTime NgaySinh { get; set; }
    public string DiaChi { get; set; }
    public string DienThoai { get; set; }
    // Constructor không tham số
    public SinhVien()
    {
        MaSV = "Chưa có mã";
        HoTen = "Chưa có tên";
        NgaySinh = DateTime.MinValue;
        DiaChi = "Chưa có địa chỉ";
        DienThoai = "Chưa có điện thoại";
    }
    // Constructor có tham số
    public SinhVien(string maSV, string hoTen, DateTime ngaySinh, string diaChi, string dienThoai)
    {
        MaSV = maSV;
        HoTen = hoTen;
        NgaySinh = ngaySinh;
        DiaChi = diaChi;
        DienThoai = dienThoai;
    }
    // Properties chỉ đọc để lấy tuổi của sinh viên
    public int LayTuoi
    {
        get
        {
            int tuoi = DateTime.Now.Year - NgaySinh.Year;
            if (DateTime.Now < NgaySinh.AddYears(tuoi)) tuoi--;
            return tuoi;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.InputEncoding = Encoding.UTF8;

        List<SinhVien> danhSachSV = new List<SinhVien>();

        Console.Write("Nhập số lượng sinh viên: ");
        int soLuong = int.Parse(Console.ReadLine());

        for (int i = 0; i < soLuong; i++)
        {
            Console.WriteLine($"\nNhập thông tin sinh viên thứ {i + 1}:");
            Console.Write("Mã SV: ");
            string maSV = Console.ReadLine();
            Console.Write("Họ Tên: ");
            string hoTen = Console.ReadLine();
            Console.Write("Ngày Sinh (yyyy-MM-dd): ");
            DateTime ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.Write("Địa Chỉ: ");
            string diaChi = Console.ReadLine();
            Console.Write("Điện Thoại: ");
            string dienThoai = Console.ReadLine();

            SinhVien sv = new SinhVien(maSV, hoTen, ngaySinh, diaChi, dienThoai);
            danhSachSV.Add(sv);
        }

        Console.WriteLine("\nDanh sách sinh viên vừa nhập:");
        foreach (var sv in danhSachSV)
        {
            Console.WriteLine($"Mã SV: {sv.MaSV}, Họ Tên: {sv.HoTen}, Ngày Sinh: {sv.NgaySinh.ToShortDateString()}, Địa Chỉ: {sv.DiaChi}, Điện Thoại: {sv.DienThoai}, Tuổi: {sv.LayTuoi}");
        }

        Console.WriteLine("\nNhấn phím bất kỳ để thoát...");
        Console.ReadKey();
    }
}
