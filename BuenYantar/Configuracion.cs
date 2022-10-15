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
    public partial class Configuracion : Form
    {
        private Gestor gestor;
        private Usuario user;

        public Configuracion(Gestor gestor, Usuario user)
        {
            this.gestor = gestor;
            this.user = user;
            InitializeComponent();

            actualizarDatos();
        }

        private void actualizarDatos()
        {
            lbNombre.Visible = false;
            tbNuevoNombre.Visible = false;
            lbPassword.Visible = false;
            lbPassword2.Visible = false;
            tbPassword.Visible = false;
            tbPassword2.Visible = false;
            btAceptar.Visible = false;
            btAceptar.Enabled = false;

            lbAvisos.Text = "";

            tbNombreCompleto.Text = user.NombreCompleto;
            tbNombre.Text = user.Nombre;
            cbPermisos.Checked = (user.Tipo == 0);
        }

        private void Configuracion_Load(object sender, EventArgs e)
        {

        }

        private void btNombre_Click(object sender, EventArgs e)
        {
            lbNombre.Visible = true;
            tbNuevoNombre.Visible = true;
            btAceptar.Visible = true;
            btAceptar.Enabled = true;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            string hash;

            if (tbNuevoNombre.Visible)
            {
                if(tbNuevoNombre.Text == "" || gestor.construirUsuario(tbNuevoNombre.Text) != null)
                {
                    lbAvisos.Text = "Error: nombre no válido, introduce otro";
                }
                else
                {
                    if (tbPassword.Visible)
                    {
                        if(tbPassword.Text == "")
                        {
                            lbAvisos.Text = "Error: contraseña no válida";
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
                                user = new Usuario(tbNuevoNombre.Text, Passwords.MD5(tbPassword.Text), user.Tipo, user.NombreCompleto);
                                gestor.modifyUserNC(user);
                                lbConfirm.Text = "Contraseña actualizada";
                                actualizarDatos();
                            }
                        }
                    }
                    else
                    {
                        user = new Usuario(tbNuevoNombre.Text, user.Hash, user.Tipo, user.NombreCompleto);
                        gestor.modifyUserNC(user);
                        lbConfirm.Text = "Contraseña actualizada";
                        actualizarDatos();
                    }
                }
            }
            else
            {
                if (tbPassword.Visible)
                {
                    if (tbPassword.Text == "")
                    {
                        lbAvisos.Text = "Error: contraseña no válida";
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
                            user = new Usuario(user.Nombre, Passwords.MD5(tbPassword.Text), user.Tipo, user.NombreCompleto);
                            gestor.modifyUserNC(user);
                            lbConfirm.Text = "Contraseña actualizada";
                            actualizarDatos();
                        }
                    }
                }
                else
                {
                    actualizarDatos();
                }
            }
        }

        private void btPassword_Click(object sender, EventArgs e)
        {
            lbConfirm.Text = "";
            lbPassword.Visible = true;
            lbPassword2.Visible = true;
            tbPassword.Visible = true;
            tbPassword2.Visible = true;
            btAceptar.Visible = true;
            btAceptar.Enabled = true;
        }
    }
}
