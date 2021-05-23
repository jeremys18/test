using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calc
{
    class Calc
    {
        static public decimal Multiply (decimal d1, decimal d2)
        {
            decimal s=d1* d2;
            return (s);
        }

        static public decimal Divide (decimal d1, decimal d2)
        {
            decimal s = d1 / d2;
            return (s);
        }
        static public decimal Add(decimal d1, decimal d2)
        {
            decimal s = d1 + d2;
            return (s);
        }
        static public decimal Subract(decimal d1, decimal d2)
        {
            decimal s = d1 - d2;
            return (s);
        }
    }

}
