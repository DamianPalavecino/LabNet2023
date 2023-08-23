using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un número para la división:");
            int valorIngresado = int.Parse(Console.ReadLine());

            10.DividirPor(valorIngresado);

            Console.ReadKey();
        }
    }
}
