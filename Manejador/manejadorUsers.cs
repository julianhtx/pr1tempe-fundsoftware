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
    public class manejadorUsers
    {
        Funciones f = new Funciones();
        public void Guardar(TextBox userName, TextBox password, TextBox Nombre, TextBox Apellido, TextBox Nivel)
        {
            MessageBox.Show(f.Guardar($"insert into Users (userName, password, firstName, lastName, level) values ('{userName.Text}', sha1('{password.Text}'), '{Nombre.Text}', '{Apellido.Text}', {Nivel.Text})"),
                "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void Borrar(int ID, string dato)
        {
            DialogResult rs = MessageBox.Show($"Estas seguro de borrar {dato}?", "Atencion!!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                f.Borrar($"delete from Users where idUser ={ID}");
                MessageBox.Show("Registro eliminado con exito", "Atencion!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void Modificar(TextBox userName, TextBox Contraseña, TextBox Nombre, TextBox Apellido, TextBox Nivel, int ID)
        {
            MessageBox.Show(f.Modificar($"update Users set userName = '{userName.Text}', password = sha1('{Contraseña.Text}'), firstName = '{Nombre.Text}', lastName = '{Apellido.Text}', level = {Nivel.Text} where idUser = {ID}"),
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
            tabla.DataSource = f.Mostrar($"select * from v_Users where firstName like '%{filtro}%'", "Users").Tables[0];
            tabla.Columns.Insert(6, Boton("Borrar", Color.Red));
            tabla.Columns.Insert(7, Boton("Editar", Color.Green));
            tabla.AutoResizeColumns();
            tabla.AutoResizeRows();
        }
    }
}
