using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2_3_4
{
    public class Logic
    {
        public static void DispararExcepcion()
        {
            try
            {
                throw new FormatException();
            }
            catch (FormatException excepcion)
            {
                Console.Write($"Excepción: {excepcion.Message}");
                Console.WriteLine($"Tipo de excepción: {excepcion.GetType()}");
            }
        }

        public static void DispararExcepcionPersonalizada(string mensaje)
        {
            try
            {
                throw new ExcepcionPersonalizada(mensaje);
            }
            catch (ExcepcionPersonalizada excepcion)
            {
                Console.WriteLine($"Mensaje de excepción: {excepcion.Message}");
                Console.WriteLine($"Tipo de excepción: {excepcion.GetType()}");
            }
        }
    }
}
