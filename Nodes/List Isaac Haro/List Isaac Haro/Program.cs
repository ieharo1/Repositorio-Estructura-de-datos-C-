using System;

namespace List_Isaac_Haro
{
    class List
    {
        public Object fact;
        public List next;
        public List start;
        public void PUSH_REVERSE(Object fact)
        {
            List push = new List();
            push.fact = fact;
            push.next = start;
            start = push;
        }
        public void PUSH (Object fact)
        {
            if (start == null)
            {
                start = new List();
                start.fact = fact;
                start.next = null;
            }
            else
            {
                List more = new List();
                more.fact = fact;
                List current = start;
                while (current.next != null)
                {
                    current = current.next;
                }
                current.next = more;
            }
            
        }
        public void PRINT()
        {
            List current = start;
            while (current!=null)
            {
                Console.WriteLine(current.fact);
                current = current.next;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List miNodo1 = new List();
            miNodo1.PUSH_REVERSE("Hola");
            miNodo1.PUSH_REVERSE("Mundo");
            miNodo1.PUSH_REVERSE("Dato3");
            miNodo1.PRINT();

            Console.WriteLine();

            Console.WriteLine("Añade al final:");
            List miNodo2 = new List();

            miNodo2.PUSH("Hola");
            miNodo2.PUSH("Mundo");
            miNodo2.PUSH("Dato3");
            miNodo2.PRINT();

            Console.ReadLine();
        }
    }
}
