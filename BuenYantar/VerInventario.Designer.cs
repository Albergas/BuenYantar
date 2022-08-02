
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
            this.tbCodigo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbFamilia = new System.Windows.Forms.TextBox();
            this.btImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbInventario
            // 
            this.lbInventario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbInventario.FormattingEnabled = true;
            this.lbInventario.ItemHeight = 29;
            this.lbInventario.Location = new System.Drawing.Point(41, 36);
            this.lbInventario.Name = "lbInventario";
            this.lbInventario.Size = new System.Drawing.Size(577, 526);
            this.lbInventario.TabIndex = 0;
            this.lbInventario.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // tbFiltrar
            // 
            this.tbFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFiltrar.Location = new System.Drawing.Point(149, 568);
            this.tbFiltrar.Name = "tbFiltrar";
            this.tbFiltrar.Size = new System.Drawing.Size(469, 35);
            this.tbFiltrar.TabIndex = 1;
            this.tbFiltrar.TextChanged += new System.EventHandler(this.tbFiltrar_TextChanged);
            // 
            // lb2
            // 
            this.lb2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lb2.AutoSize = true;
            this.lb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb2.Location = new System.Drawing.Point(36, 571);
            this.lb2.Name = "lb2";
            this.lb2.Size = new System.Drawing.Size(107, 29);
            this.lb2.TabIndex = 3;
            this.lb2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(759, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(787, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Stock:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(639, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stock de seguridad:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(743, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Precio/ud:";
            // 
            // tbNombre
            // 
            this.tbNombre.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(872, 111);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(416, 35);
            this.tbNombre.TabIndex = 8;
            // 
            // tbStock
            // 
            this.tbStock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStock.Location = new System.Drawing.Point(872, 152);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(416, 35);
            this.tbStock.TabIndex = 9;
            this.tbStock.TextChanged += new System.EventHandler(this.tbStock_TextChanged);
            // 
            // tbStockSeguridad
            // 
            this.tbStockSeguridad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbStockSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockSeguridad.Location = new System.Drawing.Point(872, 193);
            this.tbStockSeguridad.Name = "tbStockSeguridad";
            this.tbStockSeguridad.Size = new System.Drawing.Size(416, 35);
            this.tbStockSeguridad.TabIndex = 10;
            this.tbStockSeguridad.TextChanged += new System.EventHandler(this.tbStockSeguridad_TextChanged);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecio.Location = new System.Drawing.Point(872, 234);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(416, 35);
            this.tbPrecio.TabIndex = 11;
            this.tbPrecio.TextChanged += new System.EventHandler(this.tbPrecio_TextChanged);
            // 
            // lbAvisoReponer
            // 
            this.lbAvisoReponer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbAvisoReponer.AutoSize = true;
            this.lbAvisoReponer.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvisoReponer.ForeColor = System.Drawing.Color.Firebrick;
            this.lbAvisoReponer.Location = new System.Drawing.Point(768, 351);
            this.lbAvisoReponer.Name = "lbAvisoReponer";
            this.lbAvisoReponer.Size = new System.Drawing.Size(441, 29);
            this.lbAvisoReponer.TabIndex = 12;
            this.lbAvisoReponer.Text = "¡Aviso! Stock inferior al de seguridad";
            // 
            // btStockBajo
            // 
            this.btStockBajo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btStockBajo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btStockBajo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStockBajo.Location = new System.Drawing.Point(427, 609);
            this.btStockBajo.Name = "btStockBajo";
            this.btStockBajo.Size = new System.Drawing.Size(91, 85);
            this.btStockBajo.TabIndex = 13;
            this.btStockBajo.Text = "Stock bajo";
            this.btStockBajo.UseVisualStyleBackColor = false;
            this.btStockBajo.Click += new System.EventHandler(this.btStockBajo_Click);
            // 
            // btTodos
            // 
            this.btTodos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btTodos.BackColor = System.Drawing.Color.LightBlue;
            this.btTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTodos.Location = new System.Drawing.Point(524, 609);
            this.btTodos.Name = "btTodos";
            this.btTodos.Size = new System.Drawing.Size(94, 85);
            this.btTodos.TabIndex = 14;
            this.btTodos.Text = "Todos";
            this.btTodos.UseVisualStyleBackColor = false;
            this.btTodos.Click += new System.EventHandler(this.btTodos_Click);
            // 
            // btModificar
            // 
            this.btModificar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btModificar.Location = new System.Drawing.Point(845, 408);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(144, 85);
            this.btModificar.TabIndex = 15;
            this.btModificar.Text = "Modificar producto";
            this.btModificar.UseVisualStyleBackColor = false;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardar.Location = new System.Drawing.Point(995, 408);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(144, 85);
            this.btGuardar.TabIndex = 16;
            this.btGuardar.Text = "Guardar cambios";
            this.btGuardar.UseVisualStyleBackColor = false;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // btNuevo
            // 
            this.btNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(255)))), ((int)(((byte)(200)))));
            this.btNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNuevo.Location = new System.Drawing.Point(845, 499);
            this.btNuevo.Name = "btNuevo";
            this.btNuevo.Size = new System.Drawing.Size(144, 85);
            this.btNuevo.TabIndex = 17;
            this.btNuevo.Text = "Nuevo producto";
            this.btNuevo.UseVisualStyleBackColor = false;
            this.btNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(845, 590);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(144, 85);
            this.btEliminar.TabIndex = 18;
            this.btEliminar.Text = "Eliminar producto";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btGuardarNuevo
            // 
            this.btGuardarNuevo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btGuardarNuevo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btGuardarNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGuardarNuevo.Location = new System.Drawing.Point(995, 499);
            this.btGuardarNuevo.Name = "btGuardarNuevo";
            this.btGuardarNuevo.Size = new System.Drawing.Size(144, 85);
            this.btGuardarNuevo.TabIndex = 23;
            this.btGuardarNuevo.Text = "Guardar nuevo";
            this.btGuardarNuevo.UseVisualStyleBackColor = false;
            this.btGuardarNuevo.Click += new System.EventHandler(this.btGuardarNuevo_Click);
            // 
            // tbCodigo
            // 
            this.tbCodigo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCodigo.Location = new System.Drawing.Point(872, 275);
            this.tbCodigo.Name = "tbCodigo";
            this.tbCodigo.Size = new System.Drawing.Size(416, 35);
            this.tbCodigo.TabIndex = 25;
            this.tbCodigo.TextChanged += new System.EventHandler(this.tbCodigo_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(768, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 29);
            this.label5.TabIndex = 24;
            this.label5.Text = "Familia:";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 29);
            this.label6.TabIndex = 27;
            this.label6.Text = "Familia:";
            // 
            // tbFamilia
            // 
            this.tbFamilia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbFamilia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFamilia.Location = new System.Drawing.Point(149, 609);
            this.tbFamilia.Name = "tbFamilia";
            this.tbFamilia.Size = new System.Drawing.Size(159, 35);
            this.tbFamilia.TabIndex = 26;
            this.tbFamilia.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Location = new System.Drawing.Point(314, 609);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(107, 85);
            this.btImprimir.TabIndex = 28;
            this.btImprimir.Text = "IMPRIMIR";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // VerInventario
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1340, 717);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbFamilia);
            this.Controls.Add(this.tbCodigo);
            this.Controls.Add(this.label5);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VerInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.TextBox tbCodigo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbFamilia;
        private System.Windows.Forms.Button btImprimir;
    }
}