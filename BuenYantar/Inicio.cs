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
    public partial class FormInicio : Form
    {

        private Gestor gestor;
        private Usuario user;

        public FormInicio(Gestor gestor, Usuario user)
        {
            this.gestor = gestor;
            this.user = user;
            InitializeComponent();
            this.tbUser.Text = user.NombreCompleto;
            this.DialogResult = DialogResult.None;
            btTodasFacturas.Visible = (this.user.Tipo == 0);

            int w = this.Size.Width;
            int h = this.Size.Height;

            this.AutoScaleMode = AutoScaleMode.Dpi;

        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            VerInventario verInventario = new VerInventario(new Inventario(gestor), user);
            DialogResult d = verInventario.ShowDialog();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btFactura_Click(object sender, EventArgs e)
        {
            NuevaFactura nuevaFactura = new NuevaFactura(gestor, new Inventario(gestor), user);
            DialogResult d = nuevaFactura.ShowDialog();
        }

        private void btHistorial_Click(object sender, EventArgs e)
        {
            HistorialFacturas histFacturas = new HistorialFacturas(gestor, user);
            DialogResult d = histFacturas.ShowDialog();
        }

        private void btUsuarios_Click(object sender, EventArgs e)
        {
            GestionarUsuarios gUs = new GestionarUsuarios(gestor, user);
            DialogResult d = gUs.ShowDialog();
        }

        private void btReponer_Click(object sender, EventArgs e)
        {
            Informe_reponer ir = new Informe_reponer(gestor);
            DialogResult d = ir.ShowDialog();
        }

        private void btConfiguracion_Click(object sender, EventArgs e)
        {
            Configuracion config = new Configuracion(gestor, user);
            DialogResult d = config.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HistorialFacturasTodas hft = new HistorialFacturasTodas(gestor, user);
            DialogResult d = hft.ShowDialog();
        }

        private void btCerrarSesion_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
