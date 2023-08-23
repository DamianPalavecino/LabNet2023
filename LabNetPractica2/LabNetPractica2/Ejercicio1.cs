using System;

namespace LabNetPractica2
{
    public static class Ejercicio1
    {
        public static void DividirPor(int divisor)
        {
            try
            {
                int resultado = 10 / divisor;
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