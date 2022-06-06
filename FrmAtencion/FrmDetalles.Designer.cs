namespace FrmAtencion
{
    partial class FrmDetalles<T>
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnAlta = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(55, 417);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 63);
            this.button1.TabIndex = 17;
            this.button1.Text = "Atras";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnLista.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLista.Location = new System.Drawing.Point(522, 123);
            this.btnLista.Name = "btnLista";
            this.btnLista.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnLista.Size = new System.Drawing.Size(294, 59);
            this.btnLista.TabIndex = 13;
            this.btnLista.Text = "Listar";
            this.btnLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnListaVehiculos_Click);
            // 
            // btnAlta
            // 
            this.btnAlta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnAlta.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAlta.Location = new System.Drawing.Point(522, 177);
            this.btnAlta.Name = "btnAlta";
            this.btnAlta.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnAlta.Size = new System.Drawing.Size(294, 61);
            this.btnAlta.TabIndex = 14;
            this.btnAlta.Text = "Alta";
            this.btnAlta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAlta.UseVisualStyleBackColor = false;
            this.btnAlta.Click += new System.EventHandler(this.btnNuevoVehiculo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnModificar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnModificar.Location = new System.Drawing.Point(522, 234);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnModificar.Size = new System.Drawing.Size(294, 61);
            this.btnModificar.TabIndex = 15;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnBorrar
            // 
            this.btnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBorrar.Location = new System.Drawing.Point(522, 291);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnBorrar.Size = new System.Drawing.Size(294, 63);
            this.btnBorrar.TabIndex = 16;
            this.btnBorrar.Text = "Baja";
            this.btnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrar.UseVisualStyleBackColor = false;
            // 
            // FrmDetalles
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(174)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(856, 521);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAlta);
            this.Controls.Add(this.btnLista);
            this.DoubleBuffered = true;
            this.Name = "FrmDetalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.FrmVehiculos_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnAlta;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnBorrar;
    }
}
