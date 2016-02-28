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

            string word = "are";
            string text = "We are a team. We are the best.";
            string replaced = text.Replace(word, word.ToUpper());
            Console.WriteLine(replaced);
        }
    }
}
