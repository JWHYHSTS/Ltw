using System;
using System.Text;

namespace Baitap1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Write("Nhập vào tên bạn: ");
            string name = Console.ReadLine().Trim();
            Console.WriteLine($"Xin chào bạn {name}");
            Console.ReadKey();
        }
    }
}