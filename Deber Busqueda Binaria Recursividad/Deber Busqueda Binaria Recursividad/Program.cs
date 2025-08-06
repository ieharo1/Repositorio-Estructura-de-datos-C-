using System;
//Isaac Haro
//31/10/2020
//Busqueda Binaria con Recursividad
namespace Deber_Busqueda_Binaria_Recursividad
{
    class Program//Clase program
    {
        static int SEARCH(int [] a, int x, int low, int high)//Funcion para realizar la busqueda binario con recursividad
        {
            int medio;//variable
            if (low > high)//condicional para retornar el valor -1
                return -1;
            else//encuentra por medio de busqueda binaria
            {
                medio = (low + high) / 2;
                if (x == a[medio])//si se encuentra en el medio devuelve la ubicacion del arreglo
                    return medio;
                else
                {
                    if (x < a[medio])//si el arraglo en la posicion del medio es menor al valor buscado se busca con recursividad el valor
                        return SEARCH(a, x, low, medio - 1);
                    else//si es menor busca con recursividad el valor
                        return SEARCH(a, x, medio + 1, high);
                }
            }
        }
        static void SHELL(int [] a)//Ordenamiento Shell
        {
            int shell = a.Length / 2, aux;//variables int
            bool enter = false, leave = false;//variables bool
            while (leave == false)//bucle para reaizar el ordenamiento de tipo shell
            {
                enter = false;
                for(int i=0; i < a.Length-shell; i++)
                {
                    if (a[i] > a[i + shell])//cuando entra al if va ordenando mediante el metodo shell 
                    {
                        aux = a[i];
                        a[i] = a[i + shell];
                        a[i + shell] = aux;
                        enter = true;
                    }
                }
                if (enter == false && shell == 1)
                    leave = true;//sale del bucle
                else if(enter == false && shell > 1)
                    shell--;//busca con el metodo shell con una longitud -1 para poder seguir ordenando
            }
            for(int j=0; j<a.Length;j++)//imprime en consola el orden del arreglo
                Console.WriteLine(a[j]);
        }
        static void Main(string[] args)//Programa principal
        {
            Console.BackgroundColor = ConsoleColor.DarkMagenta;//El fondo de la consola se vuelve morado
            Console.ForegroundColor = ConsoleColor.Yellow;//El fondo de la consola se vuelve amaerillo
            int a, search;//variables
            Console.WriteLine("Introduce the lenght for you array");//ingreso de la longitud
            a = int.Parse(Console.ReadLine());
            int [] array = new int [a];
            for (int i=0;i<a;i++)//bucle para el ingreso de datos
            {
                Console.WriteLine($"Introduce the data {i+1}");
                array[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("This is the array order");
            SHELL(array);//imprime el arreglo ordenado de menor a mayor
            Console.WriteLine("Introduce the number do yo want to search");//introduce el numero a buscar
            search = int.Parse(Console.ReadLine());
            Console.WriteLine($"This ubication is to the programmer {SEARCH(array, search, 0, array.Length - 1)}, and this to the user {SEARCH(array, search, 0, array.Length - 1)+1}");
            //imprime la ubicacion del valor buscado
        }
    }
}
