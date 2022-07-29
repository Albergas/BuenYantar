using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Collections.ObjectModel;

namespace BuenYantar
{
    public class Factura
    {
        private List<Tuple<Item, int>> contenido;
        private Usuario user;
        private DateTime date;
        private string nombreSocio;

        public Factura(List<Tuple<Item, int>> contenido, Usuario user)
        {
            this.contenido = contenido;
            this.user = user;
            this.date = DateTime.Now;
            this.nombreSocio = user.NombreCompleto;
        }

        public string NombreSocio
        {
            get
            {
                return nombreSocio;
            }
        }

        public Factura(List<Tuple<Item, int>> contenido, Usuario user, DateTime fecha)
        {
            this.contenido = contenido;
            this.user = user;
            this.date = fecha;
            this.nombreSocio = user.NombreCompleto;
        }

        public Usuario User
        {
            get
            {
                return user;
            }
        }

        public Factura(Usuario user)
        {
            this.contenido = new List<Tuple<Item, int>>();
            this.user = user;
            this.date = DateTime.Now;
            this.nombreSocio = user.NombreCompleto;
        }

        public Factura(Usuario user, DateTime fecha)
        {
            this.contenido = new List<Tuple<Item, int>>();
            this.user = user;
            this.date = DateTime.Now;
            this.date = fecha;
            this.nombreSocio = user.NombreCompleto;
        }

        public Factura(Usuario user, DateTime fecha, string nombreSocio)
        {
            this.contenido = new List<Tuple<Item, int>>();
            this.user = user;
            this.date = DateTime.Now;
            this.date = fecha;
            this.nombreSocio = nombreSocio;
        }

        public List<Tuple<Item, int>> Contenido
        {
            get
            {
                return contenido;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }
        }

        public double precioTotal()
        {
            double precio = 0;
            foreach(Tuple<Item, int> item in contenido)
            {
                precio += item.Item1.Precio * item.Item2;
            }
            return precio;
        }

        public int cantidadProductos()
        {
            return contenido.Count;
        }

        public bool add(Item item, int cantidad)
        {
            foreach(Tuple<Item, int> elemento in contenido)
            {
                if (elemento.Item1.Nombre.Equals(item.Nombre))
                {
                    int n = elemento.Item2 + cantidad;
                    contenido.Remove(elemento);
                    contenido.Add(new Tuple<Item,int>(item, n));
                    return true;
                }
            }
            contenido.Add(new Tuple<Item, int>(item, cantidad));
            return true;
        }

        public string log()
        {
            double precItem;

            string s = "=======================================\n\n FACTURA SOCIEDAD BUEN YANTAR\n\nSocio: " + nombreSocio
                + "\n\nFecha: " + date.ToString() + "\n\n---------------------------------------\n\n";

            foreach (Tuple<Item, int> item in contenido)
            {
                precItem = item.Item2 * item.Item1.Precio;
                s += item.Item2 + " " + item.Item1.Nombre + " (" + item.Item2 + " x " + item.Item1.Precio + " = " + precItem + ")\n";
            }

            s += "\nTOTAL: " + precioTotal() + "€\n\n=======================================";
            
            return s;
        }

        public string logSinHora()
        {
            double precItem;

            string s = "=======================================\n\n FACTURA SOCIEDAD BUEN YANTAR\n\nSocio: " + nombreSocio
                + "\n\nFecha: " + date.ToShortDateString() + "\n\n---------------------------------------\n\n";

            foreach (Tuple<Item, int> item in contenido)
            {
                precItem = item.Item2 * item.Item1.Precio;
                s += item.Item2 + " " + item.Item1.Nombre + " (" + item.Item2 + " x " + item.Item1.Precio + " = " + precItem + ")\n";
            }

            s += "\nTOTAL: " + precioTotal() + "€\n\n=======================================";

            return s;
        }

        public string logBD()
        {
            string s = user.Nombre + "|" + nombreSocio + "|" + date.ToShortDateString() + "|" + cantidadProductos();

            foreach(Tuple<Item,int> elemento in contenido)
            {
                s += "|" + elemento.Item1.Nombre + "|" + elemento.Item1.Precio + "|" + elemento.Item2;
            }

            return s;
        }

        public static string logMerge(Collection<Factura> facturas)
        {
            DateTime bajo;
            DateTime alto;

            bajo = facturas[0].date;
            alto = facturas[0].date;

            Factura facturaMerged = new Factura(null, new DateTime(1), "");
            foreach(Factura f in facturas)
            {
                if (DateTime.Compare(bajo, f.date) > 0)
                    bajo = f.date;
                if (DateTime.Compare(alto, f.date) < 0)
                    alto = f.date;

                foreach(Tuple<Item,int> elem in f.contenido)
                {
                    facturaMerged.add(elem.Item1, elem.Item2);
                }
            }

            double precItem;

            string s = "=======================================\n\n RESUMEN FACTURAS SOCIEDAD BUEN YANTAR\n\n"
                + "\n\n  Resumen de: " + facturas.Count + " facturas\n\n  Del " + bajo.ToShortDateString() + " al " + alto.ToShortDateString() + "\n\n---------------------------------------\n\n";

            foreach (Tuple<Item, int> item in facturaMerged.contenido)
            {
                precItem = item.Item2 * item.Item1.Precio;
                s += item.Item2 + " " + item.Item1.Nombre + " (" + item.Item2 + " x " + item.Item1.Precio + " = " + precItem + ")\n";
            }

            s += "\nTOTAL: " + facturaMerged.precioTotal() + "€\n\n=======================================";

            return s;
        }
    }
}
