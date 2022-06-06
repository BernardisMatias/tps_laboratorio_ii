using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Exceptions
{
    public class StringInvalidoException : Exception
    {
        public StringInvalidoException(string mensaje) :base(mensaje)
        {

        }
        public StringInvalidoException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
