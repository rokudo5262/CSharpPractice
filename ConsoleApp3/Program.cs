using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List();
        }
        public static void Menu()
        {      
            Console.WriteLine("*********************************Menu********************************");
            Console.WriteLine("*01. tính tổng 10 Số Từ 1 Đến 10 Và Xuất Ra Dãy Số Đó.              *");
            Console.WriteLine("*02. Tính Tổng n Số Tự Nhiên Nhập Từ Bàn Phím Và Xuất Ra Dãy Số Đó .*");
            Console.WriteLine("*02. Tính Tổng n Số Chẳn Nhập Từ Bàn Phím Và Xuất Ra Dãy Số Đó.     *");
            Console.WriteLine("*02. Tính Tổng n Số Lẽ Nhập Từ Bàn Phím Và Xuất Ra Dãy Số Đó.       *");
            Console.WriteLine("*00. Thoát Chương Trình.                                            *");
            Console.WriteLine("*********************************************************************");
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
                    TinhTong10So();
                    Console.ReadKey();
                    List();
                    break;
                case 2:
                    TinhTongNSoTuNhien();
                    Console.ReadKey();
                    List();
                    break;
                case 3:
                    TinhTongNSoLe();
                    Console.ReadKey();
                    List();
                    break;
                case 4:
                    TinhTongNSoChan();
                    Console.ReadKey();
                    List();
                    break;
                case 5:
                    Console.Write("Chức Năng Đang Cập Nhật");
                    Console.ReadKey();
                    List();
                    break;
                case 6:
                    Console.Write("Chức Năng Đang Cập Nhật");
                    Console.ReadKey();
                    List();
                    break;
                case 7:
                    Console.Write("Chức Năng Đang Cập Nhật");
                    Console.ReadKey();
                    List();
                    break;
                case 8:
                    Console.Write("Chức Năng Đang Cập Nhật");
                    Console.ReadKey();
                    List();
                    break;
                case 9:
                    Console.Write("Chức Năng Đang Cập Nhật");
                    Console.ReadKey();
                    List();
                    break;
                case 10:
                    Console.Write("Chức Năng Đang Cập Nhật");
                    Console.ReadKey();
                    List();
                    break;
                default:
                    Console.Write("Thoát Chương Trình");
                    Console.ReadKey();
                    break;
            }
        }
        public static void TinhTong10So()
        {
            int tong = 0;
            Console.WriteLine("10 Số Tự Nhiên Là:");
            for (int i = 1; i <= 10; i++)
            {
                tong = tong + i;
                Console.Write("{0} ", i);
            }
            Console.WriteLine("Tổng Của 10 Số trên Là: {0}", tong);
        }
        public static void TinhTongNSoTuNhien()
        {
            int n;
            int tong=0;
            Console.Write("Nhập n Các Số:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N Số Lẻ Là:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                tong = tong + i;
            }
            Console.WriteLine();
            Console.WriteLine("Tổng {0} Số Tự Nhiên Là: {1}",n, tong);
        }
        public static void TinhTongNSoChan()
        {
        }
        public static void TinhTongNSoLe()
        {
        }
    }
}
