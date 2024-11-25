using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotel
{
    public partial class frmMenuPrincipal : Form
    {
        public string nivelUsuario;
        public frmMenuPrincipal(string nivelUsuario)
        {
            InitializeComponent();
            this.nivelUsuario = nivelUsuario;
            ConfigurarMenu();
        }

        private void optHabitacion_Click(object sender, EventArgs e)
        {
            frmHabitaciones H = new frmHabitaciones(nivelUsuario);
            H.Show();
        }

        private void optClientes_Click(object sender, EventArgs e)
        {
            frmClientes C = new frmClientes(nivelUsuario);
            C.Show();
        }

        private void optReservacion_Click(object sender, EventArgs e)
        {
            frmReservaciones Re = new frmReservaciones(nivelUsuario);
            Re.Show();
        }

        private void optUsuarios_Click(object sender, EventArgs e)
        {
            FrmUsuarios U = new FrmUsuarios();
            U.Show();
        }

        private void optSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public void ConfigurarMenu()
        {
            if (nivelUsuario == "Administrador")
            {
                optUsuarios.Visible = true;
            }
        }
    }
}
