using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            
            ShowNumber(a);
        }

        private static int ShowNumber(int a)
        {
            if (a % 2 == 0)
            {
                Console.WriteLine("Chisloto e chetno!");
            }
            else Console.WriteLine("Chisloto e nechetno!");
            return a;
        }
    }
}
