namespace FrmAtencion
{
    partial class FrmVehiculos<T>
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // FrmVehiculos
            // 
            this.ClientSize = new System.Drawing.Size(642, 491);
            this.Name = "FrmVehiculos";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnHistorialReservas;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button button1;
    }
}
