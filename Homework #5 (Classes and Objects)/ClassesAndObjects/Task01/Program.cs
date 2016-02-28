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
            Cat firstCat = new Cat("Gosho", 3);
            Cat secondCat = new Cat("Misho", 2);
            Cat thirdCat = new Cat("Pesho", 4);
            Cat fourthCat = new Cat("Tosho", 3);
            Cat fifthCat = new Cat("Ana", 5);
            Cat sixthCat = new Cat("Monika", 3);
            Cat seventhCat = new Cat();
            seventhCat.Name = "Tomas";
            seventhCat.Age = 4;
            Cat eightCat = new Cat();
            eightCat.Name = "Megan";
            eightCat.Age = 2;
            Cat ninthCat = new Cat("Anjelica", 2);
            Cat tenthCat = new Cat("Jenifur", 5);

            Cat[] cats = new Cat[10] {firstCat, secondCat, thirdCat, fourthCat,
            fifthCat, sixthCat, seventhCat, eightCat, ninthCat, tenthCat};

            foreach (Cat item in cats)
            {
                item.SayNameAndAge();
            }
            Console.WriteLine();
        }
    }
}
