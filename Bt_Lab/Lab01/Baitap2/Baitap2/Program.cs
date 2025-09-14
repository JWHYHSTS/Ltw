using System;
using System.Text;
Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;
try { 
    Console.WriteLine("GIẢI PHƯƠNG TRÌNH BẬC 2");
    Console.WriteLine("AX^2 + BX + C = 0");
    Console.WriteLine("------------------------");
    double A, B, C;
    Console.Write("Nhập hệ số A: ");
    A = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Nhập hệ số B: ");
    B = double.Parse(Console.ReadLine() ?? "0");
    Console.Write("Nhập hệ số C: ");
    C = double.Parse(Console.ReadLine() ?? "0");
    if (A == 0)
    {
        if (B == 0)
        {
            if (C == 0)
                Console.WriteLine("Phương trình có vô số nghiệm.");
            else
                Console.WriteLine("Phương trình vô nghiệm.");
        }
        else
        {
            double x = -C / B;
            Console.WriteLine($"Phương trình có một nghiệm: x = {x}");
        }
    }
    else
    {
        double delta = B * B - 4 * A * C;
        if (delta < 0)
        {
            Console.WriteLine("Phương trình vô nghiệm.");
        }
        else if (delta == 0)
        {
            double x = -B / (2 * A);
            Console.WriteLine($"Phương trình có nghiệm kép: x1 = x2 = {x}");
        }
        else
        {
            double sqrtDelta = Math.Sqrt(delta);
            double x1 = (-B + sqrtDelta) / (2 * A);
            double x2 = (-B - sqrtDelta) / (2 * A);
            Console.WriteLine($"Phương trình có hai nghiệm phân biệt: x1 = {x1}, x2 = {x2}");
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Lỗi: {ex.Message}");
}

