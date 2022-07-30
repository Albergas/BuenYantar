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
    public partial class GestionarUsuarios : Form
    {

        private Gestor gestor;
        private Usuario user;
        private Usuario seleccion;

        public GestionarUsuarios(Gestor gestor, Usuario user)
        {
            this.seleccion = null;
            this.gestor = gestor;
            this.user = user;
            InitializeComponent();

            tbNombre.ReadOnly = true;
            tbNombreCompleto.ReadOnly = true;
            cbPermisos.Enabled = false;

            actualizarLista();

            if(user.Tipo != 0)
            {
                btNuevo.Visible = false;
                btNuevo.Enabled = false;
                btEliminar.Visible = false;
                btEliminar.Enabled = false;
            }
        }

        private void actualizarLista()
        {
            this.actualizarDatos();
            lbUsuarios.Items.Clear();

            foreach(Usuario usuario in gestor.usuarios())
            {
                lbUsuarios.Items.Add(usuario.NombreCompleto);
            }
        }

        private void GestionarUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void actualizarDatos()
        {
            if(seleccion == null)
            {
                tbNombre.Text = "";
                tbNombreCompleto.Text = "";
                cbPermisos.Checked = false;
            }
            else
            {
                tbNombre.Text = seleccion.Nombre;
                tbNombreCompleto.Text = seleccion.NombreCompleto;
                cbPermisos.Checked = (seleccion.Tipo == 0);
            }
        }

        private void lbUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbUsuarios.SelectedItem == null)
            {
                seleccion = null;
            }
            else
            {
                seleccion = gestor.construirUsuarioNombreCompleto(lbUsuarios.SelectedItem.ToString());
            }
            actualizarDatos();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            NuevoUsuario nU = new NuevoUsuario(gestor, user);
            DialogResult d = nU.ShowDialog();

            actualizarLista();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(lbUsuarios.SelectedItem != null)
            {
                DialogResult result = MessageBox.Show("¿Seguro que quiere borrar el usuario " + tbNombreCompleto.Text + "?","Confirmar eliminación", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    gestor.removeUser(tbNombre.Text);
                    gestor.LogEliminar(user, null, null, new Usuario(tbNombre.Text, "", 1, tbNombreCompleto.Text));
                    MessageBox.Show("Se eliminó el usuario " + tbNombreCompleto.Text);
                    this.actualizarLista();
                }
            }
        }
    }
}
