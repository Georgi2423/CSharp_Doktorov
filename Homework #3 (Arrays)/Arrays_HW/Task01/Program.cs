using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] myArr = new int[n];
            int sum = 0;

            Random rand = new Random();

            for (int i = 0; i < myArr.Length; i++)
            {
                myArr[i] = rand.Next(0, 10);
                Console.WriteLine(myArr[i]);
            }
            for (int i = 0; i < myArr.Length; i++)
            {
                if (myArr[i] % 2 == 0)
                {
                    sum += myArr[i];
                }
                
            }
            Console.WriteLine(sum);

        }

    }
}

