using System;
namespace ArbolBinario
{
    class Nodo
    {
        private string Contenido;
        private Nodo izq, der;// Son las referencias para los hijos
        public Nodo(string dato = null)//Constructor
        {
            Contenido = dato;
            izq = null; der = null;
        }
        //Verificacion si el arbol esta vacio
        public bool Vacio()
        {
            bool var = false;
            if (Contenido == null && izq == null && der == null)
            { var = true; }
            return var;
        }
        //Deja al arbol Vacio
        public void Vaciar()
        {
            Contenido = null;
            izq = null; der = null;
        }
        //Generar un arbol de prueba. Igual al de la teoria
        public void DatoPrueba()
        {
            if (!Vacio())
            { Vaciar(); }
            else
            {
                Nodo p = this;
                Contenido = "A";
                this.izq = new Nodo("B");
                this.der = new Nodo("E");
                p = izq;
                p.izq = new Nodo("C");
                p.der = new Nodo("D");
                p = der;
                p.der = new Nodo("F");
                p = p.der;
                p.izq = new Nodo("G");
                p.der = new Nodo("H");
            }
        }
        //Presenta por pantalla los datos en recorrido inorden o indica si el arbol esta vacia
        public void Inorden()
        {
            if (izq != null)
            { izq.Inorden(); }
            Console.WriteLine(Contenido + " ");
            if (der != null)
                der.Inorden();
        }
        public void Preorden()
        {
            Console.WriteLine(Contenido + " ");
            if (izq != null)
            { izq.Preorden(); }
            if (der != null)
            { der.Preorden(); }
        }
        public void Generar()
        {
            Vaciar();
            Console.WriteLine("Cual es la raiz....... ");
            Contenido = Console.ReadLine();
            GenerarRec();
            Console.WriteLine("Arbol ingresado correctamente");
        }
        public void GenerarRec()
        {
            string dato, op;
            Console.WriteLine("Tiene hijo por la izquierda ? S/N");
            op = Console.ReadLine().ToLower();
            if (op == "s")
            {
                Console.WriteLine("Ingrese el dato.... ");
                dato = Console.ReadLine();
                izq = new Nodo(dato);
                izq.GenerarRec();
            }
            //Derecha
            Console.WriteLine("Tiene hijo por la derecha ? S/N");
            op = Console.ReadLine().ToLower();
            if (op == "s")
            {
                Console.WriteLine("Ingrese el dato.... ");
                dato = Console.ReadLine();
                izq = new Nodo(dato);
                izq.GenerarRec();
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Nodo arbol = new Nodo();
            arbol.DatoPrueba();
            arbol.Inorden();
            arbol.Preorden();
            arbol.Generar();
            Console.ReadKey();
        }
    }
}