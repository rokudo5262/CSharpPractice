using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Triangle : Shape
    {
        double side_a;
        double side_b;
        double side_c;
        public double SideA
        {
            get
            {
                return side_a;
            }
            set
            {
                side_a = value;
            }
        }
        public double SideB
        {
            get
            {
                return side_b;
            }
            set
            {
                side_b = value;
            }
        }
        public double SideC
        {
            get
            {
                return side_c;
            }
            set
            {
                side_c = value;
            }
        }
        public Triangle()
        {
            side_a = 0;
            side_b = 0;
            side_c = 0;
        }
        public Triangle(double a, double b,double c)
        {
            side_a = a;
            side_b = b;
            side_c = c;
        }
        public override void CalculatePerimeter()
        {
            this.Perimeter = side_a + side_b + side_c;
        }
        public override void CalculateArea()
        {
            double p= (side_a + side_b + side_c) / 2;
            this.Area = Math.Sqrt(p * (p - side_a) * (p - side_b) * (p - side_c));
        }
        
    }
}
