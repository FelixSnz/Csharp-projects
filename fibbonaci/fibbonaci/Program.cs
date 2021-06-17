using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibbonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            //Declaracion de variables
            int a = 0, b =1, limite, i, auxiliar;                                            //Se declaran las variables
            Console.WriteLine("Cuantos numneros de la serie de fibonacci se van a mostrar?");//Arroja el texto principal
            limite = int.Parse(Console.ReadLine());                                          //Introducir el dato
   
            try
            {
                if (limite > 1)
                {
                    Console.WriteLine("0");
                    for (i = 0; i < limite - 1; i++)     //ciclo for
                    {
                        auxiliar = a;
                        a = b;
                        b = auxiliar + a;               //se suma el valor anterior al actual
                        Console.WriteLine(a);           //imprime el nuevo valor de la serie
                    }
                }
                else if (limite == 1)
                {
                    Console.WriteLine("0");             //se imprime un cero en caso de pedir solo un valor
                }
                
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Se presentó un error en el programa: {0}", e.Message);
            }
            Console.ReadKey();
        }
    }
}
