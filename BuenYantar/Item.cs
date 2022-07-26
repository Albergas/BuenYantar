using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenYantar
{
    class Item
    {
        private string nombre;
        private int cantidad;
        private double precio;

        public Item(string nombre, int cantidad, double precio)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }
        }

        public void sumar(int n)
        {
            this.cantidad += n;
        }

        public void restar(int n)
        {
            this.cantidad -= n;
        }

        public string log()
        {
            string s = this.nombre + ": " + this.cantidad + " uds. (precio "+ this.precio+ "€)";
            return s;
        }
    }
}
