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

        private Inventario inventario;

        public FormInicio(Inventario i)
        {
            this.inventario = i;
            InitializeComponent();
        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            VerInventario verInventario = new VerInventario(inventario);
            DialogResult d = verInventario.ShowDialog();
        }
    }
}
