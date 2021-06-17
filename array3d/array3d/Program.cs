using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array3d
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            string repetir;
            int i, j, k, n1, n2, n3, prev_color = 0, new_color;
            Random rnd = new Random();
            
            int var_rand;

            try
            {
                do
                {

                    //se piden los datos al usuario
                    Console.WriteLine("cantidad de n1: ");
                    n1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("cantidad de n2:  ");
                    n2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("cantidad de n3:  ");
                    n3 = Convert.ToInt32(Console.ReadLine());

                    //se crea la matriz de valores random y matrices de disntintos colores
                    int[,,] matriz = new int[n1, n2, n3];

                    new_color = (int)(ConsoleColor)rnd.Next(16);


                    Console.Clear();
                    for (i = 0; i < n1; i++)
                    {

                        //se genera un color random que no sea negro y diferente al previo
                        while (new_color == (int)ConsoleColor.Black || new_color == prev_color)
                        {
                            new_color = (int)(ConsoleColor)rnd.Next(16);
                        }
                        Console.ForegroundColor = (ConsoleColor)new_color;
                        prev_color = new_color;


                        //ciclos for para generar matriz de 2x2 de un color random
                        for (j = 0; j < n2; j++)
                        {
                            for (k = 0; k < n3; k++)
                            {
                                var_rand = rnd.Next(1, 100); //se crea un numero random
                                matriz[i, j, k] = var_rand;

                                Console.SetCursorPosition(j * 3 + i * n2 *4, k * 3);//se posicia el cursor de la consola
                                Console.Write(var_rand);//se imprime el valor random
                            }
                        }
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
                Console.ForegroundColor = (ConsoleColor)rnd.Next(16); // cambia el color de la letra a rojo
                Console.WriteLine("Hubo un error en el programa: {0}", err.Message); //imprime mensaje de error
            }

            Console.ReadKey();

        }

    }
}
