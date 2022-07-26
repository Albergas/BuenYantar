using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuenYantar
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1());

            Gestor g = new Gestor("a");

            Inventario i = new Inventario(g);

            Console.WriteLine(i.log());

            Item item = new Item("hermano", 4, 87.3);
            Item item2 = new Item("cojones hermano", 4, 87.3);

            i.addItem(item);
            i.addItem(item2);

            Console.WriteLine(i.log());
        }
    }
}
