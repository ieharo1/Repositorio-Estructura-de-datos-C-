using System;

namespace Torres_de_Hanoi_recursividad
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Escribe el número de discos en la torre de hanoi: ");
            n = Leer.datoInt();
            if (n < 0)
            {
                Console.WriteLine("Error, reescriba el número de discos en la tarea: ");
                n = Leer.datoInt();
            }
            algoritmoHanoi(n, "Torre Izquierda", "Torre Central", "Torres Derecha");
        }
        public static void algoritmoHanoi(int n, String from, String temp, String to)
        {
            if (n == 0) return;
            algoritmoHanoi(n - 1, from, to, temp);
            System.Console.WriteLine("Mover disco " + n + " de " + from + " a " + to);
            algoritmoHanoi(n - 1, temp, from, to);
        }
    }
    public class Leer
    {
        public static int datoInt()
        {
            string dato;
            dato = System.Console.ReadLine();
            return int.Parse(dato);
        }
    }
}
