using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task05
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int bracket = 0;
            bool isCorrect = false;
            foreach (char symbol in str1)
            {
                if (symbol == '(')
                {
                    bracket++;
                }
                if (symbol == ')')
                {
                    bracket--;
                }
                if (bracket < 0)
                {
                    break;
                }
            }
            if (bracket == 0)
            {
                isCorrect = true;
            }
            if (isCorrect)
            {
                Console.WriteLine("Korektno postaveni skobi!");
            }
            else
            {
                Console.WriteLine("Nekorektno postaveni skobi!");

            }
        }
    }
}
