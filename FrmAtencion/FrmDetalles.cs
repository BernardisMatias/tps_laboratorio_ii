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
    public partial class FrmDetalles<T> : Form
    {
        public FrmDetalles()
        {
            InitializeComponent();
        }

        private void FrmVehiculos_Load(object sender, EventArgs e)
        {
            armarMenu();
        }

        private void btnNuevoVehiculo_Click(object sender, EventArgs e)
        {
            FormAlta<T> formAlta = new FormAlta<T>();
            formAlta.ShowDialog();
        }

        private void btnListaVehiculos_Click(object sender, EventArgs e)
        {
            FormListar<T> formListar = new FormListar<T>();
            formListar.ShowDialog();
        }

        private void armarMenu()
        {
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLista.Location = new System.Drawing.Point(522, 123);
            this.btnLista.Name = "btnLista";
            this.btnLista.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnLista.Size = new System.Drawing.Size(294, 63);
            this.btnLista.TabIndex = 16;
            this.btnLista.Text = "Lista de "+typeof(T).Name;
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLista.UseVisualStyleBackColor = false;

            this.btnAlta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlta.Location = new System.Drawing.Point(522, 177);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAlta.Size = new System.Drawing.Size(294, 63);
            this.btnAlta.TabIndex = 16;
            this.btnAlta.Text = "Alta de " + typeof(T).Name;
            this.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlta.UseVisualStyleBackColor = false;

            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(522, 234);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnModificar.Size = new System.Drawing.Size(294, 63);
            this.btnModificar.TabIndex = 16;
            this.btnModificar.Text = "Modificar " + typeof(T).Name;
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;

            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(522, 288);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnBorrar.Size = new System.Drawing.Size(294, 63);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Baja de "+typeof(T).Name;
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
        }
    }
}
