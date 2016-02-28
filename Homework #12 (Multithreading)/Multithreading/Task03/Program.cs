using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task03
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadClass threadClass = new ThreadClass();

            Thread thread1 = new Thread(new ThreadStart(threadClass.PrintNumbers));
            Thread thread2 = new Thread(new ThreadStart(threadClass.PrintText));

            thread1.Start();
            thread2.Start();
            thread1.Join();
        }
    }
}
