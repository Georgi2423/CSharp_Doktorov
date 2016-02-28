﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {

        static void Main()
        {
            List<double> numbers = new List<double>();
            double sum = 0;

            while (true)
            {
                var input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input))
                {
                    numbers.Add(double.Parse(input));
                    sum += double.Parse(input);
                }
                else
                {
                    Console.WriteLine("The sum is: " + sum);
                    break;
                }
            }

            double average = sum / numbers.Count;
            Console.WriteLine("The average is {0:F2}", average);
        }
    }
}


