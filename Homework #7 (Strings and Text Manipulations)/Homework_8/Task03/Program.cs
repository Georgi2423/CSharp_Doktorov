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
            string text = "I am George, i am 21 years old and i am a basketball player.";
            string word = string.Empty;
            string substring = "am";
            int substringCounter = 0;

            for (int i = 0; i < text.Length; i++)
            {
                word += text[i];
                if (word.Length == substring.Length)
                {
                    if (word.ToLower() == substring.ToLower())
                    {
                        substringCounter++;
                    }
                    word = string.Empty;
                    word += text[i];
                }
            }
            Console.WriteLine(text);
            Console.WriteLine("Dumata '{0}' se sreshta {1} puti!",substring, substringCounter);


        }
    }
}
