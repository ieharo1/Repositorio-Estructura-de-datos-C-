using System;
using System.Collections.Generic;
using System.Text;

namespace Rational_poo_Haro_Isaac
{
    class Rational
    {
        public long numerador;
        public long denominador;
        public Rational()
        {
            numerador = 0;
            denominador = 1;
        }
        public Rational(long i)
        {
            numerador = i;
            denominador = 1;
        }
        public Rational(long num, long dem)
        {
            numerador = num;
            denominador = dem;
        }
        public void Imprimir()
        {
            Console.WriteLine("{0}/{1}",numerador,denominador);
        }
    }
}
