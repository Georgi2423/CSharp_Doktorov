using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebApplication1
{
    public class Operation
    {
        public const string FilePath = @"C:\Users\Georgi\Desktop\Information.txt";

        public static List<Info> TakeInfoFromTheBase()
        {
            var listOfDate = new List<Info>();

            using (var reader = new StreamReader(Operation.FilePath))
            {
                var currentDateLine = reader.ReadLine();

                while (currentDateLine != null)
                {
                    var currentDate = currentDateLine.Split('|');
                    var date = new Info(
                        DateTime.Parse(currentDate[0].Trim()),
                        currentDate[1].Trim(),
                        double.Parse(currentDate[2].Trim()));
                    listOfDate.Add(date);
                    currentDateLine = reader.ReadLine();
                }
            }
            return listOfDate;
        }
        public static bool AddInfo(Info infoToAdd)

        {
            try
            {
                using (StreamWriter writer = new StreamWriter(Operation.FilePath, true))
                {
                    writer.WriteLine(infoToAdd);
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}