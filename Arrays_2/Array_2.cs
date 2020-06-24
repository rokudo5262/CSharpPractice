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
            Console.WriteLine("***********************************Menu*****************************************");
            Console.WriteLine("*01.Nhập Ma Trận 3x3 Phần Tử.Xuất Và Tính Tổng Các Phần Tử của Ma Trận.        *");
            Console.WriteLine("*02.Nhập Ma Trận Vuông nxn Phần Tử.Xuất Và Tính Tổng Các Phần Tử Của Ma Trận.  *");
            Console.WriteLine("*03.Nhập Ma Trận Thường nxm Phần Tử.Xuất Và Tính Tổng Các Phần Tử Của Ma Trận. *");
            Console.WriteLine("*04.Nhập Ma Trận Thường nxm Phần Tử.Tính Tổng Các Phần Tử Của Đường Chéo Chính.*");
            Console.WriteLine("*05.Nhập Ma Trận Thường nxm Phần Tử.Tính Tổng Các Phần Tử Của Đường Chéo Phụ.  *");
            Console.WriteLine("*06.Nhập Ma Trận Thường nxm Phần Tử.Tính Tổng Các Dòng Của Ma Trận.            *");
            Console.WriteLine("*07.Nhập Ma Trận Thường nxm Phần Tử.Tính Tổng Các Cột Của Ma Trận.             *");
            Console.WriteLine("*08.Nhập Ma Trận Thường nxm Phần Tử.Tính Tổng Các Dòng Và Các Cột Của Ma Trận. *");
            Console.WriteLine("*09.Nhập Ma Trận Thường nxm Phần Tử.Tìm Giá Trị Lớn Nhất Của Ma Trận.          *");
            Console.WriteLine("*10.Nhập Ma Trận Thường nxm Phần Tử.Tìm Giá Trị Bé Nhất Của Ma Trận.           *");
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
                    Mang2Chieu();
                    List();
                    break;
                case 2:
                    MaTranVuong();
                    List();
                    break;
                case 3:
                    MaTranThuong();
                    List();
                    break;
                case 4:
                    TongDuongCheoChinh();
                    List();
                    break;
                case 5:
                    TongDuongCheoPhu();
                    List();
                    break;
                case 6:
                    TimTongCacDong();
                    List();
                    break;
                case 7:
                    TimTongCacCot();
                    List();
                    break;
                case 8:
                    TimTongCacDongVaCacCotCuaMaTran();
                    List();
                    break;
                case 9:
                    TimGiaTriLonNhat();
                    List();
                    break;
                case 10:
                    TimGiaTriBeNhat();
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
            Console.WriteLine("Tổng Của Ma Trận Vuông Là {0}", tong);
            Console.ReadKey();
        }
        public static void NhapMaTranVuong(int n, int[,] array)
        {
            Console.WriteLine("Nhập Các Phần Tử Vào Ma Trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Phan Tử - [{0},{1}]: ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public static void XuatMaTranVuong(int n, int[,] array)
        {
            Console.WriteLine("Xuất Ma Trận:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
            }
        }
        public static void TongMaTranVuong(int n, int[,] array, int tong)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    tong += array[i, j];
                }
            }
            Console.WriteLine("Tổng Của Mảng Hai Chiều Là {0}", tong);
        }
        public static void MaTranVuong()
        {

            int tong = 0;
            Console.Write("Nhập n Phần Tử Vào Mảng:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, n];
            NhapMaTranVuong(n, array);
            XuatMaTranVuong(n, array);
            TongMaTranVuong(n, array, tong);
            Console.ReadKey();
        }
        public static void NhapMaTranThuong(int n, int m, int[,] array)
        {
            Console.WriteLine("Nhập Các Phần Tử Vào Ma Trận:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write("Phan Tử - [{0},{1}]: ", i, j);
                    array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
        public static void XuatMaTranThuong(int n, int m, int[,] array)
        {
            Console.WriteLine("Xuất Ma Trận:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
                for (int j = 0; j < m; j++)
                {
                    Console.Write("{0} ", array[i, j]);
                }
            }
            Console.WriteLine();
        }
        public static void TongMaTranThuong(int n, int m, int[,] array, int tong)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    tong += array[i, j];
                }
            }
            Console.WriteLine("Tổng Của Mảng Hai Chiều Là {0}", tong);
            Console.WriteLine();
        }
        public static void MaTranThuong()
        {
            int tong = 0;
            Console.Write("Nhập n Là Chiều Dài Ma Trận:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập m Là Chiều Rộng Ma Trận:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, m];
            NhapMaTranThuong(n, m, array);
            XuatMaTranThuong(n, m, array);
            TongMaTranThuong(n, m, array, tong);
            Console.ReadKey();
        }
        public static void TongDuongCheoChinh()
        {
            int tongduongcheochinh = 0;
            Console.Write("Nhập n Là Chiều Dài Ma Trận:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập m Là Chiều Rộng Ma Trận:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, m];
            NhapMaTranThuong(n, m, array);
            XuatMaTranThuong(n, m, array);
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        tongduongcheochinh += array[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng Đường Chéo Chính Của Ma Trận Là {0}", tongduongcheochinh);
            Console.ReadKey();
        }
        public static void TongDuongCheoPhu()
        {
            int tongduongcheophu = 0;
            Console.Write("Nhập n Là Chiều Dài Ma Trận:");
            int n = Convert.ToInt32(Console.ReadLine());
            int m = n;
            int[,] array = new int[100, 100];
            NhapMaTranThuong(n, m, array);
            XuatMaTranThuong(n, m, array);
            for (int i = 0; i < n; i++)
            {
                m = m - 1;
                for (int j = 0; j < n; j++)
                {
                    if (j == m)
                    {
                        tongduongcheophu = tongduongcheophu + array[i, j];
                    }
                }
            }
            Console.WriteLine("Tổng Đường Chéo Phụ Của Ma Trận Là {0}", tongduongcheophu);
            Console.ReadKey();
        }
        public static void TimTongCacDongVaCacCotCuaMaTran()
        {
            int[] TongCot = new int[100];
            int[] TongHang = new int[100];
            Console.Write("Nhập n Là Chiều Dài Ma Trận:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập m Là Chiều Rộng Ma Trận:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[100, 100];
            NhapMaTranThuong(n, m, array);
            XuatMaTranThuong(n, m, array);
            /* tinh tong cac hang */
            for (int i = 0; i < n; i++)
            {
                TongHang[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    TongHang[i] = TongHang[i] + array[i, j];
                }
            }
            /* tinh tong cac cot */
            for (int i = 0; i < n; i++)
            {
                TongCot[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    TongCot[i] = TongCot[i] + array[j, i];
                }
            }

            Console.Write("Tong cua cac hang va cac cot trong ma tran la:\n");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0}  ", array[i, j]);
                }
                Console.Write("{0}    ", TongHang[i]);
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < n; j++)
            {
                Console.Write("{0}   ", TongCot[j]);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void TimTongCacDong()
        {
            int[] TongHang = new int[100];
            Console.Write("Nhập n Là Chiều Dài Ma Trận:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập m Là Chiều Rộng Ma Trận:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[100, 100];
            NhapMaTranThuong(n, m, array);
            XuatMaTranThuong(n, m, array);
            for (int i = 0; i < n; i++)
            {
                TongHang[i] = 0;
                for (int j = 0; j < n; j++)
                {
                    TongHang[i] = TongHang[i] + array[i, j];
                }
            }
        }
        public static void TimTongCacCot()
        {
            int[] TongCot = new int[10];
            Console.Write("Nhập n Là Chiều Dài Ma Trận:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập m Là Chiều Rộng Ma Trận:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[n, m];
            NhapMaTranThuong(n, m, array);
            XuatMaTranThuong(n, m, array);
            /* tinh tong cac cot */
            for (int i = 0; i < n; i++)
            {
                TongCot[i] = 0;
                for (int j = 0; j < m; j++)
                {
                    TongCot[i] = TongCot[i] + array[j, i];
                }
            }

            for (int j = 0; j < m; j++)
            {
                Console.Write("{0} ", TongCot[j]);
            }
            Console.WriteLine();
        }
        public static void TimGiaTriLonNhat()
        {
            Console.Write("Nhập n Là Chiều Dài Ma Trận:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập m Là Chiều Rộng Ma Trận:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[100, 100];
            NhapMaTranThuong(n, m, array);
            XuatMaTranThuong(n, m, array);
            Console.WriteLine();
            int max = array[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; i++)
                {
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                    }
                }
            }
            Console.WriteLine("Dòng Có Giá Trị Lớn Nhất Của Ma Trận Là : {0}", max);
        }
        public static void TimGiaTriBeNhat()
        {
            Console.Write("Nhập n Là Chiều Dài Ma Trận:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập m Là Chiều Rộng Ma Trận:");
            int m = Convert.ToInt32(Console.ReadLine());
            int[,] array = new int[100, 100];
            NhapMaTranThuong(n, m, array);
            XuatMaTranThuong(n, m, array);
            Console.WriteLine();
            int min = array[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; i++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            Console.WriteLine("Giá Trị Bé Nhất Của Ma Trận Là : {0}", min);
        }
    }

}
