using System;

namespace Nodos_Practica_1
{
    class Nodo
    {
        public Object fact;
        public Nodo next;
        public Nodo start;
        public Nodo(Object fact = null)
        {
            this.fact = fact;
            next = null;
            start = null;
        }
        //public bool Empty()
        //{
        //    return start == null ;
        //}
        public void Push(Object fact)
        {
            //if (Empty())
            //{
            //    Console.WriteLine("The stack is empty");
            //}
            if (start == null)
            {
                start = new Nodo();
                start.fact = fact;
                start.next = null;
            }
            else
            {
                Nodo push = new Nodo();
                push.fact = fact;
                Nodo aux = start;
                while (aux.next != null)
                {
                    aux = aux.next;
                }
                aux.next = push;
            }
        }
        //public Object Pop()
        //{
            
            
        //}
        public void Print()
        {
            Nodo print = start;
            while (print != null)
            {
                Console.WriteLine(print.fact);
                print = print.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Nodo stack = new Nodo();
            Object fact;
            int h, k;
            Console.WriteLine("Introduce the lenght with you want to work");
            h = int.Parse(Console.ReadLine());
            for(int i=0; i<h; i++)
            {
                Console.WriteLine("Introduce the fact {0}",i+1);
                fact = Console.ReadLine();
                stack.Push(fact);
            }
            Console.WriteLine("This is push");
            stack.Print();
            //Console.WriteLine("Introduce how much facts want to delete");
            //k = int.Parse(Console.ReadLine());
            //if (k.Equals(0))
            //    Console.WriteLine("You dont insert a number to delete your stack");
            //else
            //{
            //    for (int i = 0; i < k; i++)
            //    {
            //        Console.WriteLine(stack.Pop()); 
            //    }
            //    Console.WriteLine("This is pop");
            //    stack.Print();
            //}
        }
    }
}
