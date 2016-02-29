using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Project
{
    public class Operation
    {
        public const string FilePath = @"C:\Users\Georgi\Desktop\Country.txt";

        public static List<Info> TakeInfoFromTheList()
        {
            var listOfCapital = new List<Info>();
            using (var reader = new StreamReader(Operation.FilePath))
            {
                var currentCapital = reader.ReadLine();

                while (currentCapital != null)
                {
                    var currentCountry = currentCapital.Split('|');
                    var people = new Info(
                        currentCountry[0].Trim(),
                        currentCountry[1].Trim(),
                        int.Parse(currentCountry[2].Trim()));
                    listOfCapital.Add(people);
                    currentCapital = reader.ReadLine();
                }
            }
            return listOfCapital;
        }
        public static bool AddInfo(Info infoToAdd)

        {
            try
            {
                using (StreamWriter writer = new StreamWriter(FilePath, true))
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