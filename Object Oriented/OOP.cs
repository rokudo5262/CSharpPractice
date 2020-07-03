using System;
using System.Text;

namespace Object_Oriented
{
    class OOP
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List();
        }
        public static void Menu()
        {
            Console.WriteLine("******************Menu**********************");
            Console.WriteLine("*01. Teacher And Student.                  *");
            Console.WriteLine("*02. Rectangle.                            *");
            Console.WriteLine("*03. Square.                               *");
            Console.WriteLine("*04. Circle.                               *");
            Console.WriteLine("*04. Triangle.                             *");
            Console.WriteLine("*00. Thoát Chương Trình.                   *");
            Console.WriteLine("********************************************");
        }
        public static void List()
        {
            int Selectfuntion;
            do
            {
                Menu();
                Console.Write("Vui Lòng Chọn Chức Năng:");
                Selectfuntion = Convert.ToInt32(Console.ReadLine());
                if (Selectfuntion < 0 || Selectfuntion > 13)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại.");
                }
            } while (Selectfuntion < 0 || Selectfuntion > 13);
            switch (Selectfuntion)
            {
                case 1:
                    TeacherAndStudent();
                    List();
                    break;
                case 2:
                    HinhChuNhat();
                    List();
                    break;
                case 3:
                    HinhVuong();
                    List();
                    break;
                case 4:
                    HinhTron();
                    List();
                    break;
                case 5:
                    List();
                    break;
                case 6:
                    List();
                    break;
                case 7:
                    List();
                    break;
                case 8:
                    List();
                    break;
                case 9:
                    List();
                    break;
                case 10:
                    List();
                    break;
                case 11:
                    List();
                    break;
                case 12:
                    List();
                    break;
                case 13:
                    List();
                    break;
                default:
                    Console.Write("Thoát Chương Trình.");
                    Console.ReadKey();
                    break;
            }
        }
        public static void TeacherAndStudent()
        {
            bool debug = false;
            Person myPerson = new Person(); //day la constructor mac dinh
            myPerson.LoiChao();
            /*tao mot doi tuong Student, thiet lap tuoi cho sinh vien nay la 21, 
              gui loi chao toi anh ta va thong bao tuoi*/
            Student myStudent = new Student(); //day la constructor mac dinh
            myStudent.SetAge(21);
            myStudent.SetChucVu("Học Sinh");
            myStudent.LoiChao();
            myStudent.ThongBaoTuoi();
            /*tao mot doi tuong Teacher, thiet lap tuoi cho giang vien nay la 30, 
             *de nghi anh ta chao va bat dau giang day*/
            Teacher myTeacher = new Teacher(); //day la constructor mac dinh
            myTeacher.SetAge(30);
            myTeacher.SetChucVu("Giáo Viên");
            myTeacher.ThongBaoTuoi();
            myTeacher.SetMonHoc("Ngữ Văn");
            myTeacher.LoiChao();
            myTeacher.GiangDay();
            if (debug)
            {
                Console.ReadLine();
            }
            Console.ReadKey();
        }
        public static void HinhChuNhat()
        {
            double chieudai;
            double chieurong;
            do
            {
                Console.Write("Nhập Vào Chiều Dài Hình Chữ Nhật:");
                chieudai = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập Vào Chiều Rộng Hình Chữ Nhật:");
                chieurong = Convert.ToInt32(Console.ReadLine());
                if (chieudai < chieurong && chieudai < 0 && chieurong < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (chieudai < chieurong && chieudai < 0 && chieurong < 0);
            Rectangle hcn = new Rectangle(chieudai,chieurong);
            //hcn.height = chieudai;
            //hcn.width = chieurong;
            hcn.CalculateArea();
            hcn.CalculatePerimeter();
            Console.WriteLine("Diện Tích Hình Chữ Nhật: {0}.", hcn.area);
            Console.WriteLine("Chu Vi Hình Chữ Nhật: {0}.", hcn.perimeter);
        }
        public static void HinhVuong()
        {
            double canh;
            do
            {
                Console.Write("Nhập Vào Cạnh Hình Vuông:");
                canh = Convert.ToInt32(Console.ReadLine());
                if (canh < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (canh < 0);
            Square hv = new Square();
            hv.side = canh;
            hv.CalculateArea();
            hv.CalculatePerimeter();
            Console.WriteLine("Diện Tích Hình Vuông: {0}.", hv.area);
            Console.WriteLine("Chu Vi Hình Vuông: {0}.", hv.perimeter);
        }
        public static void HinhTron()
        {
            double bankinh;
            do
            {
                Console.Write("Nhập Vào Bán Kính Hình Tròn:");
                bankinh = Convert.ToInt32(Console.ReadLine());
                if (bankinh < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (bankinh < 0);
            Circle ht = new Circle();
            ht.radious = bankinh;
            ht.CalculateArea();
            ht.CalculatePerimeter();
            Console.WriteLine("Diện Tích Hình Tròn: {0}.", ht.area);
            Console.WriteLine("Chu Vi Hình Tròn: {0}.", ht.perimeter);
        }
        public static void HinhTamGiac()
        {
            double canha;
            double canhb;
            double canhc;
            do
            {
                Console.Write("Nhap Cạnh A Của Tam Giác:");
                canha = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Cạnh B Của Tam Giác:");
                canhb = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Cạnh C Của Tam Giác:");
                canhc = Convert.ToInt32(Console.ReadLine());
                if (canha < 0 && canhb < 0 && canhc < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (canha < 0 && canhb < 0 && canhc < 0);
            Triangle htg = new Triangle();
            htg.CalculatePerimeter();
            htg.CalculateArea();
            Console.WriteLine("Diện Tích Hình Tròn: {0}.", htg.area);
            Console.WriteLine("Chu Vi Hình Tròn: {0}.", htg.perimeter);
        }
    }
}
