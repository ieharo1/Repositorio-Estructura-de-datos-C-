using System;
//ISAAC HARO
//TERCER SEMESTRE
//VERSION 0.2 motivo por imprimir en consola
//14/10/2020
//ESTRUCTURA DE DATOS
namespace Deber_Isaac_Haro
{
    public class Nodo//CLASE NODO
    {
        public Object fact;//DATO
        public Nodo next;//SIGUIENTE
        public Nodo start;//COMIENZO
        public void Add_start(Object fact)//FUNCION PARA AÑADIR AL INICIO
        {
            Nodo add_start = new Nodo();
            add_start.fact = fact;//GUARDA EL DATO EN EL NODO
            add_start.next = start;//SIGUIENTE VA A SER COMIENZO
            start = add_start;//COMIENZO VA A SER EL NODO
        }
        public void Add_final(Object fact)//FUNCION PARA AÑADIR AL FINAL
        {
            if(start == null)//SI ES NULL LOS DATOS SE GUARDAN EN NODO
            {
                start = new Nodo();
                start.fact = fact;
                start.next = null;
            }
            else// SI NO ES LLENA LOS SIGUIENTES DATOS
            {
                Nodo add_final = new Nodo();
                add_final.fact = fact;
                Nodo aux = start;
                while (aux.next != null)
                {
                    aux = aux.next;
                }
                aux.next = add_final;
            }
        }
        public Object Delete_start()//FUNCION PARA BORRAR EN EL INICIO
        {
            Nodo delete = new Nodo();
            delete = start;
            start = delete.next;
            return delete.fact;

        }
        public Object Delete_final()//FUNCION PARA BORRAR EN EL FINAL
        {
            Nodo delete = start;
            Nodo aux = start;
            while (delete.next != null)
            {
                aux = delete;
                delete = delete.next;
            }
            aux.next = delete.next;
            return aux.fact;    
        }
        public void Print()//FUNCION PARA IMPRIMIR
        {
            Nodo print = start;
            while (print != null)
            {
                Console.WriteLine(print.fact);
                print = print.next;
            }
        }
    }
    class Program//CLASE PROGRAM
    {
        static public void Start()//Funcion para imprimir el inicio
        {
            int h, hd;
            Object fact;//VARIABLE DATO
            Nodo start = new Nodo();//Nodo inicio
            Console.Title = "List";//TITULO DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("List add start");
            Console.WriteLine("Introduce the lenght with you want to work");
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            h = int.Parse(Console.ReadLine());
            for (int i = 0; i < h; i++)
            {
                Console.WriteLine("Introduce the fact{0}", i + 1);
                fact = Console.ReadLine();
                start.Add_start(fact);
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("This is list in start");
            start.Print();
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("Introduce how much facts want to delete");
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            hd = int.Parse(Console.ReadLine());
            for (int i = 0; i < hd; i++)
            {
                start.Delete_start();
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("This is list deleted {0}", hd);
            start.Print();
        }
        static public void Final()//funcion para imprimir el final
        {
            int f, fd;//VARIABLES
            Object fact;//VARIABLE DATO
            Nodo final = new Nodo();//Nodo final
            Console.Title = "List";//TITULO DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("List add final");
            Console.WriteLine("Introduce the lenght with you want to work");
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            f = int.Parse(Console.ReadLine());
            for (int i = 0; i < f; i++)
            {
                Console.WriteLine("Introduce the fact{0}", i + 1);
                fact = Console.ReadLine();
                final.Add_final(fact);
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("This is list in final");
            final.Print();
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("Introduce how much facts want to delete");
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            fd = int.Parse(Console.ReadLine());
            for (int i = 0; i < fd; i++)
            {
                final.Delete_final();
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("This is list deleted {0}", fd);
            final.Print();
        }
        static void Main(string[] args)
        {
            Start();//Imprime el inicio
            Final();//Imprime el final

        }
    }
}
