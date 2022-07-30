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
    public partial class HistorialFacturasTodas : Form
    {
        private Gestor gestor;
        private Usuario user;
        private Collection<Factura> facturas;
        private Collection<Factura> facturasMostradas;
        private bool variasMostradas;

        public HistorialFacturasTodas(Gestor gestor, Usuario user)
        {
            this.gestor = gestor;
            this.user = user;
            this.variasMostradas = false;
            InitializeComponent();

            this.facturas = gestor.facturas();
            this.facturasMostradas = new Collection<Factura>();

            btEliminar.Visible = false;

            actualizarLista();
        }

        private void actualizarLista()
        {
            facturasMostradas.Clear();

            lbFacturas.Items.Clear();
            string s;
            Collection<String> facturasDesorden = new Collection<string>();

            if(tbSocio.Text != null && tbSocio.Text != "")
            {
                if (tbDia.Text != null && tbDia.Text != "")
                {
                    int dia = Int32.Parse(tbDia.Text);

                    if (tbMes.Text != null && tbMes.Text != "")
                    {
                        int mes = Int32.Parse(tbMes.Text);

                        if (tbAno.Text != null && tbAno.Text != "")
                        {
                            int ano = Int32.Parse(tbAno.Text);

                            foreach (Factura factura in facturas)
                            {
                                if (factura.NombreSocio.ToUpper().Contains(tbSocio.Text.ToUpper()) && factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Month.ToString().Contains(mes.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                        else
                        {
                            foreach (Factura factura in facturas)
                            {
                                if (factura.NombreSocio.ToUpper().Contains(tbSocio.Text.ToUpper()) && factura.Date.Month.ToString().Contains(mes.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (tbAno.Text != null && tbAno.Text != "")
                        {
                            int ano = Int32.Parse(tbAno.Text);

                            foreach (Factura factura in facturas)
                            {
                                if (factura.NombreSocio.ToUpper().Contains(tbSocio.Text.ToUpper()) && factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                        else
                        {
                            foreach (Factura factura in facturas)
                            {
                                if (factura.NombreSocio.ToUpper().Contains(tbSocio.Text.ToUpper()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (tbMes.Text != null && tbMes.Text != "")
                    {
                        int mes = Int32.Parse(tbMes.Text);

                        if (tbAno.Text != null && tbAno.Text != "")
                        {
                            int ano = Int32.Parse(tbAno.Text);

                            foreach (Factura factura in facturas)
                            {
                                if (factura.NombreSocio.ToUpper().Contains(tbSocio.Text.ToUpper()) && factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Month.ToString().Contains(mes.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                        else
                        {
                            foreach (Factura factura in facturas)
                            {
                                if (factura.NombreSocio.ToUpper().Contains(tbSocio.Text.ToUpper()) && factura.Date.Month.ToString().Contains(mes.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (tbAno.Text != null && tbAno.Text != "")
                        {
                            int ano = Int32.Parse(tbAno.Text);

                            foreach (Factura factura in facturas)
                            {
                                if (factura.NombreSocio.ToUpper().Contains(tbSocio.Text.ToUpper()) && factura.Date.Year.ToString().Contains(ano.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                        else
                        {
                            foreach (Factura factura in facturas)
                            {
                                if(factura.NombreSocio.ToUpper().Contains(tbSocio.Text.ToUpper()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                if (tbDia.Text != null && tbDia.Text != "")
                {
                    int dia = Int32.Parse(tbDia.Text);

                    if (tbMes.Text != null && tbMes.Text != "")
                    {
                        int mes = Int32.Parse(tbMes.Text);

                        if (tbAno.Text != null && tbAno.Text != "")
                        {
                            int ano = Int32.Parse(tbAno.Text);

                            foreach (Factura factura in facturas)
                            {

                                if (factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Month.ToString().Contains(mes.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                        else
                        {
                            foreach (Factura factura in facturas)
                            {
                                if (factura.Date.Month.ToString().Contains(mes.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (tbAno.Text != null && tbAno.Text != "")
                        {
                            int ano = Int32.Parse(tbAno.Text);

                            foreach (Factura factura in facturas)
                            {
                                if (factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                        else
                        {
                            foreach (Factura factura in facturas)
                            {
                                if (factura.Date.Day.ToString().Contains(dia.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (tbMes.Text != null && tbMes.Text != "")
                    {
                        int mes = Int32.Parse(tbMes.Text);

                        if (tbAno.Text != null && tbAno.Text != "")
                        {
                            int ano = Int32.Parse(tbAno.Text);

                            foreach (Factura factura in facturas)
                            {
                                if (factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Month.ToString().Contains(mes.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                        else
                        {
                            foreach (Factura factura in facturas)
                            {
                                if (factura.Date.Month.ToString().Contains(mes.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                    }
                    else
                    {
                        if (tbAno.Text != null && tbAno.Text != "")
                        {
                            int ano = Int32.Parse(tbAno.Text);

                            foreach (Factura factura in facturas)
                            {
                                if (factura.Date.Year.ToString().Contains(ano.ToString()))
                                {
                                    s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                    facturasDesorden.Add(s);
                                    facturasMostradas.Add(factura);
                                }
                            }
                        }
                        else
                        {
                            foreach (Factura factura in facturas)
                            {
                                s = factura.NombreSocio + ", " + factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                facturasDesorden.Add(s);
                                facturasMostradas.Add(factura);
                            }
                        }
                    }
                }
            }

            for (int i = 0; i < facturasDesorden.Count; i++)
            {
                lbFacturas.Items.Add(facturasDesorden[facturasDesorden.Count - i - 1]);
            }
        }

        private void HistorialFacturas_Load(object sender, EventArgs e)
        {

        }

        private void lbFacturas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbFacturas.SelectedItem != null)
            {
                this.variasMostradas = false;
                rtbFactura.Text = facturasMostradas[lbFacturas.Items.Count - lbFacturas.SelectedIndex - 1].logSinHora();
                btEliminar.Visible = true;
            }
            else
            {
                rtbFactura.Text = "";
                btEliminar.Visible = false;
            }
        }

        private void tbDia_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!Int32.TryParse(tbDia.Text, out n))
                tbDia.Text = "";
            actualizarLista();
        }

        private void tbMes_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!Int32.TryParse(tbMes.Text, out n))
                tbMes.Text = "";
            actualizarLista();
        }

        private void tbAno_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (!Int32.TryParse(tbAno.Text, out n))
                tbAno.Text = "";
            actualizarLista();
        }

        private void tbSocio_TextChanged(object sender, EventArgs e)
        {
            actualizarLista();
        }

        private void HistorialFacturasTodas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(lbFacturas.Items.Count > 0)
            {
                rtbFactura.Text = Factura.logMerge(facturasMostradas);
                this.variasMostradas = true;
            }
        }

        private void btEliminar_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("¿Seguro que desea eliminar la factura seleccionada?", "Confirmar eliminación", MessageBoxButtons.YesNo);
            if(d == DialogResult.Yes)
            {
                MessageBox.Show("Se eliminó la siguiente factura:\n" + facturasMostradas[facturasMostradas.Count - lbFacturas.SelectedIndex - 1].logSinHora());
                gestor.LogEliminar(user, null, facturasMostradas[facturasMostradas.Count - lbFacturas.SelectedIndex - 1], null);
                gestor.removeFactura(facturasMostradas[facturasMostradas.Count - lbFacturas.SelectedIndex - 1]);
                facturas.Remove(facturasMostradas[facturasMostradas.Count - lbFacturas.SelectedIndex - 1]);
                facturasMostradas.Remove(facturasMostradas[facturasMostradas.Count - lbFacturas.SelectedIndex - 1]);
            }
            actualizarLista();
        }

        private void btConcatenar_Click(object sender, EventArgs e)
        {
            if(facturasMostradas.Count > 0)
            {
                rtbFactura.Text = Factura.logUnaAUna(facturasMostradas);
                this.variasMostradas = true;
            }
            else
            {
                rtbFactura.Text = "";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if(rtbFactura.Text != null && rtbFactura.Text != "")
            {
                gestor.imprimirTexto(rtbFactura.Text);
            }
        }
    }
}
