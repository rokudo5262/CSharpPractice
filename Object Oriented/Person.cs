using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Person
    {
        public int Age { get; set; }
        public string ChucVu { get; set; }
        public void LoiChao()
        {
            Console.WriteLine("Xin Chào");
        }
        public void SetAge(int n)
        {
            Age = n;
        }
        public void SetChucVu(string n)
        {
            ChucVu = n;
        }
    }
}
