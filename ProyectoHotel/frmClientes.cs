using Manejador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoHotel
{
    public partial class frmClientes : Form
    {
        public string nivelUsuario;
        public static int IDC = 0;
        public static string Nombre, ApellidoP, ApellidoM, Email, Telefono = "";
        int fila = 0, columna = 0;

        ManejadorCliente mc;
        public frmClientes(string nivelUsuario)
        {
            InitializeComponent();
            mc = new ManejadorCliente();
            this.nivelUsuario = nivelUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IDC = 0; Nombre = ""; ApellidoP = ""; ApellidoM = ""; Email = ""; Telefono = "";
            dtgvClientes.Visible = false;
            frmDatosCliente cliente = new frmDatosCliente();
            cliente.ShowDialog();
            txtCliente.Focus();
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            dtgvClientes.Visible = true;
            mc.MostrarGeneral(dtgvClientes, txtCliente.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 6:
                    {
                        IDC = int.Parse(dtgvClientes.Rows[fila].Cells[0].Value.ToString());
                        mc.Borrar(IDC, dtgvClientes.Rows[fila].Cells[1].Value.ToString());
                        dtgvClientes.Visible = false;
                    }
                    break;
                case 7:
                    {
                        IDC = int.Parse(dtgvClientes.Rows[fila].Cells[0].Value.ToString());
                        Nombre = dtgvClientes.Rows[fila].Cells[1].Value.ToString();
                        ApellidoP = dtgvClientes.Rows[fila].Cells[2].Value.ToString();
                        ApellidoM = dtgvClientes.Rows[fila].Cells[3].Value.ToString();
                        Email = dtgvClientes.Rows[fila].Cells[4].Value.ToString();
                        Telefono = dtgvClientes.Rows[fila].Cells[5].Value.ToString();
                        frmDatosCliente cliente = new frmDatosCliente();
                        cliente.ShowDialog();
                        dtgvClientes.Visible = false;
                    }
                    break;
            }
        }

        //private void ConfigurarMenu()
        //{
        //    if (nivelUsuario == "Administrador")
        //    {
        //        btnEditar.Enabled = true;
        //        btnBorrar.Enabled = true;
        //    }
        //}  
    }
}
