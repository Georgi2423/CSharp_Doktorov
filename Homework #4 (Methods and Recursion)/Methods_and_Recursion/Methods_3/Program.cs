using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random Rand = new Random();
            
            int a = Rand.Next(1, 100);
            int b = Rand.Next(1, 100);
            int c = Rand.Next(1, 100);
            
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(SumOfNumber(a, b, c));
            SumOfNumber(a,b,c);
        }

        private static int SumOfNumber(int a,int b, int c)
        {
            int SUM = a * b * c;
            return SUM;
        }
    }
}
