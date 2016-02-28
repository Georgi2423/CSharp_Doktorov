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
            Triangle firstTriangle = new Triangle(4, 3);
            firstTriangle.FindingTheHypotenuse();

            Triangle secondTriangle = new Triangle(6, 5);
            secondTriangle.FindingTheHypotenuse();
        }
    }
}
