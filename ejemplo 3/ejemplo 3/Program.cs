using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemplo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejemplo que muestra la forma de imprimir en consola dando formato de salida
            //declaracion de variables
            double radio, altura, volumen;
            string auxiliar;

            Console.Write("Digita el valor del radio: ");    // solicita el valor del radio
            auxiliar = Console.ReadLine();                   // Lee el valor del radio en modo texto
            radio = Convert.ToDouble(auxiliar);              // Convierte el valor a tipo double

            Console.Write("Digita el valor de la altura: "); //solicita el valor de la altura
            auxiliar = Console.ReadLine();                   //Lee el valor de le altura en modo texto
            altura = Convert.ToDouble(auxiliar);             //Convierte el valor a tipo double

            volumen = Math.PI * Math.Pow(radio, 2) * altura; //calcula el volumen

            Console.WriteLine();                             //Imprime linea en blanco
            Console.WriteLine("El cilindro de radio {0} y altura {1}, tiene un volumen igual a {2}", radio, altura, volumen.ToString("0.000"));
            //Imprime el valor de las 3 variables en la misma linea

            Console.WriteLine();
            Console.WriteLine("el volumen del cilindro es: " + String.Format("{0:##.00}", volumen));
            Console.WriteLine("Hoy es " + String.Format("{0:F}", DateTime.Now));
            Console.WriteLine("Hoy es " + String.Format("{0:dd/MM/yyy}", DateTime.Now));

            Console.ReadKey();


        }
    }
}
