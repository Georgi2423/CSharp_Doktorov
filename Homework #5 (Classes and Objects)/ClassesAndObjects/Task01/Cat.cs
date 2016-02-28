using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Cat()
        {
        }

        public void SayNameAndAge()
        {
            Console.WriteLine("Cat {0} is {1} years old.", Name, Age);
        }
    }
}
