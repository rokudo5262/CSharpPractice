using System;

namespace Recursive
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        int tinhgiaithua(int i)
        {
            if (i <= 1)
            {
                return 1;
            }
            return i * tinhgiaithua(i - 1);
        }
        int day_fibonaci(int i)
        {
            if (i == 0)
            {
                return 0;
            }
            if (i == 1)
            {
                return 1;
            }
            return day_fibonaci(i - 1) + day_fibonaci(i - 2);
        }
    }
}
