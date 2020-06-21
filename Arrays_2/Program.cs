using System;
using System.Text;

namespace Arrays_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List();
        }
        public static void Menu()
        {
            Console.WriteLine("*******************************Menu***********************************");
            Console.WriteLine("*01.Nhập Mảng 2 Chiều  .Xuất Và Tính Tổng Các Phần Tử của Mảng        *");
            Console.WriteLine("*00. Thoát Chương Trình.                                             *");
            Console.WriteLine("**********************************************************************");
        }
        public static void List()
        {
            int Selectfuntion;
            do
            {
                Menu();
                Console.Write("Vui Lòng Chọn Chức Năng:");
                Selectfuntion = Convert.ToInt32(Console.ReadLine());
                if (Selectfuntion < 0 || Selectfuntion > 10)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại.");
                }
            } while (Selectfuntion < 0 || Selectfuntion > 10);
            switch (Selectfuntion)
            {
                case 1:
                    Mang2Chieu();
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
                default:
                    Console.Write("Thoát Chương Trình");
                    Console.ReadKey();
                    break;
            }
        }
        public static void Mang2Chieu()
        {
            int[,] array = new int[3, 3];
            Console.Write("Nhap cac phan tu vao trong mang hai chieu:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("Phan tu - [{0},{1}]: ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("In Mảng Hai Chiều:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < 3; j++)
                    Console.Write("{0} ", array[i, j]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

}
