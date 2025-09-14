/*
 Thông tin một mặt hàng bao gồm: Mã mặt hàng (MaMH - số nguyên), tên mặt hàng (TenMH
- chuỗi), số lượng (SoLuong - số nguyên), đơn giá (DonGia - số thực).
 Khai báo cấu trúc mặt hàng nói trên, bao gồm cả hàm tạo và hàm tính thành tiền.
 Viết hàm thêm một mặt hàng vào trong danh sách.
 Viết hàm tìm một mặt hàng dựa vao mã mặt hàng, trả về kiểu bool (có hay không).
 Viết hàm xuất danh sách các mặt hàng.
 viết hàm xóa mặt hàng dựa vao mã mặt hàng.
 Viết hàm main thực hiện các chức năng sau:
o nhập vao danh sách các mặt hàng. Nhập xong mỗi mặt hàng hỏi người dùng có
tiếp tục nhập hay không?
o xuất danh sách các mặt hàng.
o nhập vao mã mặt hàng, tiến hành tìm kiếm mặt hàng nói trên. Nếu tìm thấy,
xóa mặt hàng và xuất danh sách các mặt hàng (sau khi xóa).
 
 */
using System;
using System.Collections.Generic;
using System.Text;

struct HangHoa
{
    public int MaMH;
    public string TenMH;
    public int SoLuong;
    public double DonGia;

    // Constructor
    public HangHoa(int maMH, string tenMH, int soLuong, double donGia)
    {
        MaMH = maMH;
        TenMH = tenMH;
        SoLuong = soLuong;
        DonGia = donGia;
    }

    // Hàm tính thành tiền
    public double ThanhTien()
    {
        return SoLuong * DonGia;
    }

    public override string ToString()
    {
        return $"{MaMH} - {TenMH} - {SoLuong} cái x {DonGia} đ = {ThanhTien()}";
    }

    // Thêm một mặt hàng vào danh sách
    public static void ThemMatHang(List<HangHoa> ds)
    {
        Console.Write("Nhập mã mặt hàng: ");
        int ma = int.Parse(Console.ReadLine());
        Console.Write("Nhập tên mặt hàng: ");
        string ten = Console.ReadLine();
        Console.Write("Nhập số lượng: ");
        int sl = int.Parse(Console.ReadLine());
        Console.Write("Nhập đơn giá: ");
        double dg = double.Parse(Console.ReadLine());
        ds.Add(new HangHoa(ma, ten, sl, dg));
    }

    // Tìm mặt hàng theo mã, trả về true nếu tìm thấy
    public static bool TimMatHang(List<HangHoa> ds, int maMH, out int index)
    {
        for (int i = 0; i < ds.Count; i++)
        {
            if (ds[i].MaMH == maMH)
            {
                index = i;
                return true;
            }
        }
        index = -1;
        return false;
    }

    // Xuất danh sách mặt hàng
    public static void XuatDanhSach(List<HangHoa> ds)
    {
        if (ds.Count == 0)
        {
            Console.WriteLine("Danh sách rỗng.");
            return;
        }
        foreach (var item in ds)
        {
            Console.WriteLine(item);
        }
    }

    // Xóa mặt hàng theo mã
    public static bool XoaMatHang(List<HangHoa> ds, int maMH)
    {
        int index;
        if (TimMatHang(ds, maMH, out index))
        {
            ds.RemoveAt(index);
            return true;
        }
        return false;
    }

    static void Main(string[] args)
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;

        List<HangHoa> danhSachMatHang = new List<HangHoa>();
        string tiepTuc;
        // Nhập danh sách mặt hàng
        do
        {
            ThemMatHang(danhSachMatHang);
            Console.Write("Bạn có muốn nhập tiếp không? (y/n): ");
            tiepTuc = Console.ReadLine();
        } while (tiepTuc.ToLower() == "y");

        // Xuất danh sách mặt hàng
        Console.WriteLine("\nDanh sách các mặt hàng:");
        XuatDanhSach(danhSachMatHang);

        // Tìm và xóa mặt hàng theo mã
        Console.Write("\nNhập mã mặt hàng cần tìm và xóa: ");
        int maTim = int.Parse(Console.ReadLine());
        if (XoaMatHang(danhSachMatHang, maTim))
        {
            Console.WriteLine("Đã xóa mặt hàng có mã {0}. Danh sách sau khi xóa:", maTim);
            XuatDanhSach(danhSachMatHang);
        }
        else
        {
            Console.WriteLine("Không tìm thấy mặt hàng có mã {0}.", maTim);
        }

        Console.WriteLine("Nhấn phím bất kỳ để kết thúc...");
        Console.ReadKey();
    }
}