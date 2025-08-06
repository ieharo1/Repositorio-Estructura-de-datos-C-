using System;
namespace Proyecto
{
    class Program
    {
        static int Fact(int n)
        {
            if (n == 0)
                return 1;
            else
                return (n * Fact(n - 1));
        }
        static int NumbNatu(int a, int b)
        {
            if (b == 1)
                return a;
            else
                return NumbNatu(a, (b - 1)) + a;
        }
        static int Fibonacci(int a)
        {
            if (a.Equals(1) || a.Equals(0))
                return a;
            else
                return Fibonacci(a - 1) + Fibonacci(a - 2);
        }

        static void Main(string[] args)
        {
            int h = 0, fact, a,b,fibo,fibo2;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (h != 5)
            {
                Console.WriteLine("Ingrese 1: Factorial 2:Multiplicacion 3:Fibonacci 4:Fin del Programa ");
                h = int.Parse(Console.ReadLine());
                switch (h)
                {
                    case 1:
                        Console.WriteLine("Ingrse el factorial");
                        fact = int.Parse(Console.ReadLine());
                        Console.WriteLine($"Su factorial es: {Fact(fact)}");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el 1er digito para multiplicar:");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el 2do digito para multiplicar");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine($"La multiplicacion es: {NumbNatu(a,b)}");
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el la posicion que busca del numero de Fibonacci");
                        fibo = int.Parse(Console.ReadLine());
                        Console.WriteLine($"El numero de fibonacci segun la posicion es: {Fibonacci(fibo)}");
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Numero mal ingresado intente nuevamente");
                        break;
                }
            }
        }
    }
}
