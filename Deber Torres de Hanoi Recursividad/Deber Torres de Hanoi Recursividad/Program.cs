//Isaac Haro
//1/11/2020
//Torres de hanoi con recursividad
using System;
namespace Deber_Torres_de_Hanoi_Recursividad
{
    class Program//Clase program
    {
        static void Main(string[] args)//Programa Principal
        {
            int n;//Variable
            Console.WriteLine("Ingrese cuantos discos dese para resolver la torre de hanoi");//Ingreso del numero de discos de la torre de hanoi
            n = int.Parse(Console.ReadLine());//Lee el numero de discos
            if (n < 0)//Si n es menor a 0 vuelve a ingresar el numero de discos para poder trabajar
            {
                Console.WriteLine("Error, ingrese nuevamente cuantos discos desea");
                n = int.Parse(Console.ReadLine());
            }
            Torredehanoi(n, "Torre Izquierda", "Torre Medio", "Torre Derecha");//Llama a la funcion de torre de hanoi
            Console.WriteLine("Fin");//Imprime fin
        }
        public static void Torredehanoi(int n, string izq, string med , string der)//Funcion para imprimir la solucion de la torre de hanoi
        {
            if (n == 0) return;//si es igual a 0 retorna vacio
            Torredehanoi(n-1, izq, der, med);//usamos la recursividad para imprimir el movimiento de los discos
            Console.WriteLine("Mover disco {0} de {1} a {2}",n,izq,der);//imprime el moviemiento de los discos
            Torredehanoi(n - 1, med, izq, der);//usamos la recursividad para mover los discos
        }
    }
}
