using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.IO;

namespace BuenYantar
{
    class Gestor
    {
        private string ruta;

        public Gestor(string ruta)
        {
            this.ruta = ruta;
        }

        public Item StringToItem(string line)
        {
            string[] datos = line.Split('|');

            int cantidad = Int32.Parse(datos[1]);
            double precio = double.Parse(datos[2]);

            return new Item(datos[0], cantidad, precio);
        }

        public string ItemToString(Item item)
        {
            string s = item.Nombre + "|" + item.Cantidad + "|" + item.Precio;
            return s;
        }

        public Collection<Item> items()
        {
            Collection<String> lineas = new Collection<string>();
            Collection<Item> items = new Collection<Item>();
            Item item;

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\aleja\OneDrive\Escritorio\buenyantarinventario.txt"))
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

            StreamWriter sw = File.AppendText(@"C:\Users\aleja\OneDrive\Escritorio\buenyantarinventario.txt");

            sw.WriteLine(nuevo);

            sw.Close();
        }

        public void removeItem(string nombre)
        {

        }

        public void modifyItem(Item item)
        {

        }
    }
}
