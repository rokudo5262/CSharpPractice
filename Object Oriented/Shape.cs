using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    public abstract class Shape
    {
        /*Diện Tích*/
        public double area;
        public double Area
        {   //Lấy giá trị
            get
            {
                return area;
            }
            //Thiết lập giá trị
            set
            {
                area = value;
            }
        }
        /*ChuVi*/
        public double perimeter;
        public double Perimeter
        {   //Lấy giá trị
            get
            {
                return perimeter;
            }
            //Thiết lập giá trị
            set
            {
                perimeter = value;
            }
        }
        //Khai báo các method trừu tượng
        //Tinh Diện Tích
        public abstract void CalculateArea();
        //Tính Chu Vi
        public abstract void CalculatePerimeter();
    }
}
