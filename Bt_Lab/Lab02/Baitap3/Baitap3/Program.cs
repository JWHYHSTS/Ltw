/*
 Thông tin một mặt hàng bao gồm: Mã mặt hàng (MaMH - số nguyên), tên mặt hàng (TenMH -
chuỗi), số lượng (SoLuong - số nguyên), đơn giá (DonGia - số thực).
 Khai báo cấu trúc mặt hàng nói trên, bao gồm cả hàm tạo và hàm tính thành tiền.
 Viết hàm thêm một mặt hàng vào trong danh sách.
 Viết hàm tìm một mặt hàng dựa vào mã mặt hàng, trả về kiểu bool (có hay không).
 Viết hàm xuất danh sách các mặt hàng.
 viết hàm xóa mặt hàng dựa vào mã mặt hàng.
 Viết hàm main thực hiện các chức năng sau:
o nhập vào danh sách các mặt hàng. Nhập xong mỗi mặt hàng hỏi người dùng có
tiếp tục nhập hay không?
o xuất danh sách các mặt hàng.
o nhập vào mã mặt hàng, tiến hành tìm kiếm mặt hàng nói trên. Nếu tìm thấy, xóa
mặt hàng và xuất danh sách các mặt hàng (sau khi xóa).
Hướng dân:
Khai báo cấu trúc Mặt hàng

 */
using System;
using System.Collections;

struct MatHang
{
    public int MaMH;
    public string TenMH;
    public int SoLuong;
    public float DonGia;

    public MatHang(int maMH, string tenMH, int soLuong, float donGia)
    {
        MaMH = maMH;
        TenMH = tenMH;
        SoLuong = soLuong;
        DonGia = donGia;
    }

    public float ThanhTien()
    {
        return SoLuong * DonGia;
    }

    public static void ThemMatHang(Hashtable danhsach, MatHang mh)
    {
        danhsach.Add(mh.MaMH, mh);
    }

    public static bool TimMatHang(Hashtable danhsach, int maMH)
    {
        return danhsach.ContainsKey(maMH);
    }

    public static void XoaMatHang(Hashtable danhsach, int maMH)
    {
        if (TimMatHang(danhsach, maMH))
            danhsach.Remove(maMH);
    }

    public static void XuatDanhSach(Hashtable danhsach)
    {
        Console.WriteLine("MaMH\tTenMH\t\tSoLuong\tDonGia\tThanhTien");
        foreach (DictionaryEntry entry in danhsach)
        {
            MatHang mh = (MatHang)entry.Value;
            Console.WriteLine($"{mh.MaMH}\t{mh.TenMH}\t\t{mh.SoLuong}\t{mh.DonGia}\t{mh.ThanhTien()}");
        }
    }
}

class Program
{
    static void Main()
    {
        Hashtable danhsach = new Hashtable();
        while (true)
        {
            Console.Write("Nhap MaMH: ");
            int maMH = int.Parse(Console.ReadLine());
            Console.Write("Nhap TenMH: ");
            string tenMH = Console.ReadLine();
            Console.Write("Nhap SoLuong: ");
            int soLuong = int.Parse(Console.ReadLine());
            Console.Write("Nhap DonGia: ");
            float donGia = float.Parse(Console.ReadLine());

            MatHang mh = new MatHang(maMH, tenMH, soLuong, donGia);
            MatHang.ThemMatHang(danhsach, mh);

            Console.Write("Ban co muon nhap tiep khong? (y/n): ");
            string tiepTuc = Console.ReadLine();
            if (tiepTuc.ToLower() != "y")
                break;
        }

        Console.WriteLine("\nDanh sach mat hang:");
        MatHang.XuatDanhSach(danhsach);

        Console.Write("\nNhap MaMH can tim va xoa: ");
        int maTim = int.Parse(Console.ReadLine());
        if (MatHang.TimMatHang(danhsach, maTim))
        {
            MatHang.XoaMatHang(danhsach, maTim);
            Console.WriteLine("Da xoa mat hang co MaMH = {0}. Danh sach con lai:", maTim);
            MatHang.XuatDanhSach(danhsach);
        }
        else
        {
            Console.WriteLine("Khong tim thay mat hang co MaMH = {0}.", maTim);
        }
    }
}

/* Ví dụ:
Nhap MaMH: 101
Nhap TenMH: Sua Hop
Nhap SoLuong: 10
Nhap DonGia: 15000
Ban co muon nhap tiep khong? (y/n): y
Nhap MaMH: 102
Nhap TenMH: Mi Goi
Nhap SoLuong: 20
Nhap DonGia: 3500
Ban co muon nhap tiep khong? (y/n): n*/