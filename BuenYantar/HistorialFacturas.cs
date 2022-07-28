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
        private Collection<Factura> facturasMostradas;
        private Usuario user;

        public HistorialFacturas(Gestor gestor, Usuario user)
        {
            this.gestor = gestor;
            this.user = user;
            InitializeComponent();

            this.facturas = gestor.facturas();
            this.facturasMostradas = new Collection<Factura>();

            actualizarLista();
        }

        private Collection<Factura> misFacturas()
        {
            Collection<Factura> misFacturas = new Collection<Factura>();

            foreach(Factura factura in facturas)
            {
                if (factura.User != null && factura.User.Nombre.Equals(user.Nombre))
                {
                    misFacturas.Add(factura);
                }
            }

            return misFacturas;
        }

        private void actualizarLista()
        {
            facturasMostradas.Clear();

            lbFacturas.Items.Clear();
            string s;
            Collection<String> facturasDesorden = new Collection<string>();

            if(tbDia.Text != null && tbDia.Text != "")
            {
                int dia = Int32.Parse(tbDia.Text);

                if(tbMes.Text != null && tbMes.Text != "")
                {
                    int mes = Int32.Parse(tbMes.Text);

                    if (tbAno.Text != null && tbAno.Text != "")
                    {
                        int ano = Int32.Parse(tbAno.Text);

                        foreach (Factura factura in misFacturas())
                        {
                            if (factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Month.ToString().Contains(mes.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                            {
                                s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                facturasDesorden.Add(s);
                                facturasMostradas.Add(factura);
                            }
                        }
                    }
                    else
                    {
                        foreach (Factura factura in misFacturas())
                        {
                            if (factura.Date.Month.ToString().Contains(mes.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                            {
                                s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
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

                        foreach (Factura factura in misFacturas())
                        {
                            if (factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Day.ToString().Contains(dia.ToString()))
                            {
                                s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                facturasDesorden.Add(s);
                                facturasMostradas.Add(factura);
                            }
                        }
                    }
                    else
                    {
                        foreach (Factura factura in misFacturas())
                        {
                            if (factura.Date.Day.ToString().Contains(dia.ToString()))
                            {
                                s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
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

                        foreach (Factura factura in misFacturas())
                        {
                            if (factura.Date.Year.ToString().Contains(ano.ToString()) && factura.Date.Month.ToString().Contains(mes.ToString()))
                            {
                                s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                facturasDesorden.Add(s);
                                facturasMostradas.Add(factura);
                            }
                        }
                    }
                    else
                    {
                        foreach (Factura factura in misFacturas())
                        {
                            if (factura.Date.Month.ToString().Contains(mes.ToString()))
                            {
                                s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
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

                        foreach (Factura factura in misFacturas())
                        {
                            if (factura.Date.Year.ToString().Contains(ano.ToString()))
                            {
                                s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                                facturasDesorden.Add(s);
                                facturasMostradas.Add(factura);
                            }
                        }
                    }
                    else
                    {
                        foreach (Factura factura in misFacturas())
                        {
                            s = factura.Date.ToShortDateString() + " (" + factura.precioTotal() + "€)";
                            facturasDesorden.Add(s);
                            facturasMostradas.Add(factura);
                        }
                    }
                }
            }

            for(int i = 0; i < facturasDesorden.Count; i++)
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
                rtbFactura.Text = facturasMostradas[lbFacturas.Items.Count - lbFacturas.SelectedIndex - 1].logSinHora();
            else
                rtbFactura.Text = "";
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
    }
}
