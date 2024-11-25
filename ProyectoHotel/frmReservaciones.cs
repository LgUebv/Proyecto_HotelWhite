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
    public partial class frmReservaciones : Form
    {
        public string nivelUsuario;
        public frmReservaciones(string nivelUsuario)
        {
            InitializeComponent();
            this.nivelUsuario = nivelUsuario;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }

        private void dtgvReservaciones_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtReservaciones_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
