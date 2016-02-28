using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03
{
    public  class ThreadClass
    {
        public void PrintNumbers()
        {
            for (int i = 0; i <= 50000; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void PrintText()
        {
            for (int i = 0; i < 25000; i++)
            {
                Console.WriteLine("Running");
                Thread.Sleep(300);
            }
        }
    }
}
