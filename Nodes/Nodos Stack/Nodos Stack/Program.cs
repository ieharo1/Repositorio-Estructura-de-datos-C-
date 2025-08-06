using System;

namespace Nodos_Stack
{
    class Nodo
    {
        private int fact;
        private Nodo next;
        public Nodo(int fact=-1)
        {
            this.fact = fact;
            next = null;
        }
        public bool Empty()
        {
            return fact == -1&& next==null;
        }
        public void Push(int d)
        {
            Nodo aux = new Nodo(d);
            if (Empty())
            {
                this.fact = d;
                next = aux;
            }
            else
            {
                aux.fact = fact;
                aux.next = next;
                next = aux;
                fact = d;
            }
        }
        public int Pop()
        {
            int answer = 0;
            Nodo Ap = next;
            answer = Ap.fact;
            next = Ap.next;
            return answer;
        }
        public void Insert()
        {
            int d, fact;
            Console.WriteLine("Hello, Enter the lenght");
            d = int.Parse(Console.ReadLine());
            for(int i=0; i < d; i++)
            {
                Console.WriteLine("Enter the number{0}",(i+1));
                fact= int.Parse(Console.ReadLine());
                Push(fact);
            }
            for(int i = 0; i < d; i++)
            {
                Console.WriteLine(Pop());
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Nodo n1 = new Nodo();
            n1.Insert();
            Console.ReadKey();
        }
    }
}
