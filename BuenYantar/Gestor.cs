using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;
using System.Drawing.Printing;
using System.Drawing;

namespace BuenYantar
{
    public class Gestor
    {
        private string rutaBase;
        private string rutaInventario;
        private string rutaInventarioCopiaSeguridad;
        private string rutaUsuarios;
        private string rutaUsuariosCopiaSeguridad;
        private string rutaFacturas;
        private string rutaFacturasCopiaSeguridad;
        private string rutaLog;
        private string rutaCarpetaFacturasBase;

        private Font lucidaConsole8Font;
        private StreamReader reader;

        public Gestor()
        {
            /*
            this.rutaInventario = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\buenyantarinventario.txt";
            this.rutaUsuarios = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\buenyantarusuarios.txt";
            this.rutaFacturas = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\buenyantarfacturas.txt";

            this.rutaInventarioCopiaSeguridad = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\backup\buenyantarinventariobackup.txt";
            this.rutaUsuariosCopiaSeguridad = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\backup\buenyantarusuariosbackup.txt";
            this.rutaFacturasCopiaSeguridad = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\backup\buenyantarfacturasbackup.txt";
            */

            lucidaConsole8Font = new Font("Lucida Console", 8);

            this.rutaBase = @"C:\BuenYantarBD\";

            this.rutaInventario = rutaBase + @"buenyantarinventario.txt";
            this.rutaUsuarios = rutaBase + @"buenyantarusuarios.txt";
            this.rutaFacturas = rutaBase + @"buenyantarfacturas.txt";

            this.rutaInventarioCopiaSeguridad = rutaBase + @"backup\buenyantarinventariobackup.txt";
            this.rutaUsuariosCopiaSeguridad = rutaBase + @"backup\buenyantarusuariosbackup.txt";
            this.rutaFacturasCopiaSeguridad = rutaBase + @"backup\buenyantarfacturasbackup.txt";

            this.rutaLog = rutaBase + @"backup\log.txt";

            this.rutaCarpetaFacturasBase = rutaBase + @"facturas\";
        }

        // ====================================================================================
        // GESTION INVENTARIO

        public Item StringToItem(string line)
        {
            string[] datos = line.Split('|');

            int cantidad = Int32.Parse(datos[1]);
            double precio = double.Parse(datos[2]);
            int seguridad = Int32.Parse(datos[3]);
            int codigo = Int32.Parse(datos[4]);

            return new Item(datos[0], cantidad, precio, seguridad, codigo);
        }

        public string ItemToString(Item item)
        {
            string s = item.Nombre + "|" + item.Cantidad + "|" + item.Precio + "|" + item.Seguridad + "|" + item.Codigo;
            return s;
        }

        public bool suficienteCantidad(string nombre, int n)
        {
            foreach(Item item in items())
            {
                if (item.Nombre.Equals(nombre))
                {
                    return item.Cantidad >= n;
                }
            }
            return false;
        }

        public Collection<Item> items()
        {
            Collection<String> lineas = new Collection<string>();
            Collection<Item> items = new Collection<Item>();
            Item item;

            foreach (string line in System.IO.File.ReadLines(rutaInventario))
            {
                lineas.Add(line);
                item = this.StringToItem(line);
                items.Add(item);
            }

            return items;
        }

        public void addItem(Item item)
        {
            string nuevo = ItemToString(item);

            StreamWriter sw = File.AppendText(rutaInventario);
            sw.WriteLine(nuevo);
            sw.Close();

            StreamWriter swBackup = File.AppendText(rutaInventarioCopiaSeguridad);
            swBackup.WriteLine(nuevo);
            swBackup.Close();
        }

        public void removeItem(string nombre)
        {
            string[] lineas = new string[1000];
            int i = 0;
            int j = 0;

            foreach (string line in System.IO.File.ReadLines(rutaInventario))
            {
                lineas[i] = line;
                i++;
            }

            StreamWriter sw = new StreamWriter(rutaInventario);
            Item item;

            while (j <= i)
            {
                if(lineas[j]!= "" && lineas[j] != null)
                {
                    item = StringToItem(lineas[j]);
                    if (!item.Nombre.Equals(nombre))
                        sw.WriteLine(lineas[j]);
                }
                j++;
            }

            sw.Close();
        }

        public void modifyItem(Item item, string nombreViejo)
        {
            this.removeItem(nombreViejo);
            this.addItem(item);
        }

        // ====================================================================================
        // GESTION USUARIOS

        public Usuario StringToUsuario(string line)
        {
            string[] datos = line.Split('|');
            int tipo = Int32.Parse(datos[2]);
            return new Usuario(datos[0], datos[1], tipo, datos[3]);
        }

        public string UsuarioToString(Usuario user)
        {
            string s = user.Nombre + "|" + user.Hash + "|" + user.Tipo + "|" + user.NombreCompleto;
            return s;
        }

        public Usuario construirUsuario(string nombre)
        {
            Usuario user;
            if (nombre.Equals("null"))
                return null;

            foreach (string line in System.IO.File.ReadLines(rutaUsuarios))
            {
                user = StringToUsuario(line);
                if (nombre.Equals(user.Nombre))
                    return user;
            }

            return null;
        }

        public Usuario construirUsuarioNombreCompleto(string nombre)
        {
            Usuario user;
            foreach (string line in System.IO.File.ReadLines(rutaUsuarios))
            {
                user = StringToUsuario(line);
                if (nombre.Equals(user.NombreCompleto))
                    return user;
            }

            return null;
        }

        public Usuario login(string nombre, string password)
        {
            Usuario user = construirUsuario(nombre);
            if(user != null)
            {
                if(Passwords.check(password, user.Hash))
                {
                    return user;
                }
                return null;
            }
            return null;
        }

        public void addUser(Usuario user)
        {
            string nuevo = UsuarioToString(user);
            StreamWriter sw = File.AppendText(rutaUsuarios);
            sw.WriteLine(nuevo);
            sw.Close();

            StreamWriter swBackup = File.AppendText(rutaUsuariosCopiaSeguridad);
            swBackup.WriteLine(nuevo);
            swBackup.Close();
        }

        public void removeUser(string nombre)
        {
            string[] lineas = new string[1000];
            int i = 0;
            int j = 0;

            foreach (string line in System.IO.File.ReadLines(rutaUsuarios))
            {
                lineas[i] = line;
                i++;
            }

            StreamWriter sw = new StreamWriter(rutaUsuarios);
            Usuario user;

            while (j <= i)
            {
                if (lineas[j] != "" && lineas[j] != null)
                {
                    user = StringToUsuario(lineas[j]);
                    if (!user.Nombre.Equals(nombre))
                        sw.WriteLine(lineas[j]);
                }
                j++;
            }

            sw.Close();
        }

        public void removeUserNC(string nombre)
        {
            string[] lineas = new string[1000];
            int i = 0;
            int j = 0;

            foreach (string line in System.IO.File.ReadLines(rutaUsuarios))
            {
                lineas[i] = line;
                i++;
            }

            StreamWriter sw = new StreamWriter(rutaUsuarios);
            Usuario user;

            while (j <= i)
            {
                if (lineas[j] != "" && lineas[j] != null)
                {
                    user = StringToUsuario(lineas[j]);
                    if (!user.NombreCompleto.Equals(nombre))
                        sw.WriteLine(lineas[j]);
                }
                j++;
            }

            sw.Close();
        }

        public void modifyUser(Usuario user)
        {
            this.removeUser(user.Nombre);
            this.addUser(user);
        }

        public void modifyUserNC(Usuario user)
        {
            this.removeUserNC(user.NombreCompleto);
            this.addUser(user);
        }

        public Collection<Usuario> usuarios()
        {
            Collection<Usuario> users = new Collection<Usuario>();
            Usuario user;

            foreach (string line in System.IO.File.ReadLines(rutaUsuarios))
            {
                user = this.StringToUsuario(line);
                users.Add(user);
            }

            return users;
        }

        // ====================================================================================
        // GESTION FACTURAS

        public Factura StringToFactura(string s)
        {
            string[] datos = s.Split('|');
            Usuario user = construirUsuario(datos[0]);
            string nombreSocio = datos[1];
            DateTime date = Convert.ToDateTime(datos[2]);
            int cant = Int32.Parse(datos[3]);

            Factura factura = new Factura(user, date, nombreSocio);

            Item item;
            int cantidad;

            int i = 4;

            for(int j = 0; j < cant; j++)
            {
                item = new Item(datos[i], 1000, double.Parse(datos[i+1]), 10, 1);
                cantidad = Int32.Parse(datos[i+2]);
                factura.add(item, cantidad);
                i += 3;
            }

            return factura;
        }

        public void addFactura(Factura factura)
        {
            string nuevo = factura.logBD();

            StreamWriter sw = File.AppendText(rutaFacturas);
            sw.WriteLine(nuevo);
            sw.Close();

            StreamWriter swBackup = File.AppendText(rutaFacturasCopiaSeguridad);
            swBackup.WriteLine(nuevo);
            swBackup.Close();

            StreamWriter swFactura = File.CreateText(rutaCarpetaFacturasBase + factura.nombreTxt() + ".txt");
            swFactura.WriteLine(factura.log());
            swFactura.Close();
        }

        public void removeFactura(Factura factura)
        {
            string[] lineas = new string[1000];
            int i = 0;
            int j = 0;

            foreach (string line in System.IO.File.ReadLines(rutaFacturas))
            {
                lineas[i] = line;
                i++;
            }

            StreamWriter sw = new StreamWriter(rutaFacturas);
            Factura f1;
            bool eliminado = false;

            while (j <= i)
            {
                if (lineas[j] != "" && lineas[j] != null)
                {
                    f1 = StringToFactura(lineas[j]);
                    if (!Factura.IgualesSinUser(f1, factura))
                    {
                        sw.WriteLine(lineas[j]);
                    }
                    else
                    {
                        if (eliminado)
                        {
                            sw.WriteLine(lineas[j]);
                        }
                        else
                        {
                            eliminado = true;
                        }
                    }
                }
                j++;
            }

            sw.Close();
        }

        public void procesarFactura(Factura factura)
        {
            Collection<Item> invent = this.items();

            foreach(Tuple<Item,int> elemento in factura.Contenido)
            {
                foreach(Item item in invent)
                {
                    if (elemento.Item1.Nombre.Equals(item.Nombre))
                    {
                        item.Cantidad = item.Cantidad - elemento.Item2;
                        modifyItem(item, item.Nombre);
                    }
                }
            }
        }

        public Collection<Factura> facturas()
        {
            Collection<Factura> facturas = new Collection<Factura>();
            Factura factura;

            foreach (string line in System.IO.File.ReadLines(rutaFacturas))
            {
                factura = StringToFactura(line);
                facturas.Add(factura);
            }

            return facturas;
        }

        public void imprimirTexto(string s)
        {
            string clave = Passwords.MD5(s);

            //if(!File.Exists(rutaCarpetaFacturasBase + clave + ".txt"))
            //{
                StreamWriter swFactura = File.CreateText(rutaCarpetaFacturasBase + clave + ".txt");
                swFactura.WriteLine(s);
                swFactura.Close();
            //}
            
            string file = rutaCarpetaFacturasBase + clave + ".txt";
            reader = new StreamReader(file);

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);

            pd.Print();

            if (reader != null)
                reader.Close();
        }

        public void imprimirFactura(Factura factura)
        {
            string file = rutaCarpetaFacturasBase + factura.nombreTxt() + ".txt";
            reader = new StreamReader(file);


            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(this.PrintTextFileHandler);

            pd.Print();

            if (reader != null)
                reader.Close();
        }

        private void PrintTextFileHandler(object sender, PrintPageEventArgs ppeArgs)
        {
            Graphics g = ppeArgs.Graphics;
            float linesPerPage = 0;
            float yPos = 0;
            int count = 0;

            float leftMargin = 8;// ppeArgs.MarginBounds.Left;
            float topMargin = 8;// ppeArgs.MarginBounds.Top;
            string line = null;

            //Calculate the lines per page on the basis of the height of the page and the height of the font  
            linesPerPage = ppeArgs.MarginBounds.Height / lucidaConsole8Font.GetHeight(g);

            //Now read lines one by one, using StreamReader  
            while (count < linesPerPage && ((line = reader.ReadLine()) != null))
            {
                //Calculate the starting position  
                yPos = topMargin + (count * lucidaConsole8Font.GetHeight(g));
                //Draw text  
                g.DrawString(line, lucidaConsole8Font, Brushes.Black, leftMargin, yPos, new StringFormat());
                //Move to next line  
                count++;
            }
            //If PrintPageEventArgs has more pages to print  
            if (line != null)
            {
                ppeArgs.HasMorePages = true;
            }
            else
            {
                ppeArgs.HasMorePages = false;
            }
        }

        public string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }

        // ==============================================================
        // LOGS
        public void LogCrear(Usuario user, Item item, Factura factura, Usuario user2)
        {
            string log = "";

            if(user2 == null)
            {
                if(item == null)
                {
                    if(factura != null)
                    {
                        log = user.Nombre + " ha creado la factura: " + factura.logBD();
                    }
                }
                else
                {
                    log = user.Nombre + " ha creado el item: " + ItemToString(item);
                }
            }
            else
            {
                log = user.Nombre + " ha creado el usuario: " + UsuarioToString(user2);
            }

            StreamWriter swLog = File.AppendText(rutaLog);
            swLog.WriteLine(log);
            swLog.Close();
        }

        public void LogEliminar(Usuario user, Item item, Factura factura, Usuario user2)
        {
            string log = "";

            if (user2 == null)
            {
                if (item == null)
                {
                    if (factura != null)
                    {
                        log = user.Nombre + " ha eliminado la factura: " + factura.logBD();
                    }
                }
                else
                {
                    log = user.Nombre + " ha eliminado el item: " + ItemToString(item);
                }
            }
            else
            {
                log = user.Nombre + " ha eliminado el usuario: " + UsuarioToString(user2);
            }

            StreamWriter swLog = File.AppendText(rutaLog);
            swLog.WriteLine(log);
            swLog.Close();
        }
    }
}
