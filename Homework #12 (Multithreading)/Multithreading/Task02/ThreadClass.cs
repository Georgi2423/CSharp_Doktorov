using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task02
{
    class ThreadClass
    {
        public ThreadClass(string name, Random rand)
        {
            this.Name = name;
            this.Sleep = rand.Next(1000, 10001);
        }

        public string Name { get; set; }

        public int Sleep { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("The thread is started!");
            PrintName();
            Thread.Sleep(this.Sleep);
            Console.WriteLine("The thread {0} complete after {1} seconds!", this.Name, this.Sleep / 1000);
        }

        private void PrintName()
        {
            Console.WriteLine("This is thread {0}!", this.Name);
        }
    }
}
