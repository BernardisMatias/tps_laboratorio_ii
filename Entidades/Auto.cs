using System;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        private int cantidadPuertas;
        private bool deLujo;
        private ECombustible combustible;

        protected int CantidadPuertas { get => cantidadPuertas;}
        protected bool DeLujo { get => deLujo;}
        protected ECombustible Combustible { get => combustible;}

        public Auto(string patente, string marca, string modelo, EColor color, int cantidadPuertas, bool deLujo, ECombustible combustible) 
            :base(patente, marca, modelo, color)
        {
            this.cantidadPuertas = cantidadPuertas;
            this.deLujo = deLujo;
            this.combustible = combustible;
        }

        public override string ComprobanteAlquiler()
        {
            return this.GetHashCode().ToString();
        }



    }
}
