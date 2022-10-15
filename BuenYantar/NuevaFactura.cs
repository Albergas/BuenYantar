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
    public partial class NuevaFactura : Form
    {
        private Gestor gestor;
        private Inventario inventario;
        private Collection<Item> inventarioOrdenado;
        private Item seleccionado;
        private Factura factura;
        private Usuario user;

        public NuevaFactura(Gestor gestor, Inventario inventario, Usuario user)
        {
            InitializeComponent();
            this.gestor = gestor;
            this.inventario = inventario;
            this.seleccionado = null;
            this.user = user;
            lbAvisos2.Text = "";
            this.inventarioOrdenado = this.inventario.ordenado();

            btQuitar.Visible = false;

            foreach (Item item in this.inventarioOrdenado)
            {
                this.lbInventario.Items.Add(item.Nombre);
            }

            factura = new Factura(this.user);
        }

        private void actualizarLista()
        {
            this.lbInventario.Items.Clear();
            actualizarOrdenacion();

            if (this.tbFiltrar.Text.Trim() != "")
            {
                if (tbFamilia.Text.Trim() != "")
                {
                    foreach (Item item in this.inventarioOrdenado)
                        if (item.Nombre.Contains(this.tbFiltrar.Text) && item.Codigo == Int32.Parse(tbFamilia.Text))
                            this.lbInventario.Items.Add(item.Nombre);
                }
                else
                {
                    foreach (Item item in this.inventarioOrdenado)
                        if (item.Nombre.Contains(this.tbFiltrar.Text))
                            this.lbInventario.Items.Add(item.Nombre);
                }
            }
            else
            {
                if (tbFamilia.Text.Trim() != "")
                {
                    foreach (Item item in this.inventarioOrdenado)
                        if (item.Codigo == Int32.Parse(tbFamilia.Text))
                            this.lbInventario.Items.Add(item.Nombre);
                }
                else
                {
                    foreach (Item item in this.inventarioOrdenado)
                        this.lbInventario.Items.Add(item.Nombre);
                }
            }
        }

        private void actualizarListaFactura()
        {
            btQuitar.Visible = false;
            this.lbFactura.Items.Clear();
            string s;
            double d;

            foreach(Tuple<Item,int> elemento in factura.Contenido)
            {
                d = elemento.Item1.Precio * elemento.Item2;
                if(elemento.Item2 > elemento.Item1.Cantidad)
                    s = "*" + elemento.Item2.ToString() + " " + elemento.Item1.Nombre + " (" + d + "€)";
                else
                    s = "" + elemento.Item2.ToString() + " " + elemento.Item1.Nombre + " (" + d + "€)";

                lbFactura.Items.Add(s);
            }

            tbTotal.Text = factura.precioTotal().ToString();
        }

        private void lbInventario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.lbInventario.SelectedItem == null)
            {
                seleccionado = null;
                esconder();
            }
            else
            {
                foreach (Item item in this.inventario.Items)
                {
                    if (item.Nombre.Equals(this.lbInventario.SelectedItem.ToString()))
                        seleccionado = item;
                }

                tbProducto.Text = seleccionado.Nombre;
                tbPrecio.Text = seleccionado.Precio.ToString();
                mostrar();
            }
        }

        private void esconder()
        {
            this.lbProducto.Visible = false;
            this.lbPrecio.Visible = false;
            this.lbCantidad.Visible = false;

            this.tbProducto.Visible = false;
            this.tbPrecio.Visible = false;
            this.tbCantidad.Visible = false;

            this.btAniadir.Visible = false;
        }

        private void mostrar()
        {
            this.lbProducto.Visible = true;
            this.lbPrecio.Visible = true;
            this.lbCantidad.Visible = true;

            this.tbProducto.Visible = true;
            this.tbPrecio.Visible = true;
            this.tbCantidad.Visible = true;

            this.btAniadir.Visible = true;
        }

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            this.actualizarLista();
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            int n;
            if(!Int32.TryParse(tbCantidad.Text, out n))
            {
                if (tbCantidad.Text.Contains("-") && !tbCantidad.Text.Contains("--"))
                {

                }
                else
                    tbCantidad.Text = "";
            }
        }

        private void btAniadir_Click(object sender, EventArgs e)
        {
            lbAvisos2.Text = "";
            try
            {
                if (tbCantidad.Text != null && tbCantidad.Text != "")
                {
                    factura.add(seleccionado, Int32.Parse(tbCantidad.Text));

                    if (!gestor.suficienteCantidad(seleccionado.Nombre, Int32.Parse(tbCantidad.Text)))
                        lbAvisos2.Text = "AVISO: has incluido en la factura más del stock registrado.\nEl stock quedará en negativo si aceptas la factura.";

                    tbCantidad.Text = "";

                    esconder();
                    actualizarListaFactura();
                }
            }
            catch(FormatException ex)
            {
                tbCantidad.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirFactura impFact = new ImprimirFactura(factura);
            DialogResult d = impFact.ShowDialog();

            if(d == DialogResult.OK)
            {
                gestor.addFactura(factura);
                gestor.procesarFactura(factura);
                gestor.LogCrear(user, null, factura, null);
                gestor.imprimirFactura(factura);
                this.Dispose();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            factura = new Factura(user);
            lbAvisos2.Text = "";
            actualizarListaFactura();
        }

        private void NuevaFactura_Load(object sender, EventArgs e)
        {

        }
        private void actualizarOrdenacion()
        {
            inventarioOrdenado = inventario.ordenado();
        }

        private void lbFactura_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lbFactura.SelectedItem != null)
            {
                btQuitar.Visible = true;
            }
            else
            {
                btQuitar.Visible = false;
            }
        }

        private void btQuitar_Click(object sender, EventArgs e)
        {
            if(lbFactura.Items.Count > 0)
            {
                string name = factura.Contenido[lbFactura.SelectedIndex].Item1.Nombre;
                Item item = new Item(name, 1, 1, 1, 1);
                factura.remove(item);
            }
            
            actualizarLista();
            actualizarListaFactura();
        }

        private void tbFamilia_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!Int32.TryParse(tbFamilia.Text, out n))
                tbFamilia.Text = "";
            this.actualizarLista();
        }
    }
}
