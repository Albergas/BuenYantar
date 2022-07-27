using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BuenYantar
{
    public class Inventario
    {
        private Gestor gestor;
        private Collection<Item> inventario;

        public Inventario(Gestor gestor)
        {
            this.gestor = gestor;
            this.inventario = gestor.items();
        }

        public Collection<Item> Items
        {
            get
            {
                return this.inventario;
            }
        }

        public string log()
        {
            string s = "";
            foreach(Item item in inventario)
            {
                s += item.log() + "\n";
            }
            return s;
        }

        public bool existe(string nombre)
        {
            foreach(Item i in inventario)
            {
                if (i.Nombre.Equals(nombre))
                    return true;
            }
            return false;
        }

        public bool addItem(Item item)
        {
            if (!existe(item.Nombre))
            {
                gestor.addItem(item);
                this.inventario = gestor.items();
                return true;
            }

            else
                return false;
        }

        public void removeItem(string nombre)
        {
            gestor.removeItem(nombre);
            this.inventario = gestor.items();
        }

        public void modifyItem(Item item)
        {
            gestor.modifyItem(item);
            this.inventario = gestor.items();
        }
    }
}
