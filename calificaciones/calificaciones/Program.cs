using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificaciones
{
    class Program
    {
        static void Main(string[] args)
        {
            //el siguiente programa obtiene el promedio de 3 calificaciones e imprime el desempeno del alumno

            //declaracion de variables
            string aux, aux_cal;
            double promedio, cal_acum = 0, temp_cal;
            int i, cal_amount;

            try
            {
                //se pide la cantidad de calificaciones
                Console.WriteLine("Cantidad de calificaciones:");
                aux_cal = Console.ReadLine();
                cal_amount = Convert.ToInt32(aux_cal);

                for (i = 1; i <=cal_amount; i++) //bucle for para pedir las calificaciones
                {

                    Console.WriteLine("Introduzca la calificacion numero {0}", i); //se pide una de las calificaciones
                    aux = Console.ReadLine(); //se lee la calificacion
                    temp_cal = Convert.ToDouble(aux); //el tipo de dato pasa de string a double

                    cal_acum += temp_cal; //se agrega la calificacion temporal a un acumulado
                    
                }

                promedio = Math.Round(cal_acum / cal_amount); // se obtiene el promedio
                promedio = Convert.ToInt32(promedio); // se convierte el promedio a tipo entero


                switch (promedio)
                {
                    case 7:
                        Console.ForegroundColor = ConsoleColor.Red;//el promedio se muestra en rojo
                        Console.WriteLine("La calificación es: " + promedio.ToString()); // se imprime la calificacion
                        Console.WriteLine("el desempeño del alumno es: Insuficiente"); 
                        break;
                    case 8:
                        Console.ForegroundColor = ConsoleColor.Yellow;//el texto se muestra en amarillo
                        Console.WriteLine("La calificación es: " + promedio.ToString());// se imprime la calificacion
                        Console.WriteLine("el desempeño del alumno es: Suficiente"); 
                        break;
                    case 9:
                        Console.ForegroundColor = ConsoleColor.Blue;//el texto se muestra en azul
                        Console.WriteLine("La calificación es: " + promedio.ToString());// se imprime la calificacion
                        Console.WriteLine("el desempeño del alumno es: Sobresaliente"); 
                        break;
                    case 10:
                        Console.ForegroundColor = ConsoleColor.Green;// el texto se muestra en verde
                        Console.WriteLine("La calificación es: " + promedio.ToString());// se imprime la calificacion
                        Console.WriteLine("el desempeño del alumno es: Autosuficiente"); 
                        break;
                    default:

                        if (promedio <= 7 && promedio <= 10)
                        {
                            Console.ForegroundColor = ConsoleColor.Red; // el color cambia a rojo
                            Console.WriteLine("La calificación es: " + "7");// se imprime la calificacion
                            Console.WriteLine("el desempeño del alumno es: Insuficiente");
                        }
                        break;

                }
            }

            catch (Exception err)
            {
                Console.ForegroundColor = ConsoleColor.Red; // el color cambia a rojo
                Console.WriteLine("Hubo un error en el programa"); //mensaje de error
                Console.WriteLine(err.Message);
            }

            Console.ReadKey();
        }
    }
}
