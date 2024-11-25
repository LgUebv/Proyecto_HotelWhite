﻿using AccesoDatos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Manejador
{
    public class ManejadorCliente
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, TextBox Email, TextBox Telefono)
        {
            MessageBox.Show(f.Guardar($"call p_AgregarCliente ('{Nombre.Text}', '{ApellidoP.Text}', '{ApellidoM.Text}', '{Email.Text}', '{Telefono.Text}');"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void Borrar(int IDC, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}?", "Atencion!!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"call p_EliminarCliente ({IDC})");
                MessageBox.Show("Registro eliminado", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox Nombre, TextBox ApellidoP, TextBox ApellidoM, TextBox Email, TextBox Telefono, int IDC)
        {
            MessageBox.Show(f.Modificar($"call p_EditarCliente ({IDC}, '{Nombre.Text}', '{ApellidoP.Text}', '{ApellidoM.Text}', '{Email.Text}', '{Telefono.Text}');"),
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
        public void MostrarHistorial(DataGridView tabla, string filtro)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"select * from Historial_Cliente where nombre like '%{filtro}%'", "usuarios").Tables[0];
            tabla.Columns.Insert(8, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(9, Boton("Modificar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }

        public void MostrarGeneral(DataGridView tabla, string Nombre)
        {
            tabla.Columns.Clear();
            tabla.DataSource = f.Mostrar($"SELECT * from Clientes WHERE NickName = '{Nombre}';", "Historial").Tables[0];
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
