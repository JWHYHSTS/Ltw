/*
 Viết 1 ứng dụng Console thực hiện các chức năng sau với List, ArrayList hoặc Hashtable
 Nhập các tên hàng hóa (kiểu chuổi) từ bàn phím, thêm vào List/ArrayList khi nào
người dùng nhập vào chuổi “stop” thì ngừng.
 Xuất các hàng hóa ra màn hình.
 Nhập vào tên một hàng hóa, tiến hành tìm kiếm theo tên, trả về true nếu tìm thấy,
ngược lại trả về false
 Xóa một hàng hóa.
 Thêm 1 hàng hóa vào vị trí index bất kỳ với index nhập từ bàn phím.

*/
List<string> mang = new List<string>();
string tmp;
//nhập chuỗi đưa vào mảng cho tới khi gặp STOP
while (true)
{
    Console.Write("Chuoi nhap : ");
    tmp = Console.ReadLine().Trim();
    if (tmp.ToUpper() == "STOP")
    {
        break;//thoát while
    }
    //thêm vào mảng
    mang.Add(tmp);
    Console.WriteLine("Count = {0}, Capacity = {1}", mang.Count, mang.Capacity);
}//end while
XuatMang(mang);
//Nhập chuỗi cần tìm
Console.Write("Can tim : ");
tmp = Console.ReadLine().Trim();
if (mang.Contains(tmp))//true : có chứa
{
    Console.WriteLine("Tim thay {0} tai vi tri {1}", tmp, mang.IndexOf(tmp));
    mang.Remove(tmp);
    //mang.RemoveAt(mang.IndexOf(tmp));
    XuatMang(mang);
}
mang.Sort();
Console.WriteLine("Sau khi sap : ");
XuatMang(mang);
mang.Clear();
Console.WriteLine("Sau khi xoa, mang con {0} phan tu", mang.Count);
static void XuatMang(List<string> M)
{
    if (M == null || M.Count == 0)
    {
        Console.WriteLine("Danh sách rỗng.");
        return;
    }
    Console.WriteLine("Danh sách hàng hóa:");
    for (int i = 0; i < M.Count; i++)
    {
        Console.WriteLine($"{i}: {M[i]}");
    }
}

/*
 Chuoi nhap : Sua
Count = 1, Capacity = 4
Chuoi nhap : Banh mi
Count = 2, Capacity = 4
Chuoi nhap : Mi tom
Count = 3, Capacity = 4
Chuoi nhap : stop
Danh sách hàng hóa:
0: Sua
1: Banh mi
2: Mi tom
Can tim : Banh mi
Tim thay Banh mi tai vi tri 1
Danh sách hàng hóa:
0: Sua
1: Mi tom
Sau khi sap : 
Danh sách hàng hóa:
0: Mi tom
1: Sua
Sau khi xoa, mang con 0 phan tu
*/