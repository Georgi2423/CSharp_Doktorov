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
            Automobile AudiA8 = new Automobile("130000 lv.", "8 L/100 km.");
            Automobile BMWX5 = new Automobile("120000 lv.", "8 L/100 km.");
            Automobile Maserati = new Automobile("250000 lv.", "14.5 L/100 km.");
            Automobile HyundaiI30 = new Automobile("25000 lv.", "6 L/100 km.");
            Automobile Mercedese220 = new Automobile("32000 lv.", "7 L/100 km.");
            SUV InfinitiQX50 = new SUV("80000 lv.", true);
            SUV VolkswagenTouareg = new SUV("90000 lv.", true);
            SUV PorscheCayenne = new SUV("100000 lv.", true);
            SUV ToyotaLandCruiser = new SUV("90000 lv.", true);
            SUV MercedesGLK = new SUV("80000 lv.", true);

            Car[] array = new Car[]
            {
                AudiA8, BMWX5, Maserati, HyundaiI30, Mercedese220, InfinitiQX50,
                VolkswagenTouareg, PorscheCayenne, ToyotaLandCruiser, MercedesGLK
            };

            foreach (var item in array)
            {
                Console.WriteLine(item);
            }

        }
    }
}
