using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n = ");
            int x = int.Parse(Console.ReadLine());

            int factorial = Factorial(x);
            Console.WriteLine("{0}! = {1}", x,factorial);

            
        }

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }
    }
}
