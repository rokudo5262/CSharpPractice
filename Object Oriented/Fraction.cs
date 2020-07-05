using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    public class Fraction
    {
        public double Numerator { get; set; }
        public double Denominator { get; set; }
        public void SetFraction(double n,double d)
        {
            Numerator = n;
            Denominator = d;
        }
        public void Nhap()
        {
            Console.Write("Nhập Vào Tử Số:");
            Numerator = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập Vào Mẩu Số:");
            Denominator = Convert.ToInt32(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine("{0}/{1}",Numerator,Denominator);
        }
        public void cong(Fraction f)
        {
            Numerator = Numerator * f.Denominator + Denominator * f.Numerator;
            Denominator = Denominator * f.Denominator;
        }
        public void tru(Fraction f)
        {
            Numerator = Numerator * f.Denominator - Denominator * f.Numerator;
            Denominator = Denominator * f.Denominator;
        }
        public void nhan(Fraction f)
        {
            Numerator = Numerator * f.Numerator;
            Denominator = Denominator * f.Denominator;
        }
        public void chia(Fraction f)
        {
            Numerator = Numerator * f.Denominator;
            Denominator = Denominator * f.Numerator;
        }
    }
}
