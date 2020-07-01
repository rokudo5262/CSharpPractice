using System;
using System.Text;

namespace Struct
{
    class Struct
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List();
        }
        public static void Menu()
        {
            Console.WriteLine("****************************Menu******************************");
            Console.WriteLine("*01. Book.                                                   *");
            Console.WriteLine("*02. Book 2.                                                 *");
            Console.WriteLine("*01. Student.                                                *");
            Console.WriteLine("*00. Thoát Chương Trình.                                     *");
            Console.WriteLine("**************************************************************");
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
                    NhapXuatBook();
                    List();
                    break;
                case 2:
                    NhapXuatBook_2();
                    List();
                    break;
                case 3:
                    NhapXuatStudent();
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
                case 11:
                    List();
                    break;
                case 12:
                    List();
                    break;
                case 13:
                    List();
                    break;
                default:
                    Console.Write("Thoát Chương Trình.");
                    Console.ReadKey();
                    break;
            }
        }
        struct Book
        {
            public int ma_sach;
            public string ten_sach;
            public string ten_tac_gia;
            public string the_loai;
            public void NhapBook(int a, string b, string c, string d)
            {
                ma_sach = a;
                ten_sach = b;
                ten_tac_gia = c;
                the_loai = d;
            }
            public void XuatBook()
            {
                Console.WriteLine("Mã Sách: {0}", ma_sach);
                Console.WriteLine("Tên sach: {0}", ten_sach);
                Console.WriteLine("Tên Tac gia: {0}", ten_tac_gia);
                Console.WriteLine("Thể Lọai: {0}", the_loai);
            }
        };
        public static void NhapXuatBook()
        {
            Book book1;
            Book book2;
            /* thong tin chi tiet ve book1 */
            book1.ma_sach = 1;
            book1.ten_sach = "Toán";
            book1.ten_tac_gia = "toán";
            book1.the_loai = "Sgk";
            /* thong tin chi tiet ve book2 */
            book2.ma_sach = 1;
            book2.ten_sach = "Văn";
            book2.ten_tac_gia = "văn";
            book2.the_loai = "Sgk";
            /* in cac thong tin cua Book1*/
            Console.WriteLine("In Thông Tin Của Sách 1:");
            Console.WriteLine("Ten sach: {0}", book1.ten_sach);
            Console.WriteLine("Tac gia: {0}", book1.ten_tac_gia);
            Console.WriteLine("The loai: {0}", book1.the_loai);
            Console.WriteLine("Ma sach: {0}", book1.ma_sach);
            /* in cac thong tin cua Book2 */
            Console.WriteLine("In Thông Tin Của Sách 2:");
            Console.WriteLine("Tên sach: {0}", book2.ten_sach);
            Console.WriteLine("Tên Tac gia: {0}", book2.ten_tac_gia);
            Console.WriteLine("Thể Lọai: {0}", book2.the_loai);
            Console.WriteLine("Mã Sách: {0}", book2.ma_sach);
            Console.ReadKey();
        }
        public static void NhapXuatBook_2()
        {
            Book book1 = new Book();   /* Khai bao Book1 thuoc kieu cau truc Book */
            Book book2 = new Book();   /* Khai bao Book2 thuoc kieu cau truc Book */
            Book book3 = new Book();
            /* thong tin Book1 */
            book1.NhapBook(1, "Anh",
            "Nguyen Văn A", "Tiếng Anh");
            /* thong tin book2 */
            book2.NhapBook(2, "Toán",
            "Trần Văn A", "Tóan Học");
            /* thong tin book3 */
            book3.NhapBook(2, "Văn",
            "Tran Thị C", "Ngữ Văn");
            /* In thong tin book1 */
            Console.WriteLine("In Thông Tin Của Sách 1:");
            book1.XuatBook();
            /* In thong tin book2 */
            Console.WriteLine("In Thông Tin Của Sách 2:");
            book2.XuatBook();
            /* In thong tin book3 */
            Console.WriteLine("In Thông Tin Của Sách 3:");
            book3.XuatBook();
            Console.ReadKey();
        }
        struct Student
        {
            public int ma_hocsinh;
            public string ten_hocsinh;
            public DateOfBirth ngay_sinh;
            public Score diem;
        }
        struct DateOfBirth
        {
            public int day;
            public int month;
            public int year;
        }
        struct Score
        {
            public int math;
            public int english;
            public int literature;
            public int physic;
            public int chemistry;
        }
        public static void NhapXuatStudent()
        {          
            int total = 1;
            Student[] student = new Student[total];
            for (int i = 0; i < total; i++)
            {
                Console.Write("Mã Học sinh: ");
                int mahocsinh = Convert.ToInt32(Console.ReadLine());
                student[i].ma_hocsinh = mahocsinh;
                Console.Write("Tên Học sinh: ");
                string nm = Console.ReadLine();
                student[i].ten_hocsinh = nm;
                Console.Write("Nhập Ngày sinh: ");
                int dd = Convert.ToInt32(Console.ReadLine());
                student[i].ngay_sinh.day = dd;
                Console.Write("Nhập Tháng sinh: ");
                int mm = Convert.ToInt32(Console.ReadLine());
                student[i].ngay_sinh.month = mm;
                Console.Write("Nhập Năm sinh: ");
                int yy = Convert.ToInt32(Console.ReadLine());
                student[i].ngay_sinh.year = yy;
                Console.Write("Nhập Điểm Môn Toán: ");
                int toan = Convert.ToInt32(Console.ReadLine());
                student[i].diem.math = toan;
                Console.Write("Nhập Điểm Môn Văn: ");
                int van = Convert.ToInt32(Console.ReadLine());
                student[i].diem.literature = van;
                Console.Write("Nhập Điểm Môn Anh: ");
                int anh = Convert.ToInt32(Console.ReadLine());
                student[i].diem.english = anh;
                Console.Write("Nhập Điểm Môn Lý: ");
                int ly = Convert.ToInt32(Console.ReadLine());
                student[i].diem.physic = ly;
                Console.Write("Nhập Điểm Môn Hóa: ");
                int hoa = Convert.ToInt32(Console.ReadLine());
                student[i].diem.chemistry = hoa;
            }
            Console.ReadKey();
        }
    }
}
