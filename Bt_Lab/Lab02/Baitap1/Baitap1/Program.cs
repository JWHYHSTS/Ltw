/*
 Viết chương trình nhập các số nguyên x và y từ bàn phím. Sau đó tính giá trị biểu thức sau
và xuất ra màn hình (có xử lý các ngoại lệ có thể xảy ra).
𝐻 = √3x+ 2y / 2x - y

Hướng dẫn:
 Tìm hiểu các hàm toán học của lớp Math để tìm hàm tính căn thức.
 Bắt các ngoại lệ
o Chia cho 0 → sử dụng lớp ngoại lệ DevideByZeroException
o Sai format → sử dụng lớp ngoại lệ FormatException
o Giá trị biểu thức dưới dấu căn <0 → Xây dựng lớp ngoại lệ mới
NotNegativeException

*/
using System;
using System.Text;

class NotNegativeException : Exception
{
    public NotNegativeException() : base("Giá trị biểu thức dưới dấu căn < 0") { }
}
partial class Program
{
    static void Main()
    {
        Console.InputEncoding = Encoding.UTF8;
        Console.OutputEncoding = Encoding.UTF8;
        try
        {
            Console.Write("Nhập x: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Nhập y: ");
            int y = int.Parse(Console.ReadLine());
            if (2 * x - y == 0)
                throw new DivideByZeroException();
            if (3 * x + 2 * y < 0)
                throw new NotNegativeException();
            double H = Math.Sqrt(3 * x + 2 * y) / (2 * x - y);
            Console.WriteLine($"H = {H}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Dữ liệu nhập vào không đúng định dạng");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Biểu thức bị chia cho 0");
        }
        catch (NotNegativeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}