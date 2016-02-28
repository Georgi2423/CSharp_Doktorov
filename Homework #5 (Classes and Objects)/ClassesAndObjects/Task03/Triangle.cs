using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task03
{
    class Triangle
    {
        public double FirstCathetus { get; set; }

        public double SecondCathetus { get; set; }

        public Triangle(double a, double b)
        {
            this.FirstCathetus = a;
            this.SecondCathetus = b;
        }

        public Triangle()
        {
        }

        public void FindingTheHypotenuse()
        {
            double c = Math.Sqrt((FirstCathetus * FirstCathetus) + (SecondCathetus * SecondCathetus));
            Console.WriteLine("The hypotenuse is {0}", c);
        }
    }
}
