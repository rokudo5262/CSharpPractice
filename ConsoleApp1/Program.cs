using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            Console.WriteLine("****************Menu************************");
            Console.WriteLine("*01. Hello World                           *");
            Console.WriteLine("*02. Tim Tong Hieu Tích Thương Của 2 So a b*");
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
                    HelloWorld();
                    List();
                    break;
                case 2:
                    BasicMath();
                    List();
                    break;
                case 3:
                    ConvertTemperature();
                    List();
                    break;
                case 4:
                    TinhTrungBinhBaSo();
                    List();
                    break;
                case 5:
                    CanBatVaBinhPhuong();
                    List();
                    break;
                case 6:
                    ChuViVaDienTichHinhChuNhat();
                    List();
                    break;
                case 7:
                    ChuViVaDienTichHinhVuong();
                    List();
                    break;
                case 8:
                    ChuViVaDienTichHinhTamGiac();
                    List();
                    break;  
                case 9:
                    ChuViVaDienTichHinhTron();
                    List();
                    break;
                case 10:
                    TheTichVaDienTichHinhCau();
                    List();
                    break;
                default:
                    Console.Write("Thoát Chương Trình");
                    Console.ReadKey();
                    break;
            }
        }
        public static void HelloWorld()
        {
            Console.Write("Hello World");
            Console.ReadKey();
        }
        public static void BasicMath()
        {
            int a;
            int b;
            int tong;
            int hieu;
            int tich;
            float thuong;
            Console.Write("Nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            tong = a + b;
            Console.WriteLine("Tong Cua a + b = {0}", tong);
            hieu = a - b;
            Console.WriteLine("Hieu Cua a - b = {0}", hieu);
            tich = a * b;
            Console.WriteLine("Hieu Cua a * b = {0}", tich);
            thuong = a / b;
            Console.WriteLine("Thuong Cua a / b = {0}", thuong);
            Console.ReadKey();
        }
        public static void ConvertTemperature()
        {
            double Celcius;
            Console.Write("Nhap Vào Độ C:");
            Celcius = Convert.ToInt32(Console.ReadLine());
            double Kelvin = Celcius + 273.12;
            double Fahrenheit = (Celcius * 1.8) + 32;
            Console.WriteLine("Độ Celcius Là :{0} C", Celcius);
            Console.WriteLine("Độ Fahrenheit Là :{0} F", Fahrenheit);
            Console.WriteLine("Do Kelvin Là :{0} K", Kelvin);
            Console.ReadKey();
        }
        public static void TinhTrungBinhBaSo()
        {
            int a;
            Console.Write("Nhập Vào Số Nguyên A:");
            a = Convert.ToInt32(Console.ReadLine());
            int b;
            Console.Write("Nhập Vào Số Nguyê B:");
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            Console.Write("Nhập Vào Số Nguyê C:");
            c = Convert.ToInt32(Console.ReadLine());
            int Trungbinh = (a + b + c) / 3;
            Console.WriteLine("Trung binh Cộng Của Ba Số A = {0}, B= {1}, C = {2} la :{3}",a,b,c,Trungbinh);
            Console.ReadKey();
        }
        public static void CanBatVaBinhPhuong()
        {
            int a;
            do
            {
                Console.Write("Nhập Vào Số Nguyên a:");
                a = Convert.ToInt32(Console.ReadLine());
            } while (a > 0);
            double pow = Math.Pow(a, 2);
            Console.WriteLine("Binh Phương Của A={0} Là :{1}", a, pow);
            double sqrt = Math.Sqrt(a);
            Console.WriteLine("Căn Bật 2 Của A={0} Là :{1}", a, sqrt);
            Console.ReadKey();
        }
        public static void ChuViVaDienTichHinhChuNhat()
        {
            int chieudai;
            int chieurong;
            do
            {
                Console.Write("Nhập Vào Chiều Dài Hình Chữ Nhật:");
                chieudai = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập Vào Chiều Rộng Hình Chữ Nhật:");
                chieurong = Convert.ToInt32(Console.ReadLine());

            } while (chieudai < chieurong || chieudai != 0 || chieurong != 0);
            int chuvihinhchunhat;
            chuvihinhchunhat = (chieudai + chieurong) * 2;
            Console.WriteLine("Chu Vi Hình Chữ Nhật Là :{0}", chuvihinhchunhat);
            int dientichhinhchunhat;
            dientichhinhchunhat = chieudai * chieurong;
            Console.WriteLine("Diện Tích Hình Chữ Nhật Là :{0}", dientichhinhchunhat);
            Console.ReadKey();
        }
        public static void ChuViVaDienTichHinhVuong()
        {
            int canh;
            Console.Write("Nhap Canh Cua Hinh Vuong:");
            canh = Convert.ToInt32(Console.ReadLine());
            int chuvihinhvuong = canh * 4;
            Console.WriteLine("Chu Vi Hinh Vuong la :{0}", chuvihinhvuong);
            int dientichhinhvuong = canh * canh;
            Console.WriteLine("Dien Tich Hinh Vuong la :{0}", dientichhinhvuong);
            Console.ReadKey();
        }
        public static void ChuViVaDienTichHinhTamGiac()
        {
            int canha;
            Console.Write("Nhap Canh a cua tam giac:");
            canha = Convert.ToInt32(Console.ReadLine());
            int canhb;
            Console.Write("Nhap Canh b cua tam giac:");
            canhb = Convert.ToInt32(Console.ReadLine());
            int canhc;
            Console.Write("Nhap Canh c cua tam giac:");
            canhc = Convert.ToInt32(Console.ReadLine());
            int chuvihinhtamgiac = canha + canhb + canhc;
            Console.WriteLine("Dien Tich Hinh Tam Giac la :{0}", chuvihinhtamgiac);
            Double p = (canha + canhb + canhc) / 2;
            double dientichhinhtamgiac = Math.Sqrt(p * (p - canha) * (p - canhb) * (p - canhc));
            Console.WriteLine("Dien Tich Hinh Tam Giac la :{0}", dientichhinhtamgiac);
            Console.ReadKey();
        }
        public static void ChuViVaDienTichHinhTron()
        {
            int bankinh;
            Console.Write("Nhap Ban Kinh Hinh Tron:");
            bankinh = Convert.ToInt32(Console.ReadLine());
            double pi = Math.PI;
            Double chuvihinhtron = 2 * pi * bankinh;
            Console.WriteLine("Chu Vi Hinh Tron la :{0}", chuvihinhtron);
            double dientichhinhtron = pi * bankinh * bankinh;
            Console.WriteLine("Dien Tich Hinh Tron la :{0}", dientichhinhtron);
            Console.ReadKey();
        }
        public static void TheTichVaDienTichHinhCau()
        {
            int bankinhhinhcau;
            Console.Write("Nhap Ban Kinh Hinh Cau:");
            bankinhhinhcau = Convert.ToInt32(Console.ReadLine());
            double r = Math.PI;
            Double dientichmatcau = 4 * r * Math.Pow(bankinhhinhcau, 2);
            Console.WriteLine("Dien Tich Mat Cau la :{0}", dientichmatcau);
            double thetichhinhcau = (4 / 3) * r * Math.Pow(bankinhhinhcau, 3);
            Console.WriteLine("The Tich Khoi Hinh Cau la :{0}", thetichhinhcau);
            Console.ReadKey();
        }
    }
}
