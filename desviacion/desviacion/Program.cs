using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desviacion
{
    class Program
    {
        static void Main(string[] args)
        {
            int control = 0;
            int n, i, j;
            double prom, sum = 0, desv;
            string aux1, aux2;

            try
            {
                
                do
                {
                    Console.ForegroundColor = ConsoleColor.Green; // cambia el color de la letra a verde
                    Console.WriteLine("especifica la cantidad de numeros ");
                    aux1 = Console.ReadLine();
                    n = Convert.ToInt32(aux1);
                    double[] doubles = new double[n];
         
                    Random rnd = new Random();

                    for (i = 0; i <= n - 1; i++)//Ciclo for
                    {
                        doubles[i] = rnd.NextDouble() * 10;
           
                        Console.WriteLine("El valor generado es: " + doubles[i]); //muestra el valor aleatorio generado
                        sum = doubles[i] + sum; //suma los numeros aleatorios acumulados
                    }
                    prom = (sum / n);

                    double diff, acum = 0;

                    for (j = 0; j <= n - 1; j++) // ciclo para calcular la desviacion
                    {
                        diff = Math.Pow(doubles[j] - prom, 2); // se eleva al cuadrado la diferencia de la formula
                        acum = diff + acum; //se suma el acumulado
                    }
                    desv = Math.Sqrt(acum / n); // se obtiene la desviacion estandar
                    Console.WriteLine("el promedio es: " + prom.ToString("0.000")); // se imprime el promedio
                    Console.WriteLine("la desviacion estandar es: " + desv.ToString("0.000")); // se imprime la desviacion estandar


                    Console.WriteLine("Realizar operacion de nuevo? y/n"); // se pregunta al usuario si quiere correr el programa otra vez
                    aux2 = Console.ReadLine();
                    if (aux2 == "Y" || aux2 == "y") // condicion para saber si correr el programa de nuevo
                    {
                        control = 1;
                        prom = 0;
                        sum = 0;
                        desv = 0;

                    }
                    else
                    {
                        control = 0;
                    }
                } while (control == 1);
            }
            catch (Exception err)//error
            {
                Console.ForegroundColor = ConsoleColor.Red; // cambia el color de la letra a rojo
                Console.WriteLine("ERROR: {0}", err.Message); //imprime mensaje de error
            }

            Console.ReadKey();
        }
    }
}
