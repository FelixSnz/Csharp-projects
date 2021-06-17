using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nombresyedades
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            Dictionary<string, int> data = new Dictionary<string, int>();
            string aux1, aux2, repetir;
            int i, data_amount, temp_age, mayores = 0, menores = 0;

            try
            {
                do
                {
                    data.Clear();
                    mayores = 0;
                    Console.ForegroundColor = ConsoleColor.Green; //se cambia el color de la letra a verde
                    Console.Write("cuantas personas se van a registrar? "); // se pide al usuario introducir algo
                    //se pide la cantidad de nombres
                    aux1 = Console.ReadLine();
                    data_amount = Convert.ToInt32(aux1);


                    for (i = 0; i < data_amount; i++)
                    {
                        Console.WriteLine();
                        Console.Write("nombre de la persona: "); // se pide al usuario el nombre de la persona
                        aux1 = Console.ReadLine();
                        
                        Console.Write("edad de la persona: "); // se pide al usuario introducir la edad de la persona
                        aux2 = Console.ReadLine();
                        temp_age = Convert.ToInt32(aux2);

                        data.Add(aux1, temp_age); //se agregan los datos en conjunto
                    }

               


                    foreach (KeyValuePair<string, int> entry in data.OrderByDescending(key => key.Value).Reverse())
                    {

                        Console.WriteLine("nombre: {0} | edad: {1} ", entry.Key, entry.Value);

                    }


                    Console.WriteLine();

                    Console.WriteLine("Realizar operacion de nuevo? y/n"); // se pregunta al usuario si quiere correr el programa otra vez
                    repetir = Console.ReadLine().ToLower();


                } while (repetir == "y");


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
