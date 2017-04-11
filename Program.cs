using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        //1、1、2、3、5、8、13、21、34
        static void Main(string[] args)
        {
            Console.WriteLine(Sum(9));
            Console.ReadKey();
        }

        public static int Fib(int n)
        {
            if (n == 2 || n==1)
            {
                return 1;
            }
            else
            {
               return Fib(n - 1)+Fib(n-2);
            }
        }

        public static int Sum(int n)
        {
            if (n == 2 || n == 1)
            {
                return 1;
            }
            int sum = 0;
            int a = 1;
            int b = 1;
            for (int i = 2; i < n; i++)
            {
                sum = a + b;
                a = b;
                b = sum;
            }
            return sum;
        }
    }
}
