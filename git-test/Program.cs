using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_test
{
    class Program
    {
        public static int Sum(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mux(int x, int y )
        {
            return x * y;

        }
        static void Main(string[] args)
        {
            //git test 1
            int sum = 0;
            for(int i=0; i<10; i++)
            {
                sum += Sum(i, i + 1);
            }

            Console.WriteLine($"SUM(...):{sum}");

            Console.WriteLine($"SUB(...):{-sum}");


            Console.WriteLine($"SUB(...):{-sum*sum}");
        }
    }
}
