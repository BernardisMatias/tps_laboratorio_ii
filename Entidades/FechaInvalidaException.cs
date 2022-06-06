using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class FechaInvalidaException : Exception
    {
        public FechaInvalidaException(string mensaje) : base(mensaje)
        {

        }
        public FechaInvalidaException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
