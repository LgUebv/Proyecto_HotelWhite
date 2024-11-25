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
    public partial class FrmLogin : Form
    {
        ManejadorLogin ml;

        public FrmLogin()
        {
            InitializeComponent();
            ml = new ManejadorLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] r = ml.Validar(txtUsuario.Text, txtClave.Text);
            if (r[0].Equals("Correcto"))
            {
                this.Hide();
                string nivelUsuario = r[1];

                frmMenuPrincipal menu = new frmMenuPrincipal(nivelUsuario);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Nombre o contraseña incorrectos, favor de consultar con el administrador", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
