using System;
using System.Text;

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
            Console.WriteLine("*03. Tính Tổng n Số Chẳn Nhập Từ Bàn Phím Và Xuất Ra Dãy Số Đó.     *");
            Console.WriteLine("*04. Tính Tổng n Số Lẽ Nhập Từ Bàn Phím Và Xuất Ra Dãy Số Đó.       *");
            Console.WriteLine("*05. Nhập Vào 1 Số. Kiểm Tra Số Đó Có Phải Số Nguyên Tố Không       *");
            Console.WriteLine("*05. Nhập Vào n Số Hàng. Vẽ Tam Giác Sao Với Số Hàng Vừa Nhập.      *");
            Console.WriteLine("*02. Tính Tổng n Số Từ Bàn Phím Và Xuất Ra Dãy Fibonacci Số Đó .*");
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
                    List();
                    break;
                case 2:
                    TinhTongNSoTuNhien();
                    List();
                    break;
                case 3:
                    TinhTongNSoLe();
                    List();
                    break;
                case 4:
                    TinhTongNSoChan();
                    List();
                    break;
                case 5:
                    KiemTraSoNguyenTo();
                    List();
                    break;
                case 6:
                    VeTamGiacSao();
                    List();
                    break;
                case 7:
                    Fibonacci();
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
            Console.ReadKey();
        }
        public static void TinhTongNSoTuNhien()
        {
            int n;
            int tong=0;
            Console.Write("Nhập n Các Số:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N Số Tự Nhiên Là:");
            for (int i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                tong = tong + i;
            }
            Console.WriteLine();
            Console.WriteLine("Tổng {0} Số Tự Nhiên Là: {1}",n, tong);
            Console.ReadKey();
        }
        public static void TinhTongNSoChan()
        {
            int n;
            int tong = 0;
            Console.Write("Nhập n Các Số:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N Số Lẻ Là:");
            for (int i = 0; i <= n; i++)
            {
                Console.Write("{0} ", 2*i);
                tong = tong + 2*i;
            }
            Console.WriteLine();
            Console.WriteLine("Tổng {0} Số Lẻ Là: {1}", n, tong);
            Console.ReadKey();

        }
        public static void TinhTongNSoLe()
        {
            int n;
            int tong = 0;
            Console.Write("Nhập n Các Số:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("N Số Chẳn Là:");
            for (int i = 1;i <= n; i++)
            {
                Console.Write("{0} ", 2*i-1);
                tong = tong + 2 * i - 1;
            }
            Console.WriteLine();
            Console.WriteLine("Tổng {0} Số Chằn Là: {1}", n, tong);
            Console.ReadKey();
        }
        public static void KiemTraSoNguyenTo()
        {
            int n;
            Console.Write("Nhập vào một số n = ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n==1 && n==0)
            {
                Console.WriteLine("{0} không phải số nguyên tố", n);
                return;
            }
            else
                for (int i = 2; i <= n; i++)
                {
                if (n % i == 0)
                {
                    Console.WriteLine("{0} không phải số nguyên tố", n);
                    return;
                }
                else
                { 
                    Console.WriteLine("{0} là số nguyên tố", n);
                    return;
                }               
            }
        }
        public static void VeTamGiacSao()
         {
            int n;
            Console.Write("Nhâp Vào N Số Hàng: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        public static void Fibonacci()
        {
            int prv = 0;
            int pre = 1;
            int trm;
            int tong = 0;
            int n;
            Console.Write("Nhap Vào n Các Số: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Day Fibonacci gồm {0} phần tử Là:", n);
            Console.Write("{0} {1}", prv, pre);
            for (int i = 3; i <= n; i++)
            {

                trm = prv + pre;
                Console.Write(" {0}", trm);
                prv = pre;
                pre = trm;
                tong = 1 + tong + trm;
            }
            Console.WriteLine();
            Console.WriteLine("Tổng {0} Số Fibonacci Của Dãy Số Là: {1}",n,tong);
            Console.ReadKey();
        }
    }
}
