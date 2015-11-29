using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vuvedete stoinost za N!: ");
            int firstNumber = int.Parse(Console.ReadLine());
           
            Console.WriteLine("Vuvedete stoinost za K!: ");
            int secondNumber = int.Parse(Console.ReadLine());
            int firstfact = 1;
            int secondfact = 1;
            int thirdfact = 1;
            for (int i = 1; i < firstNumber + 1; i++)
            {
               firstfact *= i;
            }
            for (int i = 1; i < secondNumber + 1; i++)
            {
                secondfact *= i;
            }
            for (int i = 1; i < firstNumber - secondNumber; i++)
            {
                thirdfact *= i;
            }
            Console.WriteLine();
            double sum1 = firstfact / secondfact;
            Console.WriteLine("Sumata ot delenieto na N! s K! e : {0}",sum1);
            Console.WriteLine();
            double sum2 = (firstfact * secondfact) / thirdfact;
            Console.WriteLine("Sumata ot umnojenieto na N! s K! razdeleno na razlikata v ! e : {0}",sum2);
        }
    }
}
