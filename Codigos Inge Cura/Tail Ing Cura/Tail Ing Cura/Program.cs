using System;

namespace Tail_Ing_Cura
{
    class Tail
    {
        private const int NumELements = 20;
        private int[] element = new int[NumELements];
        private int start, final;
        public Tail()
        {
            start = -1;
            final = -1;
        }
        public bool EMPTY()
        {
            if (start.Equals(final))
                return true;
            else
                return false;
        }
        public void PRINT_TAIL()
        {
            for(int cont= start + 1; cont <= final; cont++)
                Console.WriteLine("{0}",element[cont]);
        }
        public void ENTER(int a)
        {
            if (final.Equals(NumELements - 1))
                final = 0;
            element[final + 1] = a;
            final++;
            if (start.Equals(final))
            {
                Console.WriteLine("Tail is full, it does not support adding elements");
                return;
            }
        }
        public int REMOVE()
        {
            if (EMPTY())
            {
                Console.WriteLine("Tail is empty, it does not possible remove elements");
                return 0;
            }
            int aux = element[start + 1];
            element[start + 1] = 0;
            if (start.Equals(NumELements - 1))
                start = 0;
            else
                start++;
            return aux;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Tail Tail1 = new Tail();
            Tail1.ENTER(1);
            Tail1.ENTER(2);
            Tail1.ENTER(3);
            Tail1.ENTER(4);
            Console.WriteLine("This is the tail with the elements enter");
            Tail1.PRINT_TAIL();
            Console.WriteLine("Remove an element of the tail");
            Console.WriteLine("{0}", Tail1.REMOVE());
            Console.WriteLine("This is the tail after to remove an element");
            Tail1.PRINT_TAIL();
            Console.WriteLine("Remove an element of the tail");
            Console.WriteLine("{0}", Tail1.REMOVE());
            Console.WriteLine("This is the tail after to remove an element");
            Tail1.PRINT_TAIL();
            Console.WriteLine("In this point the tail have elements, because the function EMPTY returns {0}", Tail1.EMPTY());
            Console.WriteLine("Remove an element of the tail");
            Tail1.ENTER(1);
            Console.WriteLine("This is the tail after to introduce an element");
            Tail1.PRINT_TAIL();
            Console.WriteLine("In this point the tail have elements, because the function EMPTY returns {0}", Tail1.EMPTY());



        }
    }
}
