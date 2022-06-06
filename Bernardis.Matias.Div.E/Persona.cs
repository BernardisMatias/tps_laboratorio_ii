using System;

namespace Bernardis.Matias.Div.E
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

        public string Nombre { get => nombre;}
        public string Apellido { get => apellido;}
        public string NroDocumento { get => nroDocumento;}
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public DateTime FechaAlta { get => fechaAlta; set => fechaAlta = value; }
        public ESexo Sexo { get => sexo; set => sexo = value; }
        public string Pais { get => pais; set => pais = value; }
        public string Localidad { get => localidad; set => localidad = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Email { get => email; set => email = value; }
        public string Telefono { get => telefono; set => telefono = value; }

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
    }
}
