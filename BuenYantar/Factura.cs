using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace BuenYantar
{
    public class Factura
    {
        private List<Tuple<Item, int>> contenido;
        private Usuario user;
        private DateTime date;

        public Factura(List<Tuple<Item, int>> contenido, Usuario user)
        {
            this.contenido = contenido;
            this.user = user;
            this.date = DateTime.Now;
        }

        public Factura(List<Tuple<Item, int>> contenido, Usuario user, DateTime fecha)
        {
            this.contenido = contenido;
            this.user = user;
            this.date = fecha;
        }

        public Factura(Usuario user)
        {
            this.contenido = new List<Tuple<Item, int>>();
            this.user = user;
            this.date = DateTime.Now;
        }

        public Factura(Usuario user, DateTime fecha)
        {
            this.contenido = new List<Tuple<Item, int>>();
            this.user = user;
            this.date = DateTime.Now;
            this.date = fecha;
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
            DateTime localDate = DateTime.Now;
            DateTime utcDate = DateTime.UtcNow;
            double precItem;

            string s = "=======================================\n\n FACTURA SOCIEDAD BUEN YANTAR\n\nSocio: " + user.NombreCompleto
                + "\n\nFecha: " + DateTime.Now.ToString() + "\n\n---------------------------------------\n\n";

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
            string s = user.Nombre + "|" + date.ToShortDateString() + "|" + cantidadProductos();

            foreach(Tuple<Item,int> elemento in contenido)
            {
                s += "|" + elemento.Item1.Nombre + "|" + elemento.Item1.Precio + "|" + elemento.Item2;
            }

            return s;
        }
    }
}
