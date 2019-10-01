using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
        }
        public static bool IsOdd(int n)
        {
            if (n % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsEven(int n)
        {
            if (n % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsPrime(int n)
        {
            if (n <= 1)
            {
                return false;
            }
            for (int i = 2; i < n; i++)
                if (n % i == 0)
                {
                    return false;
                }
            return true;
        }

        public static int Square(int n)
        {
            return n * n;
        }

        public static int Cube(int n)
        {
            return n * n * n;
        }

        public static int Pow(int x, int y)
        {
            int rs = 1;
            for (int i = 1; i <= y; i++)
                rs = rs * x;
            return rs;
        }
    }
}

    

