using System;
using System.Text;
using System.IO;

namespace Read_File
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
            Console.WriteLine("****************************Menu******************************");
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
                    GhiFile();
                    List();
                    break;
                case 2:
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
        public static void GhiFile()
        {
            string sentence = " ";
            StreamWriter myfile;
            myfile = File.CreateText("test.txt");
            do
            {
                Console.Write("Nhập Nột Câu text: ");
                sentence = Console.ReadLine();
                if (sentence.Length != 0)
                {
                    myfile.WriteLine(sentence);
                }
            }
            while (sentence.Length != 0);
            myfile.Close();
            Console.ReadKey();
        }
    }
}
