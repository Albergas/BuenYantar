
namespace BuenYantar
{
    partial class Configuracion
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
            this.btPassword = new System.Windows.Forms.Button();
            this.cbPermisos = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNombreCompleto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.tbNuevoNombre = new System.Windows.Forms.TextBox();
            this.btAceptar = new System.Windows.Forms.Button();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.tbPassword2 = new System.Windows.Forms.TextBox();
            this.lbPassword2 = new System.Windows.Forms.Label();
            this.lbAvisos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btPassword
            // 
            this.btPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(230)))), ((int)(((byte)(255)))));
            this.btPassword.Location = new System.Drawing.Point(142, 137);
            this.btPassword.Name = "btPassword";
            this.btPassword.Size = new System.Drawing.Size(75, 63);
            this.btPassword.TabIndex = 1;
            this.btPassword.Text = "Cambiar mi contraseña";
            this.btPassword.UseVisualStyleBackColor = false;
            this.btPassword.Click += new System.EventHandler(this.btPassword_Click);
            // 
            // cbPermisos
            // 
            this.cbPermisos.AutoSize = true;
            this.cbPermisos.Enabled = false;
            this.cbPermisos.Location = new System.Drawing.Point(130, 83);
            this.cbPermisos.Name = "cbPermisos";
            this.cbPermisos.Size = new System.Drawing.Size(15, 14);
            this.cbPermisos.TabIndex = 13;
            this.cbPermisos.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Permisos de admin:";
            // 
            // tbNombreCompleto
            // 
            this.tbNombreCompleto.Location = new System.Drawing.Point(130, 31);
            this.tbNombreCompleto.Name = "tbNombreCompleto";
            this.tbNombreCompleto.ReadOnly = true;
            this.tbNombreCompleto.Size = new System.Drawing.Size(200, 20);
            this.tbNombreCompleto.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre completo:";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(130, 57);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNombre.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre de usuario:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Location = new System.Drawing.Point(44, 232);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(80, 13);
            this.lbNombre.TabIndex = 14;
            this.lbNombre.Text = "Nuevo nombre:";
            // 
            // tbNuevoNombre
            // 
            this.tbNuevoNombre.Location = new System.Drawing.Point(130, 229);
            this.tbNuevoNombre.Name = "tbNuevoNombre";
            this.tbNuevoNombre.Size = new System.Drawing.Size(200, 20);
            this.tbNuevoNombre.TabIndex = 15;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(255)))), ((int)(((byte)(222)))));
            this.btAceptar.Location = new System.Drawing.Point(255, 137);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(75, 63);
            this.btAceptar.TabIndex = 16;
            this.btAceptar.Text = "Aceptar cambios";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(130, 255);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '•';
            this.tbPassword.Size = new System.Drawing.Size(200, 20);
            this.tbPassword.TabIndex = 18;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(26, 258);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(98, 13);
            this.lbPassword.TabIndex = 17;
            this.lbPassword.Text = "Nueva contraseña:";
            // 
            // tbPassword2
            // 
            this.tbPassword2.Location = new System.Drawing.Point(130, 281);
            this.tbPassword2.Name = "tbPassword2";
            this.tbPassword2.PasswordChar = '•';
            this.tbPassword2.Size = new System.Drawing.Size(200, 20);
            this.tbPassword2.TabIndex = 20;
            // 
            // lbPassword2
            // 
            this.lbPassword2.AutoSize = true;
            this.lbPassword2.Location = new System.Drawing.Point(24, 284);
            this.lbPassword2.Name = "lbPassword2";
            this.lbPassword2.Size = new System.Drawing.Size(100, 13);
            this.lbPassword2.TabIndex = 19;
            this.lbPassword2.Text = "Repetir contraseña:";
            // 
            // lbAvisos
            // 
            this.lbAvisos.AutoSize = true;
            this.lbAvisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAvisos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbAvisos.Location = new System.Drawing.Point(26, 330);
            this.lbAvisos.Name = "lbAvisos";
            this.lbAvisos.Size = new System.Drawing.Size(0, 13);
            this.lbAvisos.TabIndex = 21;
            // 
            // Configuracion
            // 
            this.AcceptButton = this.btAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 373);
            this.Controls.Add(this.lbAvisos);
            this.Controls.Add(this.tbPassword2);
            this.Controls.Add(this.lbPassword2);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lbPassword);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbNuevoNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.cbPermisos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNombreCompleto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btPassword);
            this.Name = "Configuracion";
            this.Text = "Configuracion";
            this.Load += new System.EventHandler(this.Configuracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btPassword;
        private System.Windows.Forms.CheckBox cbPermisos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNombreCompleto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox tbNuevoNombre;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.TextBox tbPassword2;
        private System.Windows.Forms.Label lbPassword2;
        private System.Windows.Forms.Label lbAvisos;
    }
}