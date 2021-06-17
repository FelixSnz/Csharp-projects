using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string aux, again = "a";
            

            try
            {
                do
                {
                    int i, j = 0;
                    Console.ForegroundColor = ConsoleColor.Green; //se cambia el color de la letra a verde
                    Console.WriteLine("cuantas cadenas va a introducir?"); // se pide al usuario introducir algo
                    //se pide la cantidad de nombres
                    aux = Console.ReadLine();

                    Console.WriteLine(); // linea vacia
                    Console.WriteLine(aux);

                    string rtext = string.Empty; //se crea string vacia

                    for (i = aux.Length - 1; i >= 0; i--) //metodo for para crear texto inverso
                    {
                        rtext += aux[i];// se agrega caracter por caracter
                    }

                    Console.WriteLine(rtext); // se imprime el texto en reversa


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
