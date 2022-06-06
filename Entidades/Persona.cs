using Entidades.Exceptions;
using System;
using System.Linq;

namespace Entidades
{
    public abstract class Persona
    {
        public enum ESexo { MASCULINO, FEMENINO, NOBINARIO, INDEFINIDO }
        protected string nombre;
        protected string apellido;
        protected string nroDocumento;
        protected DateTime fechaNacimiento;
        private DateTime fechaAlta;
        protected ESexo sexo;
        protected string pais;
        protected string localidad;
        protected string direccion;
        protected string email;
        protected string telefono;

        public Persona(string nombre, string apellido, string nroDocumento) 
            :this(nombre,apellido,nroDocumento,new DateTime(),ESexo.INDEFINIDO,"Argentina","-","-","-","-") { }

        protected Persona(string nombre, string apellido, string nroDocumento, DateTime fechaNacimiento, ESexo sexo, string pais, string localidad, string direccion, string email, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nroDocumento = nroDocumento;
            this.fechaNacimiento = fechaNacimiento;
            this.Sexo = sexo;
            this.Pais = pais;
            this.Localidad = localidad;
            this.Direccion = direccion;
            this.Email = email;
            this.Telefono = telefono;
        }

        public string Nombre { 
            get => nombre;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringInvalidoException("El nombre no puede ser vacío o espacios.");
                }
                if (value.Any(char.IsDigit))
                {
                    throw new StringInvalidoException("El nombre no puede contener números.");
                }
                if (hasSymbols(value))
                {
                    throw new StringInvalidoException("El nombre no puede contener símbolos.");
                }
            }
        }
        public string Apellido { 
            get => apellido;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringInvalidoException("El apellido no puede ser vacío o espacios.");
                }
                else if (value.Any(char.IsDigit))
                {
                    throw new StringInvalidoException("El apellido no puede contener números.");
                }
                else if (hasSymbols(value))
                {
                    throw new StringInvalidoException("El apellido no puede contener símbolos.");
                }
                apellido = value;
            }
        }
        public string NroDocumento { 
            get => nroDocumento;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new DniInvalidoException("El DNI no puede ser vacío o espacios.");
                }
                else if (value.Any(char.IsLetter))
                {
                    throw new DniInvalidoException("El DNI no puede contener letras.");
                }
                else if (hasSymbols(value))
                {
                    throw new DniInvalidoException("El DNI no puede contener símbolos.");
                }
                nroDocumento = value;
            }
        }
        public DateTime FechaNacimiento { get => fechaNacimiento;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new FechaInvalidaException("La fecha es inválida.");
                }
                else if (value.ToString().Any(char.IsLetter))
                {
                    throw new FechaInvalidaException("La fecha no puede contener letras.");
                }
                else if (hasSymbols(value.ToString()))
                {
                    throw new FechaInvalidaException("La fecha no puede contener símbolos.");
                }
                fechaNacimiento = value;
            }
        }
        public DateTime FechaAlta { get => fechaAlta;
            set
            {
                if (value == DateTime.MinValue)
                {
                    throw new FechaInvalidaException("La fecha es inválida.");
                }
                else if (value.ToString().Any(char.IsLetter))
                {
                    throw new FechaInvalidaException("La fecha no puede contener letras.");
                }
                else if (hasSymbols(value.ToString()))
                {
                    throw new FechaInvalidaException("La fecha no puede contener símbolos.");
                }
                fechaAlta = value; 
            }
        }
        public ESexo Sexo { get => sexo;
            set
            {
                sexo = value; 
            }
        }
        public string Pais { get => pais;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringInvalidoException("El pais no puede ser vacío o espacios.");
                }
                else if (value.Any(char.IsDigit))
                {
                    throw new StringInvalidoException("El pais no puede contener números.");
                }
                else if (hasSymbols(value))
                {
                    throw new StringInvalidoException("El pais no puede contener símbolos.");
                }
                pais = value; 
            }
        }
        public string Localidad { get => localidad;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringInvalidoException("La localidad no puede ser vacío o espacios.");
                }
                else if (value.Any(char.IsDigit))
                {
                    throw new StringInvalidoException("La localidad no puede contener números.");
                }
                else if (hasSymbols(value))
                {
                    throw new StringInvalidoException("La localidad no puede contener símbolos.");
                }
                localidad = value;
            }
        }
        public string Direccion { get => direccion;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringInvalidoException("La direccion no puede ser vacío o espacios.");
                }
                else if (value.Any(char.IsDigit))
                {
                    throw new StringInvalidoException("La direccion no puede contener números.");
                }
                else if (hasSymbols(value))
                {
                    throw new StringInvalidoException("La direccion no puede contener símbolos.");
                }
                direccion = value;
            }
        }
        public string Email { get => email;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringInvalidoException("El email no puede ser vacío o espacios.");
                }
                else if (value.Any(char.IsDigit))
                {
                    throw new StringInvalidoException("El email no puede contener números.");
                }
                else if (!value.Contains("@"))
                {
                    throw new StringInvalidoException("El no contiene @. Es inválido.");
                }
                email = value; 
            }
        }
        public string Telefono { get => telefono;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new StringInvalidoException("El telefono no puede ser vacío o espacios.");
                }
                else if (value.Any(char.IsDigit))
                {
                    throw new StringInvalidoException("El telefono no puede contener números.");
                }
                else if (hasSymbols(value))
                {
                    throw new StringInvalidoException("El telefono no puede contener símbolos.");
                }
                telefono = value; 
            }
            }

        public override bool Equals(object obj)
        {
            return this.GetType() == obj.GetType();
        }
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.NroDocumento == p2.NroDocumento &&
                        p1.Equals(p2);
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }

        private bool hasSymbols(string cadena)
        {
            foreach(char a in cadena)
            {
                if (Char.IsSymbol(a))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
