using System;
using System.Text;

namespace Entidades
{
    public abstract class Vehiculo
    {
        public enum EColor { Rojo, Azul, Blanco, Gris, Negro, Verde, Naranja, Turquesa}

        protected string patente;
        protected string marca;
        protected string modelo;
        protected EColor color;
        private bool estaAlquilado;
        private bool pendienteReparacion;

        public string Patente { get => patente;}
        public string Marca { get => marca;}
        public string Modelo { get => modelo;}
        public EColor Color { get => color; set => color = value; }

        public string EstaAlquilado
        {
            get
            {
                return this.estaAlquilado ? "Alquilado" : "Disponible";
            }
        }

        public Vehiculo(string patente, string marca, string modelo, EColor color) : this(patente, marca, modelo, color, false, false) { }
        protected Vehiculo(string patente, string marca, string modelo, EColor color, bool estaAlquilado, bool pendienteReparacion)
        {
            this.patente = patente;
            this.marca = marca;
            this.modelo = modelo;
            this.Color = color;
            this.estaAlquilado = estaAlquilado;
            this.pendienteReparacion = pendienteReparacion;
        }

        public bool Equals(Vehiculo vehiculo1, Vehiculo vehiculo2)
        {
            return vehiculo1.GetType() == vehiculo2.GetType() 
                        && vehiculo1.patente == vehiculo2.patente;
        }

        public abstract string ComprobanteAlquiler();

        public static void AlquilarVehiculo(Vehiculo vehiculo)
        {
            vehiculo.estaAlquilado = true;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Patente: ");
            sb.AppendLine(this.patente);
            sb.AppendLine(" - Marca:");
            sb.AppendLine(this.marca);
            sb.AppendLine("Estado:");
            sb.AppendLine(this.EstaAlquilado);
            return sb.ToString();
        }
    }
}
