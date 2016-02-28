using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class Automobile : Car
    {
        public string Fuel { get; set; }

        public Automobile(string price, string fuel)
            : base(price)
        {
            this.Fuel = fuel;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Price, this.Fuel);

        }
    }
}
