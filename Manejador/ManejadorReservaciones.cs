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
    public class ManejadorReservaciones
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox IDCliente, TextBox IDHabitacion, TextBox Dias)
        {
            MessageBox.Show(f.Guardar($"call p_AgregarReservacion ({IDCliente.Text}, {IDHabitacion.Text}, {Dias.Text});"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Borrar(int IDR, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"call p_EliminarReservacion ({IDR})");
                MessageBox.Show("Registro eliminado", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox IDCliente, TextBox IDHabitacion, TextBox Dias, int IDR)
        {
            MessageBox.Show(f.Modificar($"call p_EditarReservacion ({IDR}, {IDCliente.Text}, {IDHabitacion.Text}, {Dias.Text});"),
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
            tabla.DataSource = f.Mostrar($"select * from Vista_Reservaciones where Nombre_Cliente like '%{filtro}%'", "reservaciones").Tables[0];
            tabla.Columns.Insert(8, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(9, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
