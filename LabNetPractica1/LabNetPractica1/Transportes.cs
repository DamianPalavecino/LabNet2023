using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace LabNetPractica1
{
    public abstract class TransportePublico
    {
        private int cantidadPasajeros;

        public TransportePublico(int cantidadPasajeros)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }
}

