using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task08_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            

            if (b.Contains(a) && b.Contains(b))
            {
                Console.WriteLine(" " + b);
            }
            Console.WriteLine();
        }
    }
}
