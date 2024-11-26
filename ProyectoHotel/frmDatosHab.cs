using Manejador;
using System;
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
    public partial class frmDatosHab : Form
    {
        ManejadorHabitaciones mh;
        public frmDatosHab()
        {
            InitializeComponent();
            mh = new ManejadorHabitaciones();
            if (frmHabitaciones.IDH > 0)
            {
                cmbTipo.Text = frmHabitaciones.Tipo.ToString();
                txtCosto.Text = frmHabitaciones.Costo.ToString();
                txtCapacidad.Text = frmHabitaciones.Capacidad.ToString();
                cmbEstado.Text = frmHabitaciones.Estado.ToString();
                txtDescripcion.Text = frmHabitaciones.Descripcion.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmHabitaciones.IDH > 0)
            {
                mh.Modificar(cmbTipo, txtCosto, txtCapacidad, cmbEstado, txtDescripcion, frmHabitaciones.IDH);
            }
            else
            {
                mh.Guardar(cmbTipo, txtCosto, txtCapacidad, cmbEstado, txtDescripcion);
            }
            Close();
        }
    }
}
