
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
            this.SuspendLayout();
            // 
            // rtbFactura
            // 
            this.rtbFactura.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFactura.Location = new System.Drawing.Point(312, 12);
            this.rtbFactura.Name = "rtbFactura";
            this.rtbFactura.Size = new System.Drawing.Size(416, 459);
            this.rtbFactura.TabIndex = 0;
            this.rtbFactura.Text = "";
            // 
            // lbFacturas
            // 
            this.lbFacturas.FormattingEnabled = true;
            this.lbFacturas.Location = new System.Drawing.Point(12, 12);
            this.lbFacturas.Name = "lbFacturas";
            this.lbFacturas.Size = new System.Drawing.Size(262, 459);
            this.lbFacturas.TabIndex = 1;
            this.lbFacturas.SelectedIndexChanged += new System.EventHandler(this.lbFacturas_SelectedIndexChanged);
            // 
            // HistorialFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 489);
            this.Controls.Add(this.lbFacturas);
            this.Controls.Add(this.rtbFactura);
            this.Name = "HistorialFacturas";
            this.Text = "HistorialFacturas";
            this.Load += new System.EventHandler(this.HistorialFacturas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbFactura;
        private System.Windows.Forms.ListBox lbFacturas;
    }
}