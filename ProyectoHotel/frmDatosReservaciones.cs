using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Manejador;

namespace ProyectoHotel
{
    public partial class frmDatosReservaciones : Form
    {
        ManejadorReservaciones mr;
        public frmDatosReservaciones()
        {
            InitializeComponent();
            mr = new ManejadorReservaciones();
        }

        private void pListas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDatosReservaciones_Load(object sender, EventArgs e)
        {

        }


        private void txtHabitacion_Click(object sender, EventArgs e)
        {
            frmHabitacion2 fc2 = new frmHabitacion2();
            fc2.ShowDialog();
            txtHabitacion.Text = frmHabitacion2.IDH.ToString();
        }

        private void txtCliente_Click(object sender, EventArgs e)
        {
            frmClientes2 fc = new frmClientes2();
            fc.ShowDialog();
            txtCliente.Text = frmClientes2.IDC.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            mr.Guardar(txtCliente, txtHabitacion, txtDias);
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
