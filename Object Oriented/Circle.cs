using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Circle:Shape
    {
        public double Radious { get; set; }
        public override void CalculateArea()
        {
            this.Area = Math.PI*Radious*Radious;
        }
        public override void CalculatePerimeter()
        {
            this.Perimeter = 2 * Math.PI * Radious;
        }
    }
}
