using System;
//Isaac Haro
//16/10/2020
//Prueba Parcial 2
namespace Prueba_Parcial_2_Isaac_Haro
{
    class Nodo//Clase nodo
    {
        public char datocliente;//Atributos de la clase nodo
        public Nodo siguiente;
        public Nodo comienzo;
        public Nodo()//Constructor
        {
            datocliente = '0';
            siguiente = null;
            comienzo = null;
        }
        public void PushCola(char dato)//Push Cola
        {
            if (comienzo == null)
            {
                comienzo = new Nodo();
                comienzo.datocliente = dato;
                comienzo.siguiente = null;
            }
            else
            {
                Nodo cola = new Nodo();
                cola.datocliente = dato;
                Nodo aux = comienzo;
                while (aux.siguiente != null)
                {
                    aux = aux.siguiente;
                }
                aux.siguiente = cola;
            }
        }
        public char PopCola()//Pop Cola
        {
            Nodo delete = comienzo;
            Nodo aux = comienzo;
            while (delete.siguiente != null)
            {
                aux = delete;
                delete = delete.siguiente;
            }
            aux.siguiente = delete.siguiente;
            return aux.datocliente;
        }
        public char[] EliminarCola(Nodo cola)
        {
            char[] arreglo = new char[cola.ContarCola()];
            Console.WriteLine("Cola Vacia");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.WriteLine(arreglo[i]);
            }
            return arreglo;
        }
        public void VerCola()//Imprimir la Cola
        {
            Nodo imprime = comienzo;
            while (imprime != null)
            {
                Console.WriteLine(imprime.datocliente);
                imprime = imprime.siguiente;
            }
        }
        public bool ColaVacio()// Cola vacio
        {
            bool vacio2;
            if (comienzo == null && siguiente == null)
                vacio2 = true;
            else
                vacio2 = false;
            return vacio2;
        }
        public int ContarCola()//Contar cola
        {
            Nodo contar = comienzo;
            int i = 0;
            while (contar != null)
            {
                contar = contar.siguiente;
                i++;
            }
            return i;
        }
    }
    class Program
    {
        static void deposito(Nodo cola)
        {
            int longp1;//Variable de tipo int
            char datop1;//Variable de tipo char
            Console.WriteLine("Deposito Banco\nIngrese la longitud con la que desea trabajar su cola 1(Numero de depositos)");
            longp1 = int.Parse(Console.ReadLine());
            for (int i = 0; i < longp1; i++)
            {
                Console.WriteLine("Ingrese su char {0} de su deposito 1 (Cola 1)", i + 1);
                datop1 = char.Parse(Console.ReadLine());
                cola.PushCola(datop1);
            }
            Console.WriteLine("El numero de depositos es {0} (Cola 1)", cola.ContarCola());
            Console.WriteLine("True = Cola Vacia y False = Cola Llena \nsu cola1 es " + cola.ColaVacio());
            Console.WriteLine("Esta es su cola");
            cola.VerCola();
        }
        static void retiro(Nodo cola)
        {
            int longp;
            Console.WriteLine("Retiro Banco\nIngrese cuantos datos desea eliminar de su cola 1 (Numero de retiros)");
            longp = int.Parse(Console.ReadLine());
            for (int i = 0; i < longp; i++)
            {
                cola.PopCola();
            }
            Console.WriteLine("Esta es su cola 1 con los datos eliminados(Retiros ya realizados)");
            cola.VerCola();
            Console.WriteLine("El numero de datos de su cola es {0}", cola.ContarCola());
        }
        static void Main(string[] args)
        {
            Nodo cola = new Nodo();//Variable de tipo Nodo
            char hola;
            deposito(cola);
            Console.WriteLine("Comenzamos con un deposito para poder realizar las transacciones");
            Console.WriteLine("Ingrese D para hacer deposito o R para hacer retiro");
            hola = char.Parse(Console.ReadLine());
            if (hola == 'D')
            {
                deposito(cola);
            }
            else if (hola == 'R')
            {
                retiro(cola);
            }
            else
            {
                Console.WriteLine("No realizo ninguna transaccion");
            }
            cola.EliminarCola(cola);
            Console.WriteLine("Fin programa");
        }
    }
}

