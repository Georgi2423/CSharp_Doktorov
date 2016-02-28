using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 4, 2, 2, 3, 2, 3, 2, 3, 1, 5, 2, 7, 7, 7, 5, 7, 4 };
            List<int> newList = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int number = numbers[i];
                int count = numbers.FindAll(x => x == number).Count;

                if (count % 2 == 0 && !newList.Contains(number))
                {
                    newList.Add(number);
                }
            }

            Console.WriteLine(string.Join(", ", newList));
        }
    }
}
