using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SerializerException : Exception
    {
        public SerializerException(string mensaje) : base(mensaje)
        {

        }
        public SerializerException(string mensaje, Exception inner) : base(mensaje, inner)
        {

        }
    }
}
