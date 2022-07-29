
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
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "/  Año";
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(234, 409);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(40, 20);
            this.tbAno.TabIndex = 14;
            this.tbAno.TextChanged += new System.EventHandler(this.tbAno_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "/  Mes";
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(145, 409);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(40, 20);
            this.tbMes.TabIndex = 12;
            this.tbMes.TextChanged += new System.EventHandler(this.tbMes_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Día";
            // 
            // tbDia
            // 
            this.tbDia.Location = new System.Drawing.Point(55, 409);
            this.tbDia.Name = "tbDia";
            this.tbDia.Size = new System.Drawing.Size(40, 20);
            this.tbDia.TabIndex = 10;
            this.tbDia.TextChanged += new System.EventHandler(this.tbDia_TextChanged);
            // 
            // lbFacturas
            // 
            this.lbFacturas.FormattingEnabled = true;
            this.lbFacturas.Location = new System.Drawing.Point(12, 12);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(392, 381);
            this.lbFacturas.TabIndex = 9;
            this.lbFacturas.SelectedIndexChanged += new System.EventHandler(this.lbFacturas_SelectedIndexChanged);
            // 
            // rtbFactura
            // 
            this.rtbFactura.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFactura.Location = new System.Drawing.Point(422, 12);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.ReadOnly = true;
            this.rtbFactura.Size = new System.Drawing.Size(429, 459);
            this.rtbFactura.TabIndex = 8;
            this.rtbFactura.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 438);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Socio:";
            // 
            // tbSocio
            // 
            this.tbSocio.Location = new System.Drawing.Point(55, 435);
            this.tbSocio.Name = "tbSocio";
            this.tbSocio.Size = new System.Drawing.Size(219, 20);
            this.tbSocio.TabIndex = 16;
            this.tbSocio.TextChanged += new System.EventHandler(this.tbSocio_TextChanged);
            // 
            // btInforme
            // 
            this.btInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.btInforme.Location = new System.Drawing.Point(308, 409);
            this.btInforme.Name = "btInforme";
            this.btInforme.Size = new System.Drawing.Size(72, 46);
            this.btInforme.TabIndex = 18;
            this.btInforme.Text = "Informe de todas";
            this.btInforme.UseVisualStyleBackColor = false;
            this.btInforme.Click += new System.EventHandler(this.button1_Click);
            // 
            // HistorialFacturasTodas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 503);
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
    }
}