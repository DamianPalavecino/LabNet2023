using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNetPractica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Omnibus> listaOmnibus = new List<Omnibus>();
            List<Taxi> listaTaxi = new List<Taxi>();

            static int LeerCantidadPasajeros(string transporte)
            {
                Console.Write($"Ingrese la cantidad de pasajeros para el {transporte}: ");
                if (int.TryParse(Console.ReadLine(), out int cantidad))
                {
                    return cantidad;
                }
                else
                {
                    Console.WriteLine("Error. Por favor, ingrese un número.");
                    return LeerCantidadPasajeros(transporte);
                }
            }

            for (int i = 1; i <= 5; i++)
            {
                int pasajerosOmnibus = LeerCantidadPasajeros($"Omnibus {i}");
                Omnibus omnibus = new Omnibus(pasajerosOmnibus);
                listaOmnibus.Add(omnibus);
            }

            for (int i = 1; i <= 5; i++)
            {
                int pasajerosTaxi = LeerCantidadPasajeros($"Taxi {i}");
                Taxi taxi = new Taxi(pasajerosTaxi);
                listaTaxi.Add(taxi);
            }

            Console.WriteLine("Cantidad de pasajeros en el Omnibus:");
            foreach (Omnibus omnibus in listaOmnibus)
            {
                Console.WriteLine($"Omnibus {listaOmnibus.IndexOf(omnibus) + 1}: {omnibus.CantidadPasajeros} pasajeros");
            }

            Console.WriteLine("Cantidad de pasajeros en el Taxi:");
            foreach (Taxi taxi in listaTaxi)
            {
                Console.WriteLine($"Taxi {listaTaxi.IndexOf(taxi) + 1}: {taxi.CantidadPasajeros} pasajeros");
            }

            Console.WriteLine("Presione Enter para salir...");
            Console.ReadLine();
        }
}
}
