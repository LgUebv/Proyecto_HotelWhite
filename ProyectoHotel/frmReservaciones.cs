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
    public partial class frmReservaciones : Form
    {
        ManejadorReservaciones mr;
        public string nivelUsuario;
        public static int IDR, IDC, IDH, Dias = 0;
        public static string FechaInicio, FechaFin = "";
        int fila = 0, columna = 0;

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmReservaciones(string nivelUsuario)
        {
            InitializeComponent();
            mr = new ManejadorReservaciones();
            this.nivelUsuario = nivelUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IDR = 0; IDC = 0; IDH = 0; Dias = 0; FechaInicio= ""; FechaFin = "";
            dtgvReservaciones.Visible = false;
            frmDatosReservaciones res = new frmDatosReservaciones();
            res.ShowDialog();
            txtReservaciones.Focus();
        }

        private void dtgvReservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 6:
                    {
                        IDR = int.Parse(dtgvReservaciones.Rows[fila].Cells[0].Value.ToString());
                        mr.Borrar(IDR, dtgvReservaciones.Rows[fila].Cells[1].Value.ToString());
                        dtgvReservaciones.Visible = false;
                    }
                    break;
                case 7:
                    {
                        IDR = int.Parse(dtgvReservaciones.Rows[fila].Cells[0].Value.ToString());
                        IDC = int.Parse(dtgvReservaciones.Rows[fila].Cells[1].Value.ToString());
                        IDH = int.Parse(dtgvReservaciones.Rows[fila].Cells[2].Value.ToString());
                        Dias = int.Parse(dtgvReservaciones.Rows[fila].Cells[3].Value.ToString());
                        FechaInicio = dtgvReservaciones.Rows[fila].Cells[4].Value.ToString();
                        FechaFin = dtgvReservaciones.Rows[fila].Cells[5].Value.ToString();
                        frmDatosReservaciones res = new frmDatosReservaciones();
                        res.ShowDialog();
                        dtgvReservaciones.Visible = false;
                    }
                    break;
            }
        }

        private void txtReservaciones_TextChanged(object sender, EventArgs e)
        {
            dtgvReservaciones.Visible=true;
            mr.Mostrar(dtgvReservaciones, txtReservaciones.Text);
        }
    }
}
