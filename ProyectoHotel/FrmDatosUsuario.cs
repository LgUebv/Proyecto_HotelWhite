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
    public partial class FrmDatosUsuario : Form
    {
        ManejadorUsuario mu;
        public FrmDatosUsuario()
        {
            mu = new ManejadorUsuario();
            InitializeComponent();
            if (FrmUsuarios.IDU > 0)
            {
                txtUsername.Text = FrmUsuarios.Nombre.ToString();
                txtPassword.Text = FrmUsuarios.Password.ToString();
                cmbRol.Text = FrmUsuarios.Rol.ToString();
                txtNombre.Text = FrmUsuarios.Nombre.ToString();
                txtApellidos.Text = FrmUsuarios.Apellidos.ToString();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (FrmUsuarios.IDU > 0)
            {
                mu.Modificar(txtUsername, txtPassword, cmbRol, txtNombre, txtApellidos, FrmUsuarios.IDU);    
            }
            else
            {
                mu.Guardar(txtUsername, txtPassword, cmbRol, txtNombre, txtApellidos);
            }
            Close();
        }
    }
}
