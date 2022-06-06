namespace FrmAtencion
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.btnNuevaReserva = new System.Windows.Forms.Button();
            this.btnImportarInfo = new System.Windows.Forms.Button();
            this.btnExportarInfo = new System.Windows.Forms.Button();
            this.picPpal = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picLogout = new System.Windows.Forms.PictureBox();
            this.lblTittle = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.btnHistorialReservas = new System.Windows.Forms.Button();
            this.btnSucursales = new System.Windows.Forms.Button();
            this.btnEmpleados = new System.Windows.Forms.Button();
            this.btnVehiculos = new System.Windows.Forms.Button();
            this.picUser = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picPpal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNuevaReserva
            // 
            this.btnNuevaReserva.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNuevaReserva.Location = new System.Drawing.Point(413, 478);
            this.btnNuevaReserva.Name = "btnNuevaReserva";
            this.btnNuevaReserva.Size = new System.Drawing.Size(339, 109);
            this.btnNuevaReserva.TabIndex = 0;
            this.btnNuevaReserva.Text = "Nueva reserva";
            this.btnNuevaReserva.UseVisualStyleBackColor = true;
            this.btnNuevaReserva.Click += new System.EventHandler(this.btnNuevaReserva_Click);
            // 
            // btnImportarInfo
            // 
            this.btnImportarInfo.Location = new System.Drawing.Point(42, 463);
            this.btnImportarInfo.Name = "btnImportarInfo";
            this.btnImportarInfo.Size = new System.Drawing.Size(147, 41);
            this.btnImportarInfo.TabIndex = 3;
            this.btnImportarInfo.Text = "Importar informacion";
            this.btnImportarInfo.UseVisualStyleBackColor = true;
            // 
            // btnExportarInfo
            // 
            this.btnExportarInfo.Location = new System.Drawing.Point(42, 510);
            this.btnExportarInfo.Name = "btnExportarInfo";
            this.btnExportarInfo.Size = new System.Drawing.Size(147, 41);
            this.btnExportarInfo.TabIndex = 4;
            this.btnExportarInfo.Text = "Exportar datos";
            this.btnExportarInfo.UseVisualStyleBackColor = true;
            // 
            // picPpal
            // 
            this.picPpal.Image = ((System.Drawing.Image)(resources.GetObject("picPpal.Image")));
            this.picPpal.ImageLocation = "";
            this.picPpal.Location = new System.Drawing.Point(388, 96);
            this.picPpal.Name = "picPpal";
            this.picPpal.Size = new System.Drawing.Size(384, 361);
            this.picPpal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picPpal.TabIndex = 5;
            this.picPpal.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(57)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.picLogout);
            this.panel1.Controls.Add(this.lblTittle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 54);
            this.panel1.TabIndex = 6;
            // 
            // picLogout
            // 
            this.picLogout.Image = ((System.Drawing.Image)(resources.GetObject("picLogout.Image")));
            this.picLogout.Location = new System.Drawing.Point(868, 12);
            this.picLogout.Name = "picLogout";
            this.picLogout.Size = new System.Drawing.Size(32, 32);
            this.picLogout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogout.TabIndex = 2;
            this.picLogout.TabStop = false;
            // 
            // lblTittle
            // 
            this.lblTittle.AutoSize = true;
            this.lblTittle.Font = new System.Drawing.Font("Lucida Sans Unicode", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTittle.ForeColor = System.Drawing.Color.SeaShell;
            this.lblTittle.Location = new System.Drawing.Point(12, 9);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(275, 34);
            this.lblTittle.TabIndex = 1;
            this.lblTittle.Text = "FLASH AUTO RENT";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(18)))), ((int)(((byte)(102)))));
            this.panel2.Controls.Add(this.lblUsuario);
            this.panel2.Controls.Add(this.btnHistorialReservas);
            this.panel2.Controls.Add(this.btnSucursales);
            this.panel2.Controls.Add(this.btnEmpleados);
            this.panel2.Controls.Add(this.btnExportarInfo);
            this.panel2.Controls.Add(this.btnVehiculos);
            this.panel2.Controls.Add(this.btnImportarInfo);
            this.panel2.Controls.Add(this.picUser);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 596);
            this.panel2.TabIndex = 7;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblUsuario.Location = new System.Drawing.Point(83, 163);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(69, 21);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // btnHistorialReservas
            // 
            this.btnHistorialReservas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnHistorialReservas.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnHistorialReservas.Image = ((System.Drawing.Image)(resources.GetObject("btnHistorialReservas.Image")));
            this.btnHistorialReservas.Location = new System.Drawing.Point(0, 377);
            this.btnHistorialReservas.Name = "btnHistorialReservas";
            this.btnHistorialReservas.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnHistorialReservas.Size = new System.Drawing.Size(232, 48);
            this.btnHistorialReservas.TabIndex = 12;
            this.btnHistorialReservas.Text = "Historial Reservas";
            this.btnHistorialReservas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHistorialReservas.UseVisualStyleBackColor = false;
            // 
            // btnSucursales
            // 
            this.btnSucursales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnSucursales.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSucursales.Image = ((System.Drawing.Image)(resources.GetObject("btnSucursales.Image")));
            this.btnSucursales.Location = new System.Drawing.Point(0, 323);
            this.btnSucursales.Name = "btnSucursales";
            this.btnSucursales.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnSucursales.Size = new System.Drawing.Size(232, 48);
            this.btnSucursales.TabIndex = 11;
            this.btnSucursales.Text = "Sucursales";
            this.btnSucursales.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSucursales.UseVisualStyleBackColor = false;
            this.btnSucursales.Click += new System.EventHandler(this.btnSucursales_Click);
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnEmpleados.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnEmpleados.Image = ((System.Drawing.Image)(resources.GetObject("btnEmpleados.Image")));
            this.btnEmpleados.Location = new System.Drawing.Point(0, 269);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnEmpleados.Size = new System.Drawing.Size(232, 48);
            this.btnEmpleados.TabIndex = 10;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // btnVehiculos
            // 
            this.btnVehiculos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(180)))), ((int)(((byte)(140)))));
            this.btnVehiculos.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnVehiculos.Image = ((System.Drawing.Image)(resources.GetObject("btnVehiculos.Image")));
            this.btnVehiculos.Location = new System.Drawing.Point(0, 215);
            this.btnVehiculos.Name = "btnVehiculos";
            this.btnVehiculos.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            this.btnVehiculos.Size = new System.Drawing.Size(232, 48);
            this.btnVehiculos.TabIndex = 9;
            this.btnVehiculos.Text = "Vehiculos";
            this.btnVehiculos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVehiculos.UseVisualStyleBackColor = false;
            this.btnVehiculos.Click += new System.EventHandler(this.btnVehiculos_Click);
            // 
            // picUser
            // 
            this.picUser.Image = ((System.Drawing.Image)(resources.GetObject("picUser.Image")));
            this.picUser.Location = new System.Drawing.Point(51, 32);
            this.picUser.Name = "picUser";
            this.picUser.Size = new System.Drawing.Size(128, 128);
            this.picUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picUser.TabIndex = 0;
            this.picUser.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(216)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(912, 650);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.picPpal);
            this.Controls.Add(this.btnNuevaReserva);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bernardis.Matias.Div2.E";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picPpal)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNuevaReserva;
        private System.Windows.Forms.Button btnImportarInfo;
        private System.Windows.Forms.Button btnExportarInfo;
        private System.Windows.Forms.PictureBox picPpal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTittle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picUser;
        private System.Windows.Forms.Button btnVehiculos;
        private System.Windows.Forms.Button btnHistorialReservas;
        private System.Windows.Forms.Button btnSucursales;
        private System.Windows.Forms.Button btnEmpleados;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picLogout;
    }
}