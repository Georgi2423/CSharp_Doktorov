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
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];
            Random rand = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = rand.Next(1, 100);
            }

            int startArraySort = Environment.TickCount;
            Array.Sort(numbers);
            Console.WriteLine("Array sort in miliseconds: " + (Environment.TickCount - startArraySort));

            int startSort = Environment.TickCount;
            var sortedOdd = numbers
                .Where(number => number % 2 == 1)
                .OrderByDescending(number => number);
            Console.WriteLine("Array sort in milisecond: " + (Environment.TickCount - startSort));

            int lastArray = Environment.TickCount;
            var sortedEven = numbers
                .Where(number => number % 2 == 0)
                .OrderBy(number => number);
            Console.WriteLine("Array sort in miliseconds: " + (Environment.TickCount - lastArray));

        }
    }
}
