
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
            this.btImprimir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rtbFactura
            // 
            this.rtbFactura.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rtbFactura.Font = new System.Drawing.Font("Lucida Console", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFactura.Location = new System.Drawing.Point(609, 38);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.ReadOnly = true;
            this.rtbFactura.Size = new System.Drawing.Size(470, 632);
            this.rtbFactura.TabIndex = 0;
            this.rtbFactura.Text = "";
            // 
            // lbFacturas
            // 
            this.lbFacturas.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFacturas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFacturas.FormattingEnabled = true;
            this.lbFacturas.ItemHeight = 25;
            this.lbFacturas.Location = new System.Drawing.Point(61, 38);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(483, 479);
            this.lbFacturas.TabIndex = 1;
            this.lbFacturas.SelectedIndexChanged += new System.EventHandler(this.lbFacturas_SelectedIndexChanged);
            // 
            // tbDia
            // 
            this.tbDia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDia.Location = new System.Drawing.Point(111, 533);
            this.tbDia.Name = "tbDia";
            this.tbDia.Size = new System.Drawing.Size(85, 35);
            this.tbDia.TabIndex = 2;
            this.tbDia.TextChanged += new System.EventHandler(this.tbDia_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Día";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 536);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "/  Mes";
            // 
            // tbMes
            // 
            this.tbMes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMes.Location = new System.Drawing.Point(286, 533);
            this.tbMes.Name = "tbMes";
            this.tbMes.Size = new System.Drawing.Size(86, 35);
            this.tbMes.TabIndex = 4;
            this.tbMes.TextChanged += new System.EventHandler(this.tbMes_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(378, 536);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "/  Año";
            // 
            // tbAno
            // 
            this.tbAno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAno.Location = new System.Drawing.Point(458, 533);
            this.tbAno.Name = "tbAno";
            this.tbAno.Size = new System.Drawing.Size(86, 35);
            this.tbAno.TabIndex = 6;
            this.tbAno.TextChanged += new System.EventHandler(this.tbAno_TextChanged);
            // 
            // btInforme
            // 
            this.btInforme.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btInforme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(220)))));
            this.btInforme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInforme.Location = new System.Drawing.Point(413, 577);
            this.btInforme.Name = "btInforme";
            this.btInforme.Size = new System.Drawing.Size(131, 93);
            this.btInforme.TabIndex = 19;
            this.btInforme.Text = "Informe de todas";
            this.btInforme.UseVisualStyleBackColor = false;
            this.btInforme.Click += new System.EventHandler(this.btInforme_Click);
            // 
            // btConcatenar
            // 
            this.btConcatenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btConcatenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btConcatenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConcatenar.Location = new System.Drawing.Point(279, 577);
            this.btConcatenar.Name = "btConcatenar";
            this.btConcatenar.Size = new System.Drawing.Size(128, 93);
            this.btConcatenar.TabIndex = 21;
            this.btConcatenar.Text = "Informe una a una";
            this.btConcatenar.UseVisualStyleBackColor = false;
            this.btConcatenar.Click += new System.EventHandler(this.btConcatenar_Click);
            // 
            // btImprimir
            // 
            this.btImprimir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.btImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btImprimir.Location = new System.Drawing.Point(945, 687);
            this.btImprimir.Name = "btImprimir";
            this.btImprimir.Size = new System.Drawing.Size(134, 96);
            this.btImprimir.TabIndex = 22;
            this.btImprimir.Text = "IMPRIMIR";
            this.btImprimir.UseVisualStyleBackColor = false;
            this.btImprimir.Click += new System.EventHandler(this.btImprimir_Click);
            // 
            // HistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 815);
            this.Controls.Add(this.btImprimir);
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
        private System.Windows.Forms.Button btImprimir;
    }
}