using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Thread firstThread = new Thread(new ThreadStart(new ThreadClass("First", rand).ShowInfo));
            firstThread.Start();
            Thread secondThread = new Thread(new ThreadStart(new ThreadClass("Second", rand).ShowInfo));
            secondThread.Start();
            Thread thirdThread = new Thread(new ThreadStart(new ThreadClass("Third", rand).ShowInfo));
            thirdThread.Start();
            Thread fourthThread = new Thread(new ThreadStart(new ThreadClass("Fourth", rand).ShowInfo));
            fourthThread.Start();
            Thread fifthThread = new Thread(new ThreadStart(new ThreadClass("Fifth", rand).ShowInfo));
            fifthThread.Start();
        }
    }
}
