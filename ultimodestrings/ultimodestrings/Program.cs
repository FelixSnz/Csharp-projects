using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ultimodestrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string aux;

            Random rnd1 = new Random();
            Random rnd2 = new Random();
            Random rndColor = new Random();

            int x, y;

            try
            {

                Console.ForegroundColor = ConsoleColor.Green; //se cambia el color de la letra a verde
                Console.WriteLine("introduzca un texto"); // se pide al usuario introducir algo
      
                aux = Console.ReadLine(); // se almacena el texto del usuario

                while (true)
                {
                    Console.Clear();// se limpia el texto de la consola
                    Console.ForegroundColor = (ConsoleColor)rndColor.Next(8); //se crea un color aleatorio
                    x = rnd1.Next(Console.WindowLeft, Console.WindowWidth);// se crea la cordenada x para el cursor
                    y = rnd2.Next(Console.WindowTop, Console.WindowHeight);// se crea la cordenada y para el cursor
                    Console.SetCursorPosition(x, y); //se marca la nueva posicion del cursor 
                    Console.WriteLine(aux); //se muestra el texto en posicion y color aleatoria
                    Thread.Sleep(1000); // se espera 10 segundos
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
