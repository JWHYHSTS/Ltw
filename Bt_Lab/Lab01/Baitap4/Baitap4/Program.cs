// 1. Viết chương trình nhập họ, tên lót, tên. Xuất ra tên đầy đủ.
using System;
using System.Runtime.CompilerServices;
using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("1.Nhập họ, tên lót, tên. Xuất ra họ tên đầy đủ.");
Console.WriteLine();

Console.Write("Nhập họ: ");
string ho = Console.ReadLine() ?? "";

Console.Write("Nhập tên lót: ");
string tenLot = Console.ReadLine() ?? "";

Console.Write("Nhập tên: ");
string ten = Console.ReadLine() ?? "";

Console.WriteLine("Họ tên đầy đủ: {0} {1} {2}", ho, tenLot, ten);
Console.ReadKey(true);

Console.WriteLine("-------------------------------------------------------");

// 2. Viết chương trình nhập vào họ tên đầy đủ. Xuất ra từng phần gồm họ, tên lót, tên.
Console.WriteLine("2.Nhập vào họ tên đầy đủ. Xuất ra từng phần gồm họ, tên lót, tên.");
Console.WriteLine();

Console.Write("Nhập họ tên đầy đủ: ");
string fullname =  Console.ReadLine() ?? "";

string SPACE = " ";
string[] parts = fullname.Split(new string[] { SPACE }, StringSplitOptions.None);

Console.WriteLine("Họ: {0}, tên lót: {1}, tên: {2}", parts[0], parts[1], parts[2]);
Console.ReadKey(true);


// 3. Viết chương trình nhập vào họ tên hoa thường không đúng qui tắc, khoảng trắng không đúng
// (có nhiều hơn 1 khoảng trắng). Xuất ra màn hình họ tên theo dạng chuẩn.

Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Nhập họ tên không theo chuẩn. Chỉnh lại theo chuẩn và xuất ra.");
Console.WriteLine();

Console.Write("Nhập họ tên không theo chuẩn: ");
string fullname1 = Console.ReadLine() ?? ""; 
string SEPERATOR = " ";

// Xóa khoảng trắng thừa
string[] parts1 = fullname1.Split(new string[] { SEPERATOR }, StringSplitOptions.RemoveEmptyEntries);

if (parts1.Length >= 2)
{
    // Viết hoa từng phần
    for (int i = 0; i < parts1.Length; i++)
    {
        parts1[i] = parts1[i].Substring(0, 1).ToUpper() + parts1[i].Substring(1).ToLower();
    }

    string ho1 = parts1[0];
    string ten1 = parts1[parts1.Length - 1];
    string tenLot1 = parts1.Length > 2 ? string.Join(" ", parts1, 1, parts1.Length - 2) : "";
    Console.WriteLine("Họ tên đúng chuẩn: {0} {1} {2}", ho1, tenLot1, ten1);
}
else
{
    Console.WriteLine("Vui lòng nhập ít nhất họ và tên (2 phần, cách nhau bởi dấu cách).");
}
Console.ReadKey(true);
