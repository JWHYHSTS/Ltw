/*
 Đề bài
Viết chương trình phát sinh ngẫu nhiên một dãy n (n > 0) số nguyên, sau đó sắp xếp dãy số tăng
dần và xuất ra màn hình. Chú ý: dùng lớp List để lưu trữ mảng số nguyên vừa phát sinh.
Hướng dẫn
Sử dụng lớp Random và hàm Next(maxValue) để sinh số ngẫu nhiên.
Cách sử dụng lớp List
o Phải chỉ định rõ kiểu dữ liệu khi dùng
o Khởi tạo một đối tượng kiểu List để chứa các số nguyên
List<int> ml = new List<int>();
o Thêm một phần tử có giá trị là 10 vào list ml
ml.Add(10);
o Lấy ra m1 phần tử tại vị trí i trong list ml:
ml[i]
o Xóa tất cả các phần tử trong list ml
ml.Clear()
o Số lượng phần tử (thực sự): ml.Count

 */

using System;
using System.Text;
using System.Collections.Generic; 
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;

const int N = 10;
List<int> lst = new List<int>();
Random rnd = new Random((int)DateTime.Now.Ticks);

for (int i = 0; i < N; i++)
{
    lst.Add(rnd.Next(100));
}

// Display the original list
Console.WriteLine("Mảng ban đầu: ");
foreach (int num in lst)
{
    Console.Write(num + " ");
}
Console.WriteLine();
lst.Sort(); // Dùng hàm Sort() để sắp xếp mảng

Console.WriteLine("Mảng sau khi sắp xếp: ");
foreach (int num in lst)
{
    Console.Write(num + " ");
}
Console.WriteLine();
