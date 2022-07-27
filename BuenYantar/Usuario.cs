using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuenYantar
{
    public class Usuario
    {
        private string nombre;
        private string hash;
        private int tipo;

        public Usuario(string nombre, string hash, int tipo)
        {
            this.nombre = nombre;
            this.hash = hash;
            this.tipo = tipo;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string Hash
        {
            get
            {
                return this.hash;
            }
        }

        public int Tipo
        {
            get
            {
                return this.tipo;
            }
        }
    }
}
