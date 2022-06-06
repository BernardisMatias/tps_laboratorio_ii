using System;

namespace Entidades
{
    public class Utilitaria : Vehiculo
    {
        private int cantidadPuertas;
        private bool deLujo;
        private bool clienteVip;

        public Utilitaria(string patente, string marca, string modelo, EColor color) 
            :base(patente, marca, modelo, color)
        {

        }

        public override string ComprobanteAlquiler()
        {
            throw new NotImplementedException();
        }
    }
}
