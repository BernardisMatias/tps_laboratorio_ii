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
    public partial class FormAlta<T> : Form
    {
        public FormAlta()
        {
            InitializeComponent();
        }

        private void FormAlta_Load(object sender, EventArgs e)
        {
            Label label = new Label();
            label.Text = "Alta de " + typeof(T).Name;
            label.Location = new Point(20, 10);
            this.Controls.Add(label);
            generarAltaDinamica();
        }

        private void generarAltaDinamica()
        {
            int i = 20;
            foreach (var prop in typeof(T).GetProperties())
            {
                Label label = new Label();
                TextBox tb = new TextBox();
                label.Name = prop.Name;
                label.Text = prop.Name + ":";
                label.Location = new Point(50, i);
                tb.Location = new Point(200, i);
                i += 20;
                this.Controls.Add(label);
                this.Controls.Add(tb);
            }
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if(typeof(T) is Persona)
            {

            }

        }
        private void altaGenerica()
        {
            try {
                foreach (var prop in typeof(T).GetProperties())
                {
                    Label label = new Label();
                    TextBox tb = new TextBox();
                    label.Name = prop.Name;
                    label.Text = prop.Name + ":";
                }
            }
            catch (Exception e)
            {
                
            }
        }
    }
}
