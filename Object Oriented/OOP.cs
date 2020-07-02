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
            Console.WriteLine("*01. Teacher And Student                   *");
            Console.WriteLine("*02. Rectangle                             *");
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
                    List();
                    break;
                case 4:
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
            Rectangle hcn = new Rectangle();
            hcn.height = chieudai;
            hcn.width = chieurong;
            hcn.CalculateArea();
            hcn.CalculatePerimeter();
            Console.WriteLine("Diện Tích : {0}.", hcn.area);
        }

    }
}
