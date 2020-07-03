using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Fraction
    {
        public double numerator;
        public double Numerator
        {
            get
            {
                return numerator;
            }
            set
            {
                numerator = value;
            }
        }
        public double denominator;
        public double Denominator
        {
            get
            {
                return denominator;
            }
            set
            {
                denominator = value;
            }
        }
        public void SetFraction(double n,double d)
        {
            Console.Write("Nhập Vào Tử Số:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập Vào Mẩu Số:");
            d = Convert.ToInt32(Console.ReadLine());
            numerator = n;
            denominator = d;
        }
        public static void cong()
        {
            
        }
        public static void tru()
        {

        }
        public static void nhan()
        {

        }
        public static void chia()
        {

        }

    }
}
