using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmAtencion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {

        }
        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            FrmVehiculos<string> formVehiculos = new FrmVehiculos<string>();
            formVehiculos.ShowDialog();
        }

    }
}
