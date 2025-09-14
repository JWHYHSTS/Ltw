using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_ClassSinhVien
{
    public class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public string DienThoai { get; set; }
        public double GPA { get; set; }
        public string XepLoai // Read-only property
        {
            get
            {
                if (GPA < 5) return "F";
                else if (GPA < 6.5) return "D";
                else if (GPA < 7.5) return "C";
                else if (GPA < 8.5) return "B";
                else return "A";
            }
        }
        public SinhVien(string ma, string ten, string dt, double gpa)
        {
            MaSV = ma;
            HoTen = ten;
            DienThoai = dt;
            GPA = gpa;
        }   
        public override string ToString()
        {
            return $"{MaSV} - {HoTen} - {DienThoai} - {GPA} - {XepLoai}";
        }
    }
}
