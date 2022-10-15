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
    public partial class Login : Form
    {
        private Gestor gestor;
        private bool secretPassword;

        public Login(Gestor gestor)
        {
            this.gestor = gestor;
            InitializeComponent();
            this.tbPassword.PasswordChar = '•';
            this.secretPassword = true;
            lbAvisos.Text = "";
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Usuario user;
            user = gestor.login(tbUsuario.Text, tbPassword.Text);
            if(user == null)
            {
                lbAvisos.Text = "Error: usuario o contraseña incorrectos";
            }
            else
            {
                this.Visible = false;
                FormInicio f = new FormInicio(gestor, user);
                DialogResult d = f.ShowDialog();
                lbAvisos.Text = "";

                if(d != DialogResult.Retry)
                {
                    this.Dispose();
                }
                else
                {
                    tbUsuario.Text = "";
                    tbPassword.Text = "";
                    this.Visible = true;
                }
            }
        }

        private void btSecreto_Click(object sender, EventArgs e)
        {
            if (this.secretPassword)
                this.tbPassword.PasswordChar = '\0';
            else
                this.tbPassword.PasswordChar = '•';
            this.secretPassword = !this.secretPassword;
        }
    }
}
