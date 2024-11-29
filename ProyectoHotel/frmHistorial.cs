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
    public partial class frmHistorial : Form
    {
        public static int IDC = frmClientes.IDC;

        ManejadorCliente mc;
        public frmHistorial()
        {
            InitializeComponent();
            mc = new ManejadorCliente();
        }

        private void frmHistorial_Load(object sender, EventArgs e)
        {
            mc.MostrarHistorial(dtgvHistorial, IDC);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
