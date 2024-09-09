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

namespace practicaTemperaturaIS
{
    public partial class Form1 : Form
    {
        manejadorLogin ml;
        public Form1()
        {
            InitializeComponent();
            ml = new manejadorLogin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] r = ml.Validar(txtUser.Text, txtClave.Text);
            if (r[0].Equals("Correcto"))
            {
                this.Hide();
                int lvlUsuario = int.Parse(r[1]);

                frmMenuUser1 menu = new frmMenuUser1(lvlUsuario);
                menu.Show();
            }
            else
            {
                MessageBox.Show("Nombre o contraseña incorrectos, favor de consultar con el administrador", "Atencion!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

    }
}
