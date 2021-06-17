using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enteroabinario
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string repetir;
            int integer_value;

            try
            {

                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("Ingrese un numero entero:");

                    integer_value = Convert.ToInt32(Console.ReadLine());//pide el valor entero


                    Console.Write("la conversion a binario seria: {0}", FromIntegerToBinary(integer_value));//muestra la conversion a binario

                    Console.WriteLine();
                    Console.WriteLine();

                    Console.WriteLine("Realizar operacion de nuevo? y/n"); // se pregunta al usuario si quiere correr el programa otra vez
                    repetir = Console.ReadLine().ToLower();
                } while (repetir == "y");


            }
            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hubo un error en el programa: {0}", err.Message); //imprime mensaje de error
            }
            Console.ReadKey();
        }

        static string FromIntegerToBinary(int integer)// metodo para realizar conversion
        {
 
            int residuo;
            string binary = string.Empty;

            while (integer > 0)//ciclo while para hacer la conversion
            {
                residuo = integer % 2; 
                integer /= 2;
                binary = residuo.ToString() + binary; //se concatenan los residuos para formar el numero en binario
            }

            return binary;
        }
    }
}
