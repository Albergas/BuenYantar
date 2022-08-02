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

        public bool contiene(Tuple<Item,int> tupla)
        {
            foreach(Tuple<Item,int> elem in contenido)
            {
                if(elem.Item1.Nombre.Equals(tupla.Item1.Nombre) && elem.Item1.Precio == tupla.Item1.Precio && elem.Item2 == tupla.Item2)
                {
                    return true;
                }
            }
            return false;
        }

        private static string logTuple(Tuple<Item, int> item)
        {
            double precItem;
            char[] temp = new char[26];
            string tempString;
            char[] cant;
            char[] nombre;
            char[] precioTemp;
            char[] precio;
            int corrector;

            precItem = item.Item2 * item.Item1.Precio;
            for (int i = 0; i < 26; i++)
            {
                temp[i] = ' ';
            }
            nombre = item.Item1.Nombre.ToCharArray();
            cant = item.Item2.ToString().ToCharArray();
            precioTemp = (item.Item1.Precio * item.Item2).ToString().ToCharArray();
            precio = completarDecimales(precioTemp);

            for (int i = 0; i < cant.Length; i++)
                temp[i] = cant[i];

            if (cant.Length < 3)
                corrector = 3;
            else
                corrector = cant.Length + 1;

            for (int i = 0; i < 16 && i < nombre.Length; i++)
                temp[i + corrector] = nombre[i];

            temp[26 - precio.Length - 1] = ' ';
            for (int i = 0; i < precio.Length; i++)
                temp[i + 26 - precio.Length] = precio[i];

            tempString = new string(temp);

            return tempString;
        }

        public string log()
        {

            string s = "==========================\n\nFRA. SOCIEDAD BUEN YANTAR\n\nSocio: " + nombreSocio
                + "\n\nFecha: " + date.ToString() + "\n\n--------------------------\n\n";

            foreach (Tuple<Item, int> item in contenido)
            {
                s += logTuple(item) + "\n";
            }

            s += "\nTOTAL: " + precioTotal() + "€\n\n==========================";
            
            return s;
        }

        public string logSinHora()
        {

            string s = "==========================\n\nFRA. SOCIEDAD BUEN YANTAR\n\nSocio: " + nombreSocio
                + "\n\nFecha: " + date.ToShortDateString() + "\n\n--------------------------\n\n";

            foreach (Tuple<Item, int> item in contenido)
            {
                s += logTuple(item) + "\n";
            }

            s += "\nTOTAL: " + precioTotal() + "€\n\n==========================";

            return s;
        }

        public string logBD()
        {
            string s = "";
            if (user != null)
                s += user.Nombre + "|" + nombreSocio + "|" + date.ToShortDateString() + "|" + cantidadProductos();
            else
                s += "null|" + nombreSocio + "|" + date.ToShortDateString() + "|" + cantidadProductos();

            foreach (Tuple<Item,int> elemento in contenido)
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

            Collection<string> socios = new Collection<string>();

            foreach(Factura factura in facturas)
            {
                if (!socios.Contains(factura.nombreSocio))
                    socios.Add(factura.nombreSocio);
            }

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

            string s = "==========================\n\nFRA. SOCIEDAD BUEN YANTAR\n\n"
                + "\n  Resumen de: " + facturas.Count + " facturas\n\n";
            s += "Socios:\n";
            foreach (string socio in socios)
                s += "  " + socio +"\n";
            s += "\n" + bajo.ToShortDateString() + " - " + alto.ToShortDateString() + "\n\n--------------------------\n\n";

            foreach (Tuple<Item, int> item in facturaMerged.contenido)
            {
                s += logTuple(item) + "\n";
            }

            s += "\nTOTAL: " + facturaMerged.precioTotal() + "€\n\n==========================";

            return s;
        }

        public static string logUnaAUna(Collection<Factura> facturas)
        {
            string s = "";
            foreach(Factura factura in facturas)
            {
                s += factura.logSinHora() + "\n";
            }
            return s;
        }

        public static bool IgualesSinUser(Factura f1, Factura f2)
        {
            bool contenidoIgual = true;
            foreach(Tuple<Item,int> tupla in f1.contenido)
            {
                if (!f2.contiene(tupla))
                    contenidoIgual = false;
            }
            Console.WriteLine(contenidoIgual);
            Console.WriteLine(f1.nombreSocio.Equals(f2.nombreSocio));
            Console.WriteLine(f1.date.Equals(f2.date));
            return (contenidoIgual && f1.nombreSocio.Equals(f2.nombreSocio) && f1.date.Equals(f2.date));
        }

        public string itemsCantidadesSeguidos()
        {
            string s = "";
            foreach(Tuple<Item,int> tupla in contenido)
            {
                s += tupla.Item1.Nombre + tupla.Item1.Precio + tupla.Item2;
            }
            return s.Replace(" ", "");
        }

        public string nombreTxt()
        {
            string s = (nombreSocio + date.ToShortDateString().Replace(@"/", "-") + itemsCantidadesSeguidos()).Replace(" ", "");
            if(s.Length > 210)
            {
                s = s.Substring(0, 200);
            }
            return s;
        }

        private static char[] completarDecimales(char[] precio)
        {
            char[] decimales = new char[2] { '0', '0' };
            char[] enteros = new char[3];
            char[] nuevo;
            int pos = 0;

            pos = precio.Length;
            for (int i = 0; i < precio.Length; i++)
                if (precio[i] == ',')
                    pos = i;

            nuevo = new char[pos + 3];

            for (int i = 0; i < nuevo.Length; i++)
                nuevo[i] = ' ';

            nuevo[nuevo.Length - 3] = ',';

            enteros = new char[pos];

            for (int i = 0; i < enteros.Length; i++)
                enteros[i] = ' ';

            for (int i = 0; i < pos; i++)
                enteros[enteros.Length - 1 - i] = precio[pos - 1 - i];

            for (int i = 0; i < precio.Length - pos - 1; i++)
                decimales[i] = precio[i + pos + 1];

            for (int i = 0; i < enteros.Length; i++)
                nuevo[enteros.Length - 1 - i] = enteros[enteros.Length - 1 - i];

            for (int i = 0; i < decimales.Length; i++)
                nuevo[enteros.Length + 1 + i] = decimales[i];

            return nuevo;
        }
    }
}
