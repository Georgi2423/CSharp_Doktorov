using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{

    public abstract class Person
    {
        public static int personCount = 0;

        public string Name { get; protected set; }

        public string Family { get; protected set; }

        private int yearsExperience;
        public int YearsExperience
        {
            get { return this.yearsExperience; }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Year's experience must be a positive integer!");
                }

                this.yearsExperience = value;
            }
        }

        public Person()
        {
        }

        public Person(string name, string family, int yearsExperience)
        {
            this.Name = name;
            this.Family = family;
            this.YearsExperience = yearsExperience;
            personCount += 1;
        }
    }
}
