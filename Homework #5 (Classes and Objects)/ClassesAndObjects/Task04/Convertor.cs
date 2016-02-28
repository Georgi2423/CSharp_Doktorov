using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Convertor
    {
        public double Celsius { get; set; }

        public Convertor(double celsius)
        {
            this.Celsius = celsius;
        }

        public Convertor()
        {
        }

        public void ConvertCelsiusToFahrenheit()
        {
            double degreesInFahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine("The result is " + degreesInFahrenheit);
        }
    }
}
