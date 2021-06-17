using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calificacionesfinales
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables y arreglos
            Dictionary<string, Array> alumnos = new Dictionary<string, Array>();
            string[] labels = {"Parcial1", "Parcial2", "Parcial3", "Promedio", "Desempeño"};
            int[] calificaciones = new int[4];
            string student_name, repetir;
            int i, j, s_amount, temp_cal, acum_cal = 0;

            try
            {
                do
                {
                    alumnos.Clear(); //se limpian los datos de los alumnos

                    Console.ForegroundColor = ConsoleColor.Green; //se cambia el color de la letra a verde
                    Console.Write("cuantos alumnos se van a promediar?"); // se pide al usuario introducir algo

                    //se pide la cantidad de alumnos
                    s_amount = Convert.ToInt32(Console.ReadLine());

                    //for que pide los datos del alumno
                    for (i = 0; i < s_amount; i++)
                    {
                        Console.WriteLine();
                        Console.Write("nombre del alumno #{0}: ", i + 1); // se pide al usuario el nombre de la persona


                        student_name = Console.ReadLine();//se almacena el nombre del alumno

                        for(j = 0; j < calificaciones.Length; j++) // cliclo for para pedir las calificaciones del alumno
                        {
                            if (j == calificaciones.Length - 1)
                            {
                                calificaciones[j] = (int)Decimal.Round((decimal)acum_cal / (calificaciones.Length - 1));// se almacena el promedio
                                break;
                            }

                            Console.Write("calificacion numero {0}: ", j+ 1); // se pide al usuario introducir una calificacion
                            temp_cal = Convert.ToInt32(Console.ReadLine());
                            calificaciones[j] = temp_cal;
                            acum_cal += temp_cal;

                            
                        }

                        alumnos.Add(student_name, (Array)calificaciones.Clone()); //se almacena el nombre del alumno y sus calificaciones
                        Array.Clear(calificaciones, 0, calificaciones.Length);
                        acum_cal = 0;
                        temp_cal = 0;
                    }

                    j = 0;
                    Console.Clear();

                    // se escriben las etiquetas de los datos (nombre, parcial, prom, etc)
                    Console.Write("Nombre");
                    for (int k = 0; k < labels.Length; k++)
                    {
                        Console.SetCursorPosition(k * 10 + alumnos.Keys.Max(key => key.Length) + 1, j);
                        Console.Write(labels[k]);
                    }
                    Console.WriteLine();


                    //se itera atravez de los datos del alumno para imprimir sus datos
                    foreach (KeyValuePair<string, Array> alumno in alumnos)
                    {
                        Console.Write(alumno.Key);

                        
                        for (i = 0; i < alumno.Value.Length; i++)//ciclo for que imprime las calificaciones y el desempeno del alumno
                        {

                            Console.SetCursorPosition(i * 10 + alumnos.Keys.Max(key => key.Length)+ 1, j+ 1);
                            Console.Write(alumno.Value.GetValue(i));
                            if (i == alumno.Value.Length - 1)
                            {
                                Console.SetCursorPosition((i+1) * 10 + alumnos.Keys.Max(key => key.Length) + 1, j + 1);

                                switch (alumno.Value.GetValue(i))// se imprime el desemeno del alumno segun su promedio
                                {
                                    case 10:
                                        Console.Write("Autonomo");
                                        break;
                                    case 9:
                                        Console.Write("Sobresaliente");
                                        break;
                                    case 8:
                                        Console.Write("Suficiente");
                                        break;
                                    default:
                                        Console.Write("Insuficiente");
                                        break;
                                }
                            }
                            
                            Console.WriteLine();

                        }
                        j++;

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
