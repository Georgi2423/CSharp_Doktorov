using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task06
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader(@"..\..\firstText.txt"))
            {
                using (StreamWriter writer = new StreamWriter(@"..\..\secondText.txt"))
                {
                    string line = reader.ReadLine();
                    char[] separator = { ',', '.', '!', '?', ';', ':' };

                    while (line != null)
                    {
                        string[] newText = line.Split(separator, StringSplitOptions.RemoveEmptyEntries);
                        foreach (var item in newText)
                        {
                            writer.WriteLine(item);
                        }

                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
