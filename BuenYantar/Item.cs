using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenYantar
{
    public class Item
    {
        private string nombre;
        private int cantidad;
        private double precio;
        private int seguridad;

        public Item(string nombre, int cantidad, double precio, int seguridad)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.seguridad = seguridad;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }

            set
            {
                this.nombre = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return this.cantidad;
            }

            set
            {
                this.cantidad = value;
            }
        }

        public double Precio
        {
            get
            {
                return this.precio;
            }

            set
            {
                this.precio = value;
            }
        }

        public int Seguridad
        {
            get
            {
                return this.seguridad;
            }

            set
            {
                this.seguridad = value;
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
            string s = this.nombre + ": " + this.cantidad + " uds. (precio "+ this.precio+ "€). Stock de seguridad " + this.seguridad + "uds.";
            return s;
        }
    }
}
