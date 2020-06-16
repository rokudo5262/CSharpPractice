using System;
using System.Text;

namespace Arrays
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
            Console.WriteLine("****************Menu************************");
            Console.WriteLine("*01. Nhập 10 Phần Tử.Tính Tổng Và Xuất Các Phần Tử Của Mảng.*");
            Console.WriteLine("*02. Nhập N Phần Tữ. *");
            Console.WriteLine("*03. Doi Do C Thanh Do F va do K           *");
            Console.WriteLine("*04. Nhap Vao 3 So Trinh Trung Binh        *");
            Console.WriteLine("*05. Tinh Chu Vi Dien Tich Hinh Chu Nhat   *");
            Console.WriteLine("*06. Tinh Chu Vi Dien Tich Hinh Chu Nhat   *");
            Console.WriteLine("*07. Tinh Chu Vi Dien Tich Hinh Vuong      *");
            Console.WriteLine("*08. Tinh Chu Vi Dien Tich Hinh Thoi       *");
            Console.WriteLine("*09. Tinh Chu Vi Dien Tich Hinh Tron       *");
            Console.WriteLine("*10. Tinh Chu Vi Dien Tich Hinh Cau        *");
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
                if (Selectfuntion < 0 || Selectfuntion > 10)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại.");
                }
            } while (Selectfuntion < 0 || Selectfuntion > 10);
            switch (Selectfuntion)
            {
                case 1:
                    Mang1Chieu10PhanTu();
                    List();
                    break;
                case 2:
                    DemSOLanXuatHienCuaPhanTu();
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
        public static void Mang1Chieu10PhanTu()
        {
            int tong = 0;
            int[] array = new int[10];
            Console.WriteLine("Nhập 10 Phần Tử Của Mảng:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Phan tu - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("In Các Phần Tử Của Mảng: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", array[i]);
                tong += array[i];
            }
            Console.WriteLine("Tong Các Phần Tử Của Mãng Là: {0}",tong);
            Console.ReadKey();
        }
        public static void DemSOLanXuatHienCuaPhanTu()
        {
            int[] array1 = new int[100];
            int[] fr1 = new int[100];
            int n;
            int bien_dem;
            Console.Write("Nhập Số Phần Tử Cần Lưu Giử Trong Mảng: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap {0} Phần Tử Vào Trong Mảng:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần Tử - {0}: ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
                fr1[i] = -1;
            }
            for (int i = 0; i < n; i++)
            {
                bien_dem = 1;
                for (int j = i + 1; j < n; j++)
                {
                    if (array1[i] == array1[j])
                    {
                        bien_dem++;
                        fr1[j] = 0;
                    }
                }
                if (fr1[i] != 0)
                {
                    fr1[i] = bien_dem;
                }
            }
            Console.WriteLine("Tần Suất Xuất Hiện Của Từng Phần Tử Trong Mảng Là:");
            for (int i = 0; i < n; i++)
            {
                if (fr1[i] != 0)
                {
                    Console.WriteLine("Phần Tử {0} Xuất Hiện {1} Lần.", array1[i], fr1[i]);
                }
            }
            Console.ReadKey();
        }
        public static void ChiaMangChanLe()
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10]; // mang chua cac phan tu chan
            int[] array3 = new int[10]; // mang chua cac phan tu le
            int i, j = 0, k = 0, n;
            Console.Write("Nhap so phan tu can luu giu trong mang: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap {0} phan tu vao trong mang:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("Phan tu - {0}: ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (i = 0; i < n; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    array2[j] = array1[i];
                    j++;
                }
                else
                {
                    array3[k] = array1[i];
                    k++;
                }
            }
            Console.WriteLine("Cac phan tu chan la:");
            for (i = 0; i < j; i++)
            {
                Console.Write("{0} ", array2[i]);
            }
            Console.WriteLine("Cac phan tu le la:");
            for (i = 0; i < k; i++)
            {
                Console.Write("{0} ", array3[i]);
            }
            Console.Write("\n\n");

            Console.ReadKey();
        }
    }
}
