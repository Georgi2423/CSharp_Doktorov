using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(MaxNumber(a, b, c));

            MaxNumber(a, b, c);

        }

         static int MaxNumber(int a, int b, int c)
        {
            if (a > b &&  a > c)
            {

                return a;
            }
            if (c > a && c > b)
            {
                return c;
            }
            else return b;
            
        }
    }
}
