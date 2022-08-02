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
    public partial class Informe_reponer : Form
    {

        private Gestor gestor;

        public Informe_reponer(Gestor gestor)
        {
            this.gestor = gestor;
            InitializeComponent();

            string s = "\n==========================\n\n ARTICULOS A REPONER\n\n";
            foreach(Item item in gestor.items())
            {
                if(item.Cantidad < item.Seguridad)
                {
                    s += " " + item.Nombre + "  (Stock: " + item.Cantidad + ", Seguridad: " + item.Seguridad + ")\n";
                }
            }

            s += "\n==========================\n";

            rtbInforme.Text = s;
        }

        private void Informe_reponer_Load(object sender, EventArgs e)
        {

        }

        private void rtbInforme_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = "==========================\n\n    LISTA DE LA COMPRA    \n\n--------------------------\n\n";
            foreach (Item item in gestor.items())
            {
                if (item.Cantidad < item.Seguridad)
                {
                    s += item.Seguridad - item.Cantidad + " " + item.Nombre + "\n";
                }
            }
            s += "\n==========================";
            gestor.imprimirTexto(s);
        }
    }
}
