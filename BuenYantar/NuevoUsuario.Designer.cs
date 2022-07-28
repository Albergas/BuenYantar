
namespace BuenYantar
{
    partial class NuevoUsuario
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
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPermisos = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btOK = new System.Windows.Forms.Button();
            this.lbAvisos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduce los datos del nuevo usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo:";
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.Location = new System.Drawing.Point(149, 83);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.Size = new System.Drawing.Size(263, 20);
            this.tbNombreCompleto.TabIndex = 2;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(149, 109);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(263, 20);
            this.tbNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre de usuario:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(149, 135);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(263, 20);
            this.tbPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(149, 161);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.PasswordChar = '•';
            this.tbPassword2.Size = new System.Drawing.Size(263, 20);
            this.tbPassword2.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Repetir contraseña:";
            // 
            // cbPermisos
            // 
            this.cbPermisos.AutoSize = true;
            this.cbPermisos.Location = new System.Drawing.Point(149, 187);
            this.cbPermisos.Name = "cbPermisos";
            this.cbPermisos.Size = new System.Drawing.Size(15, 14);
            this.cbPermisos.TabIndex = 9;
            this.cbPermisos.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Permisos de admin:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(418, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 20);
            this.button1.TabIndex = 11;
            this.button1.Text = "ver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btOK
            // 
            this.btOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.btOK.Location = new System.Drawing.Point(379, 259);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(75, 64);
            this.btOK.TabIndex = 12;
            this.btOK.Text = "Confirmar";
            this.btOK.UseVisualStyleBackColor = false;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbAvisos
            // 
            this.lbAvisos.AutoSize = true;
            this.lbAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAvisos.Location = new System.Drawing.Point(146, 219);
            this.lbAvisos.Name = "lbAvisos";
            this.lbAvisos.Size = new System.Drawing.Size(0, 13);
            this.lbAvisos.TabIndex = 13;
            // 
            // NuevoUsuario
            // 
            this.AcceptButton = this.btOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 335);
            this.Controls.Add(this.lbAvisos);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbPermisos);
            this.Controls.Add(this.tbPassword2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoUsuario";
            this.Text = "NuevoUsuario";
            this.Load += new System.EventHandler(this.NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox cbPermisos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btOK;
        private System.Windows.Forms.Label lbAvisos;
    }
}