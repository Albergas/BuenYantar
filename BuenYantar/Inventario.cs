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

        public Gestor getGestor()
        {
            return gestor;
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

        public void modifyItem(Item item, string nombreViejo)
        {
            gestor.modifyItem(item, nombreViejo);
            this.inventario = gestor.items();
        }

        public Collection<Item> ordenado()
        {
            Collection<Item> ordenados = new Collection<Item>();
            bool primero = true;
            bool metido = false;
            int cantidadActual;

            foreach(Item item in inventario)
            {
                if (primero)
                {
                    ordenados.Add(item);
                    primero = false;
                }
                else
                {
                    metido = false;
                    cantidadActual = ordenados.Count;
                    for (int i = 0; i < cantidadActual && !metido; i++)
                    {
                        if (ordenados[i].Codigo > item.Codigo)
                        {
                            ordenados.Insert(i, item);
                            metido = true;
                        }
                    }
                    if (!metido)
                    {
                        ordenados.Add(item);
                    }
                }
            }

            return ordenados;
        }
    }
}
