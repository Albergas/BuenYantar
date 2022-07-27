using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuenYantar
{
    public partial class HistorialFacturas : Form
    {
        private Gestor gestor;
        private Collection<Factura> facturas;

        public HistorialFacturas(Gestor gestor)
        {
            this.gestor = gestor;
            InitializeComponent();

            this.facturas = gestor.facturas();

            actualizarLista();
        }

        private void actualizarLista()
        {
            lbFacturas.Items.Clear();
            string s;

            foreach(Factura factura in facturas)
            {
                s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                lbFacturas.Items.Add(s);
            }
        }

        private void HistorialFacturas_Load(object sender, EventArgs e)
        {

        }

        private void lbFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFacturas.SelectedItem != null)
                rtbFactura.Text = facturas[lbFacturas.SelectedIndex].log();
            else
                rtbFactura.Text = "";
        }
    }
}
