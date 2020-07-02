using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Person
    {
        public int age;
        public int Age
        {
            get
            {
                return age;
            }
                set
            {
                age = value;
            }
        }
        public string chuc_vu;
        public string ChucVu
        {
            get 
            {
                return chuc_vu;
            }
            set 
            {
                chuc_vu = value;
            }
        }
        public void LoiChao()
        {
            Console.WriteLine("Xin Chào");
        }
        public void SetAge(int n)
        {
            age = n;
        }
        public void SetChucVu(string n)
        {
            chuc_vu = n;
        }
    }
}
