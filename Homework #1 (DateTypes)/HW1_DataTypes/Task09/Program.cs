using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your string: ");
            string a = Console.ReadLine();
            Console.WriteLine("Enter a element of this string!");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("The element is: {0}", a[n]);
        }
    }
}
