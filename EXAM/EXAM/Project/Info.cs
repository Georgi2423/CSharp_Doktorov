using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Project
{
    public class Info
    {
        public string Country { get; set; }

        public string Capital { get; set; }

        public int People { get; set; }

        public Info(string country, string capital, int people)
        {
            this.Country = country;
            this.Capital = capital;
            this.People = people;
        }

        public Info()
        {
        }

        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.Country, this.Capital, this.People);
        }
    }
}