using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    class SUV : Car
    {
        public bool IsOffRoad { get; set; }

        public SUV(string price, bool isOffRoad)
            : base(price)
        {
            this.IsOffRoad = isOffRoad;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}", this.Price, this.IsOffRoad);
        }
    }
}
