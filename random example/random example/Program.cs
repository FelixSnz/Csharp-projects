using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            double numero;
            Random rnd = new Random();

            while (x < 10)
            {
                numero = rnd.NextDouble();
                Console.WriteLine("numero aleatorio generado: {0}", numero);
                x++;
            }

            Console.ReadKey();
        }
    }
}
