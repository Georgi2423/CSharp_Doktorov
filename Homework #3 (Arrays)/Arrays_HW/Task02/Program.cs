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
            Console.WriteLine("Vuvedete duljinata na poredicata ot chisla: ");
            int lenght = int.Parse(Console.ReadLine());
            int[] arr = new int[lenght];

            arr[0] = 1;
            arr[1] = 1;

            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = (arr[i - 1] + arr[i - 2]);
            }
            for (int a = 0; a < arr.Length; a++)
            {
                Console.WriteLine(arr[a]);
            }
        }
    }
}
