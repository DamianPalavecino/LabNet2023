using System;

namespace LabNetPractica2
{
    public static class Ejercicio1
    {
        public static void DividirPor(this int dividendo, int divisor)
        {
            try
            {
                int resultado = dividendo / divisor;
                Console.WriteLine($"Resultado: {resultado}");
            }

            catch (DivideByZeroException excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }

            finally
            {
                Console.WriteLine("Operación completada.");
            }
        }
    }
}