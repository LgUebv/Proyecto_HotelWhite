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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ProyectoHotel
{
    public partial class frmHabitaciones : Form
    {
        ManejadorHabitaciones mh;
        private string nivelUsuario;
        public static int IDH = 0;
        public static string Tipo, Costo, Capacidad, Estado, Descripcion = "";
        int fila = 0, columna = 0;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtgvHabitaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public frmHabitaciones(string nivelUsuario)
        {
            InitializeComponent();
            mh = new ManejadorHabitaciones();
            this.nivelUsuario = nivelUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IDH = 0; Tipo = ""; Costo = ""; Capacidad = ""; Estado = ""; Descripcion = "";
            dtgvHabitaciones.Visible = false;
            frmDatosHab hab = new frmDatosHab();
            hab.ShowDialog();
            txtHabitacion.Focus();
        }

        private void dtgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 6:
                    {
                        IDH = int.Parse(dtgvHabitaciones.Rows[fila].Cells[0].Value.ToString());
                        mh.Borrar(IDH, dtgvHabitaciones.Rows[fila].Cells[1].Value.ToString());
                        dtgvHabitaciones.Visible = false;
                    }
                    break;
                case 7:
                    {
                        IDH = int.Parse(dtgvHabitaciones.Rows[fila].Cells[0].Value.ToString());
                        Tipo = dtgvHabitaciones.Rows[fila].Cells[1].Value.ToString();
                        Costo = dtgvHabitaciones.Rows[fila].Cells[2].Value.ToString();
                        Capacidad = dtgvHabitaciones.Rows[fila].Cells[3].Value.ToString();
                        Estado = dtgvHabitaciones.Rows[fila].Cells[4].Value.ToString();
                        Descripcion = dtgvHabitaciones.Rows[fila].Cells[5].Value.ToString();
                        frmDatosCliente cliente = new frmDatosCliente();
                        cliente.ShowDialog();
                        dtgvHabitaciones.Visible = false;
                    }
                    break;
            }
        }

        private void txtHabitacion_TextChanged(object sender, EventArgs e)
        {
            dtgvHabitaciones.Visible = true;
            mh.MostrarAdministrador(dtgvHabitaciones, txtHabitacion.Text);
        }
    }
}
