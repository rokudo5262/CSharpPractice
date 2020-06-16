using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp2
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
            Console.WriteLine("*********************************Menu***************************************");
            Console.WriteLine("*01. Nhập Vào 2 Số Nguyên.So Sánh 2 Số đó.                                 *");
            Console.WriteLine("*02. Nhập Vào 3 Số Nguyên.So Sánh 3 Số đó.                                 *");
            Console.WriteLine("*03. Nhập Vào 1 Số Nguyên Kiểm Tra Số Nguyên Đó Âm Hay Dương.              *");
            Console.WriteLine("*04. Nhập Vào 1 Số Nguyên Kiểm Tra Số Nguyên Đó Chẳn Hay Lẻ.               *"); 
            Console.WriteLine("*05. Nhập Vào 1 Năm kiểm tra Xem Năm Đó Có Phải Năm Nhuận Hay Không.       *");
            Console.WriteLine("*06. Nhập Vào 1 Tháng Xuất Ra Chữ Của Tháng Đó.                            *");
            Console.WriteLine("*07. Nhập Vào 1 Ngày Xuất Ra Chữ Của Ngày Đó.                              *");
            Console.WriteLine("*08. Nhập Vào Điểm Các Môn Tính Trung Bình Các Môn Và Xếp Loại Học Sinh Đó.*");
            Console.WriteLine("*09. Giải Phương Trình Bật 1: Ax+B=0.                                      *");
            Console.WriteLine("*10. Giải Phương Trình Bật 2: Ax^2+Bx+C=0.                                 *");
            Console.WriteLine("*11. Giải Phương Trình Bật 3: Ax^3+Bx^2+CX=D=0.                            *");
            Console.WriteLine("*12. Xuất Bản Cửu Chương.                                                  *");
            Console.WriteLine("*00. Thoát Chương Trình.                                                   *");
            Console.WriteLine("****************************************************************************");
        }
        public static void List()
        {
            int Selectfuntion;
            do
            {
                Menu();
                Console.Write("Vui Lòng Chọn 1 Chức Năng:");
                Selectfuntion = Convert.ToInt32(Console.ReadLine());
                if (Selectfuntion < 0 || Selectfuntion > 12)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại.");
                }
            } while (Selectfuntion < 0 || Selectfuntion > 12);
            switch (Selectfuntion)
            {
                case 1:                
                    SoSanhHaiSoNguyen();
                    List();
                    break;
                case 2:
                    SoSanhBaSoNguyen();
                    List();
                    break;
                case 3:            
                    KiemTraNguyenAmNguyenDuong();
                    List();
                    break;
                case 4:
                    KiemtraSoChanLe();
                    List();
                    break;
                case 5:
                    KiemTraNamNhuan();
                    List();
                    break;
                case 6:         
                    XuatChuCuaThangNhap();
                    List();
                    break;
                case 7:
                    XuatChuCuaNgayNhap();
                    List();
                    break;
                case 8:
                    TinhTrungBinhVaXepLoai5Mon();
                    List();
                    break;
                case 9:
                    GiaiPhuongTrinhBat1();
                    List();
                    break;
                case 10:
                    GiaiPhuongTrinhBat2();
                    List();
                    break;
                case 11:
                    GiaiPhuongTrinhBat3();
                    List();
                    break;
                case 12:
                    BangCuuChuong();
                    Console.ReadKey();
                    List();
                    break;
                default:
                    Console.Write("Thoát Chương Trình");
                    Console.ReadKey();
                    break;
            }
        }
        public static void SoSanhHaiSoNguyen()
        {
            int a;
            Console.Write("Nhập Số Nguyên A:");
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            Console.Write("Nhập Số Nguyên B:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("a={0} Bằng b={1}", a, b);
            }
            else if (a > b)
            {
                Console.WriteLine("a={0} Lớn Hơn b={1}", a, b);
            }
            else
            {
                Console.WriteLine("a={0} Bé Hơn b={1}", a, b);
            }
            Console.ReadKey();
        }
        public static void SoSanhBaSoNguyen()
        {
            int a;
            Console.Write("Nhập Số Nguyên A:");
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            Console.Write("Nhập Số Nguyên B:");
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.Write("Nhập Số Nguyên C:");
            c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if (b > max)
            {
                max = b;
            }
            if (c > max)
            { 
            max = c;
            }
            Console.WriteLine("Số Lớn Nhất Là {0} ", max);
            int min = a;
            if (b < min)
            {
                min = b;
            }
            if (c < min)
            {
                min = c;
            }
            Console.WriteLine("Số Bé Nhất Là {0} ", min);
            Console.ReadKey();
        }
        public static void KiemTraNguyenAmNguyenDuong()
        {
            int a;
            Console.Write("Nhập Số Nguyên A:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A = {0} không Phải Là Số Nguyên Dương Cũng Không Phải Số Nguyên Âm", a);
            }
            else if (a < 0)
            {
                Console.WriteLine("A = {0} là Số Nguyên Âm", a);
            }
            else
            {
                Console.WriteLine("A = {0} Là Số Nguyên Dương", a);
            }
            Console.ReadKey();
        }
        public static void KiemtraSoChanLe()
        {
            int a;
            Console.Write("Nhập Số Nguyên A:");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0)
            {
                Console.WriteLine("A = {0} Là Số Chẳn", a);
            }
            else
            {
                Console.WriteLine("A = {0} Là Số Lẻ", a);
            }
            Console.ReadKey();
        }
        public static void KiemTraNamNhuan()
        {
            int nam;
            do
            {
                Console.Write("Nhap Vào 1 Năm :");
                nam = Convert.ToInt32(Console.ReadLine());
                if (nam <= 0)
                {
                    Console.Write("Nhập Sai.Vui Lòng Nhập Lại:");
                }
            } while (nam <= 0);
            if (nam % 400 == 0)
            {
                Console.WriteLine("{0} La Năm Nhuận", nam);
            }
            else
            {
                if (nam % 100 == 0)
                {
                    Console.WriteLine("{0} Không Phải Là Năm Nhuận", nam);
                }
                else
                {
                    if (nam % 4 == 0)
                    {
                        Console.WriteLine("{0} Là Năm Nhuận", nam);
                    }
                    else
                    {
                        Console.WriteLine("{0} Không Phải Là Năm Nhuận", nam);
                    }
                }
            }
            Console.ReadKey();
        }
        public static void XuatChuCuaThangNhap()
        {
            int month;
            do
            {
                Console.Write("Nhập Vào 1 Tháng :");
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại");
                }
            } while (month < 1 || month > 12);
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Febuary");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("March");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("April");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("June");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("July");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("August");
                    Console.ReadKey();
                    break;
                case 8:
                    Console.WriteLine("December");
                    Console.ReadKey();
                    break;
                case 9:
                    Console.WriteLine("October");
                    Console.ReadKey();
                    break;
                case 10:
                    Console.WriteLine("December");
                    Console.ReadKey();
                    break;
                case 11:
                    Console.WriteLine("Movember");
                    Console.ReadKey();
                    break;
                case 12:
                    Console.WriteLine("January");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Tháng Bạn Nhập Không Đúng.");
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
        public static void XuatChuCuaNgayNhap()
        {
            int day;
            do
            {
                Console.Write("Nhap Vao 1 Ngay :");
                day = Convert.ToInt32(Console.ReadLine());
                if (day < 1 || day > 7)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại");
                }
            } while (day < 1 || day > 7);
            switch (day)
            {
                case 1:
                    Console.WriteLine("Sunday");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Monday");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Tuesday");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Wendnesday");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Thursday");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Friday");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Satuday");
                    Console.ReadKey();
                    break;
            }
            Console.ReadKey();
        }
        public static void TinhTrungBinhVaXepLoai5Mon()
        {
            int toan;
            int van;
            int anh;
            int ly;
            int hoa;
            do
            {
                Console.Write("Nhập Điểm Môn Toán:");
                toan = Convert.ToInt32(Console.ReadLine());
            } while (toan < 0 || toan > 10);
            do
            {
                Console.Write("Nhập Điểm Môn Văn:");
                van = Convert.ToInt32(Console.ReadLine());
            } while (van < 0 || van > 10);
            do
            {
                Console.Write("Nhập Điểm Môn Anh:");
                anh = Convert.ToInt32(Console.ReadLine());
            } while (anh < 0 || anh > 10);
            do
            {
                Console.Write("Nhập Điểm Môn Lý:");
                ly = Convert.ToInt32(Console.ReadLine());
            } while (ly < 0 || ly > 10);
            do
            {
                Console.Write("Nhập Điểm Môn Hóa:");
                hoa = Convert.ToInt32(Console.ReadLine());
            } while (hoa < 0 || hoa > 10);
            double DiemTrungBinh = (toan + ly + hoa + anh + van) / 5;
            if (DiemTrungBinh >= 8)
            {
                Console.WriteLine("Hoc Sinh Dat {0} Diem Xep Loai Gioi", DiemTrungBinh);
            }
            else
            {
                if (DiemTrungBinh < 8 && DiemTrungBinh >= 6.5)
                {
                    Console.WriteLine("Hoc Sinh Dat {0} Diem Xep Loai Kha", DiemTrungBinh);
                }
                else
                {
                    if (DiemTrungBinh < 6.5 && DiemTrungBinh >= 5)
                    {
                        Console.WriteLine("Hoc Sinh Dat {0} Diem Xep Loai Trung Binh", DiemTrungBinh);
                    }
                    else
                    {
                        if (DiemTrungBinh < 5 && DiemTrungBinh >= 3.5)
                        {
                            Console.WriteLine("Hoc Sinh Dat {0} Diem Xep Loai Yeu", DiemTrungBinh);
                        }
                        else
                        {
                            Console.WriteLine("Hoc Sinh Dat {0} Diem Xep Loai Kem", DiemTrungBinh);
                        }
                    }
                }
            }
            Console.ReadKey();
        }
        public static void GiaiPhuongTrinhBat1()
        {
            float a;
            Console.WriteLine("Nhập Vào Hệ Số A: ");
            a = float.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("A phải khác 0");
            }
            else
            {
                Console.WriteLine("Nhập Vào Hệ Số B: ");
                float b = float.Parse(Console.ReadLine());
                float x = -b / a;
                Console.WriteLine("{0}x + {1} = 0 \n=> x = {2}", a, b, x);
            }
            Console.ReadKey();
        }
        public static void GiaiPhuongTrinhBat2()
        {
            double A;
            Console.Write("Nhập Vào Hệ Số A:");
            A = Convert.ToInt32(Console.ReadLine());
            double B;
            Console.Write("Nhập Vào Hệ Số B:");
            B = Convert.ToInt32(Console.ReadLine());
            double C;
            Console.Write("Nhập Vào Hệ Số C:");
            C = Convert.ToInt32(Console.ReadLine());
            double delta = Math.Pow(B, 2) - 4 * A * C;
            double nghiem1 = (-B + Math.Sqrt(delta)) / (2 * A);
            double nghiem2 = (-B - Math.Sqrt(delta)) / (2 * A);
            double nghiemkep = -B / (2 * A);
            if (delta > 0)
            {
                Console.Write("Phương Trình {0}X^2+{1}X+{2} co 2 Nghiệm Phân Biệt.", A, B, C);
                Console.Write("X1={0}", nghiem1);
                Console.Write("X1={0}", nghiem2);
            }
            else
            {
                if (delta < 0)
                {
                    Console.Write("Phương Trinh {0}X^2+{1}X+{2} Vô Nghiệm.", A, B, C);
                }
                else
                {
                    Console.Write("Phương Trinh {0}X^2+{1}X+{2} Co 1 Nghiệm Kép.", A, B, C);
                    Console.Write("x1=x2={0}", nghiemkep);
                }
            }
            Console.ReadKey();
        }
        public static void GiaiPhuongTrinhBat3()
        {
            double a;
            double b;
            double c;
            double d;
            Console.Write("Nhập Vào Hệ Số A:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập Vào Hệ Số B:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập Vào Hệ Số C:");
            c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhập Vào Hệ Số D:");
            d = Convert.ToInt32(Console.ReadLine());
           double e= a + b + c + d;
            Console.WriteLine("{0}", e);
            Console.ReadKey();
        }
        public static void BangCuuChuong()
        {
            int a, b;
            a = 0;
            do
            {
                b = 1;
                do
                {
                    Console.WriteLine("{0} x {1} = {2}",
                        a, b, a * b);
                    b++;
                }
                while (b <= 10);
                Console.WriteLine();
                a++;
            } while (a <= 10);
            Console.ReadKey();
        }
    }
}
