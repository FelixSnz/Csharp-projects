using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo7
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejemplo de la sentencia for

            //declaracion de variables
            string aux;
            int i, number;

            try
            {
                Console.WriteLine("Escribe el numero del que quieres saber su tabla de multiplicar"); //pide el numero de la tabla de multiplicar
                aux = Console.ReadLine(); //almacene el numero de la tabla a mostrar
                number = Convert.ToInt32(aux); //convierte el numero de string a entero

                for (i = 1; i <= 12; i++) //ciclo for para mostrar la tabla de "number"
                {
                    Console.WriteLine("{0} x {1} = {2}", number, i, i * number); //imprime una de las multiplicaciones de la tabla
                }
            }
            catch(Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red; // cambia el color de la letra a rojo
                Console.WriteLine("Hubo un error en el programa: {0}", err.Message); //imprime mensaje de error
            }
            

            Console.ReadKey();
        }
    }
}
