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

        public abstract string Avanzar();
        public abstract string Detenerse();
        public abstract int CantidadPasajeros { get; set; }
    }

    public class Omnibus : TransportePublico
    {
        private int pasajeros;

        public Omnibus(int cantidadPasajeros) : base (cantidadPasajeros)
        {
            this.pasajeros = cantidadPasajeros;
        }

        public override string Avanzar()
        {
            return "El Omnibus esta avanzando.";
        }

        public override string Detenerse()
        {
            return "El Omnibus se detuvo.";
        }

        public override int CantidadPasajeros
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

    }

    public class Taxi : TransportePublico
    {
        private int pasajeros;

        public Taxi(int cantidadPasajeros) : base(cantidadPasajeros)
        {
            this.pasajeros = cantidadPasajeros;
        }

        public override string Avanzar()
        {
            return "El Taxi esta avanzando.";
        }

        public override string Detenerse()
        {
            return "El Taxi se detuvo.";
        }

        public override int CantidadPasajeros
        {
            get { return pasajeros; }
            set { pasajeros = value; }
        }

    }

}

