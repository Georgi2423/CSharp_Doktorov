using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task07
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("numbers.txt"))
            {
                using (StreamWriter firstWriter = new StreamWriter("oddLines.txt"))
                {
                    using (StreamWriter secondWriter = new StreamWriter("evenLines.txt"))
                    {
                        int lineNumber = 1;
                        string line = reader.ReadLine();

                        while (line != null)
                        {
                            if (lineNumber % 2 == 1)
                            {
                                firstWriter.WriteLine(line);
                            }
                            else
                            {
                                secondWriter.WriteLine(line);
                            }

                            lineNumber++;
                            line = reader.ReadLine();
                        }
                    }
                }
            }
        }
    }
}
