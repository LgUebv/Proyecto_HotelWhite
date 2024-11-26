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
    public partial class FrmUsuarios : Form
    {
        ManejadorUsuario mu;
        public static int IDU = 0;
        public static string Username, Password, Rol, Nombre, Apellidos = "";
        int fila = 0, columna = 0;
        public FrmUsuarios()
        {
            InitializeComponent();
            mu = new ManejadorUsuario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            IDU = 0; Username = ""; Password = ""; Rol = ""; Nombre = ""; Apellidos = "";
            dtgvUsuarios.Visible = false;
            FrmDatosUsuario user = new FrmDatosUsuario();
            user.ShowDialog();
            txtUsuarios.Focus();
        }

        private void txtUsuarios_TextChanged(object sender, EventArgs e)
        {
            dtgvUsuarios.Visible=true;
            mu.Mostrar(dtgvUsuarios, txtUsuarios.Text);
        }

        private void dtgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fila = e.RowIndex; columna = e.ColumnIndex;
            switch (columna)
            {
                case 6:
                    {
                        IDU = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        mu.Borrar(IDU, dtgvUsuarios.Rows[fila].Cells[1].Value.ToString());
                        dtgvUsuarios.Visible = false;
                    }
                    break;
                case 7:
                    {
                        IDU = int.Parse(dtgvUsuarios.Rows[fila].Cells[0].Value.ToString());
                        Username = dtgvUsuarios.Rows[fila].Cells[1].Value.ToString();
                        Password = dtgvUsuarios.Rows[fila].Cells[2].Value.ToString();
                        Rol = dtgvUsuarios.Rows[fila].Cells[3].Value.ToString();
                        Nombre = dtgvUsuarios.Rows[fila].Cells[4].Value.ToString();
                        Apellidos = dtgvUsuarios.Rows[fila].Cells[5].Value.ToString();
                        FrmDatosUsuario user = new FrmDatosUsuario();
                        user.ShowDialog();
                        dtgvUsuarios.Visible = false;
                    }
                    break;
            }
        }
    }
}
