using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardis.Matias.Div.E
{
    internal class Supervisor : Persona
    {

        private int nroLegajo;

        public Supervisor(string nombre, string apellido, string nroDocumento, int nroLegajo) 
            :base(nombre, apellido, nroDocumento)
        {
        }

        protected int NroLegajo { get => nroLegajo; set => nroLegajo = value; }
    }
}
