using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try {
                Console.WriteLine("Ingresa un dividendo:");
                int dividendo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa un divisor:");
                int divisor = Convert.ToInt32(Console.ReadLine());

                dividendo.DividirPor(divisor);
            }
            catch (FormatException)
            {
                Console.WriteLine("¡Seguro Ingreso una letra o no ingreso nada!");
            }

            Console.ReadKey();
        }
    }
}
