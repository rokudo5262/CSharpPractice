using System;
using System.Text;

namespace Recursive
{
    class Recursive
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List();
        }
        public static void Menu()
        {
            Console.WriteLine("***********************************Menu*****************************************");
            Console.WriteLine("*01.Nhập Và Xuất Chuỗi.                                                        *");
            Console.WriteLine("********************************************************************************");
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
                    Console.Write("Vui Lòng Chọn Chức Năng:");
                    int a = Convert.ToInt32(Console.ReadLine());
                    int f= tinhgiaithua(a);
                    List();
                    break;
                case 2:
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
        static int tinhgiaithua(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * tinhgiaithua(i - 1);
        }
        static int day_fibonaci(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            if (i == 1)
            {
                return 1;
            }
            return day_fibonaci(i - 1) + day_fibonaci(i - 2);
        }
    }
}
