using System;

namespace Rational
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational x = new Rational();
            Rational y = new Rational(3);
            Rational z = new Rational(5,4);

            x.Imprimir();
            y.Imprimir();
            z.Imprimir();
        }
    }
}
