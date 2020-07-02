﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    class Square:Shape
    {
        public double side;
        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public override void CalculateArea()
        {
            this.Area = side*side;
        }
        public override void CalculatePerimeter()
        {
            this.Perimeter = 4*side; 
        }
    }
}
