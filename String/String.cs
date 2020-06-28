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
            Console.WriteLine("*04.Nhập Chuỗi.Đếm Khoảng Trắng Trong Một Chuỗi.                               *");
            Console.WriteLine("*05.Nhập Chuỗi.Sắp Xếp Chuỗi ng Trong Một Chuỗi.                               *");
            Console.WriteLine("*05.Nhập Chuỗi.Sắp Xếp Chuỗi Theo Chiều Tăng Dần.                              *");
            Console.WriteLine("*06.Nhập Chuỗi.Sắp Xếp Chuỗi Theo Chiều Giảm Dần.                              *");
            Console.WriteLine("*07.Nhập Chuỗi.Đếm Số Nguyên Âm Và Phụ Âm.                                     *");
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
                    DemKhoangTrangTrongChuoi();
                    List();
                    break;
                case 5:
                    SapXepChuoiTangDan();
                    List();
                    break;
                case 6:
                    SapXepChuoiGiamDan();
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
                    Console.Write("Thoát Chương Trình.");
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
        public static void DemKhoangTrangTrongChuoi()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.Write("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.Write("In Từng Ký Tự Trong Chuổi Ban Đầu: ");
            int length = 0;
            int bien_dem = 1;
            /* lap toi phan cuoi cua chuoi */
            while (length <= str.Length - 1)
            {
                /* kiem tra xem ky tu hien tai co phai la khoang trang 
                 * hay la ky tu new line hay ky tu tab */
                if (str[length] == ' ' || str[length] == '\n' || str[length] == '\t')
                {
                    bien_dem++;
                }
                length++;
            }
            Console.WriteLine("Tong so tu co trong chuoi tren la: {0}", bien_dem);
        }
        public static void XuatChuoiChieuDaoNguoc()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.Write("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.Write("In Từng Ký Tự Trong Chuổi Ban Đầu: ");
            int l = str.Length - 1;
            Console.WriteLine("In Các Ký Tự Trong Chuỗi Theo Chiều Đão Ngược:");
            while (l >= 0)
            {
                Console.Write("{0} ", str[l]);
                l--;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void SapXepChuoiTangDan()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.WriteLine("In Từng Ký Tự Trong Chuổi Ban Đầu: ");
            int l = str.Length;
            char ch;
            char[] array = str.ToCharArray(0, l);
            for (int i = 1; i < l; i++)
            {
                for (int j = 0; j < l - i; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        ch = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = ch;
                    }
                }
            }
            Console.WriteLine("Sau khi Sắp Xếp, Chuỗi Có Dạng:");
            foreach (char c in array)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void SapXepChuoiGiamDan()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.WriteLine("In Từng Ký Tự Trong Chuổi Ban Đầu: ");
            int l = str.Length;
            char ch;
            char[] array = str.ToCharArray(0, l);
            for (int i = 1; i < l; i++)
            {
                for (int j = 0; j < l - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        ch = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = ch;
                    }
                }
            }
            Console.WriteLine("Sau khi Sắp Xếp, Chuỗi Có Dạng:");
            foreach (char c in array)
            {
                ch = c;
                Console.Write("{0} ", ch);
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void DemNguyenAmPhuAm()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.WriteLine("In Từng Ký Tự Trong Chuổi Ban Đầu: ");
        }
        public static void PhanLoaiPhanTu()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.WriteLine("In Từng Ký Tự Trong Chuổi Ban Đầu: ");
        }
    }

}
