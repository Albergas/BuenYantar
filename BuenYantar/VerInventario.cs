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
    public partial class VerInventario : Form
    {

        private Inventario inventario;
        private Collection<Item> inventarioOrdenado;
        private Item seleccionado;
        private Usuario user;

        public VerInventario(Inventario inventario, Usuario user)
        {
            InitializeComponent();
            this.inventario = inventario;
            this.inventarioOrdenado = this.inventario.ordenado();
            this.user = user;
            this.seleccionado = null;

            this.actualizarLista();

            this.btGuardar.Visible = false;
            this.btGuardarNuevo.Visible = false;

            this.actualizarDatos();

            if(this.user.Tipo != 0)
            {
                Controls.Remove(btEliminar);
                Controls.Remove(btModificar);
                Controls.Remove(btNuevo);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.btGuardar.Visible = false;
            this.btGuardarNuevo.Visible = false;

            this.btModificar.Enabled = true;
            this.btNuevo.Enabled = true;
            this.btEliminar.Enabled = true;

            if(this.lbInventario.SelectedItem == null)
            {
                seleccionado = null;
            }
            else
            {
                foreach(Item item in this.inventario.Items)
                {
                    if (item.Nombre.Equals(this.lbInventario.SelectedItem.ToString()))
                        seleccionado = item;
                }
            }
            this.actualizarDatos();
        }

        private void actualizarDatos()
        {
            this.tbNombre.ReadOnly = true;
            this.tbPrecio.ReadOnly = true;
            this.tbStock.ReadOnly = true;
            this.tbStockSeguridad.ReadOnly = true;
            this.tbCodigo.ReadOnly = true;

            this.lbAvisoReponer.Visible = false;

            this.btGuardar.Visible = false;
            this.btGuardarNuevo.Visible = false;

            if (seleccionado == null)
            {
                this.tbNombre.Text = "";
                this.tbStock.Text = "";
                this.tbStockSeguridad.Text = "";
                this.tbPrecio.Text = "";
                this.tbCodigo.Text = "";
            }
            else
            {
                this.tbNombre.Text = seleccionado.Nombre;
                this.tbStock.Text = seleccionado.Cantidad.ToString();
                this.tbStockSeguridad.Text = seleccionado.Seguridad.ToString();
                this.tbPrecio.Text = seleccionado.Precio.ToString();
                this.tbCodigo.Text = seleccionado.Codigo.ToString();

                if (seleccionado.Cantidad < seleccionado.Seguridad)
                    this.lbAvisoReponer.Visible = true;
            }
        }

        private void actualizarLista()
        {
            this.lbInventario.Items.Clear();
            actualizarOrdenacion();

            if (this.tbFiltrar.Text.Trim() != "")
            {
                if(tbFamilia.Text.Trim() != "")
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

        private void tbFiltrar_TextChanged(object sender, EventArgs e)
        {
            this.actualizarLista();
        }

        private void btStockBajo_Click(object sender, EventArgs e)
        {
            this.tbFiltrar.Text = "";
            this.lbInventario.Items.Clear();

            foreach (Item item in this.inventario.Items)
            {
                if (item.Cantidad < item.Seguridad)
                    this.lbInventario.Items.Add(item.Nombre);
            }
        }

        private void btTodos_Click(object sender, EventArgs e)
        {
            this.tbFiltrar.Text = "";
            this.lbInventario.Items.Clear();

            foreach (Item item in this.inventario.Items)
            {
                this.lbInventario.Items.Add(item.Nombre);
            }
        }

        private void btModificar_Click(object sender, EventArgs e)
        {
            this.tbNombre.ReadOnly = false;
            this.tbPrecio.ReadOnly = false;
            this.tbStock.ReadOnly = false;
            this.tbStockSeguridad.ReadOnly = false;
            this.tbCodigo.ReadOnly = false;

            this.btGuardar.Visible = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int cantidad, seguridad, codigo;
            double precio;
            string nombreViejo;

            arreglarPrecio();
            if (Int32.TryParse(tbStock.Text, out cantidad))
            {
                if(Int32.TryParse(tbStockSeguridad.Text, out seguridad))
                {
                    if(double.TryParse(tbPrecio.Text, out precio))
                    {
                        if (!tbNombre.Text.Contains('|'))
                        {
                            if (Int32.TryParse(tbCodigo.Text, out codigo))
                            {
                                nombreViejo = seleccionado.Nombre;
                                seleccionado.Nombre = tbNombre.Text;
                                seleccionado.Cantidad = cantidad;
                                seleccionado.Seguridad = seguridad;
                                seleccionado.Precio = precio;
                                seleccionado.Codigo = codigo;

                                MessageBox.Show("Cambios guardados");

                                inventario.modifyItem(seleccionado, nombreViejo);

                                this.tbNombre.ReadOnly = true;
                                this.tbStock.ReadOnly = true;
                                this.tbStockSeguridad.ReadOnly = true;
                                this.tbPrecio.ReadOnly = true;
                                this.tbCodigo.ReadOnly = true;

                                this.btGuardar.Visible = false;
                            }
                            else
                                MessageBox.Show("Error: código no válido");
                        }
                        else
                            MessageBox.Show("Error: el nombre del producto no puede contener '|'");
                    }
                    else
                    {
                        MessageBox.Show("Error: precio no válido");
                    }
                }
            }

            actualizarLista();
            actualizarDatos();
        }

        private void btStockMenos_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(tbStock.Text);
            if (n > 0)
            {
                n -= 1;
                tbStock.Text = n.ToString();
            }
        }

        private void btStockMas_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(tbStock.Text);
            n += 1;
            tbStock.Text = n.ToString();
        }

        private void btSeguridadMenos_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(tbStockSeguridad.Text);
            if (n > 0)
            {
                n -= 1;
                tbStockSeguridad.Text = n.ToString();
            }
        }

        private void btSeguridadMas_Click(object sender, EventArgs e)
        {
            int n = Int32.Parse(tbStockSeguridad.Text);
            n += 1;
            tbStockSeguridad.Text = n.ToString();
        }

        private void btNuevo_Click(object sender, EventArgs e)
        {
            this.lbInventario.SelectedItem = null;

            this.btModificar.Enabled = false;
            this.btEliminar.Enabled = false;

            this.tbNombre.ReadOnly = false;
            this.tbStock.ReadOnly = false;
            this.tbStockSeguridad.ReadOnly = false;
            this.tbPrecio.ReadOnly = false;
            this.tbCodigo.ReadOnly = false;

            this.tbNombre.Text = "";
            this.tbStock.Text = "";
            this.tbStockSeguridad.Text = "";
            this.tbPrecio.Text = "";
            this.tbCodigo.Text = "";

            this.btGuardarNuevo.Visible = true;
        }

        private void btGuardarNuevo_Click(object sender, EventArgs e)
        {

            int cantidad, seguridad, codigo;
            double precio;
            arreglarPrecio();

            if (Int32.TryParse(tbStock.Text, out cantidad))
            {
                if (Int32.TryParse(tbStockSeguridad.Text, out seguridad))
                {
                    if (double.TryParse(tbPrecio.Text, out precio))
                    {
                        if (!tbNombre.Text.Contains('|'))
                        {
                            if(Int32.TryParse(tbCodigo.Text, out codigo))
                            {
                                Item nuevoItem = new Item(tbNombre.Text, cantidad, precio, seguridad, codigo);

                                MessageBox.Show("Nuevo producto guardados");

                                inventario.addItem(nuevoItem);
                                inventario.getGestor().LogCrear(user, nuevoItem, null, null);

                                this.tbNombre.ReadOnly = true;
                                this.tbStock.ReadOnly = true;
                                this.tbStockSeguridad.ReadOnly = true;
                                this.tbPrecio.ReadOnly = true;
                                this.tbCodigo.ReadOnly = true;

                                this.btGuardar.Visible = false;
                                this.btGuardarNuevo.Visible = false;

                                this.actualizarLista();
                            }
                            else
                            {
                                MessageBox.Show("Error: codigo no válido");
                            }
                        }
                        else
                            MessageBox.Show("Error: el nombre del producto no puede contener '|'");
                    }
                    else
                    {
                        MessageBox.Show("Error: precio no válido");
                    }
                }
            }

            actualizarLista();
            actualizarDatos();
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            if(lbInventario.SelectedItem == null)
            {
                MessageBox.Show("Ningún producto seleccionado");
            }
            else
            {
                string aBorrar = lbInventario.SelectedItem.ToString();

                DialogResult result = MessageBox.Show("¿Seguro que quieres eliminar del registro el producto '" + aBorrar + "'?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    inventario.getGestor().LogEliminar(user, new Item(aBorrar,0,0,0,0), null, null);
                    this.inventario.removeItem(aBorrar);
                    this.actualizarLista();
                    MessageBox.Show("Se eliminó del registro el producto " + aBorrar);
                }
            }
        }

        private void tbStock_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!Int32.TryParse(tbStock.Text, out n))
                tbStock.Text = "";
        }

        private void tbStockSeguridad_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!Int32.TryParse(tbStockSeguridad.Text, out n))
                tbStockSeguridad.Text = "";
        }

        private void VerInventario_Load(object sender, EventArgs e)
        {

        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {
            double n;
            if(!double.TryParse(tbPrecio.Text, out n))
            {
                tbPrecio.Text = "";
            }
        }

        private void arreglarPrecio()
        {
            tbPrecio.Text = tbPrecio.Text.Replace(".", ",");
        }

        private void actualizarOrdenacion()
        {
            inventarioOrdenado = inventario.ordenado();
        }

        private void tbCodigo_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!Int32.TryParse(tbCodigo.Text, out n))
                tbCodigo.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!Int32.TryParse(tbFamilia.Text, out n))
                tbFamilia.Text = "";
            this.actualizarLista();
        }

        private void btImprimir_Click(object sender, EventArgs e)
        {
            string s = "==========================\n\nSTOCK SOCIEDAD BUEN YANTAR\n\nFecha: " + DateTime.Now.ToString() + "\n\n--------------------------\n\n";
            foreach(Item item in inventarioOrdenado)
            {
                if(item.Cantidad.ToString().Length == 1)
                    s += item.Cantidad + "  " + item.Nombre + "\n";
                else
                    s += item.Cantidad + " " + item.Nombre + "\n";
            }
            s += "\n==========================";

            Gestor gestor = new Gestor();
            gestor.imprimirTexto(s);
        }
    }
}
