using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace FrmAtencion
{
    public partial class FrmPrincipal : Form
    {
        List<Reserva> listaReservas = new List<Reserva>();
        List<Vehiculo> listaVehiculos = new List<Vehiculo>();
        List<Sucursal> listaSucursales = new List<Sucursal>();
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            Reserva reserva = new Reserva();
            FormAlta<Reserva> formReserva = new FormAlta<Reserva>();
            formReserva.ShowDialog();
        }
        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FrmDetalles<Vehiculo> formVehiculos = new FrmDetalles<Vehiculo>();
            formVehiculos.ShowDialog();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            FrmDetalles<Empleado> formEmpleados = new FrmDetalles<Empleado>();
            formEmpleados.ShowDialog();
        }

        private void btnSucursales_Click(object sender, EventArgs e)
        {
            FrmDetalles<Sucursal> formSucursales = new FrmDetalles<Sucursal>();
            formSucursales.ShowDialog();
        }
    }
}
