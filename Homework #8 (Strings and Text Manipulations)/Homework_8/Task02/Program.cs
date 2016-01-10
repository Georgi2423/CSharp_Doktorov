using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string str = "V momenta karam kurs po csharp, kudeto programiraneto na csharp e zaduljitelno!";
            string str1 = "csharp";

            for (int i = 0; i < str.Length; i++)
            {
                str1 += str[i];
               
            }
            Console.WriteLine(str1.ToUpper());
        }
    }
}
