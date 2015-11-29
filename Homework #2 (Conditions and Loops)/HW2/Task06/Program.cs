using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Vuvedete broq chisla po svoi izbor: ");

            int firstNumber = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            int value = 0;
            for (int i = 0; i < firstNumber; i++)
            {
                value = int.Parse(Console.ReadLine());

                if (value > max)
                {
                    max = value;

                }
                if (value < min)
                {
                    min = value;
                }
            }
            Console.WriteLine("Nai-golqmoto chislo e: {0}", max);
            Console.WriteLine("Nai-malkoto chislo e: {0}", min);
        }
    }
}
