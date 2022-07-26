using System;
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
            int seguridad = Int32.Parse(datos[3]);

            return new Item(datos[0], cantidad, precio, seguridad);
        }

        public string ItemToString(Item item)
        {
            string s = item.Nombre + "|" + item.Cantidad + "|" + item.Precio + "|" + item.Seguridad;
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
            string[] lineas = new string[1000];
            int i = 0;
            int j = 0;

            foreach (string line in System.IO.File.ReadLines(@"C:\Users\aleja\OneDrive\Escritorio\buenyantarinventario.txt"))
            {
                lineas[i] = line;
                Console.WriteLine(line);
                i++;
            }

            StreamWriter sw = new StreamWriter(@"C:\Users\aleja\OneDrive\Escritorio\buenyantarinventario.txt");
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
    }
}
