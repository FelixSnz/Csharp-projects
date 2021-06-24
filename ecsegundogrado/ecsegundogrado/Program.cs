using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecsegundogrado
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            double a, b, c, result_1, result_2;
            string again;
            try
            {
 
                do
                {
                    Console.Clear();


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Ingresa el coeficiente A"); //Se pide el coeficiente A
                    a = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el coeficiente B"); //Se pide el coeficiente B
                    b = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingresa el coeficiente C"); //Se pide el coeficiente C
                    c = Convert.ToDouble(Console.ReadLine());

                    (result_1, result_2) = GetSqrts(a, b, c);

                    Console.WriteLine("Las raices son x1:{0} y x2:{1} ", result_1, result_2);
                    


                    Console.WriteLine("Realizar operacion de nuevo? y/n"); // se pregunta al usuario si quiere correr el programa otra vez
                    again = Console.ReadLine().ToLower();
                } while (again == "y");


            }

            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Hubo un error en el programa: {0}", err.Message); //imprime mensaje de error
            }
            Console.ReadKey();
        }
        private static (double, double) GetSqrts(double a1, double b1, double c1)//subrutina para obtener raices de ecuaciond e segundo grado
        {
            double x1, x2;
            double sqrt = (Math.Sqrt(Math.Pow(b1, 2) - 4 * a1 * c1));//se obtiene la raiz de la formula
            if (sqrt >= 0)
            {
                //se obtienen ambas raices en caso de la raiz interior ser mayor o igual a 0
                x1 = (-(b1 + sqrt) / (2 * a1)); 
                x2 = (-(b1 - sqrt) / (2 * a1));

            }
            else
            {
                //en casi de la raiz de la ecuacion ser 0 las raices son 0th

                throw new InvalidOperationException("las raices de la ecuacion son complejas");

            }
            return (x1, x2);
        }
    }
}
