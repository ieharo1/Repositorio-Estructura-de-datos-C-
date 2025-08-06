using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSE
{
    //clase que define el nodo de la lista
    public class ListaSimple
    {
        public Object dato; // dato contenido en el nodo
        public ListaSimple siguiente; // puntero al siguiente nodo
        public ListaSimple comienzo; //Cabecera de la lista

        public void InsertarComienzo(Object dato)
        {

            ListaSimple Añadir = new ListaSimple();

            Añadir.dato = dato;
            Añadir.siguiente = comienzo;
            comienzo = Añadir;
        }

        public void InsertarFinal(Object dato)
        {

            if (comienzo == null)
            {
                comienzo = new ListaSimple();

                comienzo.dato = dato;
                comienzo.siguiente = null;
            }
            else
            {
                ListaSimple añadir = new ListaSimple();
                añadir.dato = dato;

                ListaSimple actual = comienzo;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }

                actual.siguiente = añadir;
            }
        }

        public void imprimeTodosLosNodos()
        {
            Console.WriteLine("Imprime:");

            ListaSimple actual = comienzo;
            while (actual != null)
            {
                Console.WriteLine(actual.dato);
                actual = actual.siguiente;
            }
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Añade al inicio:");
            ListaSimple miNodo1 = new ListaSimple();


            miNodo1.InsertarComienzo("Hola");
            miNodo1.InsertarComienzo("Mundo");
            miNodo1.InsertarComienzo("Dato3");
            miNodo1.imprimeTodosLosNodos();

            Console.WriteLine();

            Console.WriteLine("Añade al final:");
            ListaSimple miNodo2 = new ListaSimple();

            miNodo2.InsertarFinal("Hola");
            miNodo2.InsertarFinal("Mundo");
            miNodo2.InsertarFinal("Dato3");
            miNodo2.imprimeTodosLosNodos();

            Console.ReadLine();

        }
    }
}

