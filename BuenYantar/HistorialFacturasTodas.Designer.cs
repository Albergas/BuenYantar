
namespace BuenYantar
{
    partial class HistorialFacturasTodas
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
            this.label3 = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDia = new System.Windows.Forms.TextBox();
            this.lbFacturas = new System.Windows.Forms.ListBox();
            this.rtbFactura = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbSocio = new System.Windows.Forms.TextBox();
            this.btInforme = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btConcatenar = new System.Windows.Forms.Button();
            this.btImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(393, 568);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 15;
            this.label3.Text = "/  Año";
            // 
            // tbAno
            // 
            this.tbAno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAno.Location = new System.Drawing.Point(473, 565);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(154, 35);
            this.tbAno.TabIndex = 14;
            this.tbAno.TextChanged += new System.EventHandler(this.tbAno_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(219, 568);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "/  Mes";
            // 
            // tbMes
            // 
            this.tbMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMes.Location = new System.Drawing.Point(303, 565);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(84, 35);
            this.tbMes.TabIndex = 12;
            this.tbMes.TextChanged += new System.EventHandler(this.tbMes_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 568);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Día";
            // 
            // tbDia
            // 
            this.tbDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDia.Location = new System.Drawing.Point(121, 565);
            this.tbDia.Name = "tbDia";
            this.tbDia.Size = new System.Drawing.Size(92, 35);
            this.tbDia.TabIndex = 10;
            this.tbDia.TextChanged += new System.EventHandler(this.tbDia_TextChanged);
            // 
            // lbFacturas
            // 
            this.lbFacturas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturas.FormattingEnabled = true;
            this.lbFacturas.ItemHeight = 29;
            this.lbFacturas.Location = new System.Drawing.Point(71, 46);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(556, 497);
            this.lbFacturas.TabIndex = 9;
            this.lbFacturas.SelectedIndexChanged += new System.EventHandler(this.lbFacturas_SelectedIndexChanged);
            // 
            // rtbFactura
            // 
            this.rtbFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbFactura.Font = new System.Drawing.Font("Lucida Console", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFactura.Location = new System.Drawing.Point(733, 46);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.ReadOnly = true;
            this.rtbFactura.Size = new System.Drawing.Size(568, 592);
            this.rtbFactura.TabIndex = 8;
            this.rtbFactura.Text = "";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 609);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 29);
            this.label5.TabIndex = 17;
            this.label5.Text = "Socio:";
            // 
            // tbSocio
            // 
            this.tbSocio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbSocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSocio.Location = new System.Drawing.Point(153, 606);
            this.tbSocio.Name = "tbSocio";
            this.tbSocio.Size = new System.Drawing.Size(474, 35);
            this.tbSocio.TabIndex = 16;
            this.tbSocio.TextChanged += new System.EventHandler(this.tbSocio_TextChanged);
            // 
            // btInforme
            // 
            this.btInforme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.btInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInforme.Location = new System.Drawing.Point(512, 647);
            this.btInforme.Name = "btInforme";
            this.btInforme.Size = new System.Drawing.Size(115, 93);
            this.btInforme.TabIndex = 18;
            this.btInforme.Text = "Informe de todas";
            this.btInforme.UseVisualStyleBackColor = false;
            this.btInforme.Click += new System.EventHandler(this.button1_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(222)))));
            this.btEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliminar.Location = new System.Drawing.Point(230, 647);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(133, 93);
            this.btEliminar.TabIndex = 19;
            this.btEliminar.Text = "Eliminar selección";
            this.btEliminar.UseVisualStyleBackColor = false;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btConcatenar
            // 
            this.btConcatenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConcatenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btConcatenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConcatenar.Location = new System.Drawing.Point(369, 647);
            this.btConcatenar.Name = "btConcatenar";
            this.btConcatenar.Size = new System.Drawing.Size(137, 93);
            this.btConcatenar.TabIndex = 20;
            this.btConcatenar.Text = "Informe una a una";
            this.btConcatenar.UseVisualStyleBackColor = false;
            this.btConcatenar.Click += new System.EventHandler(this.btConcatenar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Location = new System.Drawing.Point(1130, 647);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(171, 93);
            this.btImprimir.TabIndex = 21;
            this.btImprimir.Text = "IMPRIMIR";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // HistorialFacturasTodas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 771);
            this.Controls.Add(this.btImprimir);
            this.Controls.Add(this.btConcatenar);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btInforme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbSocio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDia);
            this.Controls.Add(this.lbFacturas);
            this.Controls.Add(this.rtbFactura);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HistorialFacturasTodas";
            this.Text = "HistorialFacturasTodas";
            this.Load += new System.EventHandler(this.HistorialFacturasTodas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDia;
        private System.Windows.Forms.ListBox lbFacturas;
        private System.Windows.Forms.RichTextBox rtbFactura;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbSocio;
        private System.Windows.Forms.Button btInforme;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btConcatenar;
        private System.Windows.Forms.Button btImprimir;
    }
}