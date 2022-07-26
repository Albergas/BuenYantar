
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
            this.btModificarInventario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btInventario
            // 
            this.btInventario.BackColor = System.Drawing.Color.LemonChiffon;
            this.btInventario.Location = new System.Drawing.Point(60, 66);
            this.btInventario.Name = "btInventario";
            this.btInventario.Size = new System.Drawing.Size(75, 66);
            this.btInventario.TabIndex = 0;
            this.btInventario.Text = "Ver inventario";
            this.btInventario.UseVisualStyleBackColor = false;
            // 
            // btFactura
            // 
            this.btFactura.BackColor = System.Drawing.Color.MistyRose;
            this.btFactura.Location = new System.Drawing.Point(218, 109);
            this.btFactura.Name = "btFactura";
            this.btFactura.Size = new System.Drawing.Size(75, 66);
            this.btFactura.TabIndex = 1;
            this.btFactura.Text = "Nueva factura";
            this.btFactura.UseVisualStyleBackColor = false;
            // 
            // btModificarInventario
            // 
            this.btModificarInventario.BackColor = System.Drawing.Color.Bisque;
            this.btModificarInventario.Location = new System.Drawing.Point(60, 154);
            this.btModificarInventario.Name = "btModificarInventario";
            this.btModificarInventario.Size = new System.Drawing.Size(75, 66);
            this.btModificarInventario.TabIndex = 2;
            this.btModificarInventario.Text = "Modificar inventario";
            this.btModificarInventario.UseVisualStyleBackColor = false;
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 295);
            this.Controls.Add(this.btModificarInventario);
            this.Controls.Add(this.btFactura);
            this.Controls.Add(this.btInventario);
            this.Name = "FormInicio";
            this.Text = "Gestor Buen Yantar";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btInventario;
        private System.Windows.Forms.Button btFactura;
        private System.Windows.Forms.Button btModificarInventario;
    }
}

