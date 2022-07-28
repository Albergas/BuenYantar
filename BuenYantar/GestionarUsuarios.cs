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
        }

        private void actualizarLista()
        {
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
            NuevoUsuario nU = new NuevoUsuario(gestor);
            DialogResult d = nU.ShowDialog();

            actualizarLista();
        }
    }
}
