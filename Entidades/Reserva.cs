using System;

namespace Entidades
{
    public class Reserva
    {
        private string codigoReserva;
        private DateTime fechaSalida;
        private DateTime fechaDevolucion;
        private double precioFinal;
        private Cliente cliente;
        private Empleado empleadoGestor;
        private Vehiculo vehiculo;
        private bool devueltoOk;
        private string estado;

        public Reserva() { }

        public Reserva(string codigoReserva, DateTime fechaSalida, DateTime fechaDevolucion, double precioFinal, Cliente cliente, Empleado empleadoGestor, Vehiculo vehiculo, bool devueltoOk, string estado)
        {
            this.codigoReserva = codigoReserva;
            this.fechaSalida = fechaSalida;
            this.fechaDevolucion = fechaDevolucion;
            this.precioFinal = precioFinal;
            this.cliente = cliente;
            this.empleadoGestor = empleadoGestor;
            this.vehiculo = vehiculo;
            this.devueltoOk = devueltoOk;
            this.estado = estado;
        }

        public DateTime FechaSalida { get => fechaSalida; set => fechaSalida = value; }
        public DateTime FechaDevolucion { get => fechaDevolucion; set => fechaDevolucion = value; }
        public Vehiculo Vehiculo { get => vehiculo; set => vehiculo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public Empleado EmpleadoGestor { get => empleadoGestor; set => empleadoGestor = value; }
    }
}
