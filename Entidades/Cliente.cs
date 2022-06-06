using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cliente : Persona
    {
        private string numeroCliente;
        private static bool esHabilitado;

        static Cliente()
        {
            esHabilitado = true;
        }

        public Cliente(string nombre, string apellido, string nroDocumento, string numeroCliente, bool esHabilitado) 
            :base(nombre, apellido, nroDocumento)
        {
            this.NumeroCliente = numeroCliente;
        }
        public string NumeroCliente { get => numeroCliente; set => numeroCliente = value; }
        public bool EsHabilitado { get => esHabilitado; set => esHabilitado = value; }
    }
}
