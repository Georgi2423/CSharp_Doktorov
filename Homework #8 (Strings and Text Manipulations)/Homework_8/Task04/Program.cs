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

            string[] str = text.Split(new char[] { '.' }, StringSplitOptions.RemoveEmptyEntries);
            StringBuilder output = new StringBuilder();

            foreach (string sentance in str)
            {
                StringBuilder currnetWord = new StringBuilder();

                foreach (var ch in sentance + '.')
                {
                    if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
                    {
                        currnetWord.Append(ch);
                    }
                    else
                    {
                        if (currnetWord.ToString().ToLower() == word.ToLower())
                        {
                            output.AppendLine(sentance.Trim() + '.');
                            break;
                        }
                        currnetWord.Clear();
                    }
                }
            }

            Console.WriteLine(output);

        }
    }
}
