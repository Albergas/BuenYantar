
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
            this.btQuitar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lbAvisos2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbFamilia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbInventario
            // 
            this.lbInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventario.FormattingEnabled = true;
            this.lbInventario.ItemHeight = 25;
            this.lbInventario.Location = new System.Drawing.Point(13, 40);
            this.lbInventario.Name = "lbInventario";
            this.lbInventario.Size = new System.Drawing.Size(270, 454);
            this.lbInventario.TabIndex = 0;
            this.lbInventario.SelectedIndexChanged += new System.EventHandler(this.lbInventario_SelectedIndexChanged);
            // 
            // lbFactura
            // 
            this.lbFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFactura.FormattingEnabled = true;
            this.lbFactura.ItemHeight = 25;
            this.lbFactura.Location = new System.Drawing.Point(546, 40);
            this.lbFactura.Name = "lbFactura";
            this.lbFactura.Size = new System.Drawing.Size(336, 454);
            this.lbFactura.TabIndex = 1;
            this.lbFactura.SelectedIndexChanged += new System.EventHandler(this.lbFactura_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selecciona producto";
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(-283, 525);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(81, 29);
            this.lb2.TabIndex = 5;
            this.lb2.Text = "Filtrar:";
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltrar.Location = new System.Drawing.Point(99, 505);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(198, 29);
            this.tbFiltrar.TabIndex = 4;
            this.tbFiltrar.TextChanged += new System.EventHandler(this.tbFiltrar_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(235, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Contenido de la factura";
            // 
            // tbProducto
            // 
            this.tbProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProducto.Location = new System.Drawing.Point(289, 158);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.ReadOnly = true;
            this.tbProducto.Size = new System.Drawing.Size(251, 29);
            this.tbProducto.TabIndex = 7;
            // 
            // tbCantidad
            // 
            this.tbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCantidad.Location = new System.Drawing.Point(289, 303);
            this.tbCantidad.Name = "tbCantidad";
            this.tbCantidad.Size = new System.Drawing.Size(251, 29);
            this.tbCantidad.TabIndex = 8;
            this.tbCantidad.TextChanged += new System.EventHandler(this.tbCantidad_TextChanged);
            // 
            // lbProducto
            // 
            this.lbProducto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.Location = new System.Drawing.Point(284, 126);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(158, 24);
            this.lbProducto.TabIndex = 9;
            this.lbProducto.Text = "Producto a añadir";
            // 
            // lbCantidad
            // 
            this.lbCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.Location = new System.Drawing.Point(284, 271);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(90, 24);
            this.lbCantidad.TabIndex = 10;
            this.lbCantidad.Text = "Unidades";
            // 
            // lbPrecio
            // 
            this.lbPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPrecio.AutoSize = true;
            this.lbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecio.Location = new System.Drawing.Point(284, 200);
            this.lbPrecio.Name = "lbPrecio";
            this.lbPrecio.Size = new System.Drawing.Size(160, 24);
            this.lbPrecio.TabIndex = 12;
            this.lbPrecio.Text = "Precio por unidad";
            // 
            // tbPrecio
            // 
            this.tbPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(289, 233);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.ReadOnly = true;
            this.tbPrecio.Size = new System.Drawing.Size(251, 29);
            this.tbPrecio.TabIndex = 11;
            // 
            // btAniadir
            // 
            this.btAniadir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAniadir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.btAniadir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAniadir.Location = new System.Drawing.Point(348, 355);
            this.btAniadir.Name = "btAniadir";
            this.btAniadir.Size = new System.Drawing.Size(135, 98);
            this.btAniadir.TabIndex = 13;
            this.btAniadir.Text = "Añadir a la factura";
            this.btAniadir.UseVisualStyleBackColor = false;
            this.btAniadir.Click += new System.EventHandler(this.btAniadir_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.btAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAceptar.Location = new System.Drawing.Point(697, 552);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(185, 102);
            this.btAceptar.TabIndex = 14;
            this.btAceptar.Text = "ACEPTAR";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotal.Location = new System.Drawing.Point(662, 506);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(214, 31);
            this.tbTotal.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(565, 509);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Importe:";
            // 
            // btReset
            // 
            this.btReset.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btReset.Location = new System.Drawing.Point(578, 552);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(85, 66);
            this.btReset.TabIndex = 17;
            this.btReset.Text = "RESET";
            this.btReset.UseVisualStyleBackColor = false;
            this.btReset.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lbAvisos
            // 
            this.lbAvisos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAvisos.AutoSize = true;
            this.lbAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAvisos.Location = new System.Drawing.Point(-261, 587);
            this.lbAvisos.Name = "lbAvisos";
            this.lbAvisos.Size = new System.Drawing.Size(0, 25);
            this.lbAvisos.TabIndex = 18;
            // 
            // btQuitar
            // 
            this.btQuitar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btQuitar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.btQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btQuitar.Location = new System.Drawing.Point(454, 555);
            this.btQuitar.Name = "btQuitar";
            this.btQuitar.Size = new System.Drawing.Size(118, 63);
            this.btQuitar.TabIndex = 19;
            this.btQuitar.Text = "Quitar de la factura";
            this.btQuitar.UseVisualStyleBackColor = false;
            this.btQuitar.Click += new System.EventHandler(this.btQuitar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 506);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nombre:";
            // 
            // lbAvisos2
            // 
            this.lbAvisos2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAvisos2.AutoSize = true;
            this.lbAvisos2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvisos2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAvisos2.Location = new System.Drawing.Point(23, 596);
            this.lbAvisos2.Name = "lbAvisos2";
            this.lbAvisos2.Size = new System.Drawing.Size(0, 20);
            this.lbAvisos2.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Familia:";
            // 
            // tbFamilia
            // 
            this.tbFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFamilia.Location = new System.Drawing.Point(99, 540);
            this.tbFamilia.Name = "tbFamilia";
            this.tbFamilia.Size = new System.Drawing.Size(198, 29);
            this.tbFamilia.TabIndex = 22;
            this.tbFamilia.TextChanged += new System.EventHandler(this.tbFamilia_TextChanged);
            // 
            // NuevaFactura
            // 
            this.AcceptButton = this.btAniadir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 670);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbFamilia);
            this.Controls.Add(this.lbAvisos2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btQuitar);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
        private System.Windows.Forms.Button btQuitar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbAvisos2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbFamilia;
    }
}