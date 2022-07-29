﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;

namespace BuenYantar
{
    public class Gestor
    {
        private string rutaInventario;
        private string rutaUsuarios;
        private string rutaFacturas;

        public Gestor(string rutaInventario)
        {
            this.rutaInventario = rutaInventario;


            this.rutaInventario = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\buenyantarinventario.txt";
            this.rutaUsuarios = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\buenyantarusuarios.txt";
            this.rutaFacturas = @"C:\Users\aleja\OneDrive\Escritorio\BuenYantarBD\buenyantarfacturas.txt";
        }

        // ====================================================================================
        // GESTION INVENTARIO

        public Item StringToItem(string line)
        {
            string[] datos = line.Split('|');

            int cantidad = Int32.Parse(datos[1]);
            double precio = double.Parse(datos[2]);
            int seguridad = Int32.Parse(datos[3]);

            return new Item(datos[0], cantidad, precio, seguridad);
        }

        public string ItemToString(Item item)
        {
            string s = item.Nombre + "|" + item.Cantidad + "|" + item.Precio + "|" + item.Seguridad;
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

        public void modifyItem(Item item)
        {
            this.removeItem(item.Nombre);
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
                item = new Item(datos[i], 1000, double.Parse(datos[i+1]), 10);
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
                        modifyItem(item);
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
    }
}
