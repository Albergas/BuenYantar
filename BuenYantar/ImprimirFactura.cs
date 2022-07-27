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
    public partial class ImprimirFactura : Form
    {

        private Factura factura;

        public ImprimirFactura(Factura factura)
        {
            InitializeComponent();
            this.factura = factura;

            this.rtbFactura.Text = factura.log();
        }

        private void ImprimirFactura_Load(object sender, EventArgs e)
        {

        }
    }
}
