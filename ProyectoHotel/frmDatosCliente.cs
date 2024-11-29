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
    public partial class frmDatosCliente : Form
    {
        ManejadorCliente mc;
        public frmDatosCliente()
        {
            InitializeComponent();
            mc = new ManejadorCliente();
            if (frmClientes.IDC > 0)
            {
                txtNombre.Text = frmClientes.Nombre.ToString();
                txtApellidoP.Text = frmClientes.ApellidoP.ToString();
                txtApellidoM.Text = frmClientes.ApellidoM.ToString();
                txtEmail.Text = frmClientes.Email.ToString();
                txtTelefono.Text = frmClientes.Telefono.ToString();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (frmClientes.IDC > 0)
            {
                mc.Modificar(txtNombre, txtApellidoP, txtApellidoM, txtEmail, txtTelefono, frmClientes.IDC);
            }
            else
            {
                mc.Guardar(txtNombre, txtApellidoP, txtApellidoM, txtEmail, txtTelefono);
            }
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
