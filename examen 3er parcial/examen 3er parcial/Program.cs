using System;

namespace examen_3er_parcial
{
    //Isaac Haro
    //Examen Parcial3
    //Estructura de datos
    class Digito//clase para el digito
    {
        public int Valor(int valor)//funcion para encontrar el numero de digitos de un valor
        {
            if (valor <= 9)//si el valor es menor a 9 retorna 1
            {
                return 1;
            }
            else//si el valor no entra al if sumamos 1 a la funcion hasta que retorne un valor con la ayuda de la recursividad
            {
                return 1 + Valor(valor / 10);
            }
        }
    }
    class Potenciacion//Clase potenciacion
    {
        public int Potencia(int numero, int potencia)//funcion para hacer la potencia
        {
            if (potencia == 0)//si la potencia por defecto es 0 retornamos 1
            {
                return 1;
            }
            else if (potencia == 1)// si la potencia es 1 retornamos el numero ingresado
            {
                return numero;
            }
            else if (potencia % 2 == 0)// si la division entre 2 para la potencia es 0 retornamos la potencia con la formula estipulada en clases
            {
                return Potencia(numero, (potencia / 2)) * Potencia(numero, (potencia / 2));
            }
            else if (potencia % 2 != 0)// si la division entre 2 para la potencia es distinto de 0 retornamos la potencia con la formula estipulada en clases
            {
                return Potencia(numero, (potencia - 1) / 2) * Potencia(numero, (potencia - 1) / 2) * numero;
            }
            else
            {
                return 1;
            }
        }
    }
    class Program//clase program
    {
        static void Main(string[] args)//programa principal
        {
            //menu
            int menu;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;//El fondo de la consola se vuelve morado
            Console.ForegroundColor = ConsoleColor.Yellow;//El fondo de la consola se vuelve amaerillo
            Console.WriteLine("Desea realizar la potencia=1 o ver el numero de digitos de un numero=2 y salir=3");
            menu = int.Parse(Console.ReadLine());
            switch (menu)//switch para realizar el menu
            {
                case 1://caso potencia
                    Potenciacion pote = new Potenciacion();
                    int numero, potencia;
                    Console.WriteLine("Ingrese un numero");
                    numero = int.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese una potencia");
                    potencia = int.Parse(Console.ReadLine());
                    Console.WriteLine($"La potencia de {numero}^{potencia} es: {pote.Potencia(numero, potencia)}"); //imprime en consola la respuesta de potencia
                    break;
                case 2://caso digito
                    Digito digi = new Digito();
                    int valor;
                    Console.WriteLine("Ingrese un valor para contar el numero de digitos que tiene");
                    valor = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Su digito {valor} ingresado tiene: {digi.Valor(valor)} digitos"); //imprime en consola la respuesta del caso digito
                    break;
                case 3://caso salida
                    Console.WriteLine("Usted a salido");//imprime en consola que el usuario ya salio
                    break;
                default://caso al ingresar un numero incorrecto
                    Console.WriteLine("A ingresado un numero invalido");//imprime en consola que el numero es invalido
                    break;
            }
           
        }
    }
}
