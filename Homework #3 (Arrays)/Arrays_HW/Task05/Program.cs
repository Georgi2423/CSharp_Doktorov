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

            
            int n = int.Parse(Console.ReadLine());
            int[] firstArray = new int[n];

            int[] secondArray = new int[n];

            int couter = 0;

            for (int i = 0; i < firstArray.Length; i++)
            {

                firstArray[i] = int.Parse(Console.ReadLine());
                secondArray[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < secondArray.Length; i++)
            {


                if (firstArray[i] != secondArray[i])
                {
                    couter++;
                    break;
                }


            }
            if (couter == 0)
            {
                Console.WriteLine("Masivite sa ednakvi!");
            }
            else
            {
                Console.WriteLine("Masivite sa razlichni!");
            }
        }
    }
}
