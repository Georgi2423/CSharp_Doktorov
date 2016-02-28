using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task02
{
    public class SentenseException : Exception
    {

        public SentenseException(string message)
            : base(message)
        {
        }
    }
}



