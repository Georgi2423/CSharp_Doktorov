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
            string text = Console.ReadLine();
            var words = text.Split(new char[] { ' ', ',', '.', '!', '?', ';' }, StringSplitOptions.RemoveEmptyEntries);
            HashSet<string> result = new HashSet<string>(words);

            foreach (var word in result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
