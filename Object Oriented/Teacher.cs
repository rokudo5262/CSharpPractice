using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Teacher : Person
    {
        public string mon_hoc;
        public string MonHoc
        {
            get
            {
                return mon_hoc;
            }
            set
            {
                mon_hoc = value;
            }
        }
        public void SetMonHoc(string n)
        {
            mon_hoc = n;
        }
        public void ThongBaoTuoi()
        {
            Console.WriteLine("Tuổi Của {0} Là: {1} Tuổi.",chuc_vu, age);
        }
        public void GiangDay()
        {
            Console.WriteLine("Bắt Đầu Giảng Dạy Môn {0}.",mon_hoc);
        }
    }
}
