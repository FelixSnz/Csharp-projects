using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumamatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string aux1, aux2, repetir;
            int i, j, n_filas, n_columnas, temp_sum=0;
            Random rnd = new Random();
            int var_rand;

            try
            {
                do
                {
                    Console.WriteLine("cantidad de filas: ");
                    n_filas = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("cantidad de columnas: ");
                    n_columnas = Convert.ToInt32(Console.ReadLine());

                    int[,] matriz = new int[n_filas, n_columnas];
                    int[] sums = new int[n_filas];
                    Console.Clear();
                    for (i = 0; i < n_filas; i++)
                    {
                        for (j = 0; j< n_columnas; j++)
                        {
                            var_rand = rnd.Next(1, 100);
                            matriz[i, j] = var_rand;
                            Console.SetCursorPosition(i*5,j*5);
                            Console.Write(var_rand);
                            temp_sum = temp_sum + var_rand;
                        }

                        sums[i] = temp_sum;
                        temp_sum = 0;

                    
                    }
                    for (i = 0; i < 2; i++)
                    {
                        Console.WriteLine();
                    }

                    Console.WriteLine("--------------------------------");

                    for (i = 0; i < sums.Length; i++)
                    {
                        Console.SetCursorPosition(i * 5, Console.CursorTop);
                        Console.Write(sums[i]);
                    }



                    for (i = 0; i < 2; i++)
                    {
                        Console.WriteLine();
                    }
                    
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
