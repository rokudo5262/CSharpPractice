using System;
using System.Text;

namespace Object_Oriented
{
    class OOP
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List();
        }
        public static void Menu()
        {
            Console.WriteLine("******Menu**********************");
            Console.WriteLine("*01. Teacher.                  *");
            Console.WriteLine("*02. Student.                  *");
            Console.WriteLine("*03. Rectangle.                *");
            Console.WriteLine("*04. Square.                   *");
            Console.WriteLine("*05. Circle.                   *");
            Console.WriteLine("*06. Triangle.                 *");
            Console.WriteLine("*07. Bank Account.             *");
            Console.WriteLine("*08. Deposist.                 *");
            Console.WriteLine("*09. Withdrawal.               *");           
            Console.WriteLine("*10. Customer.                 *");
            Console.WriteLine("*11. Fraction.                 *");
            Console.WriteLine("*00. Thoát Chương Trình.       *");
            Console.WriteLine("********************************");
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
                    Teacher();
                    List();
                    break;
                case 2:
                    Student();
                    List();
                    break;
                case 3:
                    HinhChuNhat();
                    List();
                    break;
                case 4:
                    HinhVuong();
                    List();
                    break;
                case 5:
                    HinhTron();
                    List();
                    break;
                case 6:
                    HinhTamGiac();
                    List();
                    break;
                case 7:
                    Bank();
                    List();
                    break;
                case 8:
                    Deposist();
                    List();
                    break;
                case 9:
                    Withdrawal();
                    List();
                    break;
                case 10:
                    Customer();
                    List();
                    break;
                case 11:
                    Fraction();
                    List();
                    break;
                case 12:
                    List();
                    break;
                case 13:
                    List();
                    break;
                case 14:
                    List();
                    break;
                case 15:
                    List();
                    break;
                default:
                    Console.Write("Thoát Chương Trình.");
                    Console.ReadKey();
                    break;
            }
        }
        public static void Teacher()
        {
            Console.Write("Nhập Tên Giáo Viên:");
            string gv = Console.ReadLine();
            Console.Write("Nhập Tuổi Giáo Viên:");
            int a = Convert.ToInt32(Console.ReadLine());
            bool debug = false;
            Person myPerson = new Person(); //day la constructor mac dinh
            myPerson.LoiChao();
            /*tao mot doi tuong Teacher, thiet lap tuoi cho giang vien nay la 30, 
             *de nghi anh ta chao va bat dau giang day*/
            Teacher myTeacher = new Teacher(); //day la constructor mac dinh
            myTeacher.SetAge(a);
            myTeacher.SetChucVu(gv);
            myTeacher.ThongBaoTuoi();
            myTeacher.SetMonHoc("Ngữ Văn");
            myTeacher.LoiChao();
            myTeacher.GiangDay();
            if (debug)
            {
                Console.ReadLine();
            }
            Console.ReadKey();
        }
        public static void Student()
        {
            Console.Write("Nhập Tên Học Sinh:");
            string gv = Console.ReadLine();
            Console.Write("Nhập Tuổi Học Sinh:");
            int a = Convert.ToInt32(Console.ReadLine());
            bool debug = false;
            Person myPerson = new Person(); //day la constructor mac dinh
            myPerson.LoiChao();
            /*tao mot doi tuong Student, thiet lap tuoi cho sinh vien nay la 21, 
              gui loi chao toi anh ta va thong bao tuoi*/
            Student myStudent = new Student(); //day la constructor mac dinh
            myStudent.SetAge(21);
            myStudent.SetChucVu("Học Sinh");
            myStudent.LoiChao();
            myStudent.ThongBaoTuoi();
            if (debug)
            {
                Console.ReadLine();
            }
            Console.ReadKey();
        }
        public static void HinhChuNhat()
        {
            double chieudai;
            double chieurong;
            do
            {
                Console.Write("Nhập Vào Chiều Dài Hình Chữ Nhật:");
                chieudai = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhập Vào Chiều Rộng Hình Chữ Nhật:");
                chieurong = Convert.ToInt32(Console.ReadLine());
                if (chieudai < chieurong && chieudai < 0 && chieurong < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (chieudai < chieurong && chieudai < 0 && chieurong < 0);
            Rectangle hcn = new Rectangle(chieudai,chieurong);
            //hcn.height = chieudai;
            //hcn.width = chieurong;
            hcn.CalculateArea();
            hcn.CalculatePerimeter();
            Console.WriteLine("Diện Tích Hình Chữ Nhật: {0}.", hcn.area);
            Console.WriteLine("Chu Vi Hình Chữ Nhật: {0}.", hcn.perimeter);
        }
        public static void HinhVuong()
        {
            double canh;
            do
            {
                Console.Write("Nhập Vào Cạnh Hình Vuông:");
                canh = Convert.ToInt32(Console.ReadLine());
                if (canh < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (canh < 0);
            Square hv = new Square();
            hv.side = canh;
            hv.CalculateArea();
            hv.CalculatePerimeter();
            Console.WriteLine("Diện Tích Hình Vuông: {0}.", hv.area);
            Console.WriteLine("Chu Vi Hình Vuông: {0}.", hv.perimeter);
        }
        public static void HinhTron()
        {
            double bankinh;
            do
            {
                Console.Write("Nhập Vào Bán Kính Hình Tròn:");
                bankinh = Convert.ToInt32(Console.ReadLine());
                if (bankinh < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (bankinh < 0);
            Circle ht = new Circle();
            ht.Radious = bankinh;
            ht.CalculateArea();
            ht.CalculatePerimeter();
            Console.WriteLine("Diện Tích Hình Tròn: {0}.", ht.area);
            Console.WriteLine("Chu Vi Hình Tròn: {0}.", ht.perimeter);
        }
        public static void HinhTamGiac()
        {
            double canha;
            double canhb;
            double canhc;
            do
            {
                Console.Write("Nhap Cạnh A Của Tam Giác:");
                canha = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Cạnh B Của Tam Giác:");
                canhb = Convert.ToInt32(Console.ReadLine());
                Console.Write("Nhap Cạnh C Của Tam Giác:");
                canhc = Convert.ToInt32(Console.ReadLine());
                if (canha < 0 && canhb < 0 && canhc < 0)
                {
                    Console.Write("Nhập Sai Vui Lòng Nhập Lại");
                }
            } while (canha < 0 && canhb < 0 && canhc < 0);
            Triangle htg = new Triangle();
            htg.CalculatePerimeter();
            htg.CalculateArea();
            Console.WriteLine("Diện Tích Hình Tròn: {0}.", htg.area);
            Console.WriteLine("Chu Vi Hình Tròn: {0}.", htg.perimeter);
        }
        public static void Customer()
        {
            string e;
            string p;
            string f;
            string m;
            string l;
            string a;
            string c;
            Console.Write("Nhập Email:");
            e = Console.ReadLine();
            Console.Write("Nhập Password:");
            p = Console.ReadLine();
            Console.Write("Nhập Tên:");
            f = Console.ReadLine();
            Console.Write("Nhập Tên Đệm:");
            m = Console.ReadLine();
            Console.Write("Nhập Họ:");
            l = Console.ReadLine();
            Console.Write("Nhập Địa Chỉ:");
            a = Console.ReadLine();
            Console.Write("Nhập Công Ty:");
            c = Console.ReadLine();
            Customer customer = new Customer(e, p, f, m, l,a, c);
            customer.CustomerDetail();
            
        }
        public static void Bank()
        {
            Console.Write("Nhập Tên Người Dùng:");
            string o = Console.ReadLine();
            Console.Write("Nhập Số Tiền Tài Khoản:");
            decimal b = Convert.ToInt32(Console.ReadLine());            
            var account = new BackAccount(o,b);
            Console.WriteLine("Account {0} was created for {1} with {2} $.",account.Number,account.OwnerName,account.Balance);
            account.MakeDeposist(120, DateTime.Now, "Hammer");
            account.MakeDeposist(140, DateTime.Now, "Shover");
            account.MakeDeposist(160, DateTime.Now, "Hammer");
            Console.WriteLine(account.GetAccountHistory());
        }
        public static void Deposist()
        {
            var account = new BackAccount("Truong", 10000);
            Console.WriteLine("Account {0} was created for {1} with {2} $.", account.Number, account.OwnerName, account.Balance);
            account.MakeDeposist(120, DateTime.Now, "Hammer");
            Console.WriteLine("Account {0} Make Deposist, Balance: {1} $",account.Number, account.Balance);
        }
        public static void Withdrawal()
        {
            var account = new BackAccount("Truong", 10000);
            Console.WriteLine("Account {0} was created for {1} with {2} $.", account.Number, account.OwnerName, account.Balance);
            account.MakeWithdrawal(120, DateTime.Now, "Lost Money");
            Console.WriteLine("Account {0} Make Withdrawal, Balance: {1} $", account.Number, account.Balance);
        }
        public static void Fraction()
        {
            Fraction a = new Fraction();
            Fraction b= new Fraction();
            a.Nhap();
            b.Nhap();
            Console.Write("Cộng Phân Số:");
            a.cong(b);
            a.Xuat();
            Console.Write("Trừ Phân Số:");
            a.tru(b);
            a.Xuat();
            Console.Write("Nhân Phân Số:");
            a.nhan(b);
            a.Xuat();
            Console.Write("Chia Phân Số:");
            a.chia(b);
            a.Xuat();
        }
    }
}
