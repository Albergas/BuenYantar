﻿
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
            this.SuspendLayout();
            // 
            // btInventario
            // 
            this.btInventario.BackColor = System.Drawing.Color.LemonChiffon;
            this.btInventario.Location = new System.Drawing.Point(24, 59);
            this.btInventario.Name = "btInventario";
            this.btInventario.Size = new System.Drawing.Size(75, 66);
            this.btInventario.TabIndex = 0;
            this.btInventario.Text = "Inventario";
            this.btInventario.UseVisualStyleBackColor = false;
            this.btInventario.Click += new System.EventHandler(this.btInventario_Click);
            // 
            // btFactura
            // 
            this.btFactura.BackColor = System.Drawing.Color.MistyRose;
            this.btFactura.Location = new System.Drawing.Point(146, 59);
            this.btFactura.Name = "btFactura";
            this.btFactura.Size = new System.Drawing.Size(75, 66);
            this.btFactura.TabIndex = 1;
            this.btFactura.Text = "Nueva factura";
            this.btFactura.UseVisualStyleBackColor = false;
            this.btFactura.Click += new System.EventHandler(this.btFactura_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sesión iniciada como:";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(137, 17);
            this.tbUser.Name = "tbUser";
            this.tbUser.ReadOnly = true;
            this.tbUser.Size = new System.Drawing.Size(200, 20);
            this.tbUser.TabIndex = 3;
            // 
            // btReponer
            // 
            this.btReponer.BackColor = System.Drawing.Color.Moccasin;
            this.btReponer.Location = new System.Drawing.Point(146, 152);
            this.btReponer.Name = "btReponer";
            this.btReponer.Size = new System.Drawing.Size(75, 66);
            this.btReponer.TabIndex = 4;
            this.btReponer.Text = "Informe reponer";
            this.btReponer.UseVisualStyleBackColor = false;
            // 
            // btUsuarios
            // 
            this.btUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btUsuarios.Location = new System.Drawing.Point(24, 152);
            this.btUsuarios.Name = "btUsuarios";
            this.btUsuarios.Size = new System.Drawing.Size(75, 66);
            this.btUsuarios.TabIndex = 5;
            this.btUsuarios.Text = "Usuarios";
            this.btUsuarios.UseVisualStyleBackColor = false;
            // 
            // btHistorial
            // 
            this.btHistorial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(255)))));
            this.btHistorial.Location = new System.Drawing.Point(262, 59);
            this.btHistorial.Name = "btHistorial";
            this.btHistorial.Size = new System.Drawing.Size(75, 66);
            this.btHistorial.TabIndex = 6;
            this.btHistorial.Text = "Historial de mis facturas";
            this.btHistorial.UseVisualStyleBackColor = false;
            this.btHistorial.Click += new System.EventHandler(this.btHistorial_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 245);
            this.Controls.Add(this.btHistorial);
            this.Controls.Add(this.btUsuarios);
            this.Controls.Add(this.btReponer);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btFactura);
            this.Controls.Add(this.btInventario);
            this.Name = "FormInicio";
            this.Text = "Gestor Buen Yantar";
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
    }
}

