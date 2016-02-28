using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (StreamReader reader = new StreamReader("file1.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        if (CheckSentence(line))
                        {
                            Console.WriteLine(line);
                            line = reader.ReadLine();
                        }
                        else
                        {
                            throw new SentenseException("Your sentence is not completed!");
                        }
                    }
                }
            }

            catch (SentenseException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private static bool CheckSentence(string line)
        {
            if (line.EndsWith(".") || line.EndsWith("!") || line.EndsWith("?"))
            {
                return true;
            }

            return false;
        }
    }
}

