using System;
using System.Text;

namespace String
{
    class String
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
            Console.WriteLine("*02.Nhập Và Tìm Độ Dài Chuổi                                                   *");
            Console.WriteLine("*03.Nhập Và Xuất Từng Kí Tự Của Chuỗi.                                         *");
            Console.WriteLine("*04.Nhập Và Xuất Chuỗi.                                                        *");
            Console.WriteLine("*05.Nhập Và Xuất Chuỗi.                                                        *");
            Console.WriteLine("*00. Thoát Chương Trình.                                                       *");
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
                if (Selectfuntion < 0 || Selectfuntion > 10)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại.");
                }
            } while (Selectfuntion < 0 || Selectfuntion > 10);
            switch (Selectfuntion)
            {
                case 1:
                    NhapXuatChuoi();
                    List();
                    break;
                case 2:
                    TimDoDaiChuoi();
                    List();
                    break;
                case 3:
                    XuatTungPhanTuCuaChuoi();
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
        public static void NhapXuatChuoi()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.Write("Ban vua nhap chuoi: {0}", str);
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void TimDoDaiChuoi()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.Write("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.WriteLine();
            int length = 0;
            foreach (char chr in str)
            {
                length += 1;
            }
            Console.WriteLine("Độ Dài Chuổi Là: {0}", length);
            Console.ReadKey();
        }
        public static void XuatTungPhanTuCuaChuoi()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.Write("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.Write("In Từng Ký Tự Trong Chuổi Ban Đầu: ");
            int length = 0;
            while (length <= str.Length - 1)
            {
                Console.Write("{0} ", str[length]);
                length++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }

}
