using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardis.Matias.Div.E
{
    internal class Empleado : Persona
    {

        private int nroLegajo;
        private DateTime fechaBaja;
        private Supervisor supervisorACargo;

        public Empleado(string nombre, string apellido, string nroDocumento, int nroLegajo, DateTime fechaBaja, Supervisor supervisorACargo) 
            :base(nombre, apellido, nroDocumento)
        {
            this.fechaBaja = fechaBaja;
        }

        public DateTime FechaBaja { get => fechaBaja; set => fechaBaja = value; }
        protected int NroLegajo { get => nroLegajo; set => nroLegajo = value; }
        internal Supervisor SupervisorACargo { get => supervisorACargo; set => supervisorACargo = value; }
    }
}
