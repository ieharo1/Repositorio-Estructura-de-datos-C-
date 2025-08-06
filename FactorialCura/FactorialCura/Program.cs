//Isaac Haro
//28/10/2020
//Ejercicio en clase
using System;

namespace Factorialfiboynumenatural
{
    class Program
    {
        //Funcion Calculo Factorial
        static int Fact(int n)//Funcion factorial
        {
            int x, y;//definicion de variables temporales
            if (n == 0)
                return 1;//Si n es igual a 0 retornamos 1
            else//Si n es diferente de 0 realizamos las operaciones del factorial
            {
                x = n - 1;
                y = Fact(x);
                return (n * y);
            }
        }
        static int NumbNatu(int a, int b)//Funcion Numero Natural
        {
            if (b == 1)//Si b es igual a 1 retornamos a
                return a;
            else//Si b es diferente de 0 retornamos la multiplicacion de uno en uno
                return NumbNatu(a, (b - 1)) + a;
        }
        static int Fibonacci(int a)//Funcion Fibonacci
        {
            if (a.Equals(1) || a.Equals(0))//Retorna a
                return a;
            else
                return Fibonacci(a - 1) + Fibonacci(a - 2);//Contabiliza los numeros de fibonacci
        }
        //Funcion busqueda binaria 
        static int binaria(int[]arreglo,int x, int low, int high)
        {
            int medio;
            if (low > high)
                return -1;
            else
            {
                medio = (low + high) / 2;
                if (x == arreglo[medio])
                    return medio;
                else
                {
                    if (x < arreglo[medio])
                    return   binaria(arreglo,x, low, medio - 1);
                       
                    else
                        return binaria(arreglo, x, medio + 1,high);
                }
            }
        }
        static void Main(string[] args)//Programa Principal
        {
            int[] Datos = { 1, 2, 3, 4, 5};
            int x,a,b, h=0, f;//Variables
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (h != 5)
            {
                Console.WriteLine("Ingrese 1:Factorial 2:Numero Natural 3:Fibonacci 4:Binaria o 5:Fin del programa");//Seleccion del usuario para trabajar
                 h = int.Parse(Console.ReadLine());
            
                switch (h)//Switch
                {
                    case 1://Factorial
                        Console.WriteLine("Factorial\nIngrese el factorial que desea encontrar");
                        x = int.Parse(Console.ReadLine());
                        Console.WriteLine("Su factorial es" + Fact(x));
                        break;
                    case 2://Numero Natural
                        Console.WriteLine("Ingrese el primer valor para multiplicar");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo valor para multilicar");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("Su numero natural es" + NumbNatu(a, b));
                        break;
                    case 3://Fibonacci
                        Console.WriteLine("Fibonacci\nIngrese el numero de fibonacci que desea encontrar");
                        f = int.Parse(Console.ReadLine());
                        Console.WriteLine("Su numero de fibonacci es " + Fibonacci(f));
                        break;
                    case 4://Binaria
                        Console.WriteLine(binaria(Datos,3,0,Datos.Length-1));
                        break;
                    case 5://Salida
                        break;
                    default:
                        Console.WriteLine("NUMERO MAL INGRESADO INTENTE NUEVAMENTE");
                        break;
                }
                Console.ReadKey();//Permite visualizar la respuesta antes de limpiar la consola
                Console.Clear();//Limpia la consola
            }
        }
    }
}
