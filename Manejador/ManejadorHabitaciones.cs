using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AccesoDatos;

namespace Manejador
{
    public class ManejadorHabitaciones
    {
        Funciones f = new Funciones();

        public void Guardar(ComboBox Tipo , TextBox Capacidad, TextBox Costo, ComboBox Estado, TextBox Descripcion)
        {
            MessageBox.Show(f.Guardar($"CALL p_AgregarHabitacion('{Tipo.Text}', {Capacidad.Text}, {Costo.Text}, '{Estado.Text}', '{Descripcion.Text}');"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int IDH, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"call p_EliminarHabitacion({IDH})");
                MessageBox.Show("Registro eliminado con exito", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void Modificar(ComboBox Tipo, TextBox Capacidad, TextBox Costo, ComboBox Estado, TextBox Descripcion, int IDH)
        {
            MessageBox.Show(f.Modificar($"CALL p_AgregarHabitacion({IDH}, '{Tipo.Text}', {Capacidad.Text}, {Costo.Text}, '{Estado.Text}', '{Descripcion.Text}');"),
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
            tabla.DataSource = f.Mostrar($"Select * from habitaciones where tipo like '%{filtro}%'", "habitaciones").Tables[0];
            tabla.Columns.Insert(6, Boton("Seleccionar", Color.Purple));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarAdministrador(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"SELECT * from habitaciones WHERE tipo like '%{filtro}%'", "habitaciones").Tables[0];
            tabla.Columns.Insert(6, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(7, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
