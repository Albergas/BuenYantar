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
    public partial class VerInventario : Form
    {

        private Inventario inventario;
        private Item seleccionado;

        public VerInventario(Inventario inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
            this.seleccionado = null;

            foreach(Item item in this.inventario.Items)
            {
                this.lbInventario.Items.Add(item.Nombre);
            }

            this.tbStock.ReadOnly = true;
            this.tbStockSeguridad.ReadOnly = true;

            this.btGuardar.Visible = false;
            this.btGuardarNuevo.Visible = false;

            this.actualizarDatos();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
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

            this.lbAvisoReponer.Visible = false;

            this.btStockMenos.Visible = false;
            this.btStockMas.Visible = false;
            this.btSeguridadMenos.Visible = false;
            this.btSeguridadMas.Visible = false;

            this.btGuardar.Visible = false;
            this.btGuardarNuevo.Visible = false;

            if (seleccionado == null)
            {
                this.tbNombre.Text = "";
                this.tbStock.Text = "";
                this.tbStockSeguridad.Text = "";
                this.tbPrecio.Text = "";
            }
            else
            {
                this.tbNombre.Text = seleccionado.Nombre;
                this.tbStock.Text = seleccionado.Cantidad.ToString();
                this.tbStockSeguridad.Text = seleccionado.Seguridad.ToString();
                this.tbPrecio.Text = seleccionado.Precio.ToString();

                if (seleccionado.Cantidad < seleccionado.Seguridad)
                    this.lbAvisoReponer.Visible = true;
            }
        }

        private void actualizarLista()
        {
            this.lbInventario.Items.Clear();

            if (this.tbFiltrar.Text.Trim() != "")
            {
                foreach (Item item in this.inventario.Items)
                {
                    if(item.Nombre.Contains(this.tbFiltrar.Text))
                        this.lbInventario.Items.Add(item.Nombre);
                }
            }
            else
            {
                foreach (Item item in this.inventario.Items)
                {
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

            this.btStockMenos.Visible = true;
            this.btStockMas.Visible = true;
            this.btSeguridadMenos.Visible = true;
            this.btSeguridadMas.Visible = true;

            this.btGuardar.Visible = true;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            int cantidad, seguridad;
            double precio;
            if(Int32.TryParse(tbStock.Text, out cantidad))
            {
                if(Int32.TryParse(tbStockSeguridad.Text, out seguridad))
                {
                    if(double.TryParse(tbPrecio.Text, out precio))
                    {
                        if (!tbNombre.Text.Contains('|'))
                        {
                            seleccionado.Nombre = tbNombre.Text;
                            seleccionado.Cantidad = cantidad;
                            seleccionado.Seguridad = seguridad;
                            seleccionado.Precio = precio;

                            MessageBox.Show("Cambios guardados");

                            inventario.modifyItem(seleccionado);

                            this.tbNombre.ReadOnly = true;
                            this.tbStock.ReadOnly = true;
                            this.tbStockSeguridad.ReadOnly = true;
                            this.tbPrecio.ReadOnly = true;

                            this.btStockMenos.Visible = false;
                            this.btStockMas.Visible = false;
                            this.btSeguridadMenos.Visible = false;
                            this.btSeguridadMas.Visible = false;

                            this.btGuardar.Visible = false;
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

            // MessageBox.Show("Datos no válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            this.btModificar.Enabled = false;
            this.btEliminar.Enabled = false;

            this.tbNombre.ReadOnly = false;
            this.tbStock.ReadOnly = false;
            this.tbStock.ReadOnly = false;
            this.tbPrecio.ReadOnly = false;

            this.btGuardarNuevo.Visible = true;
        }

        private void btGuardarNuevo_Click(object sender, EventArgs e)
        {
            this.btGuardarNuevo.Visible = false;
        }
    }
}
