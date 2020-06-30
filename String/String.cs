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
            Console.WriteLine("*08.Nhập Chuỗi.Đếm số chữ cái, số chữ số, số ký tự đặc biệt.                   *");
            Console.WriteLine("*09.Nhập Chuỗi.Chuyễn Ký Tự Thường Thành Ký Tự In Hoa.                         *");
            Console.WriteLine("*10.Nhập Và Kiểm Tra Tài Khoản Và Mật Khẩu.                                    *");
            Console.WriteLine("*11.Nhập Chuỗi.Tìm Phần Tử Xuất Hiện Nhiều Nhất.                               *");
            Console.WriteLine("*12.Nhập 1 Ký Tự.Kiểm Tra Ký Tự Đó Là Chữ Hoa Hay Chữ Thường.                  *");
            Console.WriteLine("*13.Nhập Chuỗi.Lấy chuỗi con từ chuỗi đã cho.                                  *");         
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
                if (Selectfuntion < 0 || Selectfuntion > 13)
                {
                    Console.WriteLine("Nhập Sai. Vui Lòng Nhập Lại.");
                }
            } while (Selectfuntion < 0 || Selectfuntion > 13);
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
                    DemNguyenAmPhuAm();
                    List();
                    break;
                case 8:
                    DemChuCaiChuSoVaKiTuDatBiet();
                    List();
                    break;
                case 9:
                    ChuyenKyTuThuongThanhKyTuHoa();
                    List();
                    break;
                case 10:
                    KiemTraTaiKhoanMatKhau();
                    List();
                    break;
                case 11:
                    TimPhanTuXuatHienNhieuNhat();
                    List();
                    break;
                case 12:
                    KiemTraKyTuHoaThuong();
                    List();
                    break;
                case 13:
                    LayChuoiCon();
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
            int nguyen_am = 0;
            int phu_am = 0;
            int length = str.Length;
            for (int i = 0; i < length; i++)
            {

                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u' || str[i] == 'A' || str[i] == 'E' || str[i] == 'I' ||
                    str[i] == 'O' || str[i] == 'U')
                {
                    nguyen_am++;
                }
                else
                {
                    if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                    {
                        phu_am++;
                    }
                }
            }
            Console.WriteLine("Số Nguyên Âm Có Trong Chuỗi Là: {0}", nguyen_am);
            Console.WriteLine("Số Phụ Âm Có Trong Chuỗi Là: {0}", phu_am);
            Console.ReadKey();
        }
        public static void DemChuCaiChuSoVaKiTuDatBiet()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            int l = str.Length;
            int chu_cai = 0;
            int chu_so = 0;
            int ky_tu_dac_biet = 0;
            int i = 0;
            /* kiem tra tung ky tu trong chuoi*/
            while (i < l)
            {
                if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
                {
                    chu_cai++;
                }
                else if (str[i] >= '0' && str[i] <= '9')
                {
                    chu_so++;
                }
                else
                {
                    ky_tu_dac_biet++;
                }
                i++;
            }
            Console.WriteLine("Số Chữ Cái Trong Chuỗi Là: {0}", chu_cai);
            Console.WriteLine("Số Chữ Số Trong Chuỗi Là: {0}", chu_so);
            Console.WriteLine("Số Ký Tự Đặt Biệt Trong Chuỗi Là: {0}", ky_tu_dac_biet);
            Console.ReadKey();
        }
        public static void ChuyenKyTuThuongThanhKyTuHoa()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            int l = str.Length;
            char ch;
            char[] array;
            array = str.ToCharArray(0, l); // chuyen chuoi thanh mang ky tu.  
            Console.WriteLine("Sau Khi Chuyễn Dổi, Chuỗi Có Dạng: ");
            for (int i = 0; i < l; i++)
            { 
                ch = array[i];
                if (Char.IsLower(ch)) // kiem tra ky tu thuong 
                {
                    Console.Write(Char.ToUpper(ch)); // chuyen doi chu thuong thanh chu hoa.  
                }
                else
                {
                    Console.Write(Char.ToLower(ch)); // chuyen doi chu hoa thanh chu thuong.  
                }
            }
            Console.WriteLine();
            Console.ReadKey();
        }
        public static void KiemTraTaiKhoanMatKhau()
        {
            string username;
            string password;
            int ctr = 0;
            do
            {
                Console.Write("Nhập Tài Khoản: ");
                username = Console.ReadLine();
                Console.Write("Nhập Mật Khẩu: ");
                password = Console.ReadLine();
                if (username != "truong" || password != "12345")
                {
                    ctr++;
                }
                else
                {
                    ctr = 1;
                }
            }
            while ((username != "truong" || password != "12345") && (ctr != 3));
            if (ctr == 3)
            {
                Console.WriteLine("Ban da nhap sai username va password qua 3 lan. Xin hay thu lai!");
            }
            else
            { 
                Console.WriteLine("Ban da nhap mat khau dung!");
            }
            Console.ReadKey();
        }
        public static void TimPhanTuXuatHienNhieuNhat()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            int l = str.Length;
            int[] tan_suat=new int[255];
            int ascii;
            int i = 0;
            for (i = 0; i < 255; i++)  //thiet lap tan suat xuat hien cua tat ca ky tu ve 0  
            {
                tan_suat[i] = 0;
            }
            /* Doc tan suat cua moi ky tu */
            i = 0;
            while (i < l)
            {
                ascii = (int)str[i];
                tan_suat[ascii] += 1;
                i++;
            }
            int max = 0;
            for ( i = 0; i < 255; i++)
            {
                if (i != 32)
                {
                    if (tan_suat[i] > tan_suat[max])
                    {
                        max = i;
                    }
                }
            }
            Console.Write("Ký Tự Xuất Hiện Nhiều Nhất '{0}' Và Xuất Hiện {1} Lần.", (char)max, tan_suat[max]);
            Console.ReadKey();
        }
        public static void KiemTraKyTuHoaThuong()
        {
            Console.Write("Nhập Ký Tự:");
            string str = Console.ReadLine();
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.WriteLine("In Từng Ký Tự Trong Chuổi Ban Đầu: ");
            char ch = (char)Console.Read();
            if (Char.IsLetter(ch))
            {
                if (Char.IsUpper(ch))
                {
                    Console.WriteLine("Ky tu vua nhap la chu hoa.");
                }
                else
                {
                    Console.WriteLine("Ky tu vua nhap la chu thuong.");
                }
            }
            else
            {
                Console.WriteLine("Ky tu vua nhap khong phai la chu cai.");
            }
            Console.ReadKey();
        }
        public static void LayChuoiCon()
        {
            Console.Write("Nhập Chuỗi:");
            string str = Console.ReadLine();        
            Console.Write("Nhap vi tri bat dau de lay chuoi con: ");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap do dai cua chuoi con: ");
            int l = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bạn Vừa Nhập Chuỗi: {0}", str);
            Console.Write("Chuoi con thu duoc tu chuoi ban dau la: ");
            int ln = str.Length;
            char[] array = str.ToCharArray(0, ln);
            int c = 0;
            while (c < l)
            {
                Console.Write(array[pos + c - 1]);
                c++;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
