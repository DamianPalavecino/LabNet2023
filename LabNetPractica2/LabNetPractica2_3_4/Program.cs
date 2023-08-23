using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2_3_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logic.DispararExcepcion();
            Console.WriteLine("Ingrese un mensaje personalizado");
            string mensajePersonalizado = Console.ReadLine();
            Logic.DispararExcepcionPersonalizada(mensajePersonalizado);
            Console.ReadKey();
        }
    }
}
