using System;
using System.Collections.Generic;
using System.Text;

namespace Rational
{
    class Rational
    {
        protected long numerator, denominator;
   
        public Rational() { 
        numerator = 0;
        denominator=1;
        }

        public Rational(long i)
        {
            numerator = i;
            denominator = 1;
        }

        public Rational(long num, long denom)
        {
            numerator = num;
            denominator = denom;
        }
        public void Imprimir()
        {
            Console.WriteLine("{0}/{1}", numerator, denominator);
        }

    }
}
