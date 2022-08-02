
namespace BuenYantar
{
    partial class FormInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btInventario = new System.Windows.Forms.Button();
            this.btFactura = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.btReponer = new System.Windows.Forms.Button();
            this.btUsuarios = new System.Windows.Forms.Button();
            this.btHistorial = new System.Windows.Forms.Button();
            this.btConfiguracion = new System.Windows.Forms.Button();
            this.btCerrarSesion = new System.Windows.Forms.Button();
            this.btTodasFacturas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInventario
            // 
            this.btInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInventario.AutoSize = true;
            this.btInventario.BackColor = System.Drawing.Color.LemonChiffon;
            this.btInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInventario.Location = new System.Drawing.Point(23, 174);
            this.btInventario.Name = "btInventario";
            this.btInventario.Size = new System.Drawing.Size(321, 358);
            this.btInventario.TabIndex = 0;
            this.btInventario.Text = "Inventario";
            this.btInventario.UseVisualStyleBackColor = false;
            this.btInventario.Click += new System.EventHandler(this.btInventario_Click);
            // 
            // btFactura
            // 
            this.btFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btFactura.BackColor = System.Drawing.Color.MistyRose;
            this.btFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btFactura.Location = new System.Drawing.Point(404, 174);
            this.btFactura.Name = "btFactura";
            this.btFactura.Size = new System.Drawing.Size(429, 358);
            this.btFactura.TabIndex = 1;
            this.btFactura.Text = "Nueva factura";
            this.btFactura.UseVisualStyleBackColor = false;
            this.btFactura.Click += new System.EventHandler(this.btFactura_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(294, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sesión iniciada como:";
            // 
            // tbUser
            // 
            this.tbUser.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUser.Location = new System.Drawing.Point(577, 48);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(313, 38);
            this.tbUser.TabIndex = 3;
            // 
            // btReponer
            // 
            this.btReponer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReponer.BackColor = System.Drawing.Color.Moccasin;
            this.btReponer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReponer.Location = new System.Drawing.Point(664, 610);
            this.btReponer.Name = "btReponer";
            this.btReponer.Size = new System.Drawing.Size(169, 146);
            this.btReponer.TabIndex = 4;
            this.btReponer.Text = "Informe reponer";
            this.btReponer.UseVisualStyleBackColor = false;
            this.btReponer.Click += new System.EventHandler(this.btReponer_Click);
            // 
            // btUsuarios
            // 
            this.btUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUsuarios.Location = new System.Drawing.Point(449, 610);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(158, 146);
            this.btUsuarios.TabIndex = 5;
            this.btUsuarios.Text = "Usuarios";
            this.btUsuarios.UseVisualStyleBackColor = false;
            this.btUsuarios.Click += new System.EventHandler(this.btUsuarios_Click);
            // 
            // btHistorial
            // 
            this.btHistorial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btHistorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistorial.Location = new System.Drawing.Point(894, 174);
            this.btHistorial.Name = "btHistorial";
            this.btHistorial.Size = new System.Drawing.Size(348, 358);
            this.btHistorial.TabIndex = 6;
            this.btHistorial.Text = "Mis facturas";
            this.btHistorial.UseVisualStyleBackColor = false;
            this.btHistorial.Click += new System.EventHandler(this.btHistorial_Click);
            // 
            // btConfiguracion
            // 
            this.btConfiguracion.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btConfiguracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConfiguracion.Location = new System.Drawing.Point(881, 610);
            this.btConfiguracion.Name = "btConfiguracion";
            this.btConfiguracion.Size = new System.Drawing.Size(166, 146);
            this.btConfiguracion.TabIndex = 7;
            this.btConfiguracion.Text = "Config de usuario";
            this.btConfiguracion.UseVisualStyleBackColor = false;
            this.btConfiguracion.Click += new System.EventHandler(this.btConfiguracion_Click);
            // 
            // btCerrarSesion
            // 
            this.btCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btCerrarSesion.DialogResult = System.Windows.Forms.DialogResult.Retry;
            this.btCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrarSesion.Location = new System.Drawing.Point(1122, 646);
            this.btCerrarSesion.Name = "btCerrarSesion";
            this.btCerrarSesion.Size = new System.Drawing.Size(131, 129);
            this.btCerrarSesion.TabIndex = 9;
            this.btCerrarSesion.Text = "Cerrar sesión";
            this.btCerrarSesion.UseVisualStyleBackColor = false;
            this.btCerrarSesion.Click += new System.EventHandler(this.btCerrarSesion_Click);
            // 
            // btTodasFacturas
            // 
            this.btTodasFacturas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTodasFacturas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(255)))));
            this.btTodasFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTodasFacturas.Location = new System.Drawing.Point(215, 610);
            this.btTodasFacturas.Name = "btTodasFacturas";
            this.btTodasFacturas.Size = new System.Drawing.Size(156, 146);
            this.btTodasFacturas.TabIndex = 8;
            this.btTodasFacturas.Text = "Todas las facturas";
            this.btTodasFacturas.UseVisualStyleBackColor = false;
            this.btTodasFacturas.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1265, 787);
            this.Controls.Add(this.btCerrarSesion);
            this.Controls.Add(this.btTodasFacturas);
            this.Controls.Add(this.btConfiguracion);
            this.Controls.Add(this.btHistorial);
            this.Controls.Add(this.btUsuarios);
            this.Controls.Add(this.btReponer);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFactura);
            this.Controls.Add(this.btInventario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.Text = "Gestor Buen Yantar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btInventario;
        private System.Windows.Forms.Button btFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btReponer;
        private System.Windows.Forms.Button btUsuarios;
        private System.Windows.Forms.Button btHistorial;
        private System.Windows.Forms.Button btConfiguracion;
        private System.Windows.Forms.Button btCerrarSesion;
        private System.Windows.Forms.Button btTodasFacturas;
    }
}

