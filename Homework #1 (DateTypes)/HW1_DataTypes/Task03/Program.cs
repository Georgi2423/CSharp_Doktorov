using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "Hello CSharp";
            Console.WriteLine(myString == "Hello World"); //False

            string myString2 = "Hello World";
            Console.WriteLine(myString2 == "Hello World"); // True
        }
    }
}
