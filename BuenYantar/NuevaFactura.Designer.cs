
namespace BuenYantar
{
    partial class NuevaFactura
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
            this.lbInventario = new System.Windows.Forms.ListBox();
            this.lbFactura = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb2 = new System.Windows.Forms.Label();
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbProducto = new System.Windows.Forms.TextBox();
            this.tbCantidad = new System.Windows.Forms.TextBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.lbPrecio = new System.Windows.Forms.Label();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.btAniadir = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btReset = new System.Windows.Forms.Button();
            this.lbAvisos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbInventario
            // 
            this.lbInventario.FormattingEnabled = true;
            this.lbInventario.Location = new System.Drawing.Point(30, 37);
            this.lbInventario.Name = "lbInventario";
            this.lbInventario.Size = new System.Drawing.Size(194, 303);
            this.lbInventario.TabIndex = 0;
            this.lbInventario.SelectedIndexChanged += new System.EventHandler(this.lbInventario_SelectedIndexChanged);
            // 
            // lbFactura
            // 
            this.lbFactura.FormattingEnabled = true;
            this.lbFactura.Location = new System.Drawing.Point(455, 37);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(212, 251);
            this.lbFactura.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona producto";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(27, 349);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(35, 13);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Filtrar:";
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Location = new System.Drawing.Point(68, 346);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(156, 20);
            this.tbFiltrar.TabIndex = 4;
            this.tbFiltrar.TextChanged += new System.EventHandler(this.tbFiltrar_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(452, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contenido de la factura";
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(245, 78);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.ReadOnly = true;
            this.tbProducto.Size = new System.Drawing.Size(167, 20);
            this.tbProducto.TabIndex = 7;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Location = new System.Drawing.Point(245, 188);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(167, 20);
            this.tbCantidad.TabIndex = 8;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Location = new System.Drawing.Point(242, 62);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(147, 13);
            this.lbProducto.TabIndex = 9;
            this.lbProducto.Text = "Producto a añadir a la factura";
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Location = new System.Drawing.Point(242, 172);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(52, 13);
            this.lbCantidad.TabIndex = 10;
            this.lbCantidad.Text = "Unidades";
            // 
            // lbPrecio
            // 
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Location = new System.Drawing.Point(242, 117);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(90, 13);
            this.lbPrecio.TabIndex = 12;
            this.lbPrecio.Text = "Precio por unidad";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(245, 133);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(167, 20);
            this.tbPrecio.TabIndex = 11;
            // 
            // btAniadir
            // 
            this.btAniadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.btAniadir.Location = new System.Drawing.Point(337, 229);
            this.btAniadir.Name = "btAniadir";
            this.btAniadir.Size = new System.Drawing.Size(75, 42);
            this.btAniadir.TabIndex = 13;
            this.btAniadir.Text = "Añadir a la factura";
            this.btAniadir.UseVisualStyleBackColor = false;
            this.btAniadir.Click += new System.EventHandler(this.btAniadir_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.btAceptar.Location = new System.Drawing.Point(592, 394);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 67);
            this.btAceptar.TabIndex = 14;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(521, 294);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(146, 20);
            this.tbTotal.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(452, 297);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Precio total:";
            // 
            // btReset
            // 
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btReset.Location = new System.Drawing.Point(494, 394);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(75, 67);
            this.btReset.TabIndex = 17;
            this.btReset.Text = "RESET";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbAvisos
            // 
            this.lbAvisos.AutoSize = true;
            this.lbAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAvisos.Location = new System.Drawing.Point(258, 349);
            this.lbAvisos.Name = "lbAvisos";
            this.lbAvisos.Size = new System.Drawing.Size(0, 13);
            this.lbAvisos.TabIndex = 18;
            // 
            // NuevaFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 473);
            this.Controls.Add(this.lbAvisos);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.btAniadir);
            this.Controls.Add(this.lbPrecio);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.tbCantidad);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tbFiltrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbFactura);
            this.Controls.Add(this.lbInventario);
            this.Name = "NuevaFactura";
            this.Text = "NuevaFactura";
            this.Load += new System.EventHandler(this.NuevaFactura_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbInventario;
        private System.Windows.Forms.ListBox lbFactura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.TextBox tbFiltrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbProducto;
        private System.Windows.Forms.TextBox tbCantidad;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Label lbPrecio;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Button btAniadir;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btReset;
        private System.Windows.Forms.Label lbAvisos;
    }
}