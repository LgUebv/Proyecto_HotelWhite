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
    public partial class frmClientes2 : Form
    {
        ManejadorCliente mc;
        public string nivelUsuario;
        public static int IDC = 0;
        public static string Nombre, ApellidoP, ApellidoM, Email, Telefono = "";

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int fila = 0, columna = 0;
        public frmClientes2()
        {
            InitializeComponent();
            mc = new ManejadorCliente();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            mc.MostrarGeneral(dtgvClientes, txtCliente.Text);
        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 6:
                    {
                        IDC = int.Parse(dtgvClientes.Rows[fila].Cells[0].Value.ToString());
                        this.Close();
                    }
                    break;
            }
        }
    }
}
