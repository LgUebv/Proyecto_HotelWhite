﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotel
{
    public partial class frmClientes : Form
    {
        public string nivelUsuario;
        public frmClientes(string nivelUsuario)
        {
            InitializeComponent();
            this.nivelUsuario = nivelUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
