using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_strings
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string aux, lower, temp, again = "a";
            int i, words_amount, mayores = 0, menores;
            
            try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green; //se cambia el color de la letra a verde
                    Console.WriteLine("cuantas cadenas va a introducir?"); // se pide al usuario introducir algo
                    //se pide la cantidad de nombres
                    aux = Console.ReadLine();
                    words_amount = Convert.ToInt32(aux);

                    //se declara una string para almacenar los nombres
                    string[] words = new string[words_amount];

                    for (i = 0; i < words_amount; i++)
                    {
                        //se piden los nombres de uno en uno
                        Console.WriteLine("introduce la cadena numero {0}", i);
                        aux = Console.ReadLine();
                        words[i] = aux;
                    }

                    words = words.OrderBy(x => x.Length).ToArray(); //se ordenan los nombres de menor a mayor

                    Console.WriteLine();
                    for (i = 0; i < words_amount; i++)
                    {
                        Console.WriteLine(words[i]); // se imprime uno de los nombres ya en orden

                    }

                    Console.WriteLine("Realizar operacion de nuevo? y/n"); // se pregunta al usuario si quiere correr el programa otra vez
                    again = Console.ReadLine().ToLower();


                } while (again == "y");
                

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
