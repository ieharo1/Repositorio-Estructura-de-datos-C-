using System;
using System.Collections.Generic;

//Isaac Haro
//Examen final estructura de datos
namespace ExamenfinalIsaac
{
    class Program//Programa Principal
    {
        static void Main(string[] args)
        {
            int c;
            string [] split;
            Console.WriteLine("Bienvenido ingrese 1: para crear su arbol y 2: para crear su lista");
            c = int.Parse(Console.ReadLine());
            switch (c)
            {
                case 1://caso A
                    Console.WriteLine("Ingrese su cadena de int seguido de una coma\nEjemplo: 1,2,3.....");
                    split = Console.ReadLine().Split(",");
                    int[] array = new int[split.Length];
                    for (int i = 0; i < split.Length; i++)
                    {
                        array[i] = int.Parse(split[i]);
                    }
                    Arbol Arbol1 = new Arbol();
                    Arbol1.Ingreso(array);
                    Arbol1.Imprimir();
                    Arbol1.Contador(array);
                    break;
                case 2://caso B
                    int longi, dat;
                    Console.WriteLine("Ingrese la longitud de su lista");
                    longi = int.Parse(Console.ReadLine());
                    List<int> hola = new List<int>();
                    for (int i = 0; i < longi; i++)
                    {
                        Console.WriteLine($"Ingrese su dato {i+1}");
                        dat = int.Parse(Console.ReadLine());
                        hola.Add(dat);
                    }
                    Console.WriteLine("Su lista original es: ");
                    for (int i = 0; i < hola.Count; i++)
                    {
                        Console.Write(hola[i]+" "); 
                    }

               
                    break;
            }
        }
    }
    class Nodo//Clase Nodo
    {
        public int dato;
        public Nodo izquierdo;
        public Nodo derecho;
        public Nodo()//Constructor
        {
            izquierdo = null;
            derecho = null;
        }
    }
    class Arbol//clase arbol
    {
        public Nodo raiz;
        public int aux;
        public Arbol()
        {
            raiz = null;
        }
        public Nodo SetIzquierdo(Nodo p, int x)//Funcion para agregar directamente el nodo en el lado izquierdo
        {
            if (p.izquierdo == null)
            {
                p.izquierdo = new Nodo();
                p.izquierdo.dato = x;
            }
            return p.izquierdo;
        }
        public Nodo SetDerecho(Nodo p, int x)//Funcion para agregar directamente el nodo en el lado derecho
        {
            if (p.derecho == null)
            {
                p.derecho = new Nodo();
                p.derecho.dato = x;
            }
            return p.derecho;
        }
        public void Imprimir()//Sobrecarga de función que nos permite llamar a la otra función Imprimir
        {
            Imprimir(raiz, 4);
        }
        public void Imprimir(Nodo p, int padding)//Función que nos permite imprimir todos los nodos de nuestro árbol
        {
            if (p != null)
            {
                if (p.derecho != null)
                {
                    Imprimir(p.derecho, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.derecho != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.dato + "\n ");
                if (p.izquierdo != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Imprimir(p.izquierdo, padding + 4);
                }
            }
        }
        public void Ingreso(int[] array)//ingreso
        {
            string ingreso;
            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.dato = array[0];
            }
            Nodo aux = raiz;
            for (int i = 1; i < array.Length; i++)
            {
                Console.WriteLine($"A que lado desea ingresar el siguiente digito dentro de su arbol binario {array[i]} ingrese la palabra izquierda o derecha");
                ingreso = Console.ReadLine().ToUpper();
                if (ingreso == "IZQUIERDA")
                {
                    aux = SetIzquierdo(aux, array[i]);
                }
                else if (ingreso == "DERECHA")
                {
                    aux = SetDerecho(aux, array[i]);
                }
                else
                {
                    Console.WriteLine("Digito mal ingresado");
                }
            }
        }
        public void Contador(int[] array)//aux
        {
            int aux, aux2=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    aux = array[i];
                    if (aux >= aux2)
                    {
                        aux2 = aux;
                    }
                }

            }
            Console.WriteLine($"El digito par mas pesado del arbol es: {aux2}");
        }
    }
}
