using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Basic
{
    class Basic
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List();
        }
        public static void Menu()
        {
            Console.WriteLine("***********************************Menu*******************************");
            Console.WriteLine("*01. Xuất Hello World.                                               *");
            Console.WriteLine("*02. Chuyển Đổi số Nguyên Thành Số Nhị Phân.                         *");
            Console.WriteLine("*03. Chuyển Đổi số Nguyên Thành Số Thập Phân.                        *");
            Console.WriteLine("*04. Chuyển Đổi số Nguyên Thành Số Nhị Phân.                         *");
            Console.WriteLine("*05. Nhập 2 Số Nguyên a Và b. Tìm Tổng Hiệu Tích Thương Của 2 Số a b.*");
            Console.WriteLine("*06. Nhập Vào Độ C. Đổi Độ C Thành Độ F Và Độ K.                     *");
            Console.WriteLine("*07. Nhập Vào 3 Số Nguyên. Tính Trung Bình 3 Số Vừa Nhập             *");
            Console.WriteLine("*08. Nhập Vào 1 Số Nguyên. Tính Bình Phương Và Căn Bật 2 Của Số Nhập.*");
            Console.WriteLine("*09. Hình Chữ Nhật.                                                  *");
            Console.WriteLine("*10. Hinh Vuông.                                                     *");
            Console.WriteLine("*11. Hinh Thoi.                                                      *");
            Console.WriteLine("*12. Hinh Tròn.                                                      *");
            Console.WriteLine("*13. Hình Cầu.                                                       *");
            Console.WriteLine("*14. Hình Hộp Vuông.                                                 *");
            Console.WriteLine("*15. Hình Hộp Chữ Nhật.                                              *");
            Console.WriteLine("*16. Hình Nón.                                                       *");
            Console.WriteLine("*17. Hình Trụ.                                                       *");
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
                if (Selectfuntion < 0 || Selectfuntion > 17)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại.");
                }
            } while (Selectfuntion < 0 || Selectfuntion > 17);
            switch (Selectfuntion)
            {
                case 1:
                    HelloWorld();
                    List();
                    break;
                case 2:
                    ChuyenDoiNhiPhan();
                    List();
                    break;
                case 3:
                    ChuyenDoiNhiPhan();
                    List();
                    break;
                case 4:
                    ChuyenDoiNhiPhan();
                    List();
                    break;
                case 5:
                    TongHieuTichThuong();
                    List();
                    break;
                case 6:
                    ConvertTemperature();
                    List();
                    break;
                case 7:
                    TinhTrungBinhBaSo();
                    List();
                    break;
                case 8:
                    CanBatVaBinhPhuong();
                    List();
                    break;
                case 9:
                    HinhChuNhat();
                    List();
                    break;
                case 10:
                    HinhVuong();
                    List();
                    break;
                case 11:
                    HinhTamGiac();
                    List();
                    break;  
                case 12:
                    HinhTron();
                    List();
                    break;
                case 13:
                    HinhCau();
                    List();
                    break;
                case 14:
                    HinhHopVuong();
                    List();
                    break;
                case 15:
                    HinhHopChuNhat();
                    List();
                    break;
                case 16:
                    HinhNon();
                    List();
                    break;
                case 17:
                    HinhTru();
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
        public static void ChuyenDoiNhiPhan()
        {
            int n;
            Console.WriteLine("Nhập Vào Số Nguyên n:");
            n = Convert.ToInt32(Console.ReadLine());
            string binary = Convert.ToString(n, 2);
            Console.WriteLine("Binary Của Số n={0} Là: {1}",n,binary);
            Console.ReadKey();
        }
        public static void ChuyenDoiThapLucPhan()
        {
            int n;
            Console.WriteLine("Nhập Vào Số Nguyên n:");
            n = Convert.ToInt32(Console.ReadLine());
            string hexadecimal = Convert.ToString(n, 16);
            Console.WriteLine("Hexadecimal Của Số n={0} Là: {1}", n, hexadecimal);
            Console.ReadKey();
        }
        public static void ChuyenDoiBatPhan()
        {
            int n;
            Console.WriteLine("Nhập Vào Số Nguyên n:");
            n = Convert.ToInt32(Console.ReadLine());
            string octal = Convert.ToString(n, 8);
            Console.WriteLine("octal Của Số n={0} Là: {1}", n, octal);
            Console.ReadKey();
        }
        public static void TongHieuTichThuong()
        {
            int a;
            int b;
            int tong;
            int hieu;
            int tich;
            float thuong;
            do
            {
                Console.Write("Nhập Số Nguyên A:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (a < 0);
            do
            {
                Console.Write("Nhập Số Nguyên B:");
                b = Convert.ToInt32(Console.ReadLine());
                if (b < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (b < 0);
            tong = a + b;
            Console.WriteLine("Tổng Hai Số {0} + {1} = {2}",a, b, tong);
            hieu = a - b;
            Console.WriteLine("Hiệu Hai Số {0} + {1} = {2}", a, b, hieu);
            tich = a * b;
            Console.WriteLine("Tích Hai Số {0} + {1} = {2}", a, b, tich);
            thuong = a / b;
            Console.WriteLine("Thương Hai Số {0} + {1} = {2}", a, b, thuong);
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
            int b;
            int c;
            do
            {
                Console.Write("Nhập Vào Số Nguyên A:");
                a = Convert.ToInt32(Console.ReadLine());
                if (a < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (a < 0);
            do
            {
                Console.Write("Nhập Vào Số Nguyên B:");
                b = Convert.ToInt32(Console.ReadLine());
                if (b < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (b < 0);
            do
            {
                Console.Write("Nhập Vào Số Nguyên C:");
                c = Convert.ToInt32(Console.ReadLine());
                if (c < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (c < 0);
            int Trungbinh = (a + b + c) / 3;
            Console.WriteLine("Trung binh Cộng Của Ba Số A = {0}, B= {1}, C = {2} la :{3}", a, b, c, Trungbinh);
            Console.ReadKey();
        }
        public static void CanBatVaBinhPhuong()
        {
            int a;
            do
            {
                Console.Write("Nhập Vào Số Nguyên a:");
                a = Convert.ToInt32(Console.ReadLine());
                if(a<0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (a < 0);
            double pow = Math.Pow(a, 2);
            Console.WriteLine("Binh Phương Của A={0} Là :{1}", a, pow);
            double sqrt = Math.Sqrt(a);
            Console.WriteLine("Căn Bật 2 Của A={0} Là :{1}", a, sqrt);
            Console.ReadKey();
        }
        public static void HinhChuNhat()
        {
            int chieudai;
            int chieurong;
            do
            {
                Console.Write("Nhập Vào Chiều Dài Hình Chữ Nhật:");
                chieudai = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập Vào Chiều Rộng Hình Chữ Nhật:");
                chieurong = Convert.ToInt32(Console.ReadLine());
                if(chieudai < chieurong && chieudai < 0 && chieurong < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (chieudai < chieurong && chieudai < 0 && chieurong < 0);
            int chuvihinhchunhat;
            chuvihinhchunhat = (chieudai + chieurong) * 2;
            Console.WriteLine("Chu Vi Hình Chữ Nhật Là :{0}", chuvihinhchunhat);
            int dientichhinhchunhat;
            dientichhinhchunhat = chieudai * chieurong;
            Console.WriteLine("Diện Tích Hình Chữ Nhật Là :{0}", dientichhinhchunhat);
            Console.ReadKey();
        }
        public static void HinhVuong()
        {
            int canh;
            do
            {
                Console.Write("Nhap Canh Cua Hinh Vuong:");
                canh = Convert.ToInt32(Console.ReadLine());
                if (canh < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (canh < 0);
            int chuvihinhvuong = canh * 4;
            Console.WriteLine("Chu Vi Hinh Vuong la :{0}", chuvihinhvuong);
            int dientichhinhvuong = canh * canh;
            Console.WriteLine("Dien Tich Hinh Vuong la :{0}", dientichhinhvuong);
            Console.ReadKey();
        }
        public static void HinhTamGiac()
        {
            int canha;
            Console.Write("Nhap Cạnh A Của Tam Giác:");
            canha = Convert.ToInt32(Console.ReadLine());
            int canhb;
            Console.Write("Nhap Cạnh B Của Tam Giác:");
            canhb = Convert.ToInt32(Console.ReadLine());
            int canhc;
            Console.Write("Nhap Cạnh C Của Tam Giác:");
            canhc = Convert.ToInt32(Console.ReadLine());
            int chuvihinhtamgiac = canha + canhb + canhc;
            Console.WriteLine("Diê5n Tích Hình Tam Giác la :{0}", chuvihinhtamgiac);
            Double p = (canha + canhb + canhc) / 2;
            double dientichhinhtamgiac = Math.Sqrt(p * (p - canha) * (p - canhb) * (p - canhc));
            Console.WriteLine("Dien Tich Hinh Tam Giac la :{0}", dientichhinhtamgiac);
            Console.ReadKey();
        }
        public static void HinhTron()
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
        public static void HinhCau()
        {
            int bankinhhinhcau;
            do
            {
                Console.Write("Nhap Ban Kinh Hinh Cau:");
                bankinhhinhcau = Convert.ToInt32(Console.ReadLine());
                if (bankinhhinhcau<0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (bankinhhinhcau < 0);
            double r = Math.PI;
            Double dientichmatcau = 4 * r * Math.Pow(bankinhhinhcau, 2);
            Console.WriteLine("Dien Tich Mat Cau la :{0}", dientichmatcau);
            double thetichhinhcau = (4 / 3) * r * Math.Pow(bankinhhinhcau, 3);
            Console.WriteLine("The Tich Khoi Hinh Cau la :{0}", thetichhinhcau);
            Console.ReadKey();
        }
        public static void HinhHopVuong()
        {
            int canhhinhhopvuong;
            do
            {
                Console.Write("Nhập Bán Kính Hình Cầu:");
                canhhinhhopvuong = Convert.ToInt32(Console.ReadLine());
                if (canhhinhhopvuong < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (canhhinhhopvuong < 0);
            Double dientichhinhhopvuong = 3 *canhhinhhopvuong;
            Console.WriteLine("Diện Tích Mặt Cầu S={0}", dientichhinhhopvuong);
            double thetichhinhhopvuong = Math.Pow(canhhinhhopvuong, 3);
            Console.WriteLine("The Tich Khoi Hinh Cau V={0}", thetichhinhhopvuong);
            Console.ReadKey();
        }
        public static void HinhHopChuNhat()
        {
            double chieudai;
            double chieurong;
            double chieucao;
            do
            {
                Console.Write("Nhập Chiều Dài Hình Hộp Chữ Nhật:");
                chieudai = Convert.ToInt32(Console.ReadLine());
                if (chieudai < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (chieudai < 0);
            do
            {
                Console.Write("Nhập Chiều Rộng Hình Hộp Chữ Nhật:");
                chieurong = Convert.ToInt32(Console.ReadLine());
                if (chieurong < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (chieurong < 0);
            do
            {
                Console.Write("Nhập Chiều Cao Hình Hộp Chữ Nhật:");
                chieucao = Convert.ToInt32(Console.ReadLine());
                if (chieucao < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (chieucao < 0);
            double DienTichXungQuanh = 2 * chieucao*(chieudai+chieurong);
            double DienTichToanPhan = (2 * chieucao * (chieudai + chieurong)) + (2 * chieudai * chieurong);
            double DuongCheoHinhHop = Math.Sqrt(Math.Pow(chieudai, 2) + Math.Pow(chieurong, 2) + Math.Pow(chieucao, 2));
            double TheTichHinhHop = chieudai * chieurong * chieucao;
            Console.WriteLine("Diện Tích Xung Quanh Của Hình Hộp Chữ Nhật S={0}",DienTichXungQuanh); 
            Console.WriteLine("Diện Tích Toàn Phần Của Hình Hộp Chữ Nhật S={0}", DienTichToanPhan);
            Console.WriteLine("Thể Tích Của Hình Hộp Chữ Nhật V={0}", TheTichHinhHop);
            Console.WriteLine("Đường Chéo Của Hình Hộp Chữ Nhật D={0}", DuongCheoHinhHop);
            Console.ReadKey();
        }
        public static void HinhNon()
        {
            double p = Math.PI;
            double BanKinhDay;
            do
            {
                Console.Write("Nhập Vào Bán Kính Đáy Hình Nón:");
                BanKinhDay = Convert.ToInt32(Console.ReadLine());
                if (BanKinhDay < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (BanKinhDay < 0);
                double DuongSinh;
            do
            {
                Console.Write("Nhập Vào Đường Sinh Hình Nón:");
                DuongSinh = Convert.ToInt32(Console.ReadLine());
                if (DuongSinh < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (DuongSinh < 0);
            double DuongCao;
            do
            {
                Console.Write("Nhập Vào Đường Cao Hình Nón:");
                DuongCao = Convert.ToInt32(Console.ReadLine());
                if (DuongCao < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (DuongCao < 0);
            double DienTichXungQuanh = p * BanKinhDay * DuongCao;
            double DienTichToanPhan = DienTichXungQuanh + (p* Math.Pow(BanKinhDay,2));
            double TheTichHinhNon=(p* Math.Pow(BanKinhDay, 2)*DuongCao)/3;
            Console.WriteLine("Diện Tích Xung Quanh Của Hình Nón S={0}", DienTichXungQuanh);
            Console.WriteLine("Diện Tích Toàn Phần Của Hình Nón S={0}", DienTichToanPhan);
            Console.WriteLine("Thể Tích Của Hình Nón V={0}", TheTichHinhNon);
            Console.ReadKey();
        }
        public static void HinhTru()
        {
            double p = Math.PI;
            double BanKinh;
            do
            {
                Console.Write("Nhập Vào Bán Kính Hình Trụ:");
                BanKinh = Convert.ToInt32(Console.ReadLine());
                if (BanKinh < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (BanKinh < 0);
            double DuongCao;
            do
            {
                Console.Write("Nhập Vào Đường Cao Hình Trụ:");
                DuongCao = Convert.ToInt32(Console.ReadLine());
                if (DuongCao < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (DuongCao < 0);
            double DienTichXungQuanh = 2 * p * DuongCao * BanKinh;
            double DienTichToanPhan = DienTichXungQuanh + (2 * p * Math.Pow(BanKinh, 2));
            double TheTichHinhTru = p * Math.Pow(BanKinh, 2) * DuongCao;
            Console.WriteLine("Diện Tích Xung Quanh Của Hình Trụ S={0}", DienTichXungQuanh);
            Console.WriteLine("Diện Tích Toàn Phần Của Hình Trụ S={0}", DienTichToanPhan);
            Console.WriteLine("Thể Tích Của Hình Trụ V={0}", TheTichHinhTru);
            Console.ReadKey();
        }
    }
}
