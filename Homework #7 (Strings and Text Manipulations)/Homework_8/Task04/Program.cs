using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task04
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string word = Console.ReadLine();

            string[] sentence = text.Split('.', '!', '?');

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sentence[i].Contains(word))
                {
                    Console.WriteLine(sentence[i].Trim() + ('.'));
                }
            }
        }
    }
}
