using System;
using System.Text;

namespace Arrays_2
{
    class Array_2
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
                    Mang2ChieuNPhanTu();
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
            int tong = 0;
            Console.WriteLine("Nhập Các Phần Tử Vào Trong Mảng Hai Chiều:");
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
                {
                    Console.Write("{0} ", array[i, j]);
                    tong += array[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tổng Của Mảng Hai Chiều Là {0}",tong); 
            Console.ReadKey();
        }
        public static void MaTranVuong()
        {
            int[,] array = new int[100, 100];
            int tong = 0;
            Console.Write("Nhập n Phần Tử Vào Mảng:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập Các Phần Tử Vào Trong Mảng Hai Chiều:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
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
                {
                    Console.Write("{0} ", array[i, j]);
                    tong += array[i, j];
                }
            }
            Console.WriteLine();
            Console.WriteLine("Tổng Của Mảng Hai Chiều Là {0}", tong);
            Console.ReadKey();
        }
    }

}
