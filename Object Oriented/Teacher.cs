using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Teacher : Person
    {
        public string MonHoc { get; set; }
        public void SetMonHoc(string n)
        {
            MonHoc = n;
        }
        public void ThongBaoTuoi()
        {
            Console.WriteLine("Tuổi Của {0} Là: {1} Tuổi.",ChucVu, Age);
        }
        public void GiangDay()
        {
            Console.WriteLine("Bắt Đầu Giảng Dạy Môn {0}.", MonHoc);
        }
    }
}
