using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorUsuario
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox Nick, TextBox Clave, ComboBox Rol, TextBox Nombre, TextBox Apellidos)
        {
            MessageBox.Show(f.Guardar($"call p_AgregarUsuario ('{Nick.Text}', sha1('{Clave.Text}'), '{Rol.Text}', '{Nombre.Text}', '{Apellidos.Text}')"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Borrar(int IDU, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"call p_EliminarUsuario ({IDU})");
                MessageBox.Show("Registro eliminado", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox Nick, TextBox Clave, ComboBox Rol, TextBox Nombre, TextBox Apellidos, int IDU)
        {
            MessageBox.Show(f.Modificar($"call p_EditarUsuario ('{Nick.Text}', sha1('{Clave.Text}'), '{Rol.Text}', '{Nombre.Text}', '{Apellidos.Text}')"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        DataGridViewButtonColumn Boton(string t, Color fondo)
        {
            DataGridViewButtonColumn b = new DataGridViewButtonColumn();
            b.Text = t;
            b.UseColumnTextForButtonValue = true;
            b.FlatStyle = FlatStyle.Popup;
            b.DefaultCellStyle.BackColor = fondo;
            b.DefaultCellStyle.ForeColor = Color.White;
            return b;
        }
        public void Mostrar(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from Usuarios where nombre like '%{filtro}%'", "Usuarios").Tables[0];
            tabla.Columns.Insert(8, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(9, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
