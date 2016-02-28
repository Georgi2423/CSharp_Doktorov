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
            Convertor convertor = new Convertor(36.3);
            convertor.ConvertCelsiusToFahrenheit();

            Convertor newConvertor = new Convertor();
            newConvertor.Celsius = 23.5;
            newConvertor.ConvertCelsiusToFahrenheit();
        }
    }
}
