using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 3,5,5,2,3, 4, 4, 2, 3, 3, 4, 3, 2, 4, 2, 3, 5 };
            var occurences = new int[1001];

            foreach (var number in numbers)
            {
                occurences[number]++;
            }

            for (int i = 0; i < occurences.Length; i++)
            {
                if (occurences[i] != 0)
                {
                    Console.WriteLine("{0} -> {1}", i, occurences[i]);
                }
            }
        }
    }
}
