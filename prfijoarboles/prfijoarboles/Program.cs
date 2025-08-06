using System;
using System.Text;

namespace PrefijoArboles
{
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
        //public bool EsHermano(Nodo r, int p)
        //{
        //    Nodo aux = r;
        //    if (p == raiz.data)
        //    {
        //        Console.WriteLine("NO TIENE HERMANOS");
        //    }
        //    else
        //    {
        //        if (aux.izquierdo != null && aux.izquierdo.data != 0)
        //        {
        //            if (aux.izquierdo.data == p)
        //            {   
        //                Console.WriteLine("NODO ENCONTRADO");
        //                if (aux.derecho != null)
        //                {
        //                    Console.WriteLine("TIENE HERMANO");
        //                    c = true;
        //                }
        //            }
        //            else
        //            {
        //                EsHermano(aux.izquierdo, p);
        //            }
        //        }
        //        else if (aux.derecho != null && aux.derecho.data != 0)
        //        {
        //            if (aux.derecho.data == p)
        //            {
        //                Console.WriteLine("NODO ENCONTRADO");
        //                if (aux.izquierdo != null)
        //                {
        //                    Console.WriteLine("TIENE HERMANO");
        //                    c = true;
        //                }
        //            }
        //            else
        //            {
        //                EsHermano(aux.derecho, p);
        //            }
        //        }
        //        else
        //        {
        //            aux.data = 0;
        //            EsHermano(raiz, p);
        //        }
        //    }

        //    return c;
        //}
        /*
        public Nodo Padre (Nodo p)
        {
        public bool EsIzquierdo (Nodo p)
        {
            Nodo q;
            q = Padre(p);
            if (q == null)
                return false; // p apunta a la raiz 
            else
                if (Izquierdo(q) == p)
                return true;
            return false;
        }

        public bool EsDerecho (Nodo p)
        {

        }
        } 

    */
        public Nodo Izquierdo(Nodo p)
        {
            return p.izquierdo;
        }


        public Nodo SetIzquierdo(Nodo p, string x)
        {
            if (p.izquierdo == null)
            {
                p.izquierdo = new Nodo();
                p.izquierdo.data = x;
            }

            return p.izquierdo;
        }

        public Nodo SetDerecho(Nodo p, string x)
        {
            if (p.derecho == null)
            {
                p.derecho = new Nodo();
                p.derecho.data = x;
            }

            return p.derecho;
        }
        public Nodo PonerNodos(string[] arr)
        {
            bool doble = false;
            if (raiz == null)
            {
                raiz = new Nodo();
                raiz.data = arr[0];
            }
            Nodo aux = raiz;
            Nodo aux2;

            for (int i = 1; i < arr.Length; i++)
            {
                if (aux.izquierdo == null)
                {
                    if (arr[i] == "+" || arr[i] == "-" || arr[i] == "*" || arr[i] == "/")
                    {
                        if ((Encoding.ASCII.GetBytes(arr[i + 1].ToString())[0] >= 65 && Encoding.ASCII.GetBytes(arr[i + 1].ToString())[0] <= 90) && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] >= 65 && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] <= 90)
                        {
                            Console.WriteLine("Entra a solo letras");
                            aux = SetIzquierdo(aux, arr[i]);
                            SetIzquierdo(aux, arr[i + 1]);
                            SetDerecho(aux, arr[i + 2]);
                            aux = raiz;

                            i = i + 2;
                        }
                        else if ((arr[i + 1] == "+" || arr[i + 1] == "-" || arr[i + 1] == "" || arr[i + 1] == "/") && (arr[i + 2] == "+" || arr[i + 2] == "-" || arr[i + 2] == "" || arr[i + 2] == "/"))
                        {
                            Console.WriteLine($"Doble signo izquierda {arr[i + 1]} {arr[i + 2]}");
                            aux = SetIzquierdo(aux, arr[i]);
                            aux2 = SetIzquierdo(aux, arr[i + 1]);
                            SetDerecho(aux, arr[i + 6]);

                            aux = aux2;
                            doble = true;
                        }
                        else if ((arr[i + 1] == "+" || arr[i + 1] == "-" || arr[i + 1] == "*" || arr[i + 1] == "/" && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] >= 65 && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] <= 90))
                        {
                            if (doble)
                            {
                                Console.WriteLine("Entra a signo   y signo");
                                aux2 = SetIzquierdo(aux, arr[i + 1]);
                                SetDerecho(aux, arr[i + 4]);
                                aux = aux2;
                            }
                            else
                            {
                                Console.WriteLine("Entra a signo   y signo");
                                aux = SetIzquierdo(aux, arr[i]);
                                aux2 = SetIzquierdo(aux, arr[i + 1]);
                                SetDerecho(aux, arr[i + 4]);
                                aux = aux2;
                            }

                            i = i + 1;
                        }
                        else if ((arr[i + 2] == "+" || arr[i + 2] == "-" || arr[i + 2] == "*" || arr[i + 2] == "/" && Encoding.ASCII.GetBytes(arr[i + 1].ToString())[0] >= 65 && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] <= 90))
                        {
                            Console.WriteLine("Entra a letra y signo");
                            aux = SetIzquierdo(aux, arr[i]);
                            SetIzquierdo(aux, arr[i + 1]);
                            aux2 = SetDerecho(aux, arr[i + 2]);

                            aux = aux2;
                            i = i + 2;
                        }
                         ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ; ;
                    }
                    else
                    {
                        Console.WriteLine("entra a else set izquierdo");
                        SetIzquierdo(aux, arr[i]);
                    }
                }
                else if (aux.derecho == null)
                {
                    if (arr[i] == "+" || arr[i] == "-" || arr[i] == "*" || arr[i] == "/")
                    {
                        if ((Encoding.ASCII.GetBytes(arr[i + 1].ToString())[0] >= 65 && Encoding.ASCII.GetBytes(arr[i + 1].ToString())[0] <= 90) && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] >= 65 && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] <= 90)
                        {
                            Console.WriteLine("Entra a solo letras");
                            aux = SetDerecho(aux, arr[i]);
                            SetIzquierdo(aux, arr[i + 1]);
                            SetDerecho(aux, arr[i + 2]);
                            aux = raiz;
                            i = i + 2;
                        }
                        else if ((arr[i + 1] == "+" || arr[i + 1] == "-" || arr[i + 1] == "" || arr[i + 1] == "/") && (arr[i + 2] == "+" || arr[i + 2] == "-" || arr[i + 2] == "" || arr[i + 2] == "/"))
                        {
                            Console.WriteLine($"Doble signo dere {arr[i + 1]} {arr[i + 2]}");
                            aux = SetDerecho(aux, arr[i]);
                            aux2 = SetIzquierdo(aux, arr[i + 1]);
                            SetDerecho(aux, arr[i + 6]);
                            doble = true;

                            aux = aux2;
                        }
                        else if ((arr[i + 1] == "+" || arr[i + 1] == "-" || arr[i + 1] == "*" || arr[i + 1] == "/" && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] >= 65 && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] <= 90))
                        {
                            if (doble)
                            {
                                Console.WriteLine("Entra a signo   y signo");
                                aux2 = SetIzquierdo(aux, arr[i + 1]);
                                SetDerecho(aux, arr[i + 4]);
                                aux = aux2;
                            }
                            else
                            {

                                Console.WriteLine("Entra a signo y letra");
                                aux = SetDerecho(aux, arr[i]);
                                aux2 = SetIzquierdo(aux, arr[i + 1]);
                                SetDerecho(aux, arr[i + 4]);

                                aux = aux2;
                            }

                            i = i + 1;
                        }
                        else if ((arr[i + 2] == "+" || arr[i + 2] == "-" || arr[i + 2] == "*" || arr[i + 2] == "/" && Encoding.ASCII.GetBytes(arr[i + 1].ToString())[0] >= 65 && Encoding.ASCII.GetBytes(arr[i + 2].ToString())[0] <= 90))
                        {
                            Console.WriteLine("Entra a letra y signo");
                            aux = SetDerecho(aux, arr[i]);
                            SetIzquierdo(aux, arr[i + 1]);
                            aux2 = SetDerecho(aux, arr[i + 2]);

                            aux = aux2;

                            i = i + 2;
                        }
                    }
                    else
                    {
                        Console.WriteLine("else set derecho");
                        SetDerecho(aux, arr[i]);
                    }
                }
            }

            return raiz;
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
    class Program
    {

        static void Main(string[] args)
        {
            Arbol Prefijo = new Arbol();

            string ingreso;
            Console.WriteLine("Ingrese la ecuacion");
            ingreso = Console.ReadLine().ToUpper();

            string[] nodeData = new string[ingreso.Length];

            for (int i = 0; i < ingreso.Length; i++)
            {
                nodeData[i] = ingreso.Substring(i, 1);
            }

            Prefijo.PonerNodos(nodeData);
            Prefijo.Imprimir();
        }
    }
}