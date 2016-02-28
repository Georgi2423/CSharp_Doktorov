using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string fileName = "firstText.txt";
                ReadFile(fileName);

                string otherFile = "secondText.txt";
                WriteFile(otherFile);
            }
            catch (FileNotFoundException fnfe)
            {
                Console.WriteLine(fnfe.Message);
            }
            catch (IOException ioe)
            {
                Console.WriteLine(ioe.StackTrace);
            }
        }

        private static void ReadFile(string fileName)
        {
            using (StreamReader reader = new StreamReader("firstText.txt"))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        private static void WriteFile(string otherFile)
        {
            using (StreamWriter writer = new StreamWriter("secondText.txt"))
            {
                writer.WriteLine(Console.ReadLine());
            }
        }
    }
}
