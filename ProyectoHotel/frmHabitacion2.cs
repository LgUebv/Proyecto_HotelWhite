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
    public partial class frmHabitacion2 : Form
    {
        ManejadorHabitaciones mh;
        private string nivelUsuario;
        public static int IDH = 0;
        public static string Tipo, Costo, Capacidad, Estado, Descripcion = "";
        int fila = 0, columna = 0;
        public frmHabitacion2()
        {
            InitializeComponent();
            mh = new ManejadorHabitaciones();
        }

        private void txtHabitacion_TextChanged(object sender, EventArgs e)
        {
            dtgvHabitaciones.Visible = true;
            mh.Mostrar(dtgvHabitaciones, txtHabitacion.Text);
        }

        private void dtgvHabitaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 6:
                    {
                        IDH = int.Parse(dtgvHabitaciones.Rows[fila].Cells[0].Value.ToString());
                        this.Close();
                        dtgvHabitaciones.Visible = false;
                    }
                    break;
            }
        }
    }
}
