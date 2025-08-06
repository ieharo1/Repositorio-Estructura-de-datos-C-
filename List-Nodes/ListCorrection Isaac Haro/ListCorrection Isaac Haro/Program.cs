using System;

namespace ListCorrection
{
    //Isaac Haro-Jack Narvaez-Alan Guijarro-Martin Guerra
    //21/10/2020
    //Trabajo en grupo
    //Estructura de datos
    public class Node//Clase nodo de la lista
    {
        public Object data;//Dato del nodo
        public Node next;//Puntero al siguiente nodo
        public Object InfoNode()
        {
            return data;
        }
        public void PrintInfoNode()//Imprime la informacion contenida en un nodo
        {
            Console.WriteLine(data);
        }
        public Node InfoNextNode()//Devuelve la direccion del siguiente nodo
        {
            return next;
        }
        public void AddNextNode(Node nextnode)//Agrega al nodo la direccion del siguiente nodo
        {
            next = nextnode;
        }
        public void AddData(Object newfact)//Agrega el dato dentro del nodo
        {
            data = newfact;
        }
    }
    public class List//Clase que define una lista simple en base a el dato del primer nodo de la lista y a nodos como elmentos de la lista
    {
        public Node datanode;//Dato contenido en la lista
        public Node start;//Cabecera de la lista
        public void InsertStart(Object data)//Inserta un nodo al inicio de la lista
        {
            Node insert = new Node();
            insert.AddData(data);
            insert.AddNextNode(start);
            start = insert;
        }
        public void DeleteStart()//Elimina un nodo al inicio de la lista
        {
            if (start != null)
            {
                Node aux;
                aux = start.InfoNextNode();
                start = aux;
            }
            else
            {
                Console.WriteLine("Lista Vacia no es posible Retirar un Nodo");
            }
        }
        public void InsertFinal(Object data)//Inserta un nodo al final de la lista
        {
            if (start == null)
            {
                start = new Node();
                start.AddData(data);
                start.AddNextNode(null);
            }
            else
            {
                Node aux = new Node();
                aux.AddData(data);
                Node current = start;
                while (aux.InfoNextNode() != null)
                {
                    current = current.InfoNextNode();
                }
                current.AddNextNode(aux);
            }
        }
        public void DeleteFinal()//Elimina un nod al final de la lista
        {
            if (start == null)
            {
                Console.WriteLine("Lista Vacia, no es posible Retirar un nodo del Final ");
            }
            else
            {
                Node current = start;
                Node previous = null;
                while (current.InfoNextNode() != null)
                {
                    previous = current;
                    current = current.InfoNextNode();
                }
                previous.AddNextNode(null);
            }
        }
        public void PrintNodes()
        {
            Console.WriteLine("Imprime:");
            Node current = start;
            while (current != null)
            {
                current.PrintInfoNode();
                current = current.InfoNextNode();
            }
        }
        public void Circular()
        {
            
            Console.WriteLine("Circular");
            Node circular = start;
            Node before = null;
            Object aux = start.data;
            //Console.WriteLine(aux);
            do
            {
                circular.PrintInfoNode();
                circular = circular.InfoNextNode();
                if (circular.next == null)
                {
                    before = circular.InfoNextNode();
                    before.AddData(aux);
                    break;
                }
            }
            while (circular != start)
           ;
        }
    }
    class Program//Programa principal
    {
        static public int start;
        static public Object data;
        static void listnode1(List List1)//Funcion para imprimir la lista 1
        {
     
            Console.WriteLine("Añade al inicio:");
            Console.WriteLine("Cuantos datos deseas agregar ");
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            start = int.Parse(Console.ReadLine());
            for (int i = 0; i < start; i++)
            {
                Console.WriteLine("Agrega tu dato{0}", i + 1);
                data = Console.ReadLine();
                List1.InsertStart(data);
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
            List1.PrintNodes();
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("Cuantos datos deseas eliminar ");
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            start = int.Parse(Console.ReadLine());
            for (int i = 0; i < start; i++)
            {
                List1.DeleteStart();
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
            List1.PrintNodes();
            List1.Circular();
            List1.PrintNodes();
        }
        static void listnode2(List List2)//Funcion para imprimir la lista 2
        {
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("Añade al final:");
            Console.WriteLine("Cuantos datos deseas agregar ");
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            start = int.Parse(Console.ReadLine());
            for (int i = 0; i < start; i++)
            {
                Console.WriteLine("Agrega tu dato{0}", i + 1);
                data = Console.ReadLine();
                List2.InsertStart(data);
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
            List2.PrintNodes();
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
            Console.WriteLine("Cuantos datos deseas eliminar ");
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.White;//COLOR DE LA LETRA DE LA CONSOLA
            start = int.Parse(Console.ReadLine());
            for (int i = 0; i < start; i++)
            {
                List2.DeleteFinal();
            }
            Console.ResetColor();//RESETEA EL COLOR DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Blue;//COLOR DE LA LETRA DE LA CONSOLA
            List2.PrintNodes();

        }
        static void Main(string[] args)
        {
            Console.Title = "List";//TITULO DE LA CONSOLA
            Console.ForegroundColor = ConsoleColor.Yellow;//COLOR DE LA LETRA DE LA CONSOLA
            List List1 = new List();
            List List2 = new List();
            listnode1(List1);
            listnode2(List2);
        }
    }
}
