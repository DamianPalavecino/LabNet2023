using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2_2
{
    public static class Ejercicio2
    {
        public static void DividirPor(this int dividendo, int divisor) {
            try
            {
                int resultado = dividendo / divisor;
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException excepcion)
            {
                Console.WriteLine("¡Solo Chuck Norris divide por cero!");
                Console.WriteLine($"Excepción: {excepcion.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("¡Seguro ingresó una letra o no ingresó nada!");
            }
        }
    }
}
