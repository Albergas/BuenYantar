
namespace BuenYantar
{
    partial class Informe_reponer
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
            this.label1 = new System.Windows.Forms.Label();
            this.rtbInforme = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Artículos que es necesario reponer";
            // 
            // rtbInforme
            // 
            this.rtbInforme.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbInforme.Location = new System.Drawing.Point(12, 27);
            this.rtbInforme.Name = "rtbInforme";
            this.rtbInforme.Size = new System.Drawing.Size(599, 482);
            this.rtbInforme.TabIndex = 2;
            this.rtbInforme.Text = "";
            // 
            // Informe_reponer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 529);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbInforme);
            this.Name = "Informe_reponer";
            this.Text = "Informe_reponer";
            this.Load += new System.EventHandler(this.Informe_reponer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbInforme;
    }
}