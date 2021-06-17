using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejempl06
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejemplo try and catch
            //declaracion de variables

            int x, y, resultado;
            string auxiliar;

            try
            {
                Console.WriteLine("Escribe el valor para el dividendo: ");
                auxiliar = Console.ReadLine();
                x = Convert.ToInt32(auxiliar);

                Console.WriteLine("Escribe el valor para el divisor: ");
                auxiliar = Console.ReadLine();
                y = Convert.ToInt32(auxiliar);

                resultado = x / y;
                Console.WriteLine();
                Console.BackgroundColor = ConsoleColor.DarkBlue;        //cambia el color del fondo a azul oscuro
                Console.ForegroundColor = ConsoleColor.Cyan;            //cambia a color verde las letras de la consola
                Console.WriteLine("la division de {0} / {1} es igual a {2}", x, y, resultado);

            }

            catch(Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;              //la letra cambia a color rojo
                Console.WriteLine("se presento un error en el programa");//muestra mensaje de error
                Console.WriteLine(err.Message);                                  //imprime la excepcion

            }
            Console.ReadKey();
        }
    }
}
