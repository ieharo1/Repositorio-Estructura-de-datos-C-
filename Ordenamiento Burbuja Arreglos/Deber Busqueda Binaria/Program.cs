using System;
using System.Collections.Concurrent;

namespace Deber_Busqueda_Binaria
{
    class Program
    {
        static void Ordenar(int[] a)
        {
            int aux = 0;
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        aux = a[i];
                        a[i] = a[j];
                        a[j] = aux;
                    }
                }
            }
            for (int z=0; z < a.Length; z++)
            {
                Console.WriteLine(a[z]);
            }
        }
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Ingrese la longitud de su arreglo");
            a = int.Parse(Console.ReadLine());
            int[] b = new int[a];
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine($"Ingrese el dato {i + 1}");
                b[i] = int.Parse(Console.ReadLine());
            }
            Ordenar(b);
        }
    }
}
