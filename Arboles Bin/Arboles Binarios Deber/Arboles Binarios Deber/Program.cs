using System;
namespace arbol001
{
    //Isaac Haro
    //14/nov/2020
    //arbol binario
    class Nodo//clase nodo
    {
        public int data;//variables de tipo int y nodo
        public Nodo izquierdo;
        public Nodo derecho;
        public Nodo()//constructor
        {
            data = 0;
            izquierdo = null;
            derecho = null;
        }
    }
    class Arbol//clase arbol
    {
        public Nodo raiz;//variable de tipo nodo raiz
        public Arbol()//constructor
        {
            raiz = null;
        }
        public void SetNode(int data)//funcion para agregar un dato en el nodo
        {
            raiz = SetNode(raiz, data);
        }
        public bool hermano = false;//variable publica de tipo booleana
        public bool EsHermano(Nodo raiz, int dato)//funcion para comprobar si es hermano
        {
            Nodo aux = raiz;//variable de tipo nodo auxiliar
            if (dato == this.raiz.data)//la raiz por defecto es falso
                hermano = false;
            else
            {
                if (aux.izquierdo != null && aux.izquierdo.data != 0)//si esta en el lado izquierdo entra
                {
                    if (aux.izquierdo.data == dato )//cuando entra al if y es igual al dato que buscaba, y cumple con que tiene un hermano en el mismo nivel devolvemos un true
                    { 
                        if(aux.derecho != null)
                            hermano = true;
                    }
                    else//caso contrario se usa la recursividad para volver a ejecutar el programa
                        EsHermano(aux.izquierdo, dato);
                }
                else if (aux.derecho != null && aux.derecho.data != 0)//si esta en el lado derecho entra
                {
                    if (aux.derecho.data == dato)//cuando entra al if y es igual al dato que buscaba, y cumple con que tiene un hermano en el mismo nivel devolvemos un true
                    {
                        if(aux.izquierdo != null)
                            hermano = true;
                    }
                    else//caso contrario se usa la recursividad para volver a ejecutar el programa
                        EsHermano(aux.derecho, dato);
                }
                else//si no entra a ningun if 
                {
                    aux.data = 0;// se borra el auxiliar y se comienza desde la raiz nuevamente
                    EsHermano(this.raiz, dato);
                }
            }
            return hermano;//retornamos el valor booleano
        }
        public bool padre = false;//variable publica de tipo booleana
        public bool Padre (Nodo raiz,int dato)//funcion para comprobar que es padre
        {
            Nodo aux = raiz;// variable de tipo nodo auxiliar
            if (dato == this.raiz.data)//la raiz por defecto sera padre si contiene datos hijos
                padre = true;
            else
            {
                if (aux.izquierdo != null && aux.izquierdo.data != 0)//si esta en el lado izquierdo entra
                {
                    if (aux.izquierdo.data == dato)
                    {
                        if (aux.izquierdo.derecho != null|| aux.izquierdo.izquierdo != null)//si izquierdo y derecho de izquierdo son distintos de null sabremos que es padre
                            padre = true;
                        else// si no retornamos un false
                            padre = false;
                    }
                    else//si no usa la recursividad
                        Padre(aux.izquierdo, dato);
                       
                }
                else if (aux.derecho != null && aux.derecho.data != 0)//si esta en el lado derecho entra
                {
                    if (aux.derecho.data == dato)
                    {
                        if (aux.derecho.izquierdo != null|| aux.derecho.derecho != null)
                            padre = true;
                        else
                            padre = false;
                    }
                    else//si no usa la recursividad
                        Padre(aux.derecho, dato);
                }
                else//si no entra a ningun if borra auxiliar y vuelve a empezar con la recursividad
                {
                    aux.data = 0;
                    Padre(this.raiz, dato);
                }
            }
            return padre;
        }
        public bool izquierdo = false;//variable publica de tipo booleana
        public bool EsIzquierdo(Nodo raiz, int dato)//funcion para comprobar que es izquierdo
        {
            Nodo aux = raiz;// variable de tipo nodo auxiliar
            if (dato == this.raiz.data)//la raiz por defecto no es izquierdo por lo que se retorna false
                izquierdo = false;
            else
            {
                if (aux.izquierdo != null && aux.izquierdo.data != 0)//si esta en el lado izquierdo entra
                {
                    if (aux.izquierdo.data == dato)//comprar si es izquierdo igual al dato y retorna true
                        izquierdo = true;
                    else//si no usa la recursividad
                        EsIzquierdo(aux.izquierdo, dato);
                }
                else if (aux.derecho != null && aux.derecho.data != 0)//si esta en el lado derecho entra
                {
                    if (aux.derecho.data == dato)//compara si es derecha igual al dato y retorna false
                        izquierdo = false;
                    else//si no usa la recursividad
                        EsIzquierdo(aux.derecho, dato);
                }
                else//si no entra a ningun if borra auxiliar y vuelve a empezar con la recursividad
                {
                    aux.data = 0;
                    EsIzquierdo(this.raiz, dato);
                }
            }
            return izquierdo;
        }
        public bool derecho = false;//variable publica de tipo booleana
        public bool EsDerecho(Nodo raiz, int dato)//funcion para comprobar que es derecho
        {
            Nodo aux = raiz;// variable de tipo nodo auxiliar
            if (dato == this.raiz.data)//la raiz por defecto no es derecho por lo que se retorna false
                derecho = false;
            else
            {
                if (aux.izquierdo != null && aux.izquierdo.data != 0)//si esta en el lado izquierdo entra
                {
                    if (aux.izquierdo.data == dato)//compara si es izquierdo igual al dato y retorna false
                        derecho = false;
                    else//si no usa la recursividad
                        EsDerecho(aux.izquierdo, dato);
                }
                else if (aux.derecho != null && aux.derecho.data != 0)//si esta en el lado derecho entra
                {
                    if (aux.derecho.data == dato)//compara si es derecho igual al dato y retorn true
                        derecho = true;
                    else//si no usa la recursividad
                        EsDerecho(aux.derecho, dato);
                }
                else//si no entra a ningun if borra auxiliar y vuelve a empezar con la recursividad
                {
                    aux.data = 0;
                    EsDerecho(this.raiz, dato);
                }
            }
            return derecho;
        }
        public Nodo Izquierdo(Nodo p)//nodo izquierdo
        {
            return p.izquierdo;
        }
        public Nodo SetIzquierdo(Nodo p, int x)//se agrega al lado izquierdo
        {
            if (p.izquierdo == null)
            {
                p.izquierdo = new Nodo();
                p.izquierdo.data = x;
            }

            return p.izquierdo;
        }
        public Nodo SetDerecho(Nodo p, int x)//se agraga al lado derecho
        {
            if (p.derecho == null)
            {
                p.derecho = new Nodo();
                p.derecho.data = x;
            }

            return p.derecho;
        }
        public Nodo SetNode(Nodo p, int x)// se agrega el nodo con posiciones predeterminadas
        {
            if (p == null)
            {
                p = new Nodo();
                p.data = x;
            }
            else
            {
                if (p.izquierdo == null)
                {
                    p.izquierdo = SetNode(p.izquierdo, x);
                }
                else
                {
                    p.derecho = SetNode(p.derecho, x);
                }
            }
            return p;
        }

        public void Imprimir()//imprime el arbol
        {
            Imprimir(raiz, 4);
        }

        public void Imprimir(Nodo p, int padding)//funcion que ejecuta la impresion por consola del arbol binario
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
    class Program//programa principal
    {
        static void Main(string[] args)
        {
            string movimiento;//variables de tipo string e int
            int numdata, hermano, padre, izquierda, derecho,sw;
            Console.WriteLine("Cuantos datos desea ingresar");
            numdata = int.Parse(Console.ReadLine());//ingreso del numero de datos para trabajar
            int[] nodeData= new int[numdata];//se crea un arreglo con la longitud de los datos
            for (int i=0; i < numdata; i++)
            {
                Console.WriteLine("Ingrese el digito {0} a ingresar en el arbol", i+1);
                nodeData[i] = int.Parse(Console.ReadLine());//se registran cada uno de los datos
            }
            Arbol arbol1 = new Arbol();//se crea un arbol 1 para agregar datos por el lado izquierdo o derecho
            arbol1.SetNode(nodeData[0]);
            Nodo aux = arbol1.raiz;
            for (int i = 1; i < nodeData.Length; i++)//se utiliza un bucle for para agragar a la izquierda o derecha segun el usuario indique
            {
                Console.WriteLine("Su digito {0} desea agregarlo a la derecha o izquierda", nodeData[i]);
                movimiento = Console.ReadLine().ToUpper();
                if (movimiento == "IZQUIERDO" || movimiento == "IZQUIERDA")
                {
                    arbol1.SetIzquierdo(aux, nodeData[i]);
                    aux = aux.izquierdo;
                }
                else if (movimiento == "DERECHO" || movimiento == "DERECHA")
                {
                    arbol1.SetDerecho(aux, nodeData[i]);
                    aux = aux.derecho;
                }
            }
            Console.WriteLine("Arbol para escoger las posiciones");
            arbol1.Imprimir();// se imprime el arol bianrio
            Console.WriteLine("1.Determinar si es derecho\n2.Determinar si es izquierdo\n3.Determinar si es hermano\n4.Determinar si es padre");//se crea un menu para determinar los distintos datos
            sw = int.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    Console.WriteLine("Ingrese el dato para determinar SI es derecho");
                    derecho = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol1.EsDerecho(arbol1.raiz, derecho));
                    Console.WriteLine("False= No es derecho y True= es derecho");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el dato para determinar SI es izquierdo");
                    izquierda = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol1.EsIzquierdo(arbol1.raiz, izquierda));
                    Console.WriteLine("False= No es izquierdo y True= es izquierdo");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el dato para determinar SI es padre");
                    padre = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol1.Padre(arbol1.raiz, padre));
                    Console.WriteLine("False= No tiene Padre y True= tiene Padre");
                    break;
                case 4:

                    Console.WriteLine("Ingrese el dato para determinar SI es hermano");
                    hermano = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol1.EsHermano(arbol1.raiz, hermano));
                    Console.WriteLine("False= No tiene Hermano y True= tiene hermano");
                    break;
                default:
                    Console.WriteLine("No ingreso un numero valido");
                    break;
            }
            Arbol arbol2 = new Arbol();//se crea un arbol 2 donde se imprimira en orden predeterminado
            foreach (int i in nodeData)
                arbol2.SetNode(i);//usamos el foreach para registrar los datos en setnode
            arbol2.Imprimir();//se imprime el arbol
            Console.WriteLine("1.Determinar si es derecho\n2.Determinar si es izquierdo\n3.Determinar si es hermano\n4.Determinar si es padre");//se crea otro menu para el siguiente arbol 
            sw = int.Parse(Console.ReadLine());
            switch (sw)
            {
                case 1:
                    Console.WriteLine("Ingrese el dato para determinar SI es derecho");
                    derecho = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol2.EsDerecho(arbol2.raiz, derecho));
                    Console.WriteLine("False= No es derecho y True= es derecho");
                    break;
                case 2:
                    Console.WriteLine("Ingrese el dato para determinar SI es izquierdo");
                    izquierda = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol2.EsIzquierdo(arbol2.raiz, izquierda));
                    Console.WriteLine("False= No es izquierdo y True= es izquierdo");
                    break;
                case 3:
                    Console.WriteLine("Ingrese el dato para determinar SI es padre");
                    padre = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol2.Padre(arbol2.raiz, padre));
                    Console.WriteLine("False= No tiene Padre y True= tiene Padre");
                    break;
                case 4:

                    Console.WriteLine("Ingrese el dato para determinar SI es hermano");
                    hermano = int.Parse(Console.ReadLine());
                    Console.WriteLine(arbol2.EsHermano(arbol2.raiz, hermano));
                    Console.WriteLine("False= No tiene Hermano y True= tiene hermano");
                    break;
                default:
                    Console.WriteLine("No ingreso un numero valido");
                    break;
            }
        }
    }
}//fin programa

