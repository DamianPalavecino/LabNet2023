using System;

namespace LabNetPractica1
{
    public abstract class TransportePublico
    {
        protected int cantidadPasajeros;

        public TransportePublico(int cantidadPasajeros)
        {
            this.cantidadPasajeros = cantidadPasajeros;
        }

        public abstract void Avanzar();
        public abstract void Detenerse();
    }

    public class Omnibus : TransportePublico
    {
        private int pasajeros;

        public Omnibus(int pasajeros) : base (cantidadPasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public override string Avanzar()
        {
            return "El Omnibus esta avanzando.";
        }

        public override string Detenerse()
        {
            return "El Omnibus se detuvo.";
        }

        public int PasajerosOmnibus
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

    }

    public class Taxi : TransportePublico
    {
        private int pasajeros;

        public Taxi(int pasajeros) : base(cantidadPasajeros)
        {
            this.pasajeros = pasajeros;
        }

        public override string Avanzar()
        {
            return "El Taxi esta avanzando.";
        }

        public override string Detenerse()
        {
            return "El Taxi se detuvo.";
        }

        public int PasajerosTaxi
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

    }

}

