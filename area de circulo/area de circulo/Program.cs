using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_de_circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            // ejemplo que utuliza variables. calcula el area de un circulo a partir del radio
            // Declaracion de variables

            double centigrados, farhenheit;
            string auxiliar;

            Console.WriteLine("Introduzca la temperatura en centigrados: "); //solicita la temperatura en centigrados
            auxiliar = Console.ReadLine(); // lee el valor de la temperatura en formato string

            centigrados = Convert.ToDouble(auxiliar); //convierte la variable auxiliar (string) a tipo de dato double y almacena en "centigrados"

            farhenheit = centigrados * 1.8 + 32; //se hace la conversion de centigrados a farhenheit

            Console.WriteLine("La temperatura es: " + farhenheit.ToString("0.000")); // imprime la temperatura en farhenheit
            Console.ReadKey();
        }
    }
}
