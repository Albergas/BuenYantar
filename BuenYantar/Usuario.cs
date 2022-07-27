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
        private string nombreCompleto;

        public Usuario(string nombre, string hash, int tipo, string nc)
        {
            this.nombre = nombre;
            this.hash = hash;
            this.tipo = tipo;
            this.nombreCompleto = nc;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
        }

        public string NombreCompleto
        {
            get
            {
                return this.nombreCompleto;
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
