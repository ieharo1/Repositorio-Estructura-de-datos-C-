using System;
using System.Text;
namespace Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingreso;
            Console.WriteLine("Ingrese la ecuacion");
            ingreso = Console.ReadLine();
            string[] nodeData = new string[ingreso.Length];
            for (int i = 0; i < ingreso.Length; i++)
            {
                nodeData[i] = ingreso.Substring(i,1);
            }
            Arbol arbol1 = new Arbol();
            for(int j=0; j < nodeData.Length; j++)
            {
                arbol1.SetNode(ingreso.Substring(j, 1));
            }
            arbol1.Imprimir();
        }
    }
    class Nodo
    {
        public string data;
        public Nodo izquierdo;
        public Nodo derecho;
        public Nodo()
        {
            data = null;
            izquierdo = null;
            derecho = null;
        }
    }
    class Arbol
    {
        public Nodo raiz;
        public Arbol()
        {
            raiz = null;
        }
        public void SetNode(string data)
        {
            raiz = SetNode(raiz, data);
        }
        public Nodo SetNode(Nodo aux, string x)
        {
            if (aux == null)
            {
                aux = new Nodo();
                aux.data = x;
                if((aux.data == "*" || aux.data == "/" || aux.data == "+" || aux.data == "-"))
                {
                    aux.izquierdo = SetNode(aux.izquierdo, x);
                    aux.derecho = SetNode(aux.derecho, x);
                }
            }
            //else
            //{
            //    if (aux.izquierdo == null)
            //    {
            //        aux.izquierdo = SetNode(aux.izquierdo, x);
            //    }
            //    else if(aux.derecho == null)
            //    {
            //        aux.derecho = SetNode(aux.derecho, x);
            //    }
            //    //else if (aux.derecho==null && (aux.data == "*" || aux.data == "/" || aux.data == "+" || aux.data == "-"))
            //    //{
            //    //    aux.derecho = SetNode(aux.izquierdo, x);
            //    //}
            //    //if (aux.izquierdo == null && (Encoding.ASCII.GetBytes(x.ToString())[0] >= 65 || Encoding.ASCII.GetBytes(x.ToString())[0] <= 90))
            //    //{
            //     //&& (x == "*" || x == "/" || x == "+" || x == "-")
            //    //    Console.WriteLine("Entro i");
            //    //    aux.izquierdo.izquierdo = SetNode(aux.izquierdo.izquierdo, x);
            //    //}
            //    //else if (aux.derecho == null && (Encoding.ASCII.GetBytes(x.ToString())[0] >= 65 || Encoding.ASCII.GetBytes(x.ToString())[0] <= 90))
            //    //{
            //    //    Console.WriteLine("Entro d");
            //    //    aux.derecho = SetNode(aux.derecho, x);
            //    //}
            //}
            return aux;
        }

        public void Imprimir()
        {
            Imprimir(raiz, 4);
        }

        public void Imprimir(Nodo p, int padding)
        {
            if (p != null)
            {
                if (p.derecho != null)
                {
                    Imprimir(p.derecho, padding + 4);
                }
                if (padding > 0)
                {
                    Console.Write(" ".PadLeft(padding));
                }
                if (p.derecho != null)
                {
                    Console.Write("/\n");
                    Console.Write(" ".PadLeft(padding));
                }
                Console.Write(p.data.ToString() + "\n ");
                if (p.izquierdo != null)
                {
                    Console.Write(" ".PadLeft(padding) + "\\\n");
                    Imprimir(p.izquierdo, padding + 4);
                }
            }
        }
    }
}



