﻿using System;
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
            Console.WriteLine("*******************************Menu***********************************");
            Console.WriteLine("*01. Nhập 10 Phần Tử.Tính Tổng Và Xuất Các Phần Tử Của Mảng.         *");
            Console.WriteLine("*02. Nhập N Phần Tữ.Đếm số lần xuất hiện của từng phần tử trong mảng.*");
            Console.WriteLine("*03. Nhập N Phần Tữ.Chia mảng thành mảng chẵn, mảng lẻ.              *");
            Console.WriteLine("*04. Nhập N Phần Tữ.Sắp Xếp Mảng Tăng Dần.                           *");
            Console.WriteLine("*05. Nhập N Phần Tữ.Sắp Xếp Mảng Giảm Dần.                           *");
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
                    Mang1Chieu10PhanTu();
                    List();
                    break;
                case 2:
                    DemSOLanXuatHienCuaPhanTu();
                    List();
                    break;
                case 3:
                    ChiaMangChanLe();
                    List();
                    break;
                case 4:
                    SapXepMangTangDan();
                    List();
                    break;
                case 5:
                    SapXepMangGiamDan();
                    List();
                    break;
                case 6:
                    TimPhanTuLonNhatVaBeNhatTrongMang();
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
                Console.Write("Phan Tử - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("In Các Phần Tử Của Mảng: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", array[i]);
                tong += array[i];
            }
            Console.WriteLine("Tong Các Phần Tử Của Mảng Là: {0}",tong);
            Console.ReadKey();
        }
        public static void Mang1ChieuNPhanTu()
        {
            int n;
            int tong = 0;
            int[] array = new int[100];
            Console.Write("Nhập n Phần Tử Vào Mảng:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập {0} Phần Tử Vào Trong Mảng:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phần Tử - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Nhập 10 Phần Tử Của Mảng:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan Tử - {0} : ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("In Các Phần Tử Của Mảng: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", array[i]);
                tong += array[i];
            }
            Console.WriteLine("Tong Các Phần Tử Của Mảng Là: {0}", tong);
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
            int[] array1 = new int[100];
            int[] array2 = new int[100]; // mang chua cac phan tu chan
            int[] array3 = new int[100]; // mang chua cac phan tu le
            int tong = 0;
            int j=0;
            int k=0;
            int n;
            Console.Write("Nhập n Phần Tử Vào Mảng:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập {0} Phần Tử Vào Trong Mảng:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan Tử - {0}: ", i);
                array1[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
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
            Console.WriteLine("In Các Phần Tử Của Mảng: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array1[i]);
                tong += array1[i];
            }
            Console.WriteLine("Tong Các Phần Tử Của Mảng Là: {0}", tong);
            Console.WriteLine("Các phần Tử Chẳn Bao Gồm:");
            for (int i = 0; i < j; i++)
            {
                Console.Write("{0} ", array2[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Các Phần Tử Lẻ Bao Gồm:");
            for (int i = 0; i < k; i++)
            {
                Console.Write("{0} ", array3[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void SapXepMangTangDan()
        {
            int[] array = new int[100];
            int tong = 0;
            int bientrunggian;
            int n;
            Console.Write("Nhập n Phần Tử Vào Mảng:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập {0} Phần Tử Vào Trong Mảng:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan Tử - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("In Các Phần Tử Của Mảng: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array[i]);
                tong += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Tổng Các Phần Tử Của Mảng Là: {0}", tong);
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] < array[i])
                    {
                        //cach trao doi gia tri
                        bientrunggian = array[i];
                        array[i] = array[j];
                        array[j] = bientrunggian;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("In Các Phần Tử Của Mảng Theo Thứ Tự Tăng Dần");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void SapXepMangGiamDan()
        {
            int[] array = new int[100];
            int bientrunggian;
            int tong = 0;
            int n;
            Console.Write("Nhập n Phần Tử Vào Mảng:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập {0} Phần Tử Vào Trong Mảng:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan Tử - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("In Các Phần Tử Của Mảng: ");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array[i]);
                tong += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Tổng Các Phần Tử Của Mảng Là: {0}", tong);
            for (int i = 0; i < n; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (array[j] > array[i])
                    {
                        //cach trao doi gia tri
                        bientrunggian = array[i];
                        array[i] = array[j];
                        array[j] = bientrunggian;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("In Các Phần Tử Của Mảng Theo Thứ Tự Giảm Dần");
            for (int i = 0; i < n; i++)
            {
                Console.Write("{0}  ", array[i]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void TimPhanTuLonNhatVaBeNhatTrongMang()
        {
            int[] array = new int[100];
            int tong = 0;
            int n;
            int max = array[0];
            int min = array[0];
            Console.Write("Nhập n Phần Tử Vào Mảng:");
            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhập {0} Phần Tử Vào Trong Mảng:", n);
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan Tử - {0}: ", i);
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("In Các Phần Tử Của Mảng: ");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0}  ", array[i]);
                tong += array[i];
            }
            Console.WriteLine();
            Console.WriteLine("Tổng Các Phần Tử Của Mảng Là: {0}", tong);
            for (int i = 1; i < n; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Phấn Tử Lớn Nhất Trong Mảng Là: {0}", max);
            Console.WriteLine("Phần Tử Nhỏ nhất trong Mảng là: {0}", min);
            Console.ReadKey();
        }
    }
}