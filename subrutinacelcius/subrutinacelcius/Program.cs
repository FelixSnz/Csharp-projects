using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subrutinacelcius
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            double celcius;
            string repetir, scale;

            try
            {

                do
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Green;

                    Console.WriteLine("Ingrese la temperatura en celcius"); // se pide la temperatura en celcius
                    celcius = double.Parse(Console.ReadLine()); // la temperatura se almacena en la variable "celcius"

                    Console.WriteLine("Ingrese la escala a convertir 'F' o 'K'");// se pide en que escala se desea convertir la temperatura
                    scale = Console.ReadLine().ToLower();


                    Console.WriteLine("La temperatura es: {0} {1}", conversion(celcius, scale), scale.ToUpper() + "°");// se imprime la conversion
     

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

        static double conversion(double celcius, string scale) // subrutina para convertir de celcius a farenheit o celcius
        {
            double result = 0;

            if (scale == "f")
            {
                result = (celcius * 9 / 5) + 32;
            }
            else if (scale == "k")
            {
                result = celcius + 273.15;
            }
            else
            {
                throw new ArgumentException("la escala de temepratura no es valida, solo se acepta F o K"); //se levanta un error en caso de ingresar escala no valida
            }

            return result;
        }
    }
}
