
namespace BuenYantar
{
    partial class HistorialFacturas
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
            this.rtbFactura = new System.Windows.Forms.RichTextBox();
            this.lbFacturas = new System.Windows.Forms.ListBox();
            this.tbDia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbAno = new System.Windows.Forms.TextBox();
            this.btInforme = new System.Windows.Forms.Button();
            this.btConcatenar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbFactura
            // 
            this.rtbFactura.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFactura.Location = new System.Drawing.Point(312, 12);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.ReadOnly = true;
            this.rtbFactura.Size = new System.Drawing.Size(429, 459);
            this.rtbFactura.TabIndex = 0;
            this.rtbFactura.Text = "";
            // 
            // lbFacturas
            // 
            this.lbFacturas.FormattingEnabled = true;
            this.lbFacturas.Location = new System.Drawing.Point(12, 12);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(262, 381);
            this.lbFacturas.TabIndex = 1;
            this.lbFacturas.SelectedIndexChanged += new System.EventHandler(this.lbFacturas_SelectedIndexChanged);
            // 
            // tbDia
            // 
            this.tbDia.Location = new System.Drawing.Point(55, 409);
            this.tbDia.Name = "tbDia";
            this.tbDia.Size = new System.Drawing.Size(40, 20);
            this.tbDia.TabIndex = 2;
            this.tbDia.TextChanged += new System.EventHandler(this.tbDia_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Día";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 412);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "/  Mes";
            // 
            // tbMes
            // 
            this.tbMes.Location = new System.Drawing.Point(145, 409);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(40, 20);
            this.tbMes.TabIndex = 4;
            this.tbMes.TextChanged += new System.EventHandler(this.tbMes_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(191, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "/  Año";
            // 
            // tbAno
            // 
            this.tbAno.Location = new System.Drawing.Point(234, 409);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(40, 20);
            this.tbAno.TabIndex = 6;
            this.tbAno.TextChanged += new System.EventHandler(this.tbAno_TextChanged);
            // 
            // btInforme
            // 
            this.btInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.btInforme.Location = new System.Drawing.Point(202, 436);
            this.btInforme.Name = "btInforme";
            this.btInforme.Size = new System.Drawing.Size(72, 46);
            this.btInforme.TabIndex = 19;
            this.btInforme.Text = "Informe de todas";
            this.btInforme.UseVisualStyleBackColor = false;
            this.btInforme.Click += new System.EventHandler(this.btInforme_Click);
            // 
            // btConcatenar
            // 
            this.btConcatenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btConcatenar.Location = new System.Drawing.Point(113, 436);
            this.btConcatenar.Name = "btConcatenar";
            this.btConcatenar.Size = new System.Drawing.Size(72, 46);
            this.btConcatenar.TabIndex = 21;
            this.btConcatenar.Text = "Informe una a una";
            this.btConcatenar.UseVisualStyleBackColor = false;
            this.btConcatenar.Click += new System.EventHandler(this.btConcatenar_Click);
            // 
            // HistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 494);
            this.Controls.Add(this.btConcatenar);
            this.Controls.Add(this.btInforme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbDia);
            this.Controls.Add(this.lbFacturas);
            this.Controls.Add(this.rtbFactura);
            this.Name = "HistorialFacturas";
            this.Text = "HistorialFacturas";
            this.Load += new System.EventHandler(this.HistorialFacturas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFactura;
        private System.Windows.Forms.ListBox lbFacturas;
        private System.Windows.Forms.TextBox tbDia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbAno;
        private System.Windows.Forms.Button btInforme;
        private System.Windows.Forms.Button btConcatenar;
    }
}