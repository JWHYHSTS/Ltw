using System;
using System.Text;
Console.InputEncoding = Encoding.UTF8;
Console.OutputEncoding = Encoding.UTF8;
Console.Write("Nhập số lượng phần tử:");

string? input = Console.ReadLine();
if (string.IsNullOrWhiteSpace(input))
{
    Console.WriteLine("Giá trị nhập vào không hợp lệ.");
    return;
}
int n = int.Parse(input);
int [] arr = new int[n];
for(int i = 0; i < n; i++)
{
    Console.Write("Nhập phần tử " + i.ToString() + ": ");
    string? elementInput = Console.ReadLine();
    if (string.IsNullOrWhiteSpace(elementInput))
    {
        Console.WriteLine("Giá trị nhập vào không hợp lệ.");
        return;
    }
    arr[i] = int.Parse(elementInput);
}
int tong = 0;
for(int i = 0; i < n; i++)
{
    tong += arr[i];
}
Console.WriteLine("Tổng các phần tử trong mảng là: " + tong.ToString());
int max = arr[0];
int min = arr[0];
for(int i = 1; i < n; i++)
{
    if(arr[i] > max)
    {
        max = arr[i];
    }
    if(arr[i] < min)
    {
        min = arr[i];
    }
}
Console.WriteLine("Phần tử lớn nhất trong mảng là: " + max.ToString());
Console.WriteLine("Phần tử nhỏ nhất trong mảng là: " + min.ToString());