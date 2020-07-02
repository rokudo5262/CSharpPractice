using System;
using System.Collections.Generic;
using System.Text;

namespace Object_Oriented
{
    //Hình Chữ Nhật
    class Rectangle : Shape
    {
        //Chiều Dài
        public double height;
        //Chiều Rộng
        public double width;
        //Tạo thuộc tính Height để truyền giá trị và lấy giá trị từ biến height
        public double Height
        {   //Lấy giá trị
            get
            {
                return height;
            }
            //Thiết lập giá trị
            set
            {
                height = value;
            }
        }
        //Tạo thuộc tính Width để truyền giá trị và lấy giá trị từ biến width
        public double Width
        {   //Lấy giá trị
            get
            {
                return width;
            }
            //Thiết lập giá trị
            set
            {
                width = value;
            }
        }
        //Constructor không có tham số, khởi tạo các biến mang giá trị mặc định là 0
        public  Rectangle()
        {
            height = 0;
            width = 0;
        }
        //Contructor có tham số, khởi tạo biến mang giá trị truyền vào khi khởi tạo Constructor
        public Rectangle(double h, double w)
        {
            height = h;
            width = w;
        }
        public override void CalculateArea()
        {
            this.Area = height * width;
        }
        public override void CalculatePerimeter()
        {
            this.Perimeter = (height * 2) + (width * 2);
        }
    }
}
