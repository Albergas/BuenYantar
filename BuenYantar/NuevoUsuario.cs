using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuenYantar
{
    public partial class NuevoUsuario : Form
    {

        private Gestor gestor;
        private Usuario user1;
        private bool secretPassword;

        public NuevoUsuario(Gestor gestor, Usuario user1)
        {
            this.gestor = gestor;
            this.user1 = user1;
            InitializeComponent();
            this.tbPassword.PasswordChar = '•';
            this.secretPassword = true;
            this.DialogResult = DialogResult.None;

            lbAvisos.Text = "";
        }

        private void NuevoUsuario_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.secretPassword)
                this.tbPassword.PasswordChar = '\0';
            else
                this.tbPassword.PasswordChar = '•';
            this.secretPassword = !this.secretPassword;
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text == "" || tbNombreCompleto.Text == "" || tbPassword.Text == "" || tbPassword2.Text == "")
            {
                lbAvisos.Text = "Error: es necesario rellenar todos los campos";
            }
            else
            {
                if (!tbPassword.Text.Equals(tbPassword2.Text))
                {
                    lbAvisos.Text = "Error: contraseñas no coincidentes, vuelve a escribirla";
                    tbPassword.Text = "";
                    tbPassword2.Text = "";
                }
                else
                {
                    if(gestor.construirUsuario(tbNombre.Text) != null)
                    {
                        lbAvisos.Text = "Error: ya existe un socio con ese nombre de usuario";
                        tbNombre.Text = "";
                    }
                    else
                    {
                        string hash = Passwords.MD5(tbPassword.Text);
                        int n = 1;
                        if (cbPermisos.Checked == true)
                            n = 0;
                        Usuario user = new Usuario(tbNombre.Text, hash, n, tbNombreCompleto.Text);

                        gestor.addUser(user);
                        gestor.LogCrear(user1, null, null, user);
                        MessageBox.Show("Usuario añadido correctamente");
                        this.DialogResult = DialogResult.OK;
                        this.Dispose();
                    }
                }
            }
        }
    }
}
