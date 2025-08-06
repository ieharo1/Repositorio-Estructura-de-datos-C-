using System;
using System.Collections.Generic;
namespace FINAL_DOS
{
    // Clase Nodo con la que manejaremos los datos de nuestro grafo
    class Nodo
    {
        //atributos de la clase
        private string Dato;
        private Nodo Siguiente;
        //Constructores
        public Nodo()
        {
            Dato = null;
            Siguiente = null;
        }
        public Nodo(string d)
        {
            Dato = d;
            Siguiente = null;
        }
        public Nodo siguiente
        {
            get { return Siguiente; }
            set { Siguiente = value; }
        }
        public string dato 
        {
            get { return Dato; }
            set { Dato = value; }
        }

    }
    //Clase Program
    class Program
    {
        //Función INICIALIZAR que ingresa la respectiva información de cada nodo
        public static void INICIALIZAR(List<Nodo> p1)
        {
            string[] n2;
            char r;
            for (int i = 0; i < p1.Count; i++)
            {
                Nodo comienzo = p1[i];
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("¿Su nodo "+p1[i].dato+" tiene alguna conexión?");
                r = char.Parse(Console.ReadLine().ToUpper());
                if (r == 'S')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("A qué nodo se conecta su nodo: " + p1[i].dato);
                    n2 = Console.ReadLine().Split(",");
                    for (int j = 0; j < n2.Length; j++)
                    {
                        comienzo.siguiente = new Nodo(n2[j]);
                        comienzo = comienzo.siguiente;
                    }
                } 
            }
        }
        //Función PrintList que imprime las Listas que creamos en el programa
        public static void PrintList(List<Nodo> p1)
        {
            Console.WriteLine("Esta es su lista de adyacencia:");
            
            for (int i = 0; i < p1.Count; i++)
            {
                Nodo aux = p1[i];
                while (aux != null)
                {
                    if (aux.siguiente != null)
                    { Console.Write(aux.dato + "->"); }
                    else
                    { Console.Write(aux.dato); }
                    aux =aux.siguiente;
                }
                Console.WriteLine(" ");
            }
            
        }
        //Función PrintStack que imprime las pilas que creamos en el programa
        public static void PrintStack(Stack<string> s1)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Esta es su pila de adyacencia:");
            string[] aux = s1.ToArray();
            for (int i = aux.Length-1; i >= 0; i--)
            {
                if (i != 0)
                { Console.Write(aux[i] + "->"); }
                else 
                { Console.Write(aux[i]); }
            }
        }
        //Función Pila que raliza el proceso de búsqueda profunda
        public static void Pila(List<Nodo> p1,Stack<string> s1) 
        {
            string op;
            Stack<string> s2 = new Stack<string>();
            Console.WriteLine("¿Desde qué nodo desea empezar su búsqueda en profundidad?");
            op = Console.ReadLine().ToUpper();
            int k=0, j = 0;
            while (p1[k].dato!=op)
            {
                k++;
            }
            Console.WriteLine("Prueba: "+p1[k].dato);
            s2.Push(p1[k].dato);
          
            Nodo aux2 = p1[k];
            for (int i = 0; i < p1.Count-1; i++)
            {
                //Console.WriteLine(".siguiente: "+aux2.siguiente.dato);
                
                while (aux2.siguiente != null)
                {
                    aux2 = aux2.siguiente;
                    
                    s1.Push(aux2.dato);
                }
                string[] aux = s1.ToArray();
                s1.Clear();
                //s1 = Eliminar(aux, s1);
                //string[] aux3 = Eliminar(aux, s1).ToArray();
                s1 = Eliminar2(Eliminar(aux, s1).ToArray(), s2);
                string[] aux5 = s1.ToArray();
                //Console.WriteLine("Longitud arreglo: "+aux5.Length);
                if (aux5.Length!=0)
                {
                    s2.Push(s1.Pop());
                    //PrintStack(s2);
                    Console.WriteLine(" ");
                    string[] aux4 = s2.ToArray();
                    Console.WriteLine("PEEK: " + aux4[0]);
                    //Console.WriteLine("p1: "+ aux4[0]);
                    j = 0;
                    do
                    {
                        if (p1[j].dato != aux4[0])
                        { j++; }
                    } while (p1[j].dato != aux4[0]);
                    aux2 = p1[j];
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("Su busqueda en profundidad es:");
            PrintStack(s2);
        }
        //Función Eliminar2 que elimina nodos repetidos de la pila 1 en la pila de salida
        public static Stack<string> Eliminar2(string[] aux, Stack<string> s2)
        {
            Stack<string> saux = new Stack<string>();
            string[] principal = s2.ToArray();
            for (int k = 0; k < aux.Length; k++)
            {
                for (int i = 0; i < principal.Length; i++)
                {
                    if (aux[k] == principal[i])
                    {
                        aux[k] = null;
                    }
                }
            }
            
            for (int j = aux.Length-1; j >= 0; j--)
            {
                if (aux[j] != null)
                {
                    saux.Push(aux[j]);
                    Console.WriteLine(aux[j]);
                }

            }
            return saux;
        }
        //Función Eliminar que elimina elementos repetidos en nuestro STACK
        public static Stack<string> Eliminar(string[] aux,Stack<string> s1)
        {
           // Stack<string> saux = new Stack<string>();
            for (int j = 0; j < aux.Length; j++)
            {
                for (int k = 0; k < aux.Length; k++)
                {
                    if (k == j&&j!=aux.Length-1)
                      { k++; }
                    if (aux[j] == aux[k]&&j!= aux.Length - 1&&k!= aux.Length - 1)
                      { aux[j] = null; }
                    if(j== aux.Length - 1 && aux[k] == aux[j]&&k!= aux.Length - 1)
                      { aux[j] = null; }
                }
            }
            
            Console.WriteLine("CONEXIONES DEL NODO:");
           // Console.WriteLine("La longitud de su arreglo es: "+aux.Length);
            for (int i = aux.Length-1; i >= 0; i--)
            {
                if (aux[i] != null)
                {
                    s1.Push(aux[i]);
                    //Console.WriteLine(aux[i]);
                }
                
            }
            return s1;
        }
        //Programa Principal
        static void Main(string[] args)
        {
           
            string[] n;
            
            Nodo aux; //Creación de un Nodo aux
            List<Nodo> p1 = new List<Nodo>(); //Creación de una Lista
            Stack<string> s1 = new Stack<string>(); // Creación de una Pila
            //PRESENTACIÓN:
            Console.WriteLine("                                   BIENVENIDO A BÚSQUEDA PROFUNDA DE GRAFOS DIRIGIDOS");
            Console.WriteLine("                                       ESTRUCTURA DE DATOS");
            Console.WriteLine("TERCER SEMESTRE");
            Console.WriteLine("INTEGRANTES: Alan Guijarro, Martín Guerra, Isaac Haro, Jack Narváez");
            Console.WriteLine("..........................................................");
            //Ingreso de datos
            Console.WriteLine("Ingrese los nodos con los que va a trabajar");
            n = Console.ReadLine().Split(",");
            //Guardamos los datos en una Lista
            for (int i = 0; i < n.Length; i++)
            {
                aux = new Nodo(n[i]);
                p1.Add(aux);
            }
            //Llamada a nuestras funciones
            INICIALIZAR(p1);
            PrintList(p1);
            Pila(p1, s1);
        }            
    }
}
