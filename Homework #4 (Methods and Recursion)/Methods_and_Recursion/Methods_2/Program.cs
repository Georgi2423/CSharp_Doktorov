using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            name = PrintName();
            Console.WriteLine("Greetings, {0} !", name);

            PrintName();
        }

        private static string PrintName()
        {

            string name;
            name = Console.ReadLine();
            return name;
        }
    }
}
