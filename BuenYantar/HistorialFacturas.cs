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
    public partial class HistorialFacturas : Form
    {
        private Gestor gestor;

        public HistorialFacturas(Gestor gestor)
        {
            this.gestor = gestor;
            InitializeComponent();
        }

        private void HistorialFacturas_Load(object sender, EventArgs e)
        {

        }
    }
}
