using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorialcsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //el siguiente programa calcula el factorial del numero introducido
                int num, fact = 1;
                string aux;
                Console.WriteLine("Digita el numero para obtener su factorial:"); //pide ingresar un numero
                aux = Console.ReadLine(); //almacena el numero en una string "aux"
                num = Convert.ToInt32(aux); //convierte el valor introducido a tipo entero
                if (num == 0) //hace una comparacion para saber si el numero introducido es 0 o menor a 0
                {
                    Console.WriteLine("El factorial de {0} es: 1", num); //si el numero es 0 imprime que el factorial es 1
                }
                else if (num < 0)
                {
                    Console.WriteLine("valor no valido (negativo)"); //si el numero es negativo imprime que el numero no es valido
                }
                else
                {
                    for (int i = 1; i <= num; i++)
                    {
                        fact = fact * i; // se realiza la operacin para obtener el factorual
                    }
                    Console.WriteLine("El factorial de {0} es: {1}: ", num, fact); // se imprime el factorual
                }
            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red; // cambia el color de la letra a rojo
                Console.WriteLine("Hubo un error en el programa: {0}", err.Message); //imprime mensaje de error
            }


            Console.ReadKey();
        }
    }
}
