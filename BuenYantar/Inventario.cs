using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace BuenYantar
{
    class Inventario
    {
        private Gestor gestor;
        private Collection<Item> inventario;

        public Inventario(Gestor gestor)
        {
            this.gestor = gestor;
            this.inventario = gestor.items();
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
                inventario.Add(item);
                return true;
            }

            else
                return false;
        }
    }
}
