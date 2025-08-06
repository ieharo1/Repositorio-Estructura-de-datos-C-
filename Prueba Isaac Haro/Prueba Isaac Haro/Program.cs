using System;

namespace Prueba_Isaac_Haro
{
    class Program
    {
        static void Main(string[] args)
        {
            int sw;
            string[] abc = new string[27] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "Ñ", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            string cadena;
            Console.WriteLine("Ingrese la cadena con la que desea trabajar");
            cadena = Console.ReadLine().ToUpper();
            Console.WriteLine("Ingrese 1 si desea cifrar, 2 si desea decifrar");
            sw = int.Parse(Console.ReadLine());
            switch(sw) 
            {
                case 1:
                    Cifrar(cadena, abc);
                    break;
                case 2:
                    Descifrar(cadena, abc);
                    break;
                default:
                    Console.WriteLine("El caso ingresado no es el correcto");
                    break;
            }
        }
        static string  Cifrar(string cadena, string [] abc)
        {
            int ext = 0;
            Console.WriteLine("Ingrese la extencion del cifrado");
            ext = int.Parse(Console.ReadLine());
            string aux, cifr=" ";
            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if ((cadena.Substring(i, 1)) == Convert.ToString(abc[j]))
                    {
                        if ((cadena.Substring(i, 1)) == "Z")
                        {
                            j = 0;
                            aux = Convert.ToString(abc[j + (ext-1)]);
                            Console.Write(aux);
                            break;
                        }
                        else if ((cadena.Substring(i, 1)) == "Y")
                        {
                            j = 0;
                            aux = Convert.ToString(abc[j+(ext-2)]);
                            Console.Write(aux);
                            break;
                        }
                        else if ((cadena.Substring(i, 1)) == "X")
                        {
                            j = 0;
                            aux = Convert.ToString(abc[j + (ext - 3)]);
                            Console.Write(aux);
                            break;
                        }
                        else
                        {
                            aux = Convert.ToString(abc[j + ext]);
                            Console.Write(aux);
                        }
                    }
                   
                }
            }
            return cifr;
            
        }
       static string Descifrar(string cadena, string[] abc)
       {
            int ext = 0;
            Console.WriteLine("Ingrese la extencion del cifrado");
            ext = int.Parse(Console.ReadLine());
            string aux, desc="0";
            for (int i = 0; i < cadena.Length; i++)
            {
                for (int j = 0; j < abc.Length; j++)
                {
                    if ((cadena.Substring(i, 1)) == Convert.ToString(abc[j]))
                    {
                        if ((cadena.Substring(i, 1)) == "A")
                        {
                            j = 27;
                            aux = Convert.ToString(abc[j - (ext - 1)]);
                            Console.Write(aux);
                            j = 0;
                            break;
                        }
                        else if ((cadena.Substring(i, 1)) == "B")
                        {
                            j = 27;
                            aux = Convert.ToString(abc[j - (ext - 2)]);
                            Console.Write(aux);
                            j = 0;
                            break;
                        }
                        else if ((cadena.Substring(i, 1)) == "C")
                        {
                            j = 27;
                            aux = Convert.ToString(abc[j - (ext - 3)]);
                            Console.Write(aux);
                            j = 0;
                            break;
                        }
                        else
                        {
                            aux = Convert.ToString(abc[j - ext]);
                            Console.Write(aux);
                        }
                    }

                }
            }
            return desc;
        }
    }
}
