﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuenYantar
{
    public partial class FormInicio : Form
    {

        private Gestor gestor;
        private Usuario user;

        public FormInicio(Gestor gestor, Usuario user)
        {
            this.gestor = gestor;
            this.user = user;
            InitializeComponent();
            this.tbUser.Text = user.NombreCompleto;
        }

        private void btInventario_Click(object sender, EventArgs e)
        {
            VerInventario verInventario = new VerInventario(new Inventario(gestor));
            DialogResult d = verInventario.ShowDialog();
        }

        private void FormInicio_Load(object sender, EventArgs e)
        {

        }

        private void btFactura_Click(object sender, EventArgs e)
        {
            NuevaFactura nuevaFactura = new NuevaFactura(gestor, new Inventario(gestor), user);
            DialogResult d = nuevaFactura.ShowDialog();
        }

        private void btHistorial_Click(object sender, EventArgs e)
        {
            HistorialFacturas histFacturas = new HistorialFacturas(gestor);
            DialogResult d = histFacturas.ShowDialog();
        }
    }
}
