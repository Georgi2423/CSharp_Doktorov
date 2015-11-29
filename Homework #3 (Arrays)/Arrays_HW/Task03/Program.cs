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
            Console.WriteLine("Vuvedete chislo: ");

            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i * 10;
            }
            for (int b = 0; b < arr.Length; b++)
            {
                Console.WriteLine(arr[b]);
            }
        }
    }
}
