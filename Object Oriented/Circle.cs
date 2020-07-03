using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Circle:Shape
    {
        public double radious;
        public double Radious
        {
            get
            {
                return radious;
            }
            set
            {
                radious = value;
            }
        }
        public override void CalculateArea()
        {
            this.Area = Math.PI*radious*radious;
        }
        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * Math.PI * radious;
        }
    }
}
