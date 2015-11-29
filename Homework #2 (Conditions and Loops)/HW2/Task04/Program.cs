using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete 2 chisla: ");
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int NOD = 0;
            int biggerNumber;
            if (firstNumber>secondNumber)
            {
                biggerNumber = firstNumber;

            }
            else
            {
                biggerNumber = secondNumber;
            }
            for (int i = 1; i < biggerNumber; i++)
            {
                if (firstNumber % i == 0 && secondNumber%i ==0)
                {
                    NOD = i;
                }
            }
            Console.WriteLine("Nai-golemiqt obsht delitel e: {0}",NOD);
        }
    }
}
