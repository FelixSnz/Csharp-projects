using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formula_general
{
    class Program
    {
        static void Main(string[] args)
        {
            //ejemplo que muestra si una ecuacion cuadratica es compleja o no

            //registro de variables
            double a, b, c, x1, x2, raiz;
            string aux1, aux2, aux3; 

            Console.WriteLine("Ingresa el valor de A"); //Se pide la Variable a
            aux1 = Console.ReadLine();                  //Se guarada la variable a en tipo string
            a = Convert.ToDouble(aux1);                 //se convierte a double
            Console.WriteLine("Ingresa el valor de B"); // Se pide la variable
            aux2 = Console.ReadLine();                  //Se registra la varible b en tipo string
            b = Convert.ToDouble(aux2);                 //se convierte a double
            Console.WriteLine("Ingresa el valor de C"); // Se pide la varible c en tipo string
            aux3 = Console.ReadLine();                  // Se registra la variable C
            c = Convert.ToDouble(aux3);                 //se convierte a double


            raiz = (Math.Sqrt(Math.Pow(b, 2) - 4 * a * c));// se calcula la raiz

            if (raiz >= 0)
            //si la raiz es mayor o igual a 0, se imprime el resultado
            {
                x2 = (-(b + raiz) / (2 * a));
                x1 = (-(b - raiz) / (2 * a));
                Console.WriteLine("el resultado x1 es: {0} y x2 es: {1}", x1, x2);
            }
            else
            //si la raiz es negativa, se muestra el mensaje de error
            {
                Console.WriteLine("Las raices son complejas");
            }
            Console.ReadKey();
        }
    }
}
