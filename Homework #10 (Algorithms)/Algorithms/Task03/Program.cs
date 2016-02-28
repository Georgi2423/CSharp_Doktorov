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
            string text = Console.ReadLine();
            string[] words = text.Split(new char[] { ' ', ',', '.', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            IDictionary<string, int> sortedDict = new SortedDictionary<string, int>();

            foreach (var word in words)
            {
                if (sortedDict.ContainsKey(word))
                {
                    sortedDict[word]++;
                }
                else
                {
                    sortedDict.Add(word, 1);
                }
            }

            foreach (var word in sortedDict)
            {
                Console.WriteLine("{0}", word.Key);
            }
        }
    }
}
