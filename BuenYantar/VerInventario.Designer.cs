
namespace BuenYantar
{
    partial class VerInventario
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
            this.tbFiltrar = new System.Windows.Forms.TextBox();
            this.lb2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.tbStockSeguridad = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.lbAvisoReponer = new System.Windows.Forms.Label();
            this.btStockBajo = new System.Windows.Forms.Button();
            this.btTodos = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.btNuevo = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btGuardarNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInventario
            // 
            this.lbInventario.FormattingEnabled = true;
            this.lbInventario.Location = new System.Drawing.Point(12, 12);
            this.lbInventario.Name = "lbInventario";
            this.lbInventario.Size = new System.Drawing.Size(212, 368);
            this.lbInventario.TabIndex = 0;
            this.lbInventario.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Location = new System.Drawing.Point(68, 390);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(156, 20);
            this.tbFiltrar.TabIndex = 1;
            this.tbFiltrar.TextChanged += new System.EventHandler(this.tbFiltrar_TextChanged);
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new System.Drawing.Point(27, 393);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(35, 13);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Filtrar:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(304, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock de seguridad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(285, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio/ud:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(348, 55);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(174, 20);
            this.tbNombre.TabIndex = 8;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(348, 90);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(174, 20);
            this.tbStock.TabIndex = 9;
            this.tbStock.TextChanged += new System.EventHandler(this.tbStock_TextChanged);
            // 
            // tbStockSeguridad
            // 
            this.tbStockSeguridad.Location = new System.Drawing.Point(348, 123);
            this.tbStockSeguridad.Name = "tbStockSeguridad";
            this.tbStockSeguridad.Size = new System.Drawing.Size(174, 20);
            this.tbStockSeguridad.TabIndex = 10;
            this.tbStockSeguridad.TextChanged += new System.EventHandler(this.tbStockSeguridad_TextChanged);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(348, 154);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(174, 20);
            this.tbPrecio.TabIndex = 11;
            this.tbPrecio.TextChanged += new System.EventHandler(this.tbPrecio_TextChanged);
            // 
            // lbAvisoReponer
            // 
            this.lbAvisoReponer.AutoSize = true;
            this.lbAvisoReponer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvisoReponer.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAvisoReponer.Location = new System.Drawing.Point(305, 195);
            this.lbAvisoReponer.Name = "lbAvisoReponer";
            this.lbAvisoReponer.Size = new System.Drawing.Size(217, 13);
            this.lbAvisoReponer.TabIndex = 12;
            this.lbAvisoReponer.Text = "¡Aviso! Stock inferior al de seguridad";
            // 
            // btStockBajo
            // 
            this.btStockBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btStockBajo.Location = new System.Drawing.Point(68, 416);
            this.btStockBajo.Name = "btStockBajo";
            this.btStockBajo.Size = new System.Drawing.Size(75, 29);
            this.btStockBajo.TabIndex = 13;
            this.btStockBajo.Text = "Stock bajo";
            this.btStockBajo.UseVisualStyleBackColor = false;
            this.btStockBajo.Click += new System.EventHandler(this.btStockBajo_Click);
            // 
            // btTodos
            // 
            this.btTodos.BackColor = System.Drawing.Color.LightBlue;
            this.btTodos.Location = new System.Drawing.Point(149, 416);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(75, 29);
            this.btTodos.TabIndex = 14;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = false;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btModificar
            // 
            this.btModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btModificar.Location = new System.Drawing.Point(348, 235);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 43);
            this.btModificar.TabIndex = 15;
            this.btModificar.Text = "Modificar producto";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btGuardar.Location = new System.Drawing.Point(447, 235);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 43);
            this.btGuardar.TabIndex = 16;
            this.btGuardar.Text = "Guardar cambios";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.btNuevo.Location = new System.Drawing.Point(348, 284);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(75, 43);
            this.btNuevo.TabIndex = 17;
            this.btNuevo.Text = "Nuevo producto";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btEliminar.Location = new System.Drawing.Point(348, 337);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 43);
            this.btEliminar.TabIndex = 18;
            this.btEliminar.Text = "Eliminar producto";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardarNuevo
            // 
            this.btGuardarNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btGuardarNuevo.Location = new System.Drawing.Point(447, 284);
            this.btGuardarNuevo.Name = "btGuardarNuevo";
            this.btGuardarNuevo.Size = new System.Drawing.Size(75, 43);
            this.btGuardarNuevo.TabIndex = 23;
            this.btGuardarNuevo.Text = "Guardar nuevo";
            this.btGuardarNuevo.UseVisualStyleBackColor = false;
            this.btGuardarNuevo.Click += new System.EventHandler(this.btGuardarNuevo_Click);
            // 
            // VerInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 470);
            this.Controls.Add(this.btGuardarNuevo);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btNuevo);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btTodos);
            this.Controls.Add(this.btStockBajo);
            this.Controls.Add(this.lbAvisoReponer);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbStockSeguridad);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb2);
            this.Controls.Add(this.tbFiltrar);
            this.Controls.Add(this.lbInventario);
            this.Name = "VerInventario";
            this.Text = "VerInventario";
            this.Load += new System.EventHandler(this.VerInventario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbInventario;
        private System.Windows.Forms.TextBox tbFiltrar;
        private System.Windows.Forms.Label lb2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.TextBox tbStockSeguridad;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label lbAvisoReponer;
        private System.Windows.Forms.Button btStockBajo;
        private System.Windows.Forms.Button btTodos;
        private System.Windows.Forms.Button btModificar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.Button btNuevo;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btGuardarNuevo;
    }
}